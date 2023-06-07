namespace FileCombineProject.File_cleaner
{
    partial class FrmFileCleanerMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFileCleanerMain));
            listViewMain = new ListView();
            columnDate = new ColumnHeader();
            columnSize = new ColumnHeader();
            columnName = new ColumnHeader();
            imageList1 = new ImageList(components);
            btnRootDir = new Button();
            btnDirPatternsAdd = new Button();
            btnFilePatterns = new Button();
            lblRoot = new Label();
            listBoxDir = new ListBox();
            listBoxFile = new ListBox();
            btnAnalyze = new Button();
            label2 = new Label();
            label3 = new Label();
            checkBoxToTrash = new CheckBox();
            btnClear = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            txtBoxDir = new TextBox();
            txtBoxFile = new TextBox();
            btnDirPatternsDelete = new Button();
            button2 = new Button();
            checkBoxCheckDir = new CheckBox();
            checkBoxCheckFile = new CheckBox();
            lblCount = new Label();
            lblSize = new Label();
            SuspendLayout();
            // 
            // listViewMain
            // 
            listViewMain.CheckBoxes = true;
            listViewMain.Columns.AddRange(new ColumnHeader[] { columnDate, columnSize, columnName });
            listViewMain.LargeImageList = imageList1;
            listViewMain.Location = new Point(12, 12);
            listViewMain.Name = "listViewMain";
            listViewMain.Size = new Size(765, 630);
            listViewMain.SmallImageList = imageList1;
            listViewMain.TabIndex = 0;
            listViewMain.UseCompatibleStateImageBehavior = false;
            listViewMain.View = View.List;
            // 
            // columnDate
            // 
            columnDate.DisplayIndex = 1;
            columnDate.Text = "Date of Change";
            columnDate.Width = 120;
            // 
            // columnSize
            // 
            columnSize.DisplayIndex = 2;
            columnSize.Text = "Size";
            columnSize.Width = 120;
            // 
            // columnName
            // 
            columnName.DisplayIndex = 0;
            columnName.Text = "Name";
            columnName.Width = 280;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "images.png");
            imageList1.Images.SetKeyName(1, "Без названия.jpg");
            // 
            // btnRootDir
            // 
            btnRootDir.Location = new Point(826, 12);
            btnRootDir.Name = "btnRootDir";
            btnRootDir.Size = new Size(94, 29);
            btnRootDir.TabIndex = 1;
            btnRootDir.Text = "Set Root Dir";
            btnRootDir.UseVisualStyleBackColor = true;
            btnRootDir.Click += btnRootDir_Click;
            // 
            // btnDirPatternsAdd
            // 
            btnDirPatternsAdd.Location = new Point(1043, 146);
            btnDirPatternsAdd.Name = "btnDirPatternsAdd";
            btnDirPatternsAdd.Size = new Size(150, 29);
            btnDirPatternsAdd.TabIndex = 2;
            btnDirPatternsAdd.Text = "Add Dir Patterns";
            btnDirPatternsAdd.UseVisualStyleBackColor = true;
            btnDirPatternsAdd.Click += btnDirPatterns_Click;
            // 
            // btnFilePatterns
            // 
            btnFilePatterns.Location = new Point(1043, 281);
            btnFilePatterns.Name = "btnFilePatterns";
            btnFilePatterns.Size = new Size(150, 29);
            btnFilePatterns.TabIndex = 3;
            btnFilePatterns.Text = "Add File Patterns";
            btnFilePatterns.UseVisualStyleBackColor = true;
            btnFilePatterns.Click += btnFilePatterns_Click;
            // 
            // lblRoot
            // 
            lblRoot.AutoSize = true;
            lblRoot.Location = new Point(826, 56);
            lblRoot.Name = "lblRoot";
            lblRoot.Size = new Size(40, 20);
            lblRoot.TabIndex = 4;
            lblRoot.Text = "Path:";
            // 
            // listBoxDir
            // 
            listBoxDir.FormattingEnabled = true;
            listBoxDir.ItemHeight = 20;
            listBoxDir.Items.AddRange(new object[] { ".vs", ".DS_Store", "Debug", "bin", "debug", "obj" });
            listBoxDir.Location = new Point(826, 113);
            listBoxDir.Name = "listBoxDir";
            listBoxDir.ScrollAlwaysVisible = true;
            listBoxDir.Size = new Size(200, 104);
            listBoxDir.TabIndex = 5;
            // 
            // listBoxFile
            // 
            listBoxFile.FormattingEnabled = true;
            listBoxFile.ItemHeight = 20;
            listBoxFile.Items.AddRange(new object[] { "*.exe", "*.jpg", "*.png" });
            listBoxFile.Location = new Point(826, 248);
            listBoxFile.Name = "listBoxFile";
            listBoxFile.ScrollAlwaysVisible = true;
            listBoxFile.Size = new Size(200, 104);
            listBoxFile.TabIndex = 6;
            // 
            // btnAnalyze
            // 
            btnAnalyze.Location = new Point(826, 410);
            btnAnalyze.Name = "btnAnalyze";
            btnAnalyze.Size = new Size(200, 39);
            btnAnalyze.TabIndex = 7;
            btnAnalyze.Text = "ANALYZE";
            btnAnalyze.UseVisualStyleBackColor = true;
            btnAnalyze.Click += btnAnalyze_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(826, 468);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 8;
            label2.Text = "Count:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(826, 510);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 9;
            label3.Text = "Full Size: ";
            // 
            // checkBoxToTrash
            // 
            checkBoxToTrash.AutoSize = true;
            checkBoxToTrash.Checked = true;
            checkBoxToTrash.CheckState = CheckState.Checked;
            checkBoxToTrash.Enabled = false;
            checkBoxToTrash.Location = new Point(826, 605);
            checkBoxToTrash.Name = "checkBoxToTrash";
            checkBoxToTrash.Size = new Size(122, 24);
            checkBoxToTrash.TabIndex = 10;
            checkBoxToTrash.Text = "Move to trash";
            checkBoxToTrash.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Enabled = false;
            btnClear.Location = new Point(985, 558);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(171, 71);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtBoxDir
            // 
            txtBoxDir.Location = new Point(1043, 113);
            txtBoxDir.Name = "txtBoxDir";
            txtBoxDir.ScrollBars = ScrollBars.Vertical;
            txtBoxDir.Size = new Size(200, 27);
            txtBoxDir.TabIndex = 12;
            // 
            // txtBoxFile
            // 
            txtBoxFile.Location = new Point(1043, 248);
            txtBoxFile.Name = "txtBoxFile";
            txtBoxFile.ScrollBars = ScrollBars.Vertical;
            txtBoxFile.Size = new Size(200, 27);
            txtBoxFile.TabIndex = 13;
            // 
            // btnDirPatternsDelete
            // 
            btnDirPatternsDelete.Location = new Point(1043, 188);
            btnDirPatternsDelete.Name = "btnDirPatternsDelete";
            btnDirPatternsDelete.Size = new Size(150, 29);
            btnDirPatternsDelete.TabIndex = 14;
            btnDirPatternsDelete.Text = "Delete Dir Patterns";
            btnDirPatternsDelete.UseVisualStyleBackColor = true;
            btnDirPatternsDelete.Click += btnDirPatternsDelete_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1043, 323);
            button2.Name = "button2";
            button2.Size = new Size(150, 29);
            button2.TabIndex = 15;
            button2.Text = "Delete File Patterns";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // checkBoxCheckDir
            // 
            checkBoxCheckDir.AutoSize = true;
            checkBoxCheckDir.Checked = true;
            checkBoxCheckDir.CheckState = CheckState.Checked;
            checkBoxCheckDir.Location = new Point(834, 372);
            checkBoxCheckDir.Name = "checkBoxCheckDir";
            checkBoxCheckDir.Size = new Size(103, 24);
            checkBoxCheckDir.TabIndex = 16;
            checkBoxCheckDir.Text = "Directories";
            checkBoxCheckDir.UseVisualStyleBackColor = true;
            // 
            // checkBoxCheckFile
            // 
            checkBoxCheckFile.AutoSize = true;
            checkBoxCheckFile.Checked = true;
            checkBoxCheckFile.CheckState = CheckState.Checked;
            checkBoxCheckFile.Location = new Point(965, 372);
            checkBoxCheckFile.Name = "checkBoxCheckFile";
            checkBoxCheckFile.Size = new Size(54, 24);
            checkBoxCheckFile.TabIndex = 17;
            checkBoxCheckFile.Text = "File";
            checkBoxCheckFile.UseVisualStyleBackColor = true;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(902, 468);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(0, 20);
            lblCount.TabIndex = 18;
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Location = new Point(902, 510);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(0, 20);
            lblSize.TabIndex = 19;
            // 
            // FrmFileCleanerMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 654);
            Controls.Add(lblSize);
            Controls.Add(lblCount);
            Controls.Add(checkBoxCheckFile);
            Controls.Add(checkBoxCheckDir);
            Controls.Add(button2);
            Controls.Add(btnDirPatternsDelete);
            Controls.Add(txtBoxFile);
            Controls.Add(txtBoxDir);
            Controls.Add(btnClear);
            Controls.Add(checkBoxToTrash);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnAnalyze);
            Controls.Add(listBoxFile);
            Controls.Add(listBoxDir);
            Controls.Add(lblRoot);
            Controls.Add(btnFilePatterns);
            Controls.Add(btnDirPatternsAdd);
            Controls.Add(btnRootDir);
            Controls.Add(listViewMain);
            Name = "FrmFileCleanerMain";
            Text = "File Cleaner";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewMain;
        private Button btnRootDir;
        private Button btnDirPatternsAdd;
        private Button btnFilePatterns;
        private Label lblRoot;
        private ListBox listBoxDir;
        private ListBox listBoxFile;
        private Button btnAnalyze;
        private Label label2;
        private Label label3;
        private CheckBox checkBoxToTrash;
        private Button btnClear;
        private FolderBrowserDialog folderBrowserDialog1;
        private ImageList imageList1;
        private TextBox txtBoxDir;
        private TextBox txtBoxFile;
        private Button btnDirPatternsDelete;
        private Button button2;
        private ColumnHeader columnName;
        private ColumnHeader columnDate;
        private ColumnHeader columnSize;
        private CheckBox checkBoxCheckDir;
        private CheckBox checkBoxCheckFile;
        private Label lblCount;
        private Label lblSize;
    }
}