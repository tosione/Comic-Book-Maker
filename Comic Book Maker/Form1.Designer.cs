﻿
namespace Comic_Book_Maker
{
    partial class formMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxClean = new System.Windows.Forms.CheckBox();
            this.textBoxCleanFiles = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.numericUpDownCleanLimit = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxRemoveFolder = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelRarPath = new System.Windows.Forms.Label();
            this.buttonRarPath = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonGo = new System.Windows.Forms.Button();
            this.comboBoxOutputType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxRenameSuffix = new System.Windows.Forms.TextBox();
            this.checkBoxUseOutPath = new System.Windows.Forms.CheckBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.checkBoxCreateFromFolder = new System.Windows.Forms.CheckBox();
            this.checkBoxCreateFromComic = new System.Windows.Forms.CheckBox();
            this.checkBoxCreateFromArchive = new System.Windows.Forms.CheckBox();
            this.checkBoxParelize = new System.Windows.Forms.CheckBox();
            this.buttonSendtoShortcut = new System.Windows.Forms.Button();
            this.textBoxRarPath = new System.Windows.Forms.TextBox();
            this.checkBoxCloseAtComplete = new System.Windows.Forms.CheckBox();
            this.checkBoxStartAfterFileAdd = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnInput = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOutput = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnError = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.labelSuffix = new System.Windows.Forms.Label();
            this.comboBoxFileExistAction = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonOutputPath = new System.Windows.Forms.Button();
            this.textBoxOutPath = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonCancelClosing = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxDeleteInputFiles = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.timerClose = new System.Windows.Forms.Timer(this.components);
            this.labelAbout = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCleanLimit)).BeginInit();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Location = new System.Drawing.Point(539, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 114);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cleanup files";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel8, 0, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(276, 79);
            this.tableLayoutPanel3.TabIndex = 10;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.Controls.Add(this.checkBoxClean, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.textBoxCleanFiles, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(276, 26);
            this.tableLayoutPanel5.TabIndex = 12;
            // 
            // checkBoxClean
            // 
            this.checkBoxClean.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxClean.AutoSize = true;
            this.checkBoxClean.Checked = global::Comic_Book_Maker.Properties.Settings.Default.clean_files_enable;
            this.checkBoxClean.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxClean.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Comic_Book_Maker.Properties.Settings.Default, "clean_files_enable", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxClean.Location = new System.Drawing.Point(3, 4);
            this.checkBoxClean.Name = "checkBoxClean";
            this.checkBoxClean.Size = new System.Drawing.Size(77, 17);
            this.checkBoxClean.TabIndex = 0;
            this.checkBoxClean.Text = "Clean files:";
            this.toolTip1.SetToolTip(this.checkBoxClean, "Files that match this patterns will not be \r\nadded to the comic.\r\n");
            this.checkBoxClean.UseVisualStyleBackColor = true;
            this.checkBoxClean.CheckedChanged += new System.EventHandler(this.checkBoxClean_CheckedChanged);
            // 
            // textBoxCleanFiles
            // 
            this.textBoxCleanFiles.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxCleanFiles.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Comic_Book_Maker.Properties.Settings.Default, "clean_files_string", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxCleanFiles.Location = new System.Drawing.Point(86, 3);
            this.textBoxCleanFiles.Name = "textBoxCleanFiles";
            this.textBoxCleanFiles.Size = new System.Drawing.Size(187, 20);
            this.textBoxCleanFiles.TabIndex = 1;
            this.textBoxCleanFiles.Text = global::Comic_Book_Maker.Properties.Settings.Default.clean_files_string;
            this.toolTip1.SetToolTip(this.textBoxCleanFiles, "Use | to separate multiple files. \r\nWillcards ? and * are allowed.");
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.AutoSize = true;
            this.tableLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.Controls.Add(this.numericUpDownCleanLimit, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 26);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.Size = new System.Drawing.Size(276, 26);
            this.tableLayoutPanel6.TabIndex = 12;
            // 
            // numericUpDownCleanLimit
            // 
            this.numericUpDownCleanLimit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDownCleanLimit.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::Comic_Book_Maker.Properties.Settings.Default, "clean_files_limit_n", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numericUpDownCleanLimit.Location = new System.Drawing.Point(130, 3);
            this.numericUpDownCleanLimit.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDownCleanLimit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCleanLimit.Name = "numericUpDownCleanLimit";
            this.numericUpDownCleanLimit.Size = new System.Drawing.Size(42, 20);
            this.numericUpDownCleanLimit.TabIndex = 4;
            this.toolTip1.SetToolTip(this.numericUpDownCleanLimit, "If more files than this limit are found to \r\nbe excluded, the file will be skippe" +
        "d.");
            this.numericUpDownCleanLimit.Value = global::Comic_Book_Maker.Properties.Settings.Default.clean_files_limit_n;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Avoid clean if more than";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(178, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "files will be deleted";
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.AutoSize = true;
            this.tableLayoutPanel8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel8.Controls.Add(this.comboBoxRemoveFolder, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 52);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(193, 27);
            this.tableLayoutPanel8.TabIndex = 11;
            // 
            // comboBoxRemoveFolder
            // 
            this.comboBoxRemoveFolder.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxRemoveFolder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRemoveFolder.FormattingEnabled = true;
            this.comboBoxRemoveFolder.Items.AddRange(new object[] {
            "No",
            "Yes",
            "Smart"});
            this.comboBoxRemoveFolder.Location = new System.Drawing.Point(132, 3);
            this.comboBoxRemoveFolder.Name = "comboBoxRemoveFolder";
            this.comboBoxRemoveFolder.Size = new System.Drawing.Size(58, 21);
            this.comboBoxRemoveFolder.TabIndex = 10;
            this.toolTip1.SetToolTip(this.comboBoxRemoveFolder, resources.GetString("comboBoxRemoveFolder.ToolTip"));
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Remove folder structure:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRarPath
            // 
            this.labelRarPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelRarPath.AutoSize = true;
            this.labelRarPath.Location = new System.Drawing.Point(3, 6);
            this.labelRarPath.Name = "labelRarPath";
            this.labelRarPath.Size = new System.Drawing.Size(71, 13);
            this.labelRarPath.TabIndex = 3;
            this.labelRarPath.Text = "Rar.exe path:";
            // 
            // buttonRarPath
            // 
            this.buttonRarPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonRarPath.Location = new System.Drawing.Point(286, 3);
            this.buttonRarPath.Name = "buttonRarPath";
            this.buttonRarPath.Size = new System.Drawing.Size(24, 20);
            this.buttonRarPath.TabIndex = 6;
            this.buttonRarPath.Text = "...";
            this.buttonRarPath.Click += new System.EventHandler(this.buttonRarPath_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "If file exists:";
            // 
            // buttonGo
            // 
            this.buttonGo.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonGo.Location = new System.Drawing.Point(168, 3);
            this.buttonGo.Name = "buttonGo";
            this.tableLayoutPanel1.SetRowSpan(this.buttonGo, 2);
            this.buttonGo.Size = new System.Drawing.Size(140, 46);
            this.buttonGo.TabIndex = 6;
            this.buttonGo.Text = "Go";
            this.toolTip1.SetToolTip(this.buttonGo, resources.GetString("buttonGo.ToolTip"));
            this.buttonGo.UseVisualStyleBackColor = false;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // comboBoxOutputType
            // 
            this.comboBoxOutputType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxOutputType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOutputType.FormattingEnabled = true;
            this.comboBoxOutputType.Items.AddRange(new object[] {
            "CBZ",
            "CB7",
            "CBR"});
            this.comboBoxOutputType.Location = new System.Drawing.Point(87, 3);
            this.comboBoxOutputType.Name = "comboBoxOutputType";
            this.comboBoxOutputType.Size = new System.Drawing.Size(58, 21);
            this.comboBoxOutputType.TabIndex = 10;
            this.toolTip1.SetToolTip(this.comboBoxOutputType, resources.GetString("comboBoxOutputType.ToolTip"));
            this.comboBoxOutputType.SelectedIndexChanged += new System.EventHandler(this.comboBoxOutputType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Output filetype:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxRenameSuffix
            // 
            this.textBoxRenameSuffix.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxRenameSuffix.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Comic_Book_Maker.Properties.Settings.Default, "file_exist_suffix", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxRenameSuffix.Location = new System.Drawing.Point(207, 3);
            this.textBoxRenameSuffix.Name = "textBoxRenameSuffix";
            this.textBoxRenameSuffix.Size = new System.Drawing.Size(47, 20);
            this.textBoxRenameSuffix.TabIndex = 1;
            this.textBoxRenameSuffix.Text = global::Comic_Book_Maker.Properties.Settings.Default.file_exist_suffix;
            this.toolTip1.SetToolTip(this.textBoxRenameSuffix, "Needs to include \\n which will be substituted by numerical value.");
            this.textBoxRenameSuffix.EnabledChanged += new System.EventHandler(this.textBoxtextBoxRenameSuffix_TextChanged);
            this.textBoxRenameSuffix.TextChanged += new System.EventHandler(this.textBoxtextBoxRenameSuffix_TextChanged);
            this.textBoxRenameSuffix.VisibleChanged += new System.EventHandler(this.textBoxtextBoxRenameSuffix_TextChanged);
            // 
            // checkBoxUseOutPath
            // 
            this.checkBoxUseOutPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxUseOutPath.AutoSize = true;
            this.checkBoxUseOutPath.Checked = global::Comic_Book_Maker.Properties.Settings.Default.use_ouput_folder;
            this.checkBoxUseOutPath.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxUseOutPath.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Comic_Book_Maker.Properties.Settings.Default, "use_ouput_folder", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxUseOutPath.Location = new System.Drawing.Point(3, 111);
            this.checkBoxUseOutPath.Name = "checkBoxUseOutPath";
            this.checkBoxUseOutPath.Size = new System.Drawing.Size(105, 17);
            this.checkBoxUseOutPath.TabIndex = 2;
            this.checkBoxUseOutPath.Text = "Use output path:";
            this.toolTip1.SetToolTip(this.checkBoxUseOutPath, "If disabled, files wil be saved in same folder as input.");
            this.checkBoxUseOutPath.UseVisualStyleBackColor = true;
            this.checkBoxUseOutPath.CheckedChanged += new System.EventHandler(this.checkBoxOutPath_CheckedChanged);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.Location = new System.Drawing.Point(168, 55);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(140, 22);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Exit";
            this.toolTip1.SetToolTip(this.buttonExit, "Exit program (Esc).\r\n\r\nAll settings will be saved at \r\nexit and restored at start" +
        "up.");
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonRefresh.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonRefresh.Location = new System.Drawing.Point(168, 83);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(140, 22);
            this.buttonRefresh.TabIndex = 6;
            this.buttonRefresh.Text = "Refresh files";
            this.toolTip1.SetToolTip(this.buttonRefresh, "Check input files and update output names (F5).");
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // checkBoxCreateFromFolder
            // 
            this.checkBoxCreateFromFolder.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxCreateFromFolder.AutoSize = true;
            this.checkBoxCreateFromFolder.Checked = global::Comic_Book_Maker.Properties.Settings.Default.create_from_folders;
            this.checkBoxCreateFromFolder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCreateFromFolder.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Comic_Book_Maker.Properties.Settings.Default, "create_from_folders", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxCreateFromFolder.Location = new System.Drawing.Point(3, 3);
            this.checkBoxCreateFromFolder.Name = "checkBoxCreateFromFolder";
            this.checkBoxCreateFromFolder.Size = new System.Drawing.Size(150, 17);
            this.checkBoxCreateFromFolder.TabIndex = 0;
            this.checkBoxCreateFromFolder.Text = "Create comics from folders";
            this.toolTip1.SetToolTip(this.checkBoxCreateFromFolder, "Each folder will be compressed to a comic file.");
            this.checkBoxCreateFromFolder.UseVisualStyleBackColor = true;
            this.checkBoxCreateFromFolder.CheckedChanged += new System.EventHandler(this.checkBoxCreateFromFolder_CheckedChanged);
            // 
            // checkBoxCreateFromComic
            // 
            this.checkBoxCreateFromComic.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxCreateFromComic.AutoSize = true;
            this.checkBoxCreateFromComic.Checked = global::Comic_Book_Maker.Properties.Settings.Default.convert_comics;
            this.checkBoxCreateFromComic.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCreateFromComic.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Comic_Book_Maker.Properties.Settings.Default, "convert_comics", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxCreateFromComic.Location = new System.Drawing.Point(3, 57);
            this.checkBoxCreateFromComic.Name = "checkBoxCreateFromComic";
            this.checkBoxCreateFromComic.Size = new System.Drawing.Size(99, 17);
            this.checkBoxCreateFromComic.TabIndex = 0;
            this.checkBoxCreateFromComic.Text = "Convert comics";
            this.toolTip1.SetToolTip(this.checkBoxCreateFromComic, "Valid comic types: CBZ, CB7, CBR");
            this.checkBoxCreateFromComic.UseVisualStyleBackColor = true;
            this.checkBoxCreateFromComic.CheckedChanged += new System.EventHandler(this.checkBoxCreateFromComic_CheckedChanged);
            // 
            // checkBoxCreateFromArchive
            // 
            this.checkBoxCreateFromArchive.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxCreateFromArchive.AutoSize = true;
            this.checkBoxCreateFromArchive.Checked = global::Comic_Book_Maker.Properties.Settings.Default.create_from_archives;
            this.checkBoxCreateFromArchive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCreateFromArchive.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Comic_Book_Maker.Properties.Settings.Default, "create_from_archives", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxCreateFromArchive.Location = new System.Drawing.Point(3, 29);
            this.checkBoxCreateFromArchive.Name = "checkBoxCreateFromArchive";
            this.checkBoxCreateFromArchive.Size = new System.Drawing.Size(159, 17);
            this.checkBoxCreateFromArchive.TabIndex = 0;
            this.checkBoxCreateFromArchive.Text = "Create comics from archives";
            this.toolTip1.SetToolTip(this.checkBoxCreateFromArchive, "Valid archives types: ZIP, 7Z, RAR");
            this.checkBoxCreateFromArchive.UseVisualStyleBackColor = true;
            this.checkBoxCreateFromArchive.CheckedChanged += new System.EventHandler(this.checkBoxCreateFromArchive_CheckedChanged);
            // 
            // checkBoxParelize
            // 
            this.checkBoxParelize.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxParelize.AutoSize = true;
            this.checkBoxParelize.Checked = global::Comic_Book_Maker.Properties.Settings.Default.multi_core_enable;
            this.checkBoxParelize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxParelize.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Comic_Book_Maker.Properties.Settings.Default, "multi_core_enable", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxParelize.Location = new System.Drawing.Point(3, 3);
            this.checkBoxParelize.Name = "checkBoxParelize";
            this.checkBoxParelize.Size = new System.Drawing.Size(147, 17);
            this.checkBoxParelize.TabIndex = 0;
            this.checkBoxParelize.Text = "Use multi-core processing";
            this.toolTip1.SetToolTip(this.checkBoxParelize, "Use multiple threads in parallel to speed up the process.");
            this.checkBoxParelize.UseVisualStyleBackColor = true;
            // 
            // buttonSendtoShortcut
            // 
            this.buttonSendtoShortcut.Location = new System.Drawing.Point(3, 3);
            this.buttonSendtoShortcut.Name = "buttonSendtoShortcut";
            this.buttonSendtoShortcut.Size = new System.Drawing.Size(55, 23);
            this.buttonSendtoShortcut.TabIndex = 4;
            this.buttonSendtoShortcut.Text = "Remove";
            this.toolTip1.SetToolTip(this.buttonSendtoShortcut, resources.GetString("buttonSendtoShortcut.ToolTip"));
            this.buttonSendtoShortcut.Click += new System.EventHandler(this.buttonSendtoShortcut_Click);
            // 
            // textBoxRarPath
            // 
            this.textBoxRarPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxRarPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Comic_Book_Maker.Properties.Settings.Default, "rar_path", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxRarPath.Location = new System.Drawing.Point(80, 3);
            this.textBoxRarPath.Name = "textBoxRarPath";
            this.textBoxRarPath.Size = new System.Drawing.Size(200, 20);
            this.textBoxRarPath.TabIndex = 1;
            this.textBoxRarPath.Text = global::Comic_Book_Maker.Properties.Settings.Default.rar_path;
            this.toolTip1.SetToolTip(this.textBoxRarPath, "Used for CBR files.\r\nIncluded in comercial program Winrar.");
            this.textBoxRarPath.EnabledChanged += new System.EventHandler(this.textBoxRarPath_Changed);
            this.textBoxRarPath.TextChanged += new System.EventHandler(this.textBoxRarPath_Changed);
            this.textBoxRarPath.VisibleChanged += new System.EventHandler(this.textBoxRarPath_Changed);
            // 
            // checkBoxCloseAtComplete
            // 
            this.checkBoxCloseAtComplete.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxCloseAtComplete.AutoSize = true;
            this.checkBoxCloseAtComplete.Checked = global::Comic_Book_Maker.Properties.Settings.Default.close_after_complete;
            this.checkBoxCloseAtComplete.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Comic_Book_Maker.Properties.Settings.Default, "close_after_complete", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxCloseAtComplete.Location = new System.Drawing.Point(3, 49);
            this.checkBoxCloseAtComplete.Name = "checkBoxCloseAtComplete";
            this.checkBoxCloseAtComplete.Size = new System.Drawing.Size(190, 17);
            this.checkBoxCloseAtComplete.TabIndex = 0;
            this.checkBoxCloseAtComplete.Text = "Close after successfull completition";
            this.toolTip1.SetToolTip(this.checkBoxCloseAtComplete, "If enabled, will close the program after succesfully\r\nconverting all files.\r\nA 5 " +
        "secconds countdown will be shown, allowing \r\nto cancel the closing.");
            this.checkBoxCloseAtComplete.UseVisualStyleBackColor = true;
            // 
            // checkBoxStartAfterFileAdd
            // 
            this.checkBoxStartAfterFileAdd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxStartAfterFileAdd.AutoSize = true;
            this.checkBoxStartAfterFileAdd.Checked = global::Comic_Book_Maker.Properties.Settings.Default.go_after_file_add;
            this.checkBoxStartAfterFileAdd.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Comic_Book_Maker.Properties.Settings.Default, "go_after_file_add", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxStartAfterFileAdd.Location = new System.Drawing.Point(3, 26);
            this.checkBoxStartAfterFileAdd.Name = "checkBoxStartAfterFileAdd";
            this.checkBoxStartAfterFileAdd.Size = new System.Drawing.Size(192, 17);
            this.checkBoxStartAfterFileAdd.TabIndex = 0;
            this.checkBoxStartAfterFileAdd.Text = "Start automatically after adding files";
            this.toolTip1.SetToolTip(this.checkBoxStartAfterFileAdd, resources.GetString("checkBoxStartAfterFileAdd.ToolTip"));
            this.checkBoxStartAfterFileAdd.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSelect,
            this.ColumnInput,
            this.ColumnType,
            this.ColumnOutput,
            this.ColumnState,
            this.ColumnError});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.Location = new System.Drawing.Point(12, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 23;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.Size = new System.Drawing.Size(521, 525);
            this.dataGridView1.TabIndex = 13;
            this.toolTip1.SetToolTip(this.dataGridView1, "Drag and drop valid files here.\r\n\r\nValid file types:\r\n-Folders with files.\r\n-Arch" +
        "ives: ZIP, 7Z, RAR.\r\n-Comics: CBZ, CB7, CBR.\r\n\r\nOutput names can be editet wich " +
        "F2 \r\nor by clicking on the name.");
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            this.dataGridView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridView1_DragDrop);
            this.dataGridView1.DragOver += new System.Windows.Forms.DragEventHandler(this.dataGridView1_DragOver);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // ColumnSelect
            // 
            this.ColumnSelect.HeaderText = "";
            this.ColumnSelect.Name = "ColumnSelect";
            this.ColumnSelect.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnSelect.Width = 21;
            // 
            // ColumnInput
            // 
            this.ColumnInput.HeaderText = "Input";
            this.ColumnInput.Name = "ColumnInput";
            this.ColumnInput.ReadOnly = true;
            this.ColumnInput.Width = global::Comic_Book_Maker.Properties.Settings.Default.column_width_input;
            // 
            // ColumnType
            // 
            this.ColumnType.HeaderText = "Type";
            this.ColumnType.Name = "ColumnType";
            this.ColumnType.ReadOnly = true;
            this.ColumnType.Width = global::Comic_Book_Maker.Properties.Settings.Default.column_width_type;
            // 
            // ColumnOutput
            // 
            this.ColumnOutput.HeaderText = "Output";
            this.ColumnOutput.Name = "ColumnOutput";
            this.ColumnOutput.Width = global::Comic_Book_Maker.Properties.Settings.Default.column_width_input;
            // 
            // ColumnState
            // 
            this.ColumnState.HeaderText = "State";
            this.ColumnState.Name = "ColumnState";
            this.ColumnState.ReadOnly = true;
            this.ColumnState.Width = global::Comic_Book_Maker.Properties.Settings.Default.column_width_state;
            // 
            // ColumnError
            // 
            this.ColumnError.HeaderText = "Error";
            this.ColumnError.Name = "ColumnError";
            this.ColumnError.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "RAR executable|Rar.exe";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(876, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(400, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel1.Text = " ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel10, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel7, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxUseOutPath, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxCreateFromFolder, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxCreateFromComic, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxCreateFromArchive, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonGo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonExit, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonRefresh, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(545, 9);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(311, 184);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel10.AutoSize = true;
            this.tableLayoutPanel10.ColumnCount = 4;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel10, 2);
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel10.Controls.Add(this.textBoxRenameSuffix, 3, 0);
            this.tableLayoutPanel10.Controls.Add(this.labelSuffix, 2, 0);
            this.tableLayoutPanel10.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.comboBoxFileExistAction, 1, 0);
            this.tableLayoutPanel10.Location = new System.Drawing.Point(0, 157);
            this.tableLayoutPanel10.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel10.Size = new System.Drawing.Size(284, 27);
            this.tableLayoutPanel10.TabIndex = 14;
            // 
            // labelSuffix
            // 
            this.labelSuffix.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSuffix.AutoSize = true;
            this.labelSuffix.Location = new System.Drawing.Point(145, 7);
            this.labelSuffix.Name = "labelSuffix";
            this.labelSuffix.Size = new System.Drawing.Size(56, 13);
            this.labelSuffix.TabIndex = 3;
            this.labelSuffix.Text = "with suffix:";
            // 
            // comboBoxFileExistAction
            // 
            this.comboBoxFileExistAction.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxFileExistAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFileExistAction.FormattingEnabled = true;
            this.comboBoxFileExistAction.Items.AddRange(new object[] {
            "Overwrite",
            "Skip",
            "Rename"});
            this.comboBoxFileExistAction.Location = new System.Drawing.Point(70, 3);
            this.comboBoxFileExistAction.Name = "comboBoxFileExistAction";
            this.comboBoxFileExistAction.Size = new System.Drawing.Size(69, 21);
            this.comboBoxFileExistAction.TabIndex = 14;
            this.comboBoxFileExistAction.SelectedValueChanged += new System.EventHandler(this.comboBoxFileExistAction_SelectedValueChanged);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.AutoSize = true;
            this.tableLayoutPanel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel7, 2);
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.Controls.Add(this.buttonOutputPath, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.textBoxOutPath, 0, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 131);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.Size = new System.Drawing.Size(298, 26);
            this.tableLayoutPanel7.TabIndex = 13;
            // 
            // buttonOutputPath
            // 
            this.buttonOutputPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonOutputPath.Location = new System.Drawing.Point(271, 3);
            this.buttonOutputPath.Name = "buttonOutputPath";
            this.buttonOutputPath.Size = new System.Drawing.Size(24, 20);
            this.buttonOutputPath.TabIndex = 6;
            this.buttonOutputPath.Text = "...";
            this.buttonOutputPath.Click += new System.EventHandler(this.buttonOutputPath_Click);
            // 
            // textBoxOutPath
            // 
            this.textBoxOutPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxOutPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Comic_Book_Maker.Properties.Settings.Default, "output_path", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxOutPath.Location = new System.Drawing.Point(3, 3);
            this.textBoxOutPath.Name = "textBoxOutPath";
            this.textBoxOutPath.Size = new System.Drawing.Size(262, 20);
            this.textBoxOutPath.TabIndex = 1;
            this.textBoxOutPath.Text = global::Comic_Book_Maker.Properties.Settings.Default.output_path;
            this.textBoxOutPath.TextChanged += new System.EventHandler(this.textBoxOutPath_TextChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.comboBoxOutputType, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 80);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(148, 27);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // buttonCancelClosing
            // 
            this.buttonCancelClosing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCancelClosing.BackColor = System.Drawing.Color.LightCoral;
            this.buttonCancelClosing.Location = new System.Drawing.Point(539, 540);
            this.buttonCancelClosing.Name = "buttonCancelClosing";
            this.buttonCancelClosing.Size = new System.Drawing.Size(100, 21);
            this.buttonCancelClosing.TabIndex = 6;
            this.buttonCancelClosing.Text = "Cancel closing";
            this.buttonCancelClosing.UseVisualStyleBackColor = false;
            this.buttonCancelClosing.Visible = false;
            this.buttonCancelClosing.Click += new System.EventHandler(this.buttonCancelClosing_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.checkBoxParelize, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel11, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel9, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.checkBoxDeleteInputFiles, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.checkBoxCloseAtComplete, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.checkBoxStartAfterFileAdd, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(9, 19);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 6;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(313, 147);
            this.tableLayoutPanel4.TabIndex = 11;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.AutoSize = true;
            this.tableLayoutPanel11.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel11.ColumnCount = 2;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel11.Controls.Add(this.buttonSendtoShortcut, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.label7, 1, 0);
            this.tableLayoutPanel11.Location = new System.Drawing.Point(0, 118);
            this.tableLayoutPanel11.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 1;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel11.Size = new System.Drawing.Size(295, 29);
            this.tableLayoutPanel11.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(228, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Comic Book Maker from SendTo context menu";
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel9.AutoSize = true;
            this.tableLayoutPanel9.ColumnCount = 3;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel9.Controls.Add(this.buttonRarPath, 2, 0);
            this.tableLayoutPanel9.Controls.Add(this.labelRarPath, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.textBoxRarPath, 1, 0);
            this.tableLayoutPanel9.Location = new System.Drawing.Point(0, 92);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel9.Size = new System.Drawing.Size(313, 26);
            this.tableLayoutPanel9.TabIndex = 14;
            // 
            // checkBoxDeleteInputFiles
            // 
            this.checkBoxDeleteInputFiles.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxDeleteInputFiles.AutoSize = true;
            this.checkBoxDeleteInputFiles.Checked = global::Comic_Book_Maker.Properties.Settings.Default.delete_input_files;
            this.checkBoxDeleteInputFiles.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Comic_Book_Maker.Properties.Settings.Default, "delete_input_files", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxDeleteInputFiles.Location = new System.Drawing.Point(3, 72);
            this.checkBoxDeleteInputFiles.Name = "checkBoxDeleteInputFiles";
            this.checkBoxDeleteInputFiles.Size = new System.Drawing.Size(296, 17);
            this.checkBoxDeleteInputFiles.TabIndex = 0;
            this.checkBoxDeleteInputFiles.Text = "Delete input files at successfull completition (Recycle Bin)";
            this.checkBoxDeleteInputFiles.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.AutoSize = true;
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.Controls.Add(this.tableLayoutPanel4);
            this.groupBox3.Location = new System.Drawing.Point(539, 327);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(325, 182);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Options";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // timerClose
            // 
            this.timerClose.Tick += new System.EventHandler(this.timerClose_Tick);
            // 
            // labelAbout
            // 
            this.labelAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAbout.AutoSize = true;
            this.labelAbout.Location = new System.Drawing.Point(545, 521);
            this.labelAbout.Name = "labelAbout";
            this.labelAbout.Size = new System.Drawing.Size(121, 13);
            this.labelAbout.TabIndex = 3;
            this.labelAbout.Text = "Comic Book Maker v1.0";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(671, 521);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(193, 13);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "github.com/tosione/Comic-Book-Maker";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // formMain
            // 
            this.AcceptButton = this.buttonGo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 561);
            this.Controls.Add(this.buttonCancelClosing);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.labelAbout);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::Comic_Book_Maker.Properties.Settings.Default, "form_location", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Location = global::Comic_Book_Maker.Properties.Settings.Default.form_location;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Comic Book Maker";
            this.toolTip1.SetToolTip(this, "Files to clean: use ? and * wildcards. Multiple types separated by |.");
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form1_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formMain_KeyDown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCleanLimit)).EndInit();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBoxCreateFromComic;
        private System.Windows.Forms.CheckBox checkBoxCreateFromArchive;
        private System.Windows.Forms.CheckBox checkBoxCreateFromFolder;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxRenameSuffix;
        private System.Windows.Forms.NumericUpDown numericUpDownCleanLimit;
        private System.Windows.Forms.TextBox textBoxCleanFiles;
        private System.Windows.Forms.CheckBox checkBoxClean;
        private System.Windows.Forms.CheckBox checkBoxDeleteInputFiles;
        private System.Windows.Forms.CheckBox checkBoxCloseAtComplete;
        private System.Windows.Forms.CheckBox checkBoxParelize;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.TextBox textBoxRarPath;
        private System.Windows.Forms.Label labelRarPath;
        private System.Windows.Forms.Button buttonRarPath;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ComboBox comboBoxOutputType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBoxFileExistAction;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Label labelSuffix;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TextBox textBoxOutPath;
        private System.Windows.Forms.CheckBox checkBoxUseOutPath;
        private System.Windows.Forms.Button buttonOutputPath;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInput;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOutput;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnState;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.ComboBox comboBoxRemoveFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.Button buttonSendtoShortcut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonCancelClosing;
        private System.Windows.Forms.Timer timerClose;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label labelAbout;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBoxStartAfterFileAdd;
    }
}

