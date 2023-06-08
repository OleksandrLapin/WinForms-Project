namespace FileCombineProject
{
    partial class FormMainMenu
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
            btnRenamer = new Button();
            btnArchiver = new Button();
            btnCleaner = new Button();
            SuspendLayout();
            // 
            // btnRenamer
            // 
            btnRenamer.BackColor = Color.Green;
            btnRenamer.Font = new Font("Sitka Display", 9F, FontStyle.Italic, GraphicsUnit.Point);
            btnRenamer.Location = new Point(249, 215);
            btnRenamer.Margin = new Padding(5);
            btnRenamer.Name = "btnRenamer";
            btnRenamer.Size = new Size(300, 50);
            btnRenamer.TabIndex = 5;
            btnRenamer.Text = "RENAMER";
            btnRenamer.UseVisualStyleBackColor = false;
            btnRenamer.Click += btnRenamer_Click;
            // 
            // btnArchiver
            // 
            btnArchiver.BackColor = Color.Green;
            btnArchiver.Font = new Font("Sitka Display", 9F, FontStyle.Italic, GraphicsUnit.Point);
            btnArchiver.Location = new Point(249, 158);
            btnArchiver.Margin = new Padding(5);
            btnArchiver.Name = "btnArchiver";
            btnArchiver.Size = new Size(300, 50);
            btnArchiver.TabIndex = 4;
            btnArchiver.Text = "ARCHIVER";
            btnArchiver.UseVisualStyleBackColor = false;
            btnArchiver.Click += btnArchiver_Click;
            // 
            // btnCleaner
            // 
            btnCleaner.BackColor = Color.Green;
            btnCleaner.Font = new Font("Sitka Display", 9F, FontStyle.Italic, GraphicsUnit.Point);
            btnCleaner.Location = new Point(249, 102);
            btnCleaner.Margin = new Padding(5);
            btnCleaner.Name = "btnCleaner";
            btnCleaner.Size = new Size(300, 50);
            btnCleaner.TabIndex = 3;
            btnCleaner.Text = "FILE CLEANER";
            btnCleaner.UseVisualStyleBackColor = false;
            btnCleaner.Click += btnCleaner_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRenamer);
            Controls.Add(btnArchiver);
            Controls.Add(btnCleaner);
            Name = "MainMenu";
            Text = "Main Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRenamer;
        private Button btnArchiver;
        private Button btnCleaner;
    }
}