using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodicheskayaProgramma
{
    public partial class First : Form
    {
        public First()
        {
            InitializeComponent();
        }

        private void NextBtn_First_Click(object sender, EventArgs e)
        {
            Second gn = new Second();
            gn.Show();
            this.Hide();
        }

        private void ExitBtn_First_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы точно хотите выйти?",
             "Выход из программы", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                Application.Exit();
        }
    }
}
