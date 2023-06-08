using FileCombineProject.Archive;
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
    public partial class FormArchiver : Form
    {
        private ArchiveEngine engine = new ArchiveEngine();

        public FormArchiver()
        {
            InitializeComponent();
            cmbBoxExtention.SelectedIndex = 0;
        }

        private string GetRootDirPath(string path)
        {
            int startIndex = 0;

            startIndex = path.LastIndexOf("\\");

            string newPath = path.Remove(startIndex);

            return newPath;
        }

        private string GetDirTitle(string path)
        {
            int startIndex = 0;

            startIndex = path.LastIndexOf("\\") + 1;

            return path.Substring(startIndex);
        }

        private void btnDirectories_Click(object sender, EventArgs e)
        {
            folderBrowser.ShowDialog();
            txtBoxDir.Text = folderBrowser.SelectedPath;
            txtBoxDestination.Text = GetRootDirPath(folderBrowser.SelectedPath);
            txtBoxFileTitle.Text = GetDirTitle(folderBrowser.SelectedPath);
        }

        private void btnDestination_Click(object sender, EventArgs e)
        {
            folderBrowser.ShowDialog();
            txtBoxDestination.Text = folderBrowser.SelectedPath;
        }

        private void btnCompress_Click(object sender, EventArgs e)
        {
            string destination = $"{txtBoxDestination.Text}\\{txtBoxFileTitle.Text}{cmbBoxExtention.Text}";

            try
            {
                engine.CompressDirectory(txtBoxDir.Text, destination);

                MessageBox.Show("The archive was successfully created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
