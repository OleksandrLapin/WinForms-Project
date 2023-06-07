namespace FileCombineProject
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCleaner = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // btnCleaner
            // 
            btnCleaner.Location = new Point(235, 105);
            btnCleaner.Name = "btnCleaner";
            btnCleaner.Size = new Size(288, 29);
            btnCleaner.TabIndex = 0;
            btnCleaner.Text = "FILE CLEANER";
            btnCleaner.UseVisualStyleBackColor = true;
            btnCleaner.Click += btnCleaner_Click;
            // 
            // button1
            // 
            button1.Location = new Point(235, 161);
            button1.Name = "button1";
            button1.Size = new Size(288, 29);
            button1.TabIndex = 1;
            button1.Text = "ARCHIVER";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(235, 223);
            button2.Name = "button2";
            button2.Size = new Size(288, 29);
            button2.TabIndex = 2;
            button2.Text = "RENAMER";
            button2.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnCleaner);
            Name = "FrmMain";
            Text = "Main menu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCleaner;
        private Button button1;
        private Button button2;
    }
}