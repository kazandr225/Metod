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
    public partial class Third2 : Form
    {
        public Third2()
        {
            InitializeComponent();
        }

        private void ExitBtn_Third2_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы точно хотите выйти?",
            "Выход из программы", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void NextBtn_Third2_Click_1(object sender, EventArgs e)
        {
            Third3 gn = new Third3();
            gn.Show();
            this.Hide();
        }

        private void Check_Click(object sender, EventArgs e)
        {
            int a1 = Convert.ToInt32(txb2_1.Text);
            int a2 = Convert.ToInt32(txb2_2.Text);
            int a3 = Convert.ToInt32(txb2_3.Text);
            int a4 = Convert.ToInt32(txb2_4.Text);
            int a5 = Convert.ToInt32(txb2_5.Text);
            string a6 = txb2_6.Text;
            int a7 = Convert.ToInt32(txb2_7.Text);
            int a8 = Convert.ToInt32(txb2_8.Text);
            int a9 = Convert.ToInt32(txb2_9.Text);
            int a10 = Convert.ToInt32(txb2_10.Text);

            int lose;
            lose = 0;

            if (a1 != 1)
            {
                lose = 1;

                if (lose == 1)
                {
                    lbl2_1.Text = "1";
                    lbl2_1.ForeColor = Color.Red;
                }
                Res mn = new Res();
                Res.otmetka = Res.otmetka + 2;
            }
            else if (a1 == 1)
            {
                lose = 0;

                if (lose == 0)
                {
                    lbl2_1.Text = "Верно!";
                    lbl2_1.ForeColor = Color.Green;
                }
            }

            if (a2 != 1)
            {
                lose = 1;

                if (lose == 1)
                {
                    lbl2_2.Text = "1";
                    lbl2_2.ForeColor = Color.Red;
                }
                Res mn = new Res();
                Res.otmetka = Res.otmetka + 2;
            }
            else if (a2 == 1)
            {
                lose = 0;

                if (lose == 0)
                {
                    lbl2_2.Text = "Верно!";
                    lbl2_2.ForeColor = Color.Green;
                }
            }

            if (a3 != 2)
            {
                lose = 1;

                if (lose == 1)
                {
                    lbl2_3.Text = "2";
                    lbl2_3.ForeColor = Color.Red;
                }
                Res mn = new Res();
                Res.otmetka = Res.otmetka + 2;
            }
            else if (a3 == 2)
            {
                lose = 0;

                if (lose == 0)
                {
                    lbl2_3.Text = "Верно!";
                    lbl2_3.ForeColor = Color.Green;
                }
            }

            if (a4 != 2)
            {
                lose = 1;

                if (lose == 1)
                {
                    lbl2_4.Text = "2";
                    lbl2_4.ForeColor = Color.Red;
                }
                Res mn = new Res();
                Res.otmetka = Res.otmetka + 2;
            }
            else if (a4 == 2)
            {
                lose = 0;

                if (lose == 0)
                {
                    lbl2_4.Text = "Верно!";
                    lbl2_4.ForeColor = Color.Green;
                }
            }

            if (a5 != 2)
            {
                lose = 1;

                if (lose == 1)
                {
                    lbl2_5.Text = "2";
                    lbl2_5.ForeColor = Color.Red;
                }
                Res mn = new Res();
                Res.otmetka = Res.otmetka + 2;
            }
            else if (a5 == 2)
            {
                lose = 0;

                if (lose == 0)
                {
                    lbl2_5.Text = "Верно!";
                    lbl2_5.ForeColor = Color.Green;
                }
            }

            if (a6 != "Da")
            {
                lose = 1;

                if (lose == 1)
                {
                    lbl2_6.Text = "Да";
                    lbl2_6.ForeColor = Color.Red;
                }
                Res mn = new Res();
                Res.otmetka = Res.otmetka + 2;
            }
            else if (a6 == "Da")
            {
                lose = 0;

                if (lose == 0)
                {
                    lbl2_6.Text = "Верно!";
                    lbl2_6.ForeColor = Color.Green;
                }
            }

            if (a7 != 0)
            {
                lose = 1;

                if (lose == 1)
                {
                    lbl2_7.Text = "0";
                    lbl2_7.ForeColor = Color.Red;
                }
                Res mn = new Res();
                Res.otmetka = Res.otmetka + 2;
            }
            else if (a7 == 0)
            {
                lose = 0;

                if (lose == 0)
                {
                    lbl2_7.Text = "Верно!";
                    lbl2_7.ForeColor = Color.Green;
                }
            }

            if (a8 != 0)
            {
                lose = 1;

                if (lose == 1)
                {
                    lbl2_8.Text = "0";
                    lbl2_8.ForeColor = Color.Red;
                }
                Res mn = new Res();
                Res.otmetka = Res.otmetka + 2;
            }
            else if (a8 == 0)
            {
                lose = 0;

                if (lose == 0)
                {
                    lbl2_8.Text = "Верно!";
                    lbl2_8.ForeColor = Color.Green;
                }
            }

            if (a9 != 4)
            {
                lose = 1;

                if (lose == 1)
                {
                    lbl2_9.Text = "4";
                    lbl2_9.ForeColor = Color.Red;
                }
                Res mn = new Res();
                Res.otmetka = Res.otmetka + 2;
            }
            else if (a9 == 4)
            {
                lose = 0;

                if (lose == 0)
                {
                    lbl2_9.Text = "Верно!";
                    lbl2_9.ForeColor = Color.Green;
                }
            }

            if (a10 != 3)
            {
                lose = 1;

                if (lose == 1)
                {
                    lbl2_10.Text = "3";
                    lbl2_10.ForeColor = Color.Red;
                }
                Res mn = new Res();
                Res.otmetka = Res.otmetka + 2;
            }
            else if (a10 == 3)
            {
                lose = 0;

                if (lose == 0)
                {
                    lbl2_10.Text = "Верно!";
                    lbl2_10.ForeColor = Color.Green;
                }
            }
        }

        private void Btn2_1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Максимальный элемент строки оценок - это a31, следовательно столбец 1 будет разрешающим.",
            "Подсказка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btn2_2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Тут необходимо выбрать минимум соотношений bi (aij). b1/a11; b2/a12 -> 4/2 - минимальный; 3/1. Минимальный элемент находится в 1 строке, следовательно строка будет разрешающей.",
                         "Подсказка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btn2_3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Элемент называется разрешающим, если находится на пересечении разрешающего столбца и разрешающей строки, следовательно 2 - разрешающий элемент",
             "Подсказка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btn2_4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("В строке оценок лишь 2 элемента больше нуля, следовательно свободных элементов тоже будет 2 ",
            "Подсказка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btn2_5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("5 столбцов - 2 свободных переменных - 1 = 2",
             "Подсказка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btn2_6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("F’= - (2x1 +x2) => min, в нее требуется подставить 0; F’= (2*0 +0) => min, функция равна 0",
            "Подсказка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btn2_7_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Столбец смешанный, следовательно x1=0",
             "Подсказка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btn2_8_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Столбец смешанный, следовательно x2=0",
            "Подсказка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btn2_9_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Единица стоит в 1-ой строке, следоваетльно x3 = 4",
             "Подсказка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btn2_10_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Единица стоит во 2-ой строке, следоваетльно x4 = 3",
             "Подсказка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
