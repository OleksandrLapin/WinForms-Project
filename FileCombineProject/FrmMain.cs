using FileCombineProject.File_cleaner;

namespace FileCombineProject
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnCleaner_Click(object sender, EventArgs e)
        {
            FrmFileCleanerMain frm = new FrmFileCleanerMain();
            frm.ShowDialog();
        }
    }
}