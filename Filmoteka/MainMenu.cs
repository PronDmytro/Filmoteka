using System;
using System.Windows.Forms;

namespace Filmoteka
{
    public partial class MainMenu : Form
    {

        public int user_id { get; set; }
        public int user_rights { get; set; }
        public string connectionString { get; set; }

        public string programName { get; set; }
        public MainMenu()
        {
            InitializeComponent();
        }

        private void classesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Companys frm = new Form_Companys();
            frm.connectionString = connectionString;
            frm.user_id = user_id;
            frm.user_rights = user_rights;


            frm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            // якщо треба вийти з програми повністю, треба написати
            // Application.Exit();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void teachersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Directors frm = new Form_Directors();
            frm.connectionString = connectionString;
            frm.user_id = user_id;
            frm.user_rights = user_rights;


            frm.ShowDialog();
        }

        private void scheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Films frm = new Form_Films();
            frm.connectionString = connectionString;
            frm.user_id = user_id;
            frm.user_rights = user_rights;

            frm.ShowDialog();

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout frm = new FormAbout();

            frm.programName = programName;

            frm.ShowDialog();
        }
    }
}
