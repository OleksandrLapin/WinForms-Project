using FileCombineProject.File_cleaner;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;

namespace FileCombineProject
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }


        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string connString = @"Server=.\SQLEXPRESS;Database=ProjectFileCombine;Trusted_Connection=True;Encrypt=False";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    //MessageBox.Show("Connection open");
                    SqlCommand cmd = new SqlCommand()
                    {
                        Connection = conn,
                        CommandType = CommandType.Text,
                        CommandText = "SELECT * FROM users;"
                    };

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string login = reader.GetFieldValue<string>(1);
                        string password = reader.GetFieldValue<string>(2);

                        if (login == txtBoxLogin.Text && password == txtBoxPassword.Text)
                        {
                            MainMenu mainMenu = new MainMenu();
                            mainMenu.ShowDialog();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    conn.Close();
                    //MessageBox.Show("Connection closed");
                }
            };
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxLogin.Text != "" && txtBoxPassword.Text != "")
                btnLogIn.Enabled = true;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            signIn.ShowDialog();         
        }
    }
}