namespace FileCombineProject
{
    partial class MainMenu
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
            button2 = new Button();
            button1 = new Button();
            btnCleaner = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(249, 215);
            button2.Name = "button2";
            button2.Size = new Size(288, 29);
            button2.TabIndex = 5;
            button2.Text = "RENAMER";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(249, 158);
            button1.Name = "button1";
            button1.Size = new Size(288, 29);
            button1.TabIndex = 4;
            button1.Text = "ARCHIVER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnCleaner
            // 
            btnCleaner.Location = new Point(249, 102);
            btnCleaner.Name = "btnCleaner";
            btnCleaner.Size = new Size(288, 29);
            btnCleaner.TabIndex = 3;
            btnCleaner.Text = "FILE CLEANER";
            btnCleaner.UseVisualStyleBackColor = true;
            btnCleaner.Click += btnCleaner_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnCleaner);
            Name = "MainMenu";
            Text = "MainMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private Button button1;
        private Button btnCleaner;
    }
}