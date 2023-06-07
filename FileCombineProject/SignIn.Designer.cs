namespace FileCombineProject
{
    partial class SignIn
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
            btnSignIn = new Button();
            txtBoxLogin = new TextBox();
            txtBoxPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnSignIn
            // 
            btnSignIn.Enabled = false;
            btnSignIn.Location = new Point(338, 250);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(94, 29);
            btnSignIn.TabIndex = 0;
            btnSignIn.Text = "SIGN IN";
            btnSignIn.UseVisualStyleBackColor = true;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // txtBoxLogin
            // 
            txtBoxLogin.Location = new Point(338, 104);
            txtBoxLogin.Name = "txtBoxLogin";
            txtBoxLogin.Size = new Size(164, 27);
            txtBoxLogin.TabIndex = 1;
            txtBoxLogin.TextChanged += txtBoxLogin_TextChanged;
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.Location = new Point(338, 195);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.Size = new Size(164, 27);
            txtBoxPassword.TabIndex = 2;
            txtBoxPassword.TextChanged += txtBoxLogin_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(338, 68);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 3;
            label1.Text = "Enter the login:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(338, 149);
            label2.Name = "label2";
            label2.Size = new Size(138, 20);
            label2.TabIndex = 4;
            label2.Text = "Enter the password:";
            // 
            // SignIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBoxPassword);
            Controls.Add(txtBoxLogin);
            Controls.Add(btnSignIn);
            Name = "SignIn";
            Text = "SignIn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSignIn;
        private TextBox txtBoxLogin;
        private TextBox txtBoxPassword;
        private Label label1;
        private Label label2;
    }
}