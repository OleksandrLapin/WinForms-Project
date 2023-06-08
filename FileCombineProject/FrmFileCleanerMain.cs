using FileProcessor;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using FileCombineProject.File_cleaner;


namespace FileCombineProject.File_cleaner
{
    public partial class FrmFileCleanerMain : Form
    {
        private Finder finder = new Finder();

        public FrmFileCleanerMain()
        {
            InitializeComponent();
            //listViewMain.GridLines = true;
            //listViewMain.FullRowSelect = true;
            //listViewMain.Scrollable = true;
        }


        private void btnRootDir_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string path = folderBrowserDialog1.SelectedPath;

            lblRoot.Text = path;
        }



        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            long size = 0;

            listViewMain.Items.Clear();
            finder.Container.Dirs.Clear();
            finder.Container.Files.Clear();

            string[] dirPatterns = GetDirPatterns();
            finder.DirMasks = dirPatterns;

            string[] filePatterns = GetFilePatterns();
            finder.FileMasks = filePatterns;

            try
            {
                if (checkBoxCheckDir.Checked && checkBoxCheckFile.Checked)
                    finder.FindAll(lblRoot.Text);
                else if (checkBoxCheckDir.Checked && !checkBoxCheckFile.Checked)
                    finder.FindDirectories(lblRoot.Text);
                else if (!checkBoxCheckDir.Checked && checkBoxCheckFile.Checked)
                    finder.FindFiles(lblRoot.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Set Root Directory", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            foreach (DirectoryInfo DirInfo in finder.Container.Dirs)
            {
                ListViewItem item = new ListViewItem();

                item.SubItems[0].Text = DirInfo.Name;
                item.Tag = new DirectoryInfo(DirInfo.FullName);
                item.ImageIndex = 1;
                item.SubItems.Add(DirInfo.LastWriteTime.ToString());

                listViewMain.Items.Add(item);
            }

            foreach (FileInfo fileInfo in finder.Container.Files)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems[0].Text = fileInfo.Name;
                item.SubItems.Add(fileInfo.LastWriteTime.ToString());
                item.SubItems.Add((fileInfo.Length / 1024).ToString() + "Kb");
                item.Tag = new FileInfo(fileInfo.FullName);
                item.ImageIndex = 0;

                size += fileInfo.Length;
                listViewMain.Items.Add(item);
            }

            lblCount.Text = $"{listViewMain.Items.Count}";
            lblSize.Text = $"{size / 1024} Kb";

            btnClear.Enabled = true;
            checkBoxToTrash.Enabled = true;
        }

        private string[] GetDirPatterns()
        {
            List<string>? list = new List<string>();
            foreach (var item in listBoxDir.Items)
                list.Add(item.ToString());

            string[] dirPatterns;
            dirPatterns = list.ToArray();

            return dirPatterns;
        }

        private string[] GetFilePatterns()
        {
            List<string>? list = new List<string>();
            foreach (var item in listBoxFile.Items)
                list.Add(item.ToString());

            string[] filePatterns;
            filePatterns = list.ToArray();

            return filePatterns;
        }

        private void btnDirPatterns_Click(object sender, EventArgs e)
        {
            listBoxDir.Items.Add(txtBoxDir.Text);
        }

        private void btnDirPatternsDelete_Click(object sender, EventArgs e)
        {
            listBoxDir.Items.Remove(listBoxDir.SelectedItem);
        }

        private void btnFilePatterns_Click(object sender, EventArgs e)
        {
            listBoxFile.Items.Add(txtBoxFile.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBoxFile.Items.Remove(listBoxFile.SelectedItem);
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewMain.CheckedItems)
            {
                Cleaner.Clean(item.Tag as FileSystemInfo, checkBoxToTrash.Checked);
                listViewMain.Items.Remove(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
