using System;
using System.Diagnostics;       //for external processes
using System.IO;                //for file access
using System.Linq;              //for DataGridViewRowCollection.Cast()
using System.Threading;         //for multithreading
using System.Threading.Tasks;   //for multithreading
using System.Windows.Forms;


//TODO: revise tab order
//TODO: implement command line arguments
// -s     start automatically
// -up     use previous settings      
// -e      exit after completition
// -es     exit after successfull completition
// -a      add files/folders
// -otz    output file type cbz
// -ot7    output file type cb7
// -otr    output file type cbr
// -op     output path
// -oeo    output file exists overwrite    
// -oes    output file exists skip
// -oer<pat>   output file exists rename with <pat> pattern
// -m      use multicore
// -di     delete input files
// -c<pat> clean files 
// -c<pat><n>  clean files limiting
// -r      remove folder structure
// -rs     remove folder structure smart


namespace Comic_Book_Maker
{
    public partial class formMain : Form
    {
        /// Types
        enum fEA { Overwrite, Skip, Rename };   //file exist action
        enum rFS { no, yes, smart };    //remove folder structure option


        /// Objects
        private delegate void endDelegate();   //to invoke processEnd() 
        private readonly Stopwatch crono = new Stopwatch(); //for measuring processing time
        private readonly string shortcutPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.SendTo), "Comic Book Maker.lnk");   //path to shortcut file
        private const string FolderStr = "Folder", ArchiveStr = "Archive", ComicStr = "Comic";  //strings defining the input types
        private const int totalSteps = 5;       //total number of steps of the process
        private string outType = "cbz";         //output type (lower case)
        private readonly string programFolderPath = Path.GetDirectoryName(Application.ExecutablePath);
        private fEA fileExistAction = fEA.Overwrite;
        private rFS removeFolderStruct;
        private bool ErrorRarPath = false;      //Rar.exe is missing when Output is CBR
        private bool Error7zipPath = false;     //7z.exe or 7z.dll are missing 
        private bool ErrorRenameSuffix = false; //Suffix pattern doesnt constaint \n when Rename Output is selected
        private bool cancelClosing = false;     //cancel auto-closing when finished
        private int closingCounter;             //counter (0.1 s) for autoclosing


        /// Initialization and Closing
        public formMain(string[] args1)
        {
            InitializeComponent();

            showThread("Main");

            //settings that are not assignable 
            comboBoxOutputType.SelectedIndex = Properties.Settings.Default.output_type_selection;
            comboBoxFileExistAction.SelectedIndex = Properties.Settings.Default.file_exist_selection;
            comboBoxRemoveFolder.SelectedIndex = Properties.Settings.Default.remove_folder_structure_selection;

            this.Size = Properties.Settings.Default.form_size;

            //configure initial sorting of dataGridView1;
            dataGridView1.Sort(dataGridView1.Columns[1], System.ComponentModel.ListSortDirection.Ascending);
            updateSendtoShortcutButtonText();

            labelAbout.Text = Application.ProductName + " v" + System.Reflection.Assembly.GetEntryAssembly().GetName().Version.ToString(2);

            //test existence of 7zip files
            if (!File.Exists(Path.Combine(programFolderPath, "7z.exe")) || !File.Exists(Path.Combine(programFolderPath, "7z.dll")))
            {
                Error7zipPath = true;
                showWarning("Missing 7z.exe or 7z.dll in program folder");
                buttonGo.Enabled = !Error7zipPath && !ErrorRarPath && !ErrorRenameSuffix;
            }

            //if command line arguments are given
            if (args1.Length > 0)
                populateGrid(args1, true);
        }
        private void formMain_Shown(object sender, EventArgs e)
        {
            //When main windows hasn't at least 100 pix on scrreen, reposition it at 100 pix (upper-right)
            if (!isOnScreen(this,100))
                Location = new System.Drawing.Point(100, 100);
        }
        private void form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //settings that are not assignable
            Properties.Settings.Default.file_exist_selection = comboBoxFileExistAction.SelectedIndex;
            Properties.Settings.Default.output_type_selection = comboBoxOutputType.SelectedIndex;
            Properties.Settings.Default.remove_folder_structure_selection = comboBoxRemoveFolder.SelectedIndex;
            Properties.Settings.Default.form_size = this.Size;

            Properties.Settings.Default.column_width_input = ColumnInput.Width;
            Properties.Settings.Default.column_width_type = ColumnType.Width;
            Properties.Settings.Default.column_width_output = ColumnOutput.Width;
            Properties.Settings.Default.column_width_state = ColumnState.Width;

            Comic_Book_Maker.Properties.Settings.Default.Save();
            ;
        }


        /// Event handlers
        private void dataGridView1_DragOver(object sender, DragEventArgs e)
        {
            // If the data is a file or a bitmap.
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                if ((ModifierKeys & Keys.Control) != 0)
                    e.Effect = DragDropEffects.Copy;
                else
                    e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void dataGridView1_DragDrop(object sender, DragEventArgs e)
        {
            // Handle FileDrop data.
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                if (e.Effect == DragDropEffects.Move)
                    populateGrid((string[])e.Data.GetData(DataFormats.FileDrop), true);
                else if (e.Effect == DragDropEffects.Copy)
                    populateGrid((string[])e.Data.GetData(DataFormats.FileDrop), false);
            }
        }
        private void checkBoxCreateFromFolder_CheckedChanged(object sender, EventArgs e)
        {
            updateOutputNames();
            updateSelectedRows();
        }
        private void checkBoxCreateFromArchive_CheckedChanged(object sender, EventArgs e)
        {
            updateOutputNames();
            updateSelectedRows();
        }
        private void checkBoxCreateFromComic_CheckedChanged(object sender, EventArgs e)
        {
            updateOutputNames();
            updateSelectedRows();
        }
        private void checkBoxOutPath_CheckedChanged(object sender, EventArgs e)
        {
            updateOutputNames();

            textBoxOutPath.Enabled = checkBoxUseOutPath.Checked;
            buttonOutputPath.Enabled = checkBoxUseOutPath.Checked;
        }
        private void comboBoxOutputType_SelectedIndexChanged(object sender, EventArgs e)
        {
            outType = comboBoxOutputType.Text.ToLower();

            bool isRar = (outType == "cbr");
            textBoxRarPath.Enabled = isRar;
            labelRarPath.Enabled = isRar;
            buttonRarPath.Enabled = isRar;

            updateOutputNames();
        }
        private void buttonGo_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                updateOutputNames();
                processAllRows();
            }
            else
                showStatus("No files to process");
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            updateOutputNames();
        }
        private void checkBoxExcludeFiles_CheckedChanged(object sender, EventArgs e)
        {
            textBoxExludeFiles.Enabled = checkBoxExcludeFiles.Checked;
            numericUpDownCleanLimit.Enabled = checkBoxExcludeFiles.Checked;
        }
        private void comboBoxFileExistAction_SelectedValueChanged(object sender, EventArgs e)
        {
            fileExistAction = (fEA)comboBoxFileExistAction.SelectedIndex;

            textBoxRenameSuffix.Visible = (fileExistAction == fEA.Rename);
            labelSuffix.Visible = (fileExistAction == fEA.Rename);

            updateOutputNames();
        }
        private void buttonOutputPath_Click(object sender, EventArgs e)
        {
            string s = textBoxOutPath.Text;
            if (Directory.Exists(s))
                folderBrowserDialog1.SelectedPath = s;
            else if (File.Exists(s))
                folderBrowserDialog1.SelectedPath = Path.GetDirectoryName(s);
            else
                folderBrowserDialog1.SelectedPath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
            folderBrowserDialog1.ShowDialog();
            textBoxOutPath.Text = folderBrowserDialog1.SelectedPath;
        }
        private void buttonRarPath_Click(object sender, EventArgs e)
        {
            string rarFolderPath = Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "WinRar");
            if (!Directory.Exists(rarFolderPath))
                rarFolderPath = System.Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);

            openFileDialog1.InitialDirectory = rarFolderPath;
            openFileDialog1.ShowDialog();

            if (File.Exists(openFileDialog1.FileName))
                textBoxRarPath.Text = openFileDialog1.FileName;
        }
        private void textBoxOutPath_TextChanged(object sender, EventArgs e)
        {
            if (textBoxOutPath.Enabled && !Directory.Exists(textBoxOutPath.Text))
                showStatus("Output directory does not exist, will be created");
            else
                showStatus("");
            updateOutputNames();
        }
        private void textBoxRarPath_Changed(object sender, EventArgs e)
        {
            ErrorRarPath = textBoxRarPath.Enabled && !File.Exists(textBoxRarPath.Text);
            if (ErrorRarPath)
                errorProvider1.SetError(textBoxRarPath, "Rar.exe not found");
            else
                errorProvider1.SetError(textBoxRarPath, "");
            buttonGo.Enabled = !Error7zipPath && !ErrorRarPath && !ErrorRenameSuffix;
        }
        private void textBoxtextBoxRenameSuffix_TextChanged(object sender, EventArgs e)
        {
            ErrorRenameSuffix = textBoxRenameSuffix.Enabled && textBoxRenameSuffix.Visible && !textBoxRenameSuffix.Text.Contains("\\n");
            if (ErrorRenameSuffix)
                errorProvider1.SetError(textBoxRenameSuffix, "Suffix pattern doesn't contains \\n");
            else
                errorProvider1.SetError(textBoxRenameSuffix, "");
            buttonGo.Enabled = !Error7zipPath && !ErrorRarPath && !ErrorRenameSuffix;
            updateOutputNames();
        }
        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                bool allChecked = true;
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    allChecked = allChecked && (bool)row.Cells[0].Value;

                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    row.Cells[0].Value = !allChecked;
            }
        }
        private void formMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F5)
                updateOutputNames();
            else if (e.KeyData == Keys.Escape)
            {
                if (!dataGridView1.IsCurrentCellInEditMode)
                    Close();
            }
        }
        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (dataGridView1.AreAllCellsSelected(false))
                    dataGridView1.ClearSelection();
                else
                    dataGridView1.SelectAll();
            }
        }
        private void buttonSendtoShortcut_Click(object sender, EventArgs e)
        {
            if (File.Exists(shortcutPath))
                File.Delete(shortcutPath);
            else
                createShortcut(shortcutPath, Application.ExecutablePath);
            updateSendtoShortcutButtonText();
        }
        private void buttonCancelClosing_Click(object sender, EventArgs e)
        {
            cancelClosing = true;
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/tosione/Comic-Book-Maker");
        }
        private void timerClose_Tick(object sender, EventArgs e)
        {
            closingCounter--;

            //show countdown
            showWarning("Closing in " + (closingCounter / 10).ToString() + " s");

            //if canceled
            if (cancelClosing)
            {
                //stop countdown
                timerClose.Stop();

                //hide cancel button again and disable cancel
                buttonCancelClosing.Visible = false;
                cancelClosing = false;
                showStatus("Closing canceled");
            }
            //if not canceled
            else
            {
                //whatch if countdown reached end to close
                if (closingCounter == 0)
                    Close();
            }
        }


        /// Auxiliar functions
        private string quote(string s)
        {
            // Adds quotes around string for paths with spaces
            return "\"" + s + "\"";
        }
        private void showWarning(string text)
        {
            toolStripStatusLabel1.ForeColor = System.Drawing.Color.Red;
            toolStripStatusLabel1.Text = text;
            statusStrip1.Refresh();
        }
        private void showStatus(string text)
        {
            toolStripStatusLabel1.ForeColor = DefaultForeColor;
            toolStripStatusLabel1.Text = text;
            statusStrip1.Refresh();
        }
        private void showStatus(string text, double time)
        {
            toolStripStatusLabel1.ForeColor = DefaultForeColor;
            toolStripStatusLabel1.Text = text + ": " + time.ToString("F2") + " s";
            statusStrip1.Refresh();
        }
        private void showError(string text, double t)
        {
            toolStripStatusLabel1.ForeColor = System.Drawing.Color.Red;
            toolStripStatusLabel1.Text = text + ": " + t.ToString("F2") + " s";
            statusStrip1.Refresh();
        }
        private void createShortcut(string shortcutLocation, string targetFileLocation)
        {
            //source:
            //https://www.fluxbytes.com/csharp/create-shortcut-programmatically-in-c/

            IWshRuntimeLibrary.WshShell shell = new IWshRuntimeLibrary.WshShell();
            IWshRuntimeLibrary.IWshShortcut shortcut = (IWshRuntimeLibrary.IWshShortcut)shell.CreateShortcut(shortcutLocation);

            shortcut.Description = "My shortcut description";   // The description of the shortcut
            //shortcut.IconLocation = @"c:\myicon.ico";           // The icon of the shortcut
            shortcut.TargetPath = targetFileLocation;           // The path of the file that will launch when the shortcut is run
            shortcut.Save();                                    // Save the shortcut
        }
        private void updateSendtoShortcutButtonText()
        {
            if (File.Exists(shortcutPath))
                buttonSendtoShortcut.Text = "Remove";
            else
                buttonSendtoShortcut.Text = "Add";
        }
        [Conditional("DEBUG")] 
        private void showThread(string s)
        {
            //show message with thread ID in console for debuggin 
            Console.WriteLine(s + " (Thread ID = " + Thread.CurrentThread.ManagedThreadId.ToString() + ")");
        }
        private bool isOnScreen(Form form,int minPixel)
        {
            //source: https://stackoverflow.com/questions/987018/determining-if-a-form-is-completely-off-screen
            Screen[] screens = Screen.AllScreens;
            foreach (Screen screen in screens)
            {
                System.Drawing.Point formTopLeft = new System.Drawing.Point(form.Left + minPixel, form.Top + minPixel);
                if (screen.WorkingArea.Contains(formTopLeft))
                    return true;
            }
            return false;
        }


        /// Main functions
        private void populateGrid(string[] files, bool replace)
        {
            int i;
            string inPath;

            //clear dataGridView if needed 
            if (replace)
                dataGridView1.Rows.Clear();

            //for each input file
            for (i = 0; i <= files.GetUpperBound(0); i++)
            {
                inPath = files[i];
                bool duplicate = false;

                //search if duplicate file
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if ((string)row.Cells[1].Value == inPath)
                        duplicate = true;
                }

                //if not, add to dataGridView1 depending on type
                if (!duplicate)
                {
                    //as directory
                    if (Directory.Exists(inPath))
                    {
                        object[] row = { true, inPath, FolderStr, "", "", false };
                        dataGridView1.Rows.Add(row);
                    }
                    else if (File.Exists(inPath))
                    {
                        //as archive file
                        string ext = Path.GetExtension(inPath).ToLower();
                        if (ext == ".zip" || ext == ".7z" || ext == ".rar")
                        {
                            object[] row = { true, inPath, ArchiveStr, "", "", false };
                            dataGridView1.Rows.Add(row);
                        }
                        //as comic file
                        else if (ext == ".cbz" || ext == ".cb7" || ext == ".cbr")
                        {
                            object[] row = { true, inPath, ComicStr, "", "", false };
                            dataGridView1.Rows.Add(row);
                        }
                    }
                }
            }

            //update output names and selected rows
            updateOutputNames();
            updateSelectedRows();

            //sort rows
            if (dataGridView1.SortedColumn != null)
            {
                if (dataGridView1.SortOrder == SortOrder.Ascending)
                    dataGridView1.Sort(dataGridView1.SortedColumn, System.ComponentModel.ListSortDirection.Ascending);
                if (dataGridView1.SortOrder == SortOrder.Descending)
                    dataGridView1.Sort(dataGridView1.SortedColumn, System.ComponentModel.ListSortDirection.Descending);
            }

            if (checkBoxStartAfterFileAdd.Checked && !Error7zipPath)
                processAllRows();

        }
        private void updateOutputNames()
        {
            string inType, inPath, outPath;

            //for each row
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                //get input data
                inPath = (string)row.Cells[1].Value;
                inType = (string)row.Cells[2].Value;

                //construct outputPath
                if (checkBoxUseOutPath.Checked)
                    outPath = Path.Combine(textBoxOutPath.Text, Path.ChangeExtension(Path.GetFileName(inPath), outType));
                else
                    outPath = Path.ChangeExtension(inPath, outType);

                //if output file already exists and rename option is selected
                if (File.Exists(outPath) && (fileExistAction == fEA.Rename))
                {
                    //test if rename pattern contains \n
                    string pattern;
                    if (textBoxRenameSuffix.Text.Contains("\\n"))
                        pattern = textBoxRenameSuffix.Text;
                    else
                        pattern = "_\\n";

                    //try pattern with numbers 1-100
                    string outPath0 = outPath;
                    int j = 1;
                    while (File.Exists(outPath) && j <= 1000)
                    {
                        outPath = Path.Combine(Path.GetDirectoryName(outPath0), Path.GetFileNameWithoutExtension(outPath0) + pattern.Replace("\\n", j.ToString()) + Path.GetExtension(outPath0));
                        j++;
                    }
                    //if none found show warning
                    if (j > 1000)
                    {
                        row.Cells[4].Value = "Renamed also exist";
                        outPath = outPath0;
                    }
                }
                //set outputPath in any case
                row.Cells[3].Value = outPath;

                //if input file dont exist show warning
                if (!Directory.Exists(inPath) && !File.Exists(inPath))
                    row.Cells[4].Value = "Input file doesn't exist";

            }
            dataGridView1.Refresh();
        }
        private void updateSelectedRows()
        {
            //for each row
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string inType = (string)row.Cells[2].Value;

                //select row based on options
                row.Cells[0].Value = (inType == FolderStr && checkBoxCreateFromFolder.Checked) ||
                                    (inType == ArchiveStr && checkBoxCreateFromArchive.Checked) ||
                                    (inType == ComicStr && checkBoxCreateFromComic.Checked);
            }
        }
        private void processAllRows()
        {
            showStatus("Working");

            //reset statusBar
            toolStripProgressBar1.Value = 0;
            toolStripProgressBar1.Maximum = totalSteps * dataGridView1.Rows.Count;

            //disable buttons while working
            buttonGo.Enabled = false;
            buttonExit.Enabled = false;
            buttonRefresh.Enabled = false;

            //create output directory if it does not exist
            if (!Directory.Exists(textBoxOutPath.Text))
                Directory.CreateDirectory(textBoxOutPath.Text);

            //reset status & errors for all rows
            foreach (DataGridViewRow Row in dataGridView1.Rows)
            {
                Row.Cells[4].Value = "";
                Row.Cells[5].Value = false;
            }

            //get parameters for clean up
            char[] separator = { '|' };
            string[] cleanStr = checkBoxExcludeFiles.Checked ? textBoxExludeFiles.Text.Split(separator, StringSplitOptions.RemoveEmptyEntries) : null;
            for (int i = 0; i <= cleanStr.GetUpperBound(0); i++)
                cleanStr[i] = cleanStr[i].Trim();
            int nCleanLimit = (int)numericUpDownCleanLimit.Value;
            removeFolderStruct = (rFS)comboBoxRemoveFolder.SelectedIndex;

            //start crono (will be stopped in processEnd)
            crono.Restart();
            showThread("Entering ProcessAllRows");

            //process rows
            if (checkBoxMultiThread.Checked)
            {
                //parallel execution of processRow();
                Task task1 = Task.Run(() =>
                {
                    showThread("Parallel start");
                    Parallel.ForEach(dataGridView1.Rows.Cast<DataGridViewRow>(), row => { processRow(row, cleanStr, nCleanLimit, removeFolderStruct); });
                });
                task1.ContinueWith((antecedent) =>
                {
                    //function to execute after finishing all processRow()
                    showThread("Continue With");
                    this.Invoke(new endDelegate(processEnd));
                });
            }
            else
            {
                //sequential execution of processRow();
                Task task1 = Task.Run(() =>
                {
                    showThread("Sequential start");
                    foreach (DataGridViewRow row in dataGridView1.Rows) processRow(row, cleanStr, nCleanLimit, removeFolderStruct);
                });
                task1.ContinueWith((antecedent) =>
                {
                    //function to execute after finishing all processRow();
                    showThread("ContinueWith");
                    this.Invoke(new endDelegate(processEnd));
                });
            }

            showThread("Exiting ProcessAllRows");
        }
        private void processEnd()
        {
            showThread("Tasks End");

            crono.Stop();

            //search for errors on hidden column
            int errN = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if ((bool)row.Cells[5].Value)
                    errN++;
            }

            //if errors show them
            if (errN > 0)
                showError("Finished with errors", crono.Elapsed.TotalSeconds);
            //if no errors
            else
            {
                //show status
                showStatus("Finished", crono.Elapsed.TotalSeconds);

                //start auto-close operation (if specified)
                if (checkBoxCloseAtComplete.Checked)
                {
                    //show cancel button
                    buttonCancelClosing.Visible = true;

                    //start timer
                    timerClose.Start();
                    closingCounter = 50; //50 means 5 s (timer interval = 100 ms)
                }
            }

            //re-enable buttons
            buttonGo.Enabled = true;
            buttonExit.Enabled = true;
            buttonRefresh.Enabled = true;

        }
        private void processRow(DataGridViewRow row, string[] cleanPatterns, int nCleanLimit, rFS removeFolders)
        {
            showThread("Process Row " + row.Index.ToString());

            //variables
            string inPath = (string)row.Cells[1].Value;     //path of input folder or file
            string inType = (string)row.Cells[2].Value;     //type of input folder/archive/comic
            string outPath = (string)row.Cells[3].Value;    //path of output comic file
            int step = 0;

            //local functions to handle step & show progress or exit
            void stepIncrease(string message)
            {
                step++;

                row.Cells[4].Value = message;
                if (step > 1)
                    BeginInvoke((Action)delegate { toolStripProgressBar1.Value++; });
            }
            void stepExit(string message)
            {
                row.Cells[4].Value = "Skip: " + message;
                row.Cells[5].Value = true;   //store error on hidden column for evaluation after all steps finish
                BeginInvoke((Action)delegate { toolStripProgressBar1.Value += (totalSteps - step + 1); });  //compensate for remaining steps
            }
            void stepSkipAll()
            {
                BeginInvoke((Action)delegate { toolStripProgressBar1.Value += totalSteps; });  //compensate for remaining steps
            }


            //olny handle files that are checked
            if ((bool)row.Cells[0].Value)
            {
                //*********************************************************
                // step 1: extract
                //*********************************************************
                stepIncrease("Decompressing");

                //if input file/folder is missing show error
                if (!Directory.Exists(inPath) && !File.Exists(inPath))
                {
                    stepExit("Input file or folder missing");
                    return;
                }

                //get tempPath (folder)
                string tempPath = Path.Combine(Path.GetTempPath(), "CBM - " + Path.GetFileNameWithoutExtension(inPath));
                //if tempPath exists, try to delete
                if (Directory.Exists(tempPath))
                {
                    Directory.Delete(tempPath, true);
                    //TODO: handle file delete exception
                }
                //if still exist, try other names
                if (Directory.Exists(tempPath))
                {
                    string tempPath0 = tempPath;
                    int j = 1;
                    while (Directory.Exists(tempPath) && j <= 1000)
                    {
                        tempPath = tempPath0 + "_" + j.ToString();
                        j++;
                    }
                }
                //if still exist, show error
                if (Directory.Exists(tempPath))
                {
                    stepExit("Can't create temporal directory");
                    return;
                }

                //create tempPath
                Directory.CreateDirectory(tempPath);
                //TODO: handle directory create exception

                //depending on input type
                if (inType == FolderStr)
                {
                    //copy folder to tempPath (using VisualBasic function)
                    Microsoft.VisualBasic.FileIO.FileSystem.CopyDirectory(inPath, tempPath, true);
                }
                else
                {
                    /// 7-Zip basic parameters to extract with full path:
                    ///     7z.exe x {archive} {switches}
                    /// Swithes:
                    ///     -ao{mode}       overwrite mode (a=all)
                    ///     -o{outdir}      set output directory

                    //or extract comic/archive to tempPath
                    Process pr7z = new Process();
                    pr7z.StartInfo = new ProcessStartInfo();
                    pr7z.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    pr7z.StartInfo.FileName = "7z.exe";
                    pr7z.StartInfo.Arguments = "x " + quote(inPath) + " -o" + quote(tempPath) + " -aoa";
                    pr7z.Start();
                    pr7z.WaitForExit();

                    //TODO: handle 7zip extract exception
                }


                //*********************************************************
                // Step 2: clean files
                //*********************************************************
                stepIncrease("Cleaning");

                //if provided cleanPatterns array is not empty
                if (cleanPatterns != null)
                {
                    //search files to delete
                    System.Collections.Generic.List<string> filesToDelete = new System.Collections.Generic.List<string>();
                    foreach (string pattern in cleanPatterns)
                        filesToDelete.AddRange(Directory.GetFiles(tempPath, pattern, SearchOption.AllDirectories));

                    if (filesToDelete.Count > nCleanLimit)
                    {
                        //if to much found, exit
                        stepExit("Excessive files to clean");
                        return;
                    }
                    else
                    {
                        //if not to much, delete them
                        foreach (string file in filesToDelete)
                            File.Delete(file);
                        //TODO: handle file delete exception
                    }
                }

                //remove folder structure option
                if (removeFolders == rFS.yes)
                {
                    string[] tempFilePaths = Directory.GetFileSystemEntries(tempPath, "*", SearchOption.AllDirectories);

                    //get only filenames
                    string[] tempFileNames = new string[tempFilePaths.Length];
                    for (int i = 0; i < tempFilePaths.Length; i++)
                        tempFileNames[i] = Path.GetFileName(tempFilePaths[i]);

                    //search for duplicate filenames
                    int n = tempFileNames.Length;
                    if (n >= 2)
                    {
                        bool dupeFound = false;
                        int i = 0, j;
                        while (i <= n - 2 && !dupeFound)
                        {
                            j = i + 1;
                            while (j <= n - 1 && !dupeFound)
                            {
                                dupeFound = tempFileNames[i] == tempFileNames[j];
                                j++;
                            }
                            i++;
                        }
                        if (dupeFound)
                        {
                            //if found, exit
                            stepExit("Folder structure cannot be removed because duplicate files");
                            return;
                        }
                    }

                    //if not, move files to tempPath
                    foreach (string srcFilePath in tempFilePaths)
                    {
                        string destFilePath = Path.Combine(tempPath, Path.GetFileName(srcFilePath));
                        if (srcFilePath != destFilePath)    //avoid moving if already in root folder
                            File.Move(srcFilePath, destFilePath);
                        //TODO: handle file move exception
                    }

                    //remove remaining folders
                    string[] dirs = Directory.GetDirectories(tempPath);
                    foreach (string dir in dirs)
                    {
                        if (Directory.GetFiles(dir).Length == 0)
                            Directory.Delete(dir, true);
                        //TODO: handle file delete exception
                    }
                }

                //remove folder structure smart option
                else if (removeFolders == rFS.smart)
                {
                    string[] files, dirs;
                    string tempPathPrev;

                    //dive into directories while only one directory (and no file) in it
                    do
                    {
                        tempPathPrev = tempPath;
                        files = Directory.GetFiles(tempPath);
                        dirs = Directory.GetDirectories(tempPath);
                        if (files.Length == 0 && dirs.Length == 1)
                            tempPath = dirs[0];
                    }
                    while (tempPath != tempPathPrev);
                }


                //*********************************************************
                // Step 3: compress
                //*********************************************************
                stepIncrease("Compressing");

                //check if outPath already exists
                if (File.Exists(outPath))
                {
                    //if owerwrite option, delete file
                    if (fileExistAction == fEA.Overwrite)
                    {
                        File.Delete(outPath);
                        //TODO: handle file delete exception
                    }
                    //if skip option, exit
                    else if (fileExistAction == fEA.Skip)
                    {
                        stepExit("Output file exists");
                        return;
                    }
                    //if rename option, exit (this case should not exits as output name is checked before processRows() starts)
                    else if (fileExistAction == fEA.Rename)
                    {
                        stepExit("Renamed output file exists");
                        return;
                    }
                }

                //depending on output type
                if (outType == "cbz")
                {
                    //compress to CBZ
                    Process pr7z = new Process();
                    pr7z.StartInfo = new ProcessStartInfo();
                    pr7z.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    pr7z.StartInfo.FileName = "7z.exe";
                    pr7z.StartInfo.Arguments = "a -mx=0 -tzip -r -mmt=off " + quote(outPath) + " " + quote(Path.Combine(tempPath, "*.*"));
                    pr7z.Start();
                    pr7z.WaitForExit();
                    //TODO: handle 7zip compress exception
                }
                else if (outType == "cb7")
                {
                    //compress to CB7
                    Process pr7z = new Process();
                    pr7z.StartInfo = new ProcessStartInfo();
                    pr7z.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    pr7z.StartInfo.FileName = "7z.exe";
                    pr7z.StartInfo.Arguments = "a -mx0 -t7z -r -mmt=off " + quote(outPath) + " " + quote(Path.Combine(tempPath, "*.*"));
                    pr7z.Start();
                    pr7z.WaitForExit();
                    //TODO: handle 7zip compress exception
                }
                else if (outType == "cbr")
                {
                    //compress to CBZ
                    Process prRar = new Process();
                    prRar.StartInfo = new ProcessStartInfo();
                    prRar.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    prRar.StartInfo.FileName = textBoxRarPath.Text;
                    prRar.StartInfo.Arguments = "a -ed -ep1 -m0 -ma4 -r -mt1 " + quote(outPath) + " " + quote(Path.Combine(tempPath, "*.*"));
                    prRar.Start();
                    prRar.WaitForExit();
                    //TODO: handle rar compress exception
                }

                /// 7-Zip basic parameters to Compress:
                ///     7z.exe a {archive} {files|@listfiles} {switches}
                /// Swithes:
                ///     -bb{level}      output log level (0=none..3)
                ///     -mx={level}     compression level (0=none,1,3,5,7,9)
                ///     -mt={mode}      multithreading mode (on,off)
                ///     -r              enable recurse directory for wildcards
                ///     -t{type}        set type of archive (7z,zip)
                ///     -x!{wildcard}   exclude files

                /// RAR basic parameters to Compress:
                ///     rar.exe a {switches} {archive}  {files|@listfiles} 
                /// Switches:
                ///     -ed             do no add empty folders
                ///     -ep1            exclude base folder from names
                ///     -m{level}       compression level (0=none)
                ///     -ma{version}    specify archive version (4|5)
                ///     -ms{types}      file types to store
                ///     -mt{threads}    number of threads
                ///     -r              recurse subfolders
                ///     -r0             recurse subfolders for wildcards
                ///     -x{wildcard}    exclude specified file


                //*********************************************************
                // Step 4: delete inPath 
                //*********************************************************
                stepIncrease("Deleting input");

                //if delete ipnut option and output is not overwriting input
                if (checkBoxDeleteInputFiles.Checked && (inPath != outPath))
                {
                    //deletes file/folder to recycle bin, using VisualBasic functions: https://diptimayapatra.wordpress.com/2014/01/16/delete-file-to-recycle-bin-in-c/
                    if (Directory.Exists(inPath))
                        Microsoft.VisualBasic.FileIO.FileSystem.DeleteDirectory(inPath, Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs, Microsoft.VisualBasic.FileIO.RecycleOption.SendToRecycleBin);
                    else if (File.Exists(inPath))
                        Microsoft.VisualBasic.FileIO.FileSystem.DeleteFile(inPath, Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs, Microsoft.VisualBasic.FileIO.RecycleOption.SendToRecycleBin);
                    //TODO: handle folder delete exception
                }


                //*********************************************************
                // Step 5: delete tempPath
                //*********************************************************
                stepIncrease("Deleting temp");

                if (Directory.Exists(tempPath))
                    Directory.Delete(tempPath, true);
                //TODO: handle folder delete exception

                //*********************************************************
                // End
                //*********************************************************
                stepIncrease("Finished");

            }
            else
            {
                stepSkipAll();
            }
        }


    }   //formMain
}   //Comic_Book_Maker


