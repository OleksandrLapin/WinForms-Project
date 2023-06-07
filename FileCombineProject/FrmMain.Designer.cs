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
            label1 = new Label();
            label2 = new Label();
            txtBoxLogin = new TextBox();
            txtBoxPassword = new TextBox();
            btnSignIn = new Button();
            btnLogIn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(173, 68);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 3;
            label1.Text = "Login:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(173, 148);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 4;
            label2.Text = "Password:";
            // 
            // txtBoxLogin
            // 
            txtBoxLogin.Location = new Point(173, 94);
            txtBoxLogin.Name = "txtBoxLogin";
            txtBoxLogin.Size = new Size(235, 27);
            txtBoxLogin.TabIndex = 5;
            txtBoxLogin.TextChanged += textBox1_TextChanged;
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.Location = new Point(173, 171);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.Size = new Size(235, 27);
            txtBoxPassword.TabIndex = 6;
            txtBoxPassword.TextChanged += textBox1_TextChanged;
            // 
            // btnSignIn
            // 
            btnSignIn.Location = new Point(12, 409);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(94, 29);
            btnSignIn.TabIndex = 7;
            btnSignIn.Text = "SIGN IN";
            btnSignIn.UseVisualStyleBackColor = true;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // btnLogIn
            // 
            btnLogIn.Enabled = false;
            btnLogIn.Location = new Point(173, 236);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(94, 29);
            btnLogIn.TabIndex = 8;
            btnLogIn.Text = "LOG IN";
            btnLogIn.UseVisualStyleBackColor = true;
            btnLogIn.Click += buttonLogIn_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogIn);
            Controls.Add(btnSignIn);
            Controls.Add(txtBoxPassword);
            Controls.Add(txtBoxLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmMain";
            Text = "Main menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox txtBoxLogin;
        private TextBox txtBoxPassword;
        private Button btnSignIn;
        private Button btnLogIn;
    }
}