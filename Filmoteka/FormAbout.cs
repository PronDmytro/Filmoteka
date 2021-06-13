using System;
using System.Windows.Forms;

namespace Filmoteka
{
    public partial class FormAbout : Form
    {
        public string programName { get; set; }

        public FormAbout()
        {
            InitializeComponent();
        }

        private void FormAbout_Load(object sender, EventArgs e)
        {
            label_header.Text = programName;
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
