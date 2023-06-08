using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileCombineProject
{
    public partial class FormSignIn : Form
    {
        public FormSignIn()
        {
            InitializeComponent();
        }

        private void txtBoxLogin_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxLogin.Text != "" && txtBoxPassword.Text != "")
                btnSignIn.Enabled = true;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string connString = @"Server=.\SQLEXPRESS;Database=ProjectFileCombine;Trusted_Connection=True;Encrypt=False";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("Connection open");
                    SqlCommand cmd = new SqlCommand()
                    {
                        Connection = conn,
                        CommandType = CommandType.Text,
                        CommandText = $"INSERT INTO users(login, password) VALUES ('{txtBoxLogin.Text}','{txtBoxPassword.Text}');"
                    };

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                    MessageBox.Show("Connection open");
                }
            };
        }
    }
}
