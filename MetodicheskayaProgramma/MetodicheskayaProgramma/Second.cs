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
    public partial class Second : Form
    {
        public Second()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("imgs//picture1.jpg"); 
        }
        int count = 1;
        private void NextBtn_Second_Click(object sender, EventArgs e)
        {
            Third1 gn = new Third1();
            gn.Show();
            this.Hide();
        }

        private void BackBtn_Second_Click(object sender, EventArgs e)
        {
            First gn = new First();
            gn.Show();
            this.Hide();
        }

        private void RightBtn_Second_Click(object sender, EventArgs e)
        {
            if (count == 15)
            {
                RightBtn_Second.Visible = false;
                LeftBtn_Second.Visible = true;
            }
            if (count != 15)
            {
                count++;
                pictureBox1.Image = Image.FromFile("imgs//picture" + count + ".jpg");
       
            }
        }

        private void LeftBtn_Second_Click(object sender, EventArgs e)
        {
            if (count == 1)
            {
                LeftBtn_Second.Visible = false;
                RightBtn_Second.Visible = true;
            }
            if (count != 1)
            {
                count--;
                pictureBox1.Image = Image.FromFile("imgs//picture" + count + ".jpg");
            }
        }

        private void ExitBtn_Second_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы точно хотите выйти?",
             "Выход из программы", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                Application.Exit();
        }
    }
}
