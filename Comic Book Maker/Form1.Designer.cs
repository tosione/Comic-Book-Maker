
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
            this.checkBoxRemoveFoldersSmart = new System.Windows.Forms.CheckBox();
            this.checkBoxRemoveFolders = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxClean = new System.Windows.Forms.CheckBox();
            this.textBoxCleanFiles = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.numericUpDownCleanLimit = new System.Windows.Forms.NumericUpDown();
            this.checkBoxCleanLimit = new System.Windows.Forms.CheckBox();
            this.labelRarPath = new System.Windows.Forms.Label();
            this.buttonRarPath = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonGo = new System.Windows.Forms.Button();
            this.comboBoxOutputType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxRenameSuffix = new System.Windows.Forms.TextBox();
            this.labelSuffix = new System.Windows.Forms.Label();
            this.comboBoxFileExistAction = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonOutputPath = new System.Windows.Forms.Button();
            this.textBoxOutPath = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxUseOutPath = new System.Windows.Forms.CheckBox();
            this.checkBoxCreateFromFolder = new System.Windows.Forms.CheckBox();
            this.checkBoxCreateFromComic = new System.Windows.Forms.CheckBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.checkBoxCreateFromArchive = new System.Windows.Forms.CheckBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxParelize = new System.Windows.Forms.CheckBox();
            this.checkBoxDeleteInputFiles = new System.Windows.Forms.CheckBox();
            this.checkBoxCloseAtComplete = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxRarPath = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnInput = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOutput = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnError = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCleanLimit)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Location = new System.Drawing.Point(600, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 133);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Clean files";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.checkBoxRemoveFoldersSmart, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.checkBoxRemoveFolders, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(233, 98);
            this.tableLayoutPanel3.TabIndex = 10;
            // 
            // checkBoxRemoveFoldersSmart
            // 
            this.checkBoxRemoveFoldersSmart.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxRemoveFoldersSmart.AutoSize = true;
            this.checkBoxRemoveFoldersSmart.Checked = global::Comic_Book_Maker.Properties.Settings.Default.remove_folders_smart;
            this.checkBoxRemoveFoldersSmart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRemoveFoldersSmart.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Comic_Book_Maker.Properties.Settings.Default, "remove_folders_smart", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxRemoveFoldersSmart.Location = new System.Drawing.Point(3, 78);
            this.checkBoxRemoveFoldersSmart.Name = "checkBoxRemoveFoldersSmart";
            this.checkBoxRemoveFoldersSmart.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.checkBoxRemoveFoldersSmart.Size = new System.Drawing.Size(73, 17);
            this.checkBoxRemoveFoldersSmart.TabIndex = 0;
            this.checkBoxRemoveFoldersSmart.Text = "Smart";
            this.checkBoxRemoveFoldersSmart.UseVisualStyleBackColor = true;
            // 
            // checkBoxRemoveFolders
            // 
            this.checkBoxRemoveFolders.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxRemoveFolders.AutoSize = true;
            this.checkBoxRemoveFolders.Checked = global::Comic_Book_Maker.Properties.Settings.Default.remove_folders;
            this.checkBoxRemoveFolders.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRemoveFolders.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Comic_Book_Maker.Properties.Settings.Default, "remove_folders", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxRemoveFolders.Location = new System.Drawing.Point(3, 55);
            this.checkBoxRemoveFolders.Name = "checkBoxRemoveFolders";
            this.checkBoxRemoveFolders.Size = new System.Drawing.Size(139, 17);
            this.checkBoxRemoveFolders.TabIndex = 0;
            this.checkBoxRemoveFolders.Text = "Remove folder structure";
            this.checkBoxRemoveFolders.UseVisualStyleBackColor = true;
            this.checkBoxRemoveFolders.CheckedChanged += new System.EventHandler(this.checkBoxRemoveFolders_CheckedChanged);
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
            this.tableLayoutPanel5.Size = new System.Drawing.Size(233, 26);
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
            this.checkBoxClean.UseVisualStyleBackColor = true;
            this.checkBoxClean.CheckedChanged += new System.EventHandler(this.checkBoxClean_CheckedChanged);
            // 
            // textBoxCleanFiles
            // 
            this.textBoxCleanFiles.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxCleanFiles.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Comic_Book_Maker.Properties.Settings.Default, "clean_files_string", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxCleanFiles.Location = new System.Drawing.Point(86, 3);
            this.textBoxCleanFiles.Name = "textBoxCleanFiles";
            this.textBoxCleanFiles.Size = new System.Drawing.Size(144, 20);
            this.textBoxCleanFiles.TabIndex = 1;
            this.textBoxCleanFiles.Text = global::Comic_Book_Maker.Properties.Settings.Default.clean_files_string;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.AutoSize = true;
            this.tableLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.Controls.Add(this.numericUpDownCleanLimit, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.checkBoxCleanLimit, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 26);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.Size = new System.Drawing.Size(227, 26);
            this.tableLayoutPanel6.TabIndex = 12;
            // 
            // numericUpDownCleanLimit
            // 
            this.numericUpDownCleanLimit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDownCleanLimit.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::Comic_Book_Maker.Properties.Settings.Default, "clean_files_limit_n", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numericUpDownCleanLimit.Location = new System.Drawing.Point(182, 3);
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
            this.numericUpDownCleanLimit.Value = global::Comic_Book_Maker.Properties.Settings.Default.clean_files_limit_n;
            // 
            // checkBoxCleanLimit
            // 
            this.checkBoxCleanLimit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxCleanLimit.Checked = global::Comic_Book_Maker.Properties.Settings.Default.clean_files_limit_enable;
            this.checkBoxCleanLimit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCleanLimit.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Comic_Book_Maker.Properties.Settings.Default, "clean_files_limit_n", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxCleanLimit.Location = new System.Drawing.Point(0, 4);
            this.checkBoxCleanLimit.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxCleanLimit.Name = "checkBoxCleanLimit";
            this.checkBoxCleanLimit.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.checkBoxCleanLimit.Size = new System.Drawing.Size(179, 17);
            this.checkBoxCleanLimit.TabIndex = 0;
            this.checkBoxCleanLimit.Text = "Limit number of files to clean";
            this.checkBoxCleanLimit.UseVisualStyleBackColor = true;
            this.checkBoxCleanLimit.CheckedChanged += new System.EventHandler(this.checkBoxCleanLimit_CheckedChanged);
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
            this.buttonRarPath.UseVisualStyleBackColor = true;
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
            this.buttonGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGo.Location = new System.Drawing.Point(241, 3);
            this.buttonGo.Name = "buttonGo";
            this.tableLayoutPanel1.SetRowSpan(this.buttonGo, 3);
            this.buttonGo.Size = new System.Drawing.Size(86, 63);
            this.buttonGo.TabIndex = 6;
            this.buttonGo.Text = "Go";
            this.buttonGo.UseVisualStyleBackColor = true;
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
            this.comboBoxOutputType.SelectedIndexChanged += new System.EventHandler(this.comboBoxOutputType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Output filetype:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "\"RAR executable|Rar.exe\"";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 489);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(937, 22);
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel10, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel7, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxUseOutPath, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxCreateFromFolder, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxCreateFromComic, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonExit, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxCreateFromArchive, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonGo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonRefresh, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(598, 9);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(330, 189);
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
            this.tableLayoutPanel10.Location = new System.Drawing.Point(0, 159);
            this.tableLayoutPanel10.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel10.Size = new System.Drawing.Size(284, 27);
            this.tableLayoutPanel10.TabIndex = 14;
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
            this.textBoxRenameSuffix.EnabledChanged += new System.EventHandler(this.textBoxtextBoxRenameSuffix_TextChanged);
            this.textBoxRenameSuffix.TextChanged += new System.EventHandler(this.textBoxtextBoxRenameSuffix_TextChanged);
            this.textBoxRenameSuffix.VisibleChanged += new System.EventHandler(this.textBoxtextBoxRenameSuffix_TextChanged);
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
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 130);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.Size = new System.Drawing.Size(316, 26);
            this.tableLayoutPanel7.TabIndex = 13;
            // 
            // buttonOutputPath
            // 
            this.buttonOutputPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonOutputPath.Location = new System.Drawing.Point(289, 3);
            this.buttonOutputPath.Name = "buttonOutputPath";
            this.buttonOutputPath.Size = new System.Drawing.Size(24, 20);
            this.buttonOutputPath.TabIndex = 6;
            this.buttonOutputPath.Text = "...";
            this.buttonOutputPath.UseVisualStyleBackColor = true;
            this.buttonOutputPath.Click += new System.EventHandler(this.buttonOutputPath_Click);
            // 
            // textBoxOutPath
            // 
            this.textBoxOutPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxOutPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Comic_Book_Maker.Properties.Settings.Default, "output_path", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxOutPath.Location = new System.Drawing.Point(3, 3);
            this.textBoxOutPath.Name = "textBoxOutPath";
            this.textBoxOutPath.Size = new System.Drawing.Size(280, 20);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 78);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(148, 26);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // checkBoxUseOutPath
            // 
            this.checkBoxUseOutPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxUseOutPath.AutoSize = true;
            this.checkBoxUseOutPath.Checked = global::Comic_Book_Maker.Properties.Settings.Default.specifiy_ouput_folder;
            this.checkBoxUseOutPath.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxUseOutPath.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Comic_Book_Maker.Properties.Settings.Default, "specifiy_ouput_folder", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxUseOutPath.Location = new System.Drawing.Point(3, 108);
            this.checkBoxUseOutPath.Name = "checkBoxUseOutPath";
            this.checkBoxUseOutPath.Size = new System.Drawing.Size(105, 17);
            this.checkBoxUseOutPath.TabIndex = 2;
            this.checkBoxUseOutPath.Text = "Use output path:";
            this.checkBoxUseOutPath.UseVisualStyleBackColor = true;
            this.checkBoxUseOutPath.CheckedChanged += new System.EventHandler(this.checkBoxOutPath_CheckedChanged);
            // 
            // checkBoxCreateFromFolder
            // 
            this.checkBoxCreateFromFolder.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxCreateFromFolder.AutoSize = true;
            this.checkBoxCreateFromFolder.Checked = global::Comic_Book_Maker.Properties.Settings.Default.create_from_folders;
            this.checkBoxCreateFromFolder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCreateFromFolder.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Comic_Book_Maker.Properties.Settings.Default, "create_from_folders", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxCreateFromFolder.Location = new System.Drawing.Point(3, 4);
            this.checkBoxCreateFromFolder.Name = "checkBoxCreateFromFolder";
            this.checkBoxCreateFromFolder.Size = new System.Drawing.Size(150, 17);
            this.checkBoxCreateFromFolder.TabIndex = 0;
            this.checkBoxCreateFromFolder.Text = "Create comics from folders";
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
            this.checkBoxCreateFromComic.Location = new System.Drawing.Point(3, 56);
            this.checkBoxCreateFromComic.Name = "checkBoxCreateFromComic";
            this.checkBoxCreateFromComic.Size = new System.Drawing.Size(99, 17);
            this.checkBoxCreateFromComic.TabIndex = 0;
            this.checkBoxCreateFromComic.Text = "Convert comics";
            this.checkBoxCreateFromComic.UseVisualStyleBackColor = true;
            this.checkBoxCreateFromComic.CheckedChanged += new System.EventHandler(this.checkBoxCreateFromComic_CheckedChanged);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.Location = new System.Drawing.Point(241, 81);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(86, 20);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // checkBoxCreateFromArchive
            // 
            this.checkBoxCreateFromArchive.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxCreateFromArchive.AutoSize = true;
            this.checkBoxCreateFromArchive.Checked = global::Comic_Book_Maker.Properties.Settings.Default.create_from_archives;
            this.checkBoxCreateFromArchive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCreateFromArchive.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Comic_Book_Maker.Properties.Settings.Default, "create_from_archives", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxCreateFromArchive.Location = new System.Drawing.Point(3, 30);
            this.checkBoxCreateFromArchive.Name = "checkBoxCreateFromArchive";
            this.checkBoxCreateFromArchive.Size = new System.Drawing.Size(159, 17);
            this.checkBoxCreateFromArchive.TabIndex = 0;
            this.checkBoxCreateFromArchive.Text = "Create comics from archives";
            this.checkBoxCreateFromArchive.UseVisualStyleBackColor = true;
            this.checkBoxCreateFromArchive.CheckedChanged += new System.EventHandler(this.checkBoxCreateFromArchive_CheckedChanged);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefresh.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonRefresh.Location = new System.Drawing.Point(241, 107);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(86, 20);
            this.buttonRefresh.TabIndex = 6;
            this.buttonRefresh.Text = "Refresh files";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.checkBoxParelize, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.checkBoxDeleteInputFiles, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.checkBoxCloseAtComplete, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel9, 0, 3);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(9, 19);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(313, 95);
            this.tableLayoutPanel4.TabIndex = 11;
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
            this.checkBoxParelize.UseVisualStyleBackColor = true;
            // 
            // checkBoxDeleteInputFiles
            // 
            this.checkBoxDeleteInputFiles.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxDeleteInputFiles.AutoSize = true;
            this.checkBoxDeleteInputFiles.Checked = global::Comic_Book_Maker.Properties.Settings.Default.delete_input_files;
            this.checkBoxDeleteInputFiles.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Comic_Book_Maker.Properties.Settings.Default, "delete_input_files", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxDeleteInputFiles.Location = new System.Drawing.Point(3, 49);
            this.checkBoxDeleteInputFiles.Name = "checkBoxDeleteInputFiles";
            this.checkBoxDeleteInputFiles.Size = new System.Drawing.Size(296, 17);
            this.checkBoxDeleteInputFiles.TabIndex = 0;
            this.checkBoxDeleteInputFiles.Text = "Delete input files at successfull completition (Recycle Bin)";
            this.checkBoxDeleteInputFiles.UseVisualStyleBackColor = true;
            // 
            // checkBoxCloseAtComplete
            // 
            this.checkBoxCloseAtComplete.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxCloseAtComplete.AutoSize = true;
            this.checkBoxCloseAtComplete.Checked = global::Comic_Book_Maker.Properties.Settings.Default.close_after_complete;
            this.checkBoxCloseAtComplete.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Comic_Book_Maker.Properties.Settings.Default, "close_after_complete", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxCloseAtComplete.Location = new System.Drawing.Point(3, 26);
            this.checkBoxCloseAtComplete.Name = "checkBoxCloseAtComplete";
            this.checkBoxCloseAtComplete.Size = new System.Drawing.Size(190, 17);
            this.checkBoxCloseAtComplete.TabIndex = 0;
            this.checkBoxCloseAtComplete.Text = "Close after successfull completition";
            this.checkBoxCloseAtComplete.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanel9.Location = new System.Drawing.Point(0, 69);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel9.Size = new System.Drawing.Size(313, 26);
            this.tableLayoutPanel9.TabIndex = 14;
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
            this.textBoxRarPath.EnabledChanged += new System.EventHandler(this.textBoxRarPath_Changed);
            this.textBoxRarPath.TextChanged += new System.EventHandler(this.textBoxRarPath_Changed);
            this.textBoxRarPath.VisibleChanged += new System.EventHandler(this.textBoxRarPath_Changed);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.AutoSize = true;
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.Controls.Add(this.tableLayoutPanel4);
            this.groupBox3.Location = new System.Drawing.Point(600, 344);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(325, 130);
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
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.Location = new System.Drawing.Point(12, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 23;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(582, 475);
            this.dataGridView1.TabIndex = 13;
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
            // formMain
            // 
            this.AcceptButton = this.buttonGo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(937, 511);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::Comic_Book_Maker.Properties.Settings.Default, "form_location", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = global::Comic_Book_Maker.Properties.Settings.Default.form_location;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Comic Book Maker";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form1_FormClosed);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCleanLimit)).EndInit();
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
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.CheckBox checkBoxRemoveFoldersSmart;
        private System.Windows.Forms.CheckBox checkBoxCleanLimit;
        private System.Windows.Forms.CheckBox checkBoxRemoveFolders;
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
    }
}

