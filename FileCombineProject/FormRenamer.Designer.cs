namespace FileCombineProject
{
    partial class FormRenamer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRenamer));
            lViewAnalyzedFiles = new ListView();
            colName = new ColumnHeader();
            colDate = new ColumnHeader();
            colSize = new ColumnHeader();
            combBxGPart = new ComboBox();
            combBxConnector = new ComboBox();
            combBxPrefix = new ComboBox();
            lblSetRenamePattern = new Label();
            btnRename = new Button();
            btnAnalyze = new Button();
            lblSetFilePatterns = new Label();
            txtbxDir = new TextBox();
            lblSetDir = new Label();
            btnBrowse = new Button();
            imageList1 = new ImageList(components);
            DirBrowser = new FolderBrowserDialog();
            button1 = new Button();
            btnFilePatternsDelete = new Button();
            txtBoxFile = new TextBox();
            btnFilePatternsAdd = new Button();
            listBoxFile = new ListBox();
            SuspendLayout();
            // 
            // lViewAnalyzedFiles
            // 
            lViewAnalyzedFiles.Alignment = ListViewAlignment.Left;
            lViewAnalyzedFiles.BackColor = SystemColors.Window;
            lViewAnalyzedFiles.CheckBoxes = true;
            lViewAnalyzedFiles.Columns.AddRange(new ColumnHeader[] { colName, colDate, colSize });
            lViewAnalyzedFiles.Font = new Font("Sitka Display", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lViewAnalyzedFiles.Location = new Point(14, 12);
            lViewAnalyzedFiles.Margin = new Padding(5, 3, 5, 3);
            lViewAnalyzedFiles.Name = "lViewAnalyzedFiles";
            lViewAnalyzedFiles.Size = new Size(523, 399);
            lViewAnalyzedFiles.TabIndex = 2;
            lViewAnalyzedFiles.TileSize = new Size(210, 32);
            lViewAnalyzedFiles.UseCompatibleStateImageBehavior = false;
            lViewAnalyzedFiles.View = View.Details;
            // 
            // colName
            // 
            colName.Text = "Name";
            colName.Width = 280;
            // 
            // colDate
            // 
            colDate.Text = "Date of change";
            colDate.Width = 120;
            // 
            // colSize
            // 
            colSize.Text = "Size";
            colSize.Width = 120;
            // 
            // combBxGPart
            // 
            combBxGPart.DropDownStyle = ComboBoxStyle.DropDownList;
            combBxGPart.Font = new Font("Sitka Display", 9F, FontStyle.Italic, GraphicsUnit.Point);
            combBxGPart.FormattingEnabled = true;
            combBxGPart.Items.AddRange(new object[] { "UUID", "Ordinal number", "Random string" });
            combBxGPart.Location = new Point(775, 291);
            combBxGPart.Name = "combBxGPart";
            combBxGPart.Size = new Size(140, 29);
            combBxGPart.TabIndex = 31;
            // 
            // combBxConnector
            // 
            combBxConnector.DropDownStyle = ComboBoxStyle.DropDownList;
            combBxConnector.Font = new Font("Sitka Display", 9F, FontStyle.Italic, GraphicsUnit.Point);
            combBxConnector.FormattingEnabled = true;
            combBxConnector.Items.AddRange(new object[] { "_", ".", " ", "-", "," });
            combBxConnector.Location = new Point(724, 291);
            combBxConnector.Name = "combBxConnector";
            combBxConnector.Size = new Size(45, 29);
            combBxConnector.TabIndex = 30;
            // 
            // combBxPrefix
            // 
            combBxPrefix.Font = new Font("Sitka Display", 9F, FontStyle.Italic, GraphicsUnit.Point);
            combBxPrefix.FormattingEnabled = true;
            combBxPrefix.Items.AddRange(new object[] { "img", "video", "txt", "movie", "file", "data" });
            combBxPrefix.Location = new Point(574, 291);
            combBxPrefix.Name = "combBxPrefix";
            combBxPrefix.Size = new Size(144, 29);
            combBxPrefix.TabIndex = 29;
            // 
            // lblSetRenamePattern
            // 
            lblSetRenamePattern.AutoSize = true;
            lblSetRenamePattern.Font = new Font("Sitka Display", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblSetRenamePattern.Location = new Point(574, 268);
            lblSetRenamePattern.Name = "lblSetRenamePattern";
            lblSetRenamePattern.Size = new Size(129, 21);
            lblSetRenamePattern.TabIndex = 28;
            lblSetRenamePattern.Text = "Set Rename Pattern";
            // 
            // btnRename
            // 
            btnRename.BackColor = Color.Green;
            btnRename.Enabled = false;
            btnRename.Font = new Font("Sitka Display", 9F, FontStyle.Italic, GraphicsUnit.Point);
            btnRename.Location = new Point(574, 370);
            btnRename.Margin = new Padding(5, 3, 5, 3);
            btnRename.Name = "btnRename";
            btnRename.Size = new Size(341, 35);
            btnRename.TabIndex = 27;
            btnRename.Text = "Rename";
            btnRename.UseVisualStyleBackColor = false;
            btnRename.Click += btnRename_Click;
            // 
            // btnAnalyze
            // 
            btnAnalyze.BackColor = Color.Green;
            btnAnalyze.Font = new Font("Sitka Display", 9F, FontStyle.Italic, GraphicsUnit.Point);
            btnAnalyze.Location = new Point(573, 214);
            btnAnalyze.Margin = new Padding(5, 3, 5, 3);
            btnAnalyze.Name = "btnAnalyze";
            btnAnalyze.Size = new Size(342, 35);
            btnAnalyze.TabIndex = 26;
            btnAnalyze.Text = "Analyze";
            btnAnalyze.UseVisualStyleBackColor = false;
            btnAnalyze.Click += btnAnalyze_Click;
            // 
            // lblSetFilePatterns
            // 
            lblSetFilePatterns.AutoSize = true;
            lblSetFilePatterns.Font = new Font("Sitka Display", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblSetFilePatterns.Location = new Point(574, 57);
            lblSetFilePatterns.Name = "lblSetFilePatterns";
            lblSetFilePatterns.Size = new Size(113, 21);
            lblSetFilePatterns.TabIndex = 25;
            lblSetFilePatterns.Text = "Set File Patterns ";
            // 
            // txtbxDir
            // 
            txtbxDir.Font = new Font("Sitka Display", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtbxDir.Location = new Point(573, 21);
            txtbxDir.Margin = new Padding(5, 3, 5, 3);
            txtbxDir.Name = "txtbxDir";
            txtbxDir.Size = new Size(268, 26);
            txtbxDir.TabIndex = 21;
            // 
            // lblSetDir
            // 
            lblSetDir.AutoSize = true;
            lblSetDir.Font = new Font("Sitka Display", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblSetDir.Location = new Point(573, 5);
            lblSetDir.Margin = new Padding(2, 0, 2, 0);
            lblSetDir.Name = "lblSetDir";
            lblSetDir.Size = new Size(89, 21);
            lblSetDir.TabIndex = 23;
            lblSetDir.Text = "Set Directory";
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = Color.LightGray;
            btnBrowse.FlatStyle = FlatStyle.Popup;
            btnBrowse.Font = new Font("Sitka Display", 9F, FontStyle.Italic, GraphicsUnit.Point);
            btnBrowse.Location = new Point(847, 21);
            btnBrowse.Margin = new Padding(5, 3, 5, 3);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(68, 27);
            btnBrowse.TabIndex = 22;
            btnBrowse.Text = "Browse...";
            btnBrowse.TextAlign = ContentAlignment.MiddleRight;
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "images.png");
            imageList1.Images.SetKeyName(1, "Без названия.jpg");
            // 
            // DirBrowser
            // 
            DirBrowser.OkRequiresInteraction = true;
            DirBrowser.ShowHiddenFiles = true;
            DirBrowser.ShowNewFolderButton = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Sitka Display", 9F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(942, 351);
            button1.Name = "button1";
            button1.Size = new Size(94, 54);
            button1.TabIndex = 32;
            button1.Text = "Back to the main menu";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnFilePatternsDelete
            // 
            btnFilePatternsDelete.BackColor = Color.Green;
            btnFilePatternsDelete.Font = new Font("Sitka Display", 9F, FontStyle.Italic, GraphicsUnit.Point);
            btnFilePatternsDelete.ForeColor = Color.Black;
            btnFilePatternsDelete.Location = new Point(794, 168);
            btnFilePatternsDelete.Name = "btnFilePatternsDelete";
            btnFilePatternsDelete.Size = new Size(121, 29);
            btnFilePatternsDelete.TabIndex = 36;
            btnFilePatternsDelete.Text = "Delete File Patterns";
            btnFilePatternsDelete.UseVisualStyleBackColor = false;
            btnFilePatternsDelete.Click += btnFilePatternsDelete_Click;
            // 
            // txtBoxFile
            // 
            txtBoxFile.Font = new Font("Sitka Display", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtBoxFile.Location = new Point(794, 81);
            txtBoxFile.Name = "txtBoxFile";
            txtBoxFile.ScrollBars = ScrollBars.Vertical;
            txtBoxFile.Size = new Size(121, 26);
            txtBoxFile.TabIndex = 35;
            // 
            // btnFilePatternsAdd
            // 
            btnFilePatternsAdd.BackColor = Color.Green;
            btnFilePatternsAdd.Font = new Font("Sitka Display", 9F, FontStyle.Italic, GraphicsUnit.Point);
            btnFilePatternsAdd.ForeColor = Color.Black;
            btnFilePatternsAdd.Location = new Point(794, 124);
            btnFilePatternsAdd.Name = "btnFilePatternsAdd";
            btnFilePatternsAdd.Size = new Size(121, 29);
            btnFilePatternsAdd.TabIndex = 33;
            btnFilePatternsAdd.Text = "Add File Patterns";
            btnFilePatternsAdd.UseVisualStyleBackColor = false;
            btnFilePatternsAdd.Click += btnFilePatternsAdd_Click;
            // 
            // listBoxFile
            // 
            listBoxFile.Font = new Font("Sitka Display", 9F, FontStyle.Italic, GraphicsUnit.Point);
            listBoxFile.FormattingEnabled = true;
            listBoxFile.ItemHeight = 21;
            listBoxFile.Items.AddRange(new object[] { "*.exe", "*.jpg", "*.png" });
            listBoxFile.Location = new Point(574, 81);
            listBoxFile.Name = "listBoxFile";
            listBoxFile.ScrollAlwaysVisible = true;
            listBoxFile.Size = new Size(200, 88);
            listBoxFile.TabIndex = 37;
            // 
            // FormRenamer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1028, 425);
            Controls.Add(listBoxFile);
            Controls.Add(btnFilePatternsDelete);
            Controls.Add(txtBoxFile);
            Controls.Add(btnFilePatternsAdd);
            Controls.Add(button1);
            Controls.Add(combBxGPart);
            Controls.Add(combBxConnector);
            Controls.Add(combBxPrefix);
            Controls.Add(lblSetRenamePattern);
            Controls.Add(btnRename);
            Controls.Add(btnAnalyze);
            Controls.Add(lblSetFilePatterns);
            Controls.Add(txtbxDir);
            Controls.Add(lblSetDir);
            Controls.Add(btnBrowse);
            Controls.Add(lViewAnalyzedFiles);
            Name = "FormRenamer";
            Text = "Renamer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lViewAnalyzedFiles;
        private ColumnHeader colName;
        private ColumnHeader colDate;
        private ColumnHeader colSize;
        private ComboBox combBxGPart;
        private ComboBox combBxConnector;
        private ComboBox combBxPrefix;
        private Label lblSetRenamePattern;
        private Button btnRename;
        private Button btnAnalyze;
        private Label lblSetFilePatterns;
        private TextBox txtbxDir;
        private Label lblSetDir;
        private Button btnBrowse;
        private ImageList imageList1;
        private FolderBrowserDialog DirBrowser;
        private Button button1;
        private Button btnFilePatternsDelete;
        private TextBox txtBoxFile;
        private Button btnFilePatternsAdd;
        private ListBox listBoxFile;
    }
}