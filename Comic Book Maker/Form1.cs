using System;
using System.Diagnostics;   //for processes
using System.IO;            //for file access
using System.Linq;          //for DataGridViewRowCollection.Cast()
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comic_Book_Maker
{
    public partial class formMain : Form
    {
        //types
        private enum prErr { None, NoInputFileFolder, CreatingTemp, Extracting, Cleaning, Compressing, DeletingTemp, DeletingInput }

        //objects
        private readonly Stopwatch crono = new Stopwatch();
        private const string FolderStr = "Folder", ArchiveStr = "Archive", ComicStr = "Comic";
        private const int nStep = 5;
        private string outType = "";
        private enum fEA { Overwrite, Skip, Rename };
        private fEA fileExistAction = fEA.Overwrite;
        private delegate void endDelegate();
        bool ErrorRarPath = false;
        bool ErrorRenameSuffix = false;

        //initialization
        public formMain(string[] args1)
        {
            InitializeComponent();

            //settings that are not assignable 
            comboBoxOutputType.SelectedIndex = Properties.Settings.Default.output_type_selection;
            comboBoxFileExistAction.SelectedIndex = Properties.Settings.Default.file_exist_selection;
            this.Size = Properties.Settings.Default.form_size;

            //if command line arguments are given
            if (args1.Length > 0)
                populateGrid(args1, true);

            //configure initial sorting of dataGridView1;
            dataGridView1.Sort(dataGridView1.Columns[1], System.ComponentModel.ListSortDirection.Ascending);

            showThread("Main");
        }

        //TODO: add shell menu entry
        //TODO: finish command line arguments
        //TODO: check errors not used (exctracting, cleaning, compressing, deleting temp, deleting input)
        //TODO: make easy show row error 

        //event handlers
        private void form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //settings that are not assignable
            Properties.Settings.Default.file_exist_selection = comboBoxFileExistAction.SelectedIndex;
            Properties.Settings.Default.output_type_selection = comboBoxOutputType.SelectedIndex;
            Properties.Settings.Default.form_size = this.Size;

            Properties.Settings.Default.column_width_input = ColumnInput.Width;
            Properties.Settings.Default.column_width_type = ColumnType.Width;
            Properties.Settings.Default.column_width_output = ColumnOutput.Width;
            Properties.Settings.Default.column_width_state = ColumnState.Width;

            Comic_Book_Maker.Properties.Settings.Default.Save();
            ;
        }
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
        }
        private void checkBoxCreateFromArchive_CheckedChanged(object sender, EventArgs e)
        {
            updateOutputNames();
        }
        private void checkBoxCreateFromComic_CheckedChanged(object sender, EventArgs e)
        {
            updateOutputNames();
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
            updateOutputNames();
            processAllRows();
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            updateOutputNames();
        }
        private void checkBoxClean_CheckedChanged(object sender, EventArgs e)
        {
            textBoxCleanFiles.Enabled = checkBoxClean.Checked;
            checkBoxCleanLimit.Enabled = checkBoxClean.Checked;
            numericUpDownCleanLimit.Enabled = checkBoxClean.Checked && checkBoxCleanLimit.Checked;
        }
        private void checkBoxCleanLimit_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownCleanLimit.Enabled = checkBoxClean.Checked && checkBoxCleanLimit.Checked;
        }
        private void checkBoxRemoveFolders_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxRemoveFoldersSmart.Enabled = checkBoxRemoveFolders.Checked;
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
            openFileDialog1.InitialDirectory = Path.GetDirectoryName(textBoxRarPath.Text);
            openFileDialog1.ShowDialog();
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
            buttonGo.Enabled = !ErrorRarPath && !ErrorRenameSuffix;
        }
        private void textBoxtextBoxRenameSuffix_TextChanged(object sender, EventArgs e)
        {
            ErrorRenameSuffix = textBoxRenameSuffix.Enabled && !textBoxRenameSuffix.Text.Contains("\\n");
            if (ErrorRenameSuffix)
                errorProvider1.SetError(textBoxRenameSuffix, "Suffix pattern doesn't contains \\n");
            else
                errorProvider1.SetError(textBoxRenameSuffix, "");
            buttonGo.Enabled = !ErrorRarPath && !ErrorRenameSuffix;

            updateOutputNames();
        }
        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    row.Cells[0].Value = !(bool)(row.Cells[0].Value);
            }
            if (e.KeyCode == Keys.F2)
            {
                dataGridView1.BeginEdit(false);
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


        //functions
        private string quote(string s)
        {
            // Adds quotes around string for paths with spaces
            return "\"" + s + "\"";
        }
        private void showError(string s, double t)
        {
            toolStripStatusLabel1.ForeColor = System.Drawing.Color.Red;
            toolStripStatusLabel1.Text = s + ": " + t.ToString("F2") + " s";
            statusStrip1.Refresh();
        }
        private void showStatus(string s)
        {
            toolStripStatusLabel1.ForeColor = DefaultForeColor;
            toolStripStatusLabel1.Text = s;
            statusStrip1.Refresh();
        }
        private void showStatus(string s, double t)
        {
            toolStripStatusLabel1.ForeColor = DefaultForeColor;
            toolStripStatusLabel1.Text = s + ": " + t.ToString("F2") + " s";
            statusStrip1.Refresh();
        }
        private void showThread(string s)
        {
            //show message with thread ID
            Console.WriteLine(s + " (Thread ID = " + Thread.CurrentThread.ManagedThreadId.ToString() + ")");
        }
        private void populateGrid(string[] files, bool replace)
        {
            int i;
            string inPath;

            //clear dataGridView if needed 
            if (replace)
                dataGridView1.Rows.Clear();

            for (i = 0; i <= files.GetUpperBound(0); i++)
            {
                inPath = files[i];
                bool duplicate = false;

                //search if duplicate
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if ((string)row.Cells[1].Value == inPath)
                        duplicate = true;
                }

                if (!duplicate)
                {
                    //Add to dataGridView1 depending on inType
                    if (Directory.Exists(inPath))
                    {
                        object[] row = { true, inPath, FolderStr, "", "", prErr.None };
                        dataGridView1.Rows.Add(row);
                    }
                    else if (File.Exists(inPath))
                    {
                        string ext = Path.GetExtension(inPath).ToLower();
                        if (ext == ".zip" || ext == ".7z" || ext == ".rar")
                        {
                            object[] row = { true, inPath, ArchiveStr, "", "", prErr.None };
                            dataGridView1.Rows.Add(row);
                        }
                        else if (ext == ".cbz" || ext == ".cb7" || ext == ".cbr")
                        {
                            object[] row = { true, inPath, ComicStr, "", "", prErr.None };
                            dataGridView1.Rows.Add(row);
                        }
                    }
                }
            }

            updateOutputNames();

            if (dataGridView1.SortedColumn != null)
            {
                if (dataGridView1.SortOrder == SortOrder.Ascending)
                    dataGridView1.Sort(dataGridView1.SortedColumn, System.ComponentModel.ListSortDirection.Ascending);
                if (dataGridView1.SortOrder == SortOrder.Descending)
                    dataGridView1.Sort(dataGridView1.SortedColumn, System.ComponentModel.ListSortDirection.Descending);
            }
        }
        private void updateOutputNames()
        {
            string inType, inPath, outPath;

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

                //if outPath already exists, create renamed name
                if (File.Exists(outPath) && (fileExistAction == fEA.Rename))
                {
                    //test if pattern contains \n
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

                //if inPath dont exist show warning
                if (!Directory.Exists(inPath) && !File.Exists(inPath))
                {
                    row.Cells[4].Value = "Input file doesn't exist";
                }

                row.Cells[3].Value = outPath;

                //select row based on options
                row.Cells[0].Value = (inType == FolderStr && checkBoxCreateFromFolder.Checked) ||
                                    (inType == ArchiveStr && checkBoxCreateFromArchive.Checked) ||
                                    (inType == ComicStr && checkBoxCreateFromComic.Checked);


            }
            dataGridView1.Refresh();
        }
        private void processAllRows()
        {
            showStatus("Working");

            //reset statusBar
            toolStripProgressBar1.Value = 0;
            toolStripProgressBar1.Maximum = nStep * dataGridView1.Rows.Count;

            //disable buttons
            buttonGo.Enabled = false;
            buttonExit.Enabled = false;
            buttonRefresh.Enabled = false;

            //create outPath if it does not exist
            if (!Directory.Exists(textBoxOutPath.Text))
                Directory.CreateDirectory(textBoxOutPath.Text);

            //reset status & errors for each file
            foreach (DataGridViewRow Row in dataGridView1.Rows)
            {
                Row.Cells[4].Value = "";
                Row.Cells[5].Value = prErr.None;
            }

            crono.Restart();     //crono will be stopped in processEnd()

            showThread("Entering ProcessAllRows");

            //process rows
            if (checkBoxParelize.Checked)
            {
                //parallel
                Task task1 = Task.Run(() =>
                {
                    showThread("Parallel start");
                    Parallel.ForEach(dataGridView1.Rows.Cast<DataGridViewRow>(), row => { processRow(row); });
                });
                task1.ContinueWith((antecedent) =>
                {
                    showThread("Continue With");
                    this.Invoke(new endDelegate(processEnd));
                });
            }
            else
            {
                //sequential
                Task task1 = Task.Run(() =>
                {
                    showThread("Sequential start");
                    foreach (DataGridViewRow row in dataGridView1.Rows) processRow(row);
                });
                task1.ContinueWith((antecedent) =>
                {
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

            //search for errors on each row (cells[5] are hidden)
            int errN = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if ((prErr)row.Cells[5].Value != prErr.None)
                    errN++;
            }

            //update statusbar
            if (errN > 0)
                showError("Finished with errors", crono.Elapsed.TotalSeconds);
            else
                showStatus("Finished", crono.Elapsed.TotalSeconds);

            //disable buttons
            buttonGo.Enabled = true;
            buttonExit.Enabled = true;
            buttonRefresh.Enabled = true;

            //close if selected
            if (checkBoxCloseAtComplete.Checked)
            {
                //show countdown
                System.Threading.Thread.Sleep(1000);
                for (int i = 5; i > 0; i--)
                {
                    showStatus("Closing in " + i.ToString() + " s");
                    System.Threading.Thread.Sleep(1000);
                }
                Close();
            }
        }
        private void processRow(DataGridViewRow row)
        {
            showThread("Process Row " + row.Index.ToString());

            //olny handle files that are checked
            if ((bool)row.Cells[0].Value)
            {
                string inPath = (string)row.Cells[1].Value;
                string inType = (string)row.Cells[2].Value;
                string outPath = (string)row.Cells[3].Value;


                //*********************************************************
                // step 1: extract
                //*********************************************************
                row.Cells[4].Value = "Decompressing";

                if (!Directory.Exists(inPath) && !File.Exists(inPath))
                {
                    row.Cells[4].Value = "Error: Input file don't exist";
                    row.Cells[5].Value = prErr.NoInputFileFolder;
                    BeginInvoke((Action)delegate { toolStripProgressBar1.Value += 5; });  //compensate for resting increments
                    return;
                }

                //get initial tempPath (folder)
                string tempPath = Path.Combine(Path.GetTempPath(), "CBM_" + Path.GetFileNameWithoutExtension(inPath));
                //if tempPath exists, try to delete
                if (Directory.Exists(tempPath))
                {
                    try
                    {
                        Directory.Delete(tempPath, true);
                    }
                    catch
                    {
                    }
                }
                //if still exist, search for unexisting directory
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
                    row.Cells[4].Value = "Error: creating temp directory";
                    row.Cells[5].Value = prErr.CreatingTemp;
                    BeginInvoke((Action)delegate { toolStripProgressBar1.Value += 5; });  //compensate for resting increments
                    return;
                }

                //create tempPath
                Directory.CreateDirectory(tempPath);

                //copy folder or extract archive/comic to tempPath
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

                    //extract  comic/archive to tempPath
                    Process pr7z = new Process();
                    pr7z.StartInfo = new ProcessStartInfo();
                    pr7z.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    pr7z.StartInfo.FileName = "7z.exe";
                    pr7z.StartInfo.Arguments = "x " + quote(inPath) + " -o" + quote(tempPath) + " -aoa";
                    pr7z.Start();
                    pr7z.WaitForExit();
                }

                BeginInvoke((Action)delegate { toolStripProgressBar1.Value++; });


                //*********************************************************
                // Step 2: clean files
                //*********************************************************
                row.Cells[4].Value = "Cleaning";
                //TODO: clean files in tempPath
                BeginInvoke((Action)delegate { toolStripProgressBar1.Value++; });


                //*********************************************************
                // Step 3: compress
                //*********************************************************
                row.Cells[4].Value = "Compressing";

                //if outPath already exists, handle acordingly
                if (File.Exists(outPath))
                {
                    if (fileExistAction == fEA.Overwrite)
                        File.Delete(outPath);
                    else if (fileExistAction == fEA.Skip)
                    {
                        row.Cells[4].Value = "Skipped: file exists";    //skip is not treated as an error)
                        BeginInvoke((Action)delegate { toolStripProgressBar1.Value += 3; });  //compensate for resting increments
                        return;
                    }
                    else if (fileExistAction == fEA.Rename)
                    {
                        row.Cells[4].Value = "Renamed also exist: skipping";    //renaming option, but file exist -> skip
                        BeginInvoke((Action)delegate { toolStripProgressBar1.Value += 3; });  //compensate for resting increments
                        return;
                    }
                }

                //compress to comic
                if (outType == "cbz")
                {
                    /// 7-Zip basic parameters to Compress:
                    ///     7z.exe a {archive} {files|@listfiles} {switches}
                    /// Swithes:
                    ///     -bb{level}      output log level (0=none..3)
                    ///     -mx={level}     compression level (0=none,1,3,5,7,9)
                    ///     -mt={mode}      multithreading mode (on,off)
                    ///     -r              enable recurse directory for wildcards
                    ///     -t{type}        set type of archive (7z,zip)
                    ///     -x!{wildcard}   exclude files

                    Process pr7z = new Process();
                    pr7z.StartInfo = new ProcessStartInfo();
                    pr7z.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    pr7z.StartInfo.FileName = "7z.exe";
                    pr7z.StartInfo.Arguments = "a -mx=0 -tzip -r -mmt=off -bb1 " + quote(outPath) + " " + quote(Path.Combine(tempPath, "*.*"));
                    pr7z.Start();
                    pr7z.WaitForExit();
                }
                else if (outType == "cb7")
                {
                    Process pr7z = new Process();
                    pr7z.StartInfo = new ProcessStartInfo();
                    pr7z.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    pr7z.StartInfo.FileName = "7z.exe";
                    pr7z.StartInfo.Arguments = "a -mx0 -t7z -r -mmt=off " + quote(outPath) + " " + quote(Path.Combine(tempPath, "*.*"));
                    pr7z.Start();
                    pr7z.WaitForExit();
                }
                else if (outType == "cbr")
                {
                    ////test again ir Rar.exe exists
                    //if (!File.Exists(textBoxRarPath.Text))
                    //{
                    //    row.Cells[4].Value = "Error: missing rar.exe";
                    //    row.Cells[5].Value = prErr.MissingRar;
                    //    BeginInvoke((Action)delegate { toolStripProgressBar1.Value += 3; });  //compensate for resting increments
                    //    return;
                    //}

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

                    Process prRar = new Process();
                    prRar.StartInfo = new ProcessStartInfo();
                    prRar.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    prRar.StartInfo.FileName = textBoxRarPath.Text;
                    prRar.StartInfo.Arguments = "a -ed -ep1 -m0 -ma4 -r -mt1 " + quote(outPath) + " " + quote(Path.Combine(tempPath, "*.*"));
                    prRar.Start();
                    prRar.WaitForExit();
                }
                BeginInvoke((Action)delegate { toolStripProgressBar1.Value++; });


                //*********************************************************
                // Step 4: delete inPath 
                //*********************************************************
                row.Cells[4].Value = "Deleting input";
                //if option enabled and output is not overwriting input
                if (checkBoxDeleteInputFiles.Checked && (inPath != outPath))
                {
                    //deletes to recycle bin, using VisualBasic functions: https://diptimayapatra.wordpress.com/2014/01/16/delete-file-to-recycle-bin-in-c/
                    if (Directory.Exists(inPath))
                        Microsoft.VisualBasic.FileIO.FileSystem.DeleteDirectory(inPath, Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs, Microsoft.VisualBasic.FileIO.RecycleOption.SendToRecycleBin);
                    else if (File.Exists(inPath))
                        Microsoft.VisualBasic.FileIO.FileSystem.DeleteFile(inPath, Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs, Microsoft.VisualBasic.FileIO.RecycleOption.SendToRecycleBin);
                }
                BeginInvoke((Action)delegate { toolStripProgressBar1.Value++; });


                //*********************************************************
                // Step 5: delete tempPath
                //*********************************************************
                row.Cells[4].Value = "Deleting temp";
                if (Directory.Exists(tempPath))
                    Directory.Delete(tempPath, true);
                BeginInvoke((Action)delegate { toolStripProgressBar1.Value++; });


                //*********************************************************
                // End
                //*********************************************************
                row.Cells[4].Value = "Finished";
            }
        }
        private void argumentsHandle(string[] args)
        {
            /// -s     start automatically
            /// -up     use previous settings      
            /// -e      exit after completition
            /// -es     exit after successfull completition
            /// -a      add files/folders
            /// -otz    output file type cbz
            /// -ot7    output file type cb7
            /// -otr    output file type cbr
            /// -op     output path
            /// -oeo    output file exists overwrite    
            /// -oes    output file exists skip
            /// -oer<pat>   output file exists rename with <pat> pattern
            /// -m      use multicore
            /// -di     delete input files
            /// -c<pat> clean files 
            /// -c<pat><n>  clean files limiting
            /// -r      remove folder structure
            /// -rs     remove folder structure smart

        }

    }   //formMain
}   //Comic_Book_Maker
