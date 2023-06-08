namespace FileCombineProject
{
    partial class FormArchiver
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtBoxDir = new TextBox();
            txtBoxDestination = new TextBox();
            txtBoxFileTitle = new TextBox();
            cmbBoxExtention = new ComboBox();
            btnDirectories = new Button();
            btnDestination = new Button();
            btnCompress = new Button();
            folderBrowser = new FolderBrowserDialog();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Display", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(74, 9);
            label1.Name = "label1";
            label1.Size = new Size(98, 21);
            label1.TabIndex = 0;
            label1.Text = "Set Directories";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Display", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(74, 109);
            label2.Name = "label2";
            label2.Size = new Size(100, 21);
            label2.TabIndex = 1;
            label2.Text = "Set Distination";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Display", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(74, 205);
            label3.Name = "label3";
            label3.Size = new Size(41, 21);
            label3.TabIndex = 2;
            label3.Text = "Title:";
            // 
            // txtBoxDir
            // 
            txtBoxDir.Font = new Font("Sitka Display", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtBoxDir.Location = new Point(74, 32);
            txtBoxDir.Name = "txtBoxDir";
            txtBoxDir.ScrollBars = ScrollBars.Horizontal;
            txtBoxDir.Size = new Size(251, 26);
            txtBoxDir.TabIndex = 3;
            // 
            // txtBoxDestination
            // 
            txtBoxDestination.Font = new Font("Sitka Display", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtBoxDestination.Location = new Point(74, 132);
            txtBoxDestination.Name = "txtBoxDestination";
            txtBoxDestination.ScrollBars = ScrollBars.Horizontal;
            txtBoxDestination.Size = new Size(251, 26);
            txtBoxDestination.TabIndex = 4;
            // 
            // txtBoxFileTitle
            // 
            txtBoxFileTitle.Font = new Font("Sitka Display", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtBoxFileTitle.Location = new Point(74, 227);
            txtBoxFileTitle.Name = "txtBoxFileTitle";
            txtBoxFileTitle.ScrollBars = ScrollBars.Horizontal;
            txtBoxFileTitle.Size = new Size(137, 26);
            txtBoxFileTitle.TabIndex = 5;
            // 
            // cmbBoxExtention
            // 
            cmbBoxExtention.Font = new Font("Sitka Display", 9F, FontStyle.Italic, GraphicsUnit.Point);
            cmbBoxExtention.FormattingEnabled = true;
            cmbBoxExtention.Items.AddRange(new object[] { ".zip" });
            cmbBoxExtention.Location = new Point(248, 226);
            cmbBoxExtention.Name = "cmbBoxExtention";
            cmbBoxExtention.Size = new Size(77, 29);
            cmbBoxExtention.TabIndex = 6;
            // 
            // btnDirectories
            // 
            btnDirectories.BackColor = Color.Green;
            btnDirectories.Font = new Font("Sitka Display", 9F, FontStyle.Italic, GraphicsUnit.Point);
            btnDirectories.Location = new Point(363, 17);
            btnDirectories.Margin = new Padding(0);
            btnDirectories.Name = "btnDirectories";
            btnDirectories.Size = new Size(94, 54);
            btnDirectories.TabIndex = 7;
            btnDirectories.Text = "Set Directories";
            btnDirectories.UseVisualStyleBackColor = false;
            btnDirectories.Click += btnDirectories_Click;
            // 
            // btnDestination
            // 
            btnDestination.BackColor = Color.Green;
            btnDestination.Font = new Font("Sitka Display", 9F, FontStyle.Italic, GraphicsUnit.Point);
            btnDestination.Location = new Point(363, 118);
            btnDestination.Name = "btnDestination";
            btnDestination.Size = new Size(94, 54);
            btnDestination.TabIndex = 8;
            btnDestination.Text = "Set Destination";
            btnDestination.UseVisualStyleBackColor = false;
            btnDestination.Click += btnDestination_Click;
            // 
            // btnCompress
            // 
            btnCompress.BackColor = Color.Green;
            btnCompress.Font = new Font("Sitka Display", 9F, FontStyle.Italic, GraphicsUnit.Point);
            btnCompress.Location = new Point(74, 302);
            btnCompress.Name = "btnCompress";
            btnCompress.Size = new Size(153, 29);
            btnCompress.TabIndex = 9;
            btnCompress.Text = "Compress";
            btnCompress.UseVisualStyleBackColor = false;
            btnCompress.Click += btnCompress_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Sitka Display", 9F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(363, 302);
            button1.Name = "button1";
            button1.Size = new Size(94, 54);
            button1.TabIndex = 10;
            button1.Text = "Back to the main menu";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormArchiver
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(459, 361);
            Controls.Add(button1);
            Controls.Add(btnCompress);
            Controls.Add(btnDestination);
            Controls.Add(btnDirectories);
            Controls.Add(cmbBoxExtention);
            Controls.Add(txtBoxFileTitle);
            Controls.Add(txtBoxDestination);
            Controls.Add(txtBoxDir);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormArchiver";
            Text = "Archiver";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtBoxDir;
        private TextBox txtBoxDestination;
        private TextBox txtBoxFileTitle;
        private ComboBox cmbBoxExtention;
        private Button btnDirectories;
        private Button btnDestination;
        private Button btnCompress;
        private FolderBrowserDialog folderBrowser;
        private Button button1;
    }
}