using System;
using System.Diagnostics;   //for processes
using System.IO;            //fo file access
using System.Windows.Forms;

namespace Comic_Book_Maker
{
    public partial class formMain : Form
    {
        public formMain(string[] args1)
        {
            InitializeComponent();

            //settings that are not assignable 
            comboBoxOutputType.SelectedIndex = Properties.Settings.Default.output_type_selection;
            comboBoxFileExistAction.SelectedIndex = Properties.Settings.Default.file_exist_selection;
            this.Size = Properties.Settings.Default.form_size;

            //if command line arguments are given
            if (args1.Length > 0)
                populateGrid(args1, false);

            //configure initial sorting of dataGridView1;
            dataGridView1.Sort(dataGridView1.Columns[1], System.ComponentModel.ListSortDirection.Ascending);

        }

        //TODO: add shell menu entry
        //TODO: finish command line arguments

        //types
        enum stepErr { None, CreatingTemp, Extracting, Cleaning, Compressing, FileExistNoOverwrite, MissingRar, DeletingTemp, DeletingInput }

        //objects
        private const string FolderStr = "Folder", ArchiveStr = "Archive", ComicStr = "Comic";

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
        private void dataGridView1_DragEnter(object sender, DragEventArgs e)
        {
            // If the data is a file or a bitmap, display the copy cursor.
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
                // Assign the file names to a string array, in case the user has selected multiple files.
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
            updateOutputNames();

            bool isRar = comboBoxOutputType.Text == "CBR";
            textBoxRarPath.Enabled = isRar;
            labelRarPath.Enabled = isRar;
            buttonRarPath.Enabled = isRar;
        }
        private void buttonGo_Click(object sender, EventArgs e)
        {
            double t = 0;
            int errorN = steps(ref t);

            //update statusbar
            switch (errorN)
            {
                case 0:
                    showStatus("Finished", t);
                    break;
                case 1:
                    showError("Rar.exe not found");
                    break;
                case 2:
                    showError("Unable to create temporal directory");
                    break;
                default:
                    showError("Undefined error, call agent Mulder");
                    break;
            }

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
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            updateOutputNames();
        }
        private void checkBoxCleanFiles_CheckedChanged(object sender, EventArgs e)
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
        private void checkBoxMultiCore_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownNCore.Enabled = checkBoxMultiCore.Checked;
            labelNCore.Enabled = checkBoxMultiCore.Checked;
        }
        private void comboBoxFileExistAction_SelectedValueChanged(object sender, EventArgs e)
        {
            textBoxSuffixPattern.Visible = (comboBoxFileExistAction.SelectedIndex == 2);  //2=Rename
            labelSuffix.Visible = (comboBoxFileExistAction.SelectedIndex == 2);
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
            if (textBoxRarPath.Enabled && !File.Exists(textBoxRarPath.Text))
                errorProvider1.SetError(textBoxRarPath, "Rar.exe not found");
            else
                errorProvider1.SetError(textBoxRarPath, "");
        }
        private void textBoxFileExistSuffixPattern_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSuffixPattern.Enabled && !textBoxSuffixPattern.Text.Contains("\\n"))
                errorProvider1.SetError(textBoxSuffixPattern, "Suffix pattern doesn't contains \\n");
            else
                errorProvider1.SetError(textBoxSuffixPattern, "");
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
            return ("\"" + s + "\"");
        }
        private void showError(string s)
        {
            toolStripStatusLabel1.ForeColor = System.Drawing.Color.Red;
            toolStripStatusLabel1.Text = "Error:" + s;
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

        private void populateGrid(string[] files, bool addFiles)
        {
            int i, j;
            string inPath;
            if (!addFiles)
                dataGridView1.Rows.Clear();

            try
            {
                for (i = 0; i <= files.GetUpperBound(0); i++)
                {
                    inPath = files[i];
                    if (Directory.Exists(inPath))
                    {
                        j = dataGridView1.Rows.Count;
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[j].Cells[0].Value = true;
                        dataGridView1.Rows[j].Cells[1].Value = inPath;
                        dataGridView1.Rows[j].Cells[2].Value = FolderStr;
                    }
                    else if (File.Exists(inPath))
                    {
                        string ext = Path.GetExtension(inPath).ToLower();
                        if (ext == ".zip" || ext == ".7z" || ext == ".rar")
                        {
                            j = dataGridView1.Rows.Count;
                            dataGridView1.Rows.Add();
                            dataGridView1.Rows[j].Cells[0].Value = true;
                            dataGridView1.Rows[j].Cells[1].Value = inPath;
                            dataGridView1.Rows[j].Cells[2].Value = ArchiveStr;
                        }
                        else if (ext == ".cbz" || ext == ".cb7" || ext == ".cbr")
                        {
                            j = dataGridView1.Rows.Count;
                            dataGridView1.Rows.Add();
                            dataGridView1.Rows[j].Cells[0].Value = true;
                            dataGridView1.Rows[j].Cells[1].Value = inPath;
                            dataGridView1.Rows[j].Cells[2].Value = ComicStr;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            updateOutputNames();
        }
        private void updateOutputNames()
        {
            string inType, inPath, outPath, outExt, outDir;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {


                inPath = (string)dataGridView1.Rows[i].Cells[1].Value;
                inType = (string)dataGridView1.Rows[i].Cells[2].Value;


                outDir = textBoxOutPath.Text;
                outExt = comboBoxOutputType.Text.ToLower();

                if (checkBoxUseOutPath.Checked)
                    outPath = Path.Combine(outDir, Path.ChangeExtension(Path.GetFileName(inPath), outExt));
                else
                    outPath = Path.ChangeExtension(inPath, outExt);

                if (File.Exists(outPath) && (comboBoxFileExistAction.SelectedIndex == 2)) //2 = rename
                {
                    string pattern;
                    if (textBoxSuffixPattern.Text.Contains("\\n"))
                        pattern = textBoxSuffixPattern.Text;
                    else
                        pattern = "_\\n";    //use another pattern

                    string outPath0 = outPath;
                    int j = 1;
                    while (File.Exists(outPath) && j <= 100)
                    {
                        outPath = Path.Combine(Path.GetDirectoryName(outPath0), Path.GetFileNameWithoutExtension(outPath0) + pattern.Replace("\\n", j.ToString()) + Path.GetExtension(outPath0));
                        j++;
                    }
                }

                dataGridView1.Rows[i].Cells[3].Value = outPath;
                dataGridView1.Rows[i].Cells[0].Value = (inType == FolderStr && checkBoxCreateFromFolder.Checked) ||
                                                       (inType == ArchiveStr && checkBoxCreateFromArchive.Checked) ||
                                                       (inType == ComicStr && checkBoxCreateFromComic.Checked);
            }
        }

        //steps functions
        private int steps(ref double t)
        {
            Stopwatch crono = Stopwatch.StartNew();
            //int i;
            //const int nStep = 5;

            //reset status for each file
            //for (i = 0; i < dataGridView1.Rows.Count; i++)
            //    dataGridView1.Rows[i].Cells[4].Value = "";
            int j;
            for (j = 0; j < dataGridView1.Rows.Count; j++)
                dataGridView1.Rows[j].Cells[4].Value = "";

            //reset statusBar
            toolStripProgressBar1.Value = 0;
            toolStripProgressBar1.Maximum = 5 * dataGridView1.Rows.Count;
            showStatus("Working");

            //for (i = 0; i < dataGridView1.Rows.Count; i++)
            System.Threading.Tasks.Parallel.For(0, dataGridView1.Rows.Count - 1, i =>
              {
                  if ((bool)dataGridView1.Rows[i].Cells[0].Value)
                  {
                      string inPath, inType, outPath, tempPath = "", outType;
                      stepErr err;

                      inPath = (string)dataGridView1.Rows[i].Cells[1].Value;
                      inType = (string)dataGridView1.Rows[i].Cells[2].Value;
                      outPath = (string)dataGridView1.Rows[i].Cells[3].Value;
                      outType = comboBoxOutputType.Text.ToLower();

                    //step 1: extract
                    //dataGridView1.Rows[i].Cells[4].Value = "Decompressing";
                    err = step1_Extract(inPath, inType, ref tempPath);
                    //toolStripProgressBar1.Value = nStep * i + 1;

                    //step 2: clean
                    if (err == stepErr.None)
                      {
                        //dataGridView1.Rows[i].Cells[4].Value = "Cleaning";
                        err = step2_Clean(tempPath);
                      }
                    //toolStripProgressBar1.Value = nStep * i + 2;

                    //step 3: compress
                    if (err == stepErr.None)
                      {
                        //dataGridView1.Rows[i].Cells[4].Value = "Compressing";
                        err = step3_Compress(tempPath, outPath, outType);
                      }
                    //toolStripProgressBar1.Value = nStep * i + 3;

                    //step 4: delete input
                    if (err == stepErr.None)
                      {
                        //dataGridView1.Rows[i].Cells[4].Value = "Deleting input";
                        err = step4_DeleteInput(inPath, outPath);
                      }
                    //toolStripProgressBar1.Value = nStep * i + 4;

                    //step 5: delete temporal
                    //dataGridView1.Rows[i].Cells[4].Value = "Deleting temp";
                    err |= step5_DeleteTemp(tempPath);
                    //toolStripProgressBar1.Value = nStep * i + 5;

                    //finished
                    //if (err == stepErr.None)
                    //    dataGridView1.Rows[i].Cells[4].Value = "Finished";
                    //else if (err == stepErr.FileExistNoOverwrite)
                    //    dataGridView1.Rows[i].Cells[4].Value = "Skipped: file exists";
                    //else
                    //    dataGridView1.Rows[i].Cells[4].Value = "Error: " + err.ToString();
                }
              });

            crono.Stop();
            t = crono.Elapsed.TotalSeconds;

            return (0);
        }
        private stepErr step1_Extract(string inPath, string inType, ref string tempPath)
        {
            // if inPath is a folder copy directory to temporal folder
            // if inPath is a comic/archive extract it to a temporal folder

            tempPath = Path.Combine(/*HACK: need to restore real temp dir path *//* Path.GetTempPath()*/ "C:\\Users\\Gabriel\\Desktop\\temp", "CBM_" + Path.GetFileNameWithoutExtension(inPath));

            if (inType == FolderStr)
            {
                //copy folder to tempPath (using VisualBasic function)
                Microsoft.VisualBasic.FileIO.FileSystem.CopyDirectory(inPath, tempPath, true);
            }
            else
            {
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
                //if still exist, return error
                if (Directory.Exists(tempPath))
                    return (stepErr.CreatingTemp);

                //create tempPath
                Directory.CreateDirectory(tempPath);

                /// 7-Zip basic parameters to extract with full path:
                ///     7z.exe x {archive} {switches}
                /// Swithes:
                ///     -ao{mode}       overwrite mode (a=all)
                ///     -o{outdir}      set output directory
                Process pr7z = new Process();
                pr7z.StartInfo = new ProcessStartInfo();
                pr7z.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                pr7z.StartInfo.FileName = "7z.exe";
                pr7z.StartInfo.Arguments = "x " + quote(inPath) + " -o" + quote(tempPath) + " -aoa";
                pr7z.Start();
                pr7z.WaitForExit();
            }
            return (0);
        }
        private stepErr step2_Clean(string tempPath)
        {
            _ = tempPath;
            //TODO: implement clean function
            return (0);
        }
        private stepErr step3_Compress(string tempPath, string outPath, string outType)
        {
            // compress tempPath (folder) to outPath (comic file of type outType)
            // delet outPath if exists previously

            if (File.Exists(outPath))
            {
                if (comboBoxFileExistAction.SelectedIndex == 0)         //Overwrite
                    File.Delete(outPath);
                else if (comboBoxFileExistAction.SelectedIndex == 1)    //Skip
                    return (stepErr.FileExistNoOverwrite);
                else if (comboBoxFileExistAction.SelectedIndex == 2)    //Rename
                    updateOutputNames();
            }

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
                if (!File.Exists(textBoxRarPath.Text))
                    return (stepErr.MissingRar);

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
            return (0);
        }
        private stepErr step4_DeleteInput(string inPath, string outPath)
        {
            //delete inPath if option is enabled
            if (checkBoxDeleteInputFiles.Checked && (inPath != outPath))
            {
                //deletes to recycle bin, using VisualBasic functions
                //https://diptimayapatra.wordpress.com/2014/01/16/delete-file-to-recycle-bin-in-c/

                if (Directory.Exists(inPath))
                    Microsoft.VisualBasic.FileIO.FileSystem.DeleteDirectory(inPath, Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs, Microsoft.VisualBasic.FileIO.RecycleOption.SendToRecycleBin);
                else if (File.Exists(inPath))
                    Microsoft.VisualBasic.FileIO.FileSystem.DeleteFile(inPath, Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs, Microsoft.VisualBasic.FileIO.RecycleOption.SendToRecycleBin);
            }
            return (0);
        }
        private stepErr step5_DeleteTemp(string tempPath)
        {
            //delete tempPath
            if (Directory.Exists(tempPath))
                Directory.Delete(tempPath, true);
            return (0);
        }








    }
}
