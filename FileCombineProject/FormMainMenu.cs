using FileCombineProject.File_cleaner;
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
    public partial class FormMainMenu : Form
    {
        public FormMainMenu()
        {
            InitializeComponent();
        }

        private void btnCleaner_Click(object sender, EventArgs e)
        {
            FrmFileCleanerMain frm = new FrmFileCleanerMain();
            frm.ShowDialog();
        }

        private void btnArchiver_Click(object sender, EventArgs e)
        {
            FormArchiver archiver = new FormArchiver();
            archiver.ShowDialog();
        }

        private void btnRenamer_Click(object sender, EventArgs e)
        {
            FormRenamer renamer = new FormRenamer();
            renamer.ShowDialog();
        }
    }
}
