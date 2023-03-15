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
            this.btnCleaner = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCleaner
            // 
            this.btnCleaner.Location = new System.Drawing.Point(103, 76);
            this.btnCleaner.Name = "btnCleaner";
            this.btnCleaner.Size = new System.Drawing.Size(288, 29);
            this.btnCleaner.TabIndex = 0;
            this.btnCleaner.Text = "FILE CLEANER";
            this.btnCleaner.UseVisualStyleBackColor = true;
            this.btnCleaner.Click += new System.EventHandler(this.btnCleaner_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCleaner);
            this.Name = "FrmMain";
            this.Text = "Main menu";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCleaner;
    }
}