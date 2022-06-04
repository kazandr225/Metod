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
    public partial class Third3 : Form
    {
        public Third3()
        {
            InitializeComponent();
        }

        private void NextBtn_Third3_Click_1(object sender, EventArgs e)
        {
            Third4 gn = new Third4();
            gn.Show();
            this.Hide();
        }

        private void ExitBtn_Third3_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы точно хотите выйти?",
            "Выход из программы", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void Check_Click(object sender, EventArgs e)
        {
            int a1 = Convert.ToInt32(txb3_1.Text);
            int a2 = Convert.ToInt32(txb3_2.Text);
            int a3 = Convert.ToInt32(txb3_3.Text);
            int a4 = Convert.ToInt32(txb3_4.Text);
            int a5 = Convert.ToInt32(txb3_5.Text);
            string a6 = txb3_6.Text;
            int a7 = Convert.ToInt32(txb3_7.Text);
            int a8 = Convert.ToInt32(txb3_8.Text);
            int a9 = Convert.ToInt32(txb3_9.Text);
            int a10 = Convert.ToInt32(txb3_10.Text);

            int lose;
            lose = 0;

            if (a1 != 1)
            {
                lose = 1;

                if (lose == 1)
                {
                    lbl3_1.Text = "1";
                    lbl3_1.ForeColor = Color.Red;
                }
                Res mn = new Res();
                Res.otmetka = Res.otmetka + 2;
            }
            else if (a1 == 1)
            {
                lose = 0;

                if (lose == 0)
                {
                    lbl3_1.Text = "Верно!";
                    lbl3_1.ForeColor = Color.Green;
                }
            }

            if (a2 != 1)
            {
                lose = 1;

                if (lose == 1)
                {
                    lbl3_2.Text = "1";
                    lbl3_2.ForeColor = Color.Red;
                }
                Res mn = new Res();
                Res.otmetka = Res.otmetka + 2;
            }
            else if (a2 == 1)
            {
                lose = 0;

                if (lose == 0)
                {
                    lbl3_2.Text = "Верно!";
                    lbl3_2.ForeColor = Color.Green;
                }
            }

            if (a3 != 2)
            {
                lose = 1;

                if (lose == 1)
                {
                    lbl3_3.Text = "2";
                    lbl3_3.ForeColor = Color.Red;
                }
                Res mn = new Res();
                Res.otmetka = Res.otmetka + 2;
            }
            else if (a3 == 2)
            {
                lose = 0;

                if (lose == 0)
                {
                    lbl3_3.Text = "Верно!";
                    lbl3_3.ForeColor = Color.Green;
                }
            }

            if (a4 != 2)
            {
                lose = 1;

                if (lose == 1)
                {
                    lbl3_4.Text = "2";
                    lbl3_4.ForeColor = Color.Red;
                }
                Res mn = new Res();
                Res.otmetka = Res.otmetka + 2;
            }
            else if (a4 == 2)
            {
                lose = 0;

                if (lose == 0)
                {
                    lbl3_4.Text = "Верно!";
                    lbl3_4.ForeColor = Color.Green;
                }
            }

            if (a5 != 2)
            {
                lose = 1;

                if (lose == 1)
                {
                    lbl3_5.Text = "2";
                    lbl3_5.ForeColor = Color.Red;
                }
                Res mn = new Res();
                Res.otmetka = Res.otmetka + 2;
            }
            else if (a5 == 2)
            {
                lose = 0;

                if (lose == 0)
                {
                    lbl3_5.Text = "Верно!";
                    lbl3_5.ForeColor = Color.Green;
                }
            }

            if (a6 != "Da")
            {
                lose = 1;

                if (lose == 1)
                {
                    lbl3_6.Text = "Да";
                    lbl3_6.ForeColor = Color.Red;
                }
                Res mn = new Res();
                Res.otmetka = Res.otmetka + 2;
            }
            else if (a6 == "Da")
            {
                lose = 0;

                if (lose == 0)
                {
                    lbl3_6.Text = "Верно!";
                    lbl3_6.ForeColor = Color.Green;
                }
            }

            if (a7 != 0)
            {
                lose = 1;

                if (lose == 1)
                {
                    lbl3_7.Text = "0";
                    lbl3_7.ForeColor = Color.Red;
                }
                Res mn = new Res();
                Res.otmetka = Res.otmetka + 2;
            }
            else if (a7 == 0)
            {
                lose = 0;

                if (lose == 0)
                {
                    lbl3_7.Text = "Верно!";
                    lbl3_7.ForeColor = Color.Green;
                }
            }

            if (a8 != 0)
            {
                lose = 1;

                if (lose == 1)
                {
                    lbl3_8.Text = "0";
                    lbl3_8.ForeColor = Color.Red;
                }
                Res mn = new Res();
                Res.otmetka = Res.otmetka + 2;
            }
            else if (a8 == 0)
            {
                lose = 0;

                if (lose == 0)
                {
                    lbl3_8.Text = "Верно!";
                    lbl3_8.ForeColor = Color.Green;
                }
            }

            if (a9 != 4)
            {
                lose = 1;

                if (lose == 1)
                {
                    lbl3_9.Text = "4";
                    lbl3_9.ForeColor = Color.Red;
                }
                Res mn = new Res();
                Res.otmetka = Res.otmetka + 2;
            }
            else if (a9 == 4)
            {
                lose = 0;

                if (lose == 0)
                {
                    lbl3_9.Text = "Верно!";
                    lbl3_9.ForeColor = Color.Green;
                }
            }

            if (a10 != 3)
            {
                lose = 1;

                if (lose == 1)
                {
                    lbl3_10.Text = "3";
                    lbl3_10.ForeColor = Color.Red;
                }
                Res mn = new Res();
                Res.otmetka = Res.otmetka + 2;
                Console.WriteLine();
            }
            else if (a10 == 3)
            {
                lose = 0;

                if (lose == 0)
                {
                    lbl3_10.Text = "Верно!";
                    lbl3_10.ForeColor = Color.Green;
                }
            }
        }
    }
}
