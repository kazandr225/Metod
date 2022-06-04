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
    public partial class Third1 : Form
    {
        public Third1()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("imgs//PR//picture1.1.jpg");
            pictureBox2.Image = Image.FromFile("imgs//PR//picture1.2.jpg");
        }

        private void NextBtn_Third1_Click(object sender, EventArgs e)
        {
            Third2 gn = new Third2();
            gn.Show();
            this.Hide();
        }

        private void ExitBtn_Third1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы точно хотите выйти?",
             "Выход из программы", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void Check_Click(object sender, EventArgs e)
        {


            int a1 = Convert.ToInt32(txb1_1.Text);
            int a2 = Convert.ToInt32(txb1_2.Text);
            int a3 = Convert.ToInt32(txb1_3.Text);
            int a4 = Convert.ToInt32(txb1_4.Text);
            int a5 = Convert.ToInt32(txb1_5.Text);
            string a6 = txb1_6.Text;
            int a7 = Convert.ToInt32(txb1_7.Text);
            int a8 = Convert.ToInt32(txb1_8.Text);
            int a9 = Convert.ToInt32(txb1_9.Text);
            int a10 = Convert.ToInt32(txb1_10.Text);

            int lose;
            lose = 0;

            if (a1 != 1)
            {
                lose = 1;

                if (lose == 1)
                {
                    lbl1_1.Text = "1";
                    lbl1_1.ForeColor = Color.Red;
                }
                Res mn = new Res();
                Res.otmetka = Res.otmetka + 2;
            }
            else if (a1 == 1)
            {
                lose = 0;

                if (lose == 0)
                {
                    lbl1_1.Text = "Верно!";
                    lbl1_1.ForeColor = Color.Green;
                }
            }

            if (a2 != 1)
            {
                lose = 1;

                if (lose == 1)
                {
                    lbl1_2.Text = "1";
                    lbl1_2.ForeColor = Color.Red;
                }
                Res mn = new Res();
                Res.otmetka = Res.otmetka + 2;
            }
            else if (a2 == 1)
            {
                lose = 0;

                if (lose == 0)
                {
                    lbl1_2.Text = "Верно!";
                    lbl1_2.ForeColor = Color.Green;
                }
            }

            if (a3 != 2)
            {
                lose = 1;

                if (lose == 1)
                {
                    lbl1_3.Text = "2";
                    lbl1_3.ForeColor = Color.Red;
                }
                Res mn = new Res();
                Res.otmetka = Res.otmetka + 2;
            }
            else if (a3 == 2)
            {
                lose = 0;

                if (lose == 0)
                {
                    lbl1_3.Text = "Верно!";
                    lbl1_3.ForeColor = Color.Green;
                }
            }

            if (a4 != 2)
            {
                lose = 1;

                if (lose == 1)
                {
                    lbl1_4.Text = "2";
                    lbl1_4.ForeColor = Color.Red;
                }
                Res mn = new Res();
                Res.otmetka = Res.otmetka + 2;
            }
            else if (a4 == 2)
            {
                lose = 0;

                if (lose == 0)
                {
                    lbl1_4.Text = "Верно!";
                    lbl1_4.ForeColor = Color.Green;
                }
            }

            if (a5 != 2)
            {
                lose = 1;

                if (lose == 1)
                {
                    lbl1_5.Text = "2";
                    lbl1_5.ForeColor = Color.Red;
                }
                Res mn = new Res();
                Res.otmetka = Res.otmetka + 2;
            }
            else if (a5 == 2)
            {
                lose = 0;

                if (lose == 0)
                {
                    lbl1_5.Text = "Верно!";
                    lbl1_5.ForeColor = Color.Green;
                }
            }

            if (a6 != "Da")
            {
                lose = 1;

                if (lose == 1)
                {
                    lbl1_6.Text = "Да";
                    lbl1_6.ForeColor = Color.Red;
                }
                Res mn = new Res();
                Res.otmetka = Res.otmetka + 2;
            }
            else if (a6 == "Da")
            {
                lose = 0;

                if (lose == 0)
                {
                    lbl1_6.Text = "Верно!";
                    lbl1_6.ForeColor = Color.Green;
                }
            }

            if (a7 != 0)
            {
                lose = 1;

                if (lose == 1)
                {
                    lbl1_7.Text = "0";
                    lbl1_7.ForeColor = Color.Red;
                }
                Res mn = new Res();
                Res.otmetka = Res.otmetka + 2;
            }
            else if (a7 == 0)
            {
                lose = 0;

                if (lose == 0)
                {
                    lbl1_7.Text = "Верно!";
                    lbl1_7.ForeColor = Color.Green;
                }
            }

            if (a8 != 0)
            {
                lose = 1;

                if (lose == 1)
                {
                    lbl1_8.Text = "0";
                    lbl1_8.ForeColor = Color.Red;
                }
                Res mn = new Res();
                Res.otmetka = Res.otmetka + 2;
            }
            else if (a8 == 0)
            {
                lose = 0;

                if (lose == 0)
                {
                    lbl1_8.Text = "Верно!";
                    lbl1_8.ForeColor = Color.Green;
                }
            }

            if (a9 != 4)
            {
                lose = 1;

                if (lose == 1)
                {
                    lbl1_9.Text = "4";
                    lbl1_9.ForeColor = Color.Red;
                }
                Res mn = new Res();
                Res.otmetka = Res.otmetka + 2;
            }
            else if (a9 == 4)
            {
                lose = 0;

                if (lose == 0)
                {
                    lbl1_9.Text = "Верно!";
                    lbl1_9.ForeColor = Color.Green;
                }
            }
            
            if (a10 != 3)
            {
                lose = 1;

                if (lose == 1)
                {
                    lbl1_10.Text = "3";
                    lbl1_10.ForeColor = Color.Red;
                }
                Res mn = new Res();
                Res.otmetka = Res.otmetka + 2;
            }
            else if (a10 == 3)
            {
                lose = 0;

                if (lose == 0)
                {
                    lbl1_10.Text = "Верно!";
                    lbl1_10.ForeColor = Color.Green;
                }
            }
        }

        private void Btn1_1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Максимальный элемент строки оценок - это a31, следовательно столбец 1 будет разрешающим.",
             "Подсказка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btn1_2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Тут необходимо выбрать минимум соотношений bi (aij). b1/a11; b2/a12 -> 4/2 - минимальный; 3/1. Минимальный элемент находится в 1 строке, следовательно строка будет разрешающей.",
                         "Подсказка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btn1_3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Элемент называется разрешающим, если находится на пересечении разрешающего столбца и разрешающей строки, следовательно 2 - разрешающий элемент",
             "Подсказка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btn1_4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("В строке оценок лишь 2 элемента больше нуля, следовательно свободных элементов тоже будет 2 ",
             "Подсказка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btn1_5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("5 столбцов - 2 свободных переменных - 1 = 2",
             "Подсказка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btn1_6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("F’= - (2x1 +x2) => min, в нее требуется подставить 0; F’= (2*0 +0) => min, функция равна 0",
             "Подсказка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btn1_7_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Столбец смешанный, следовательно x1=0",
             "Подсказка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btn1_8_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Столбец смешанный, следовательно x2=0",
             "Подсказка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btn1_9_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Единица стоит в 1-ой строке, следоваетльно x3 = 4",
             "Подсказка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btn1_10_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Единица стоит во 2-ой строке, следоваетльно x4 = 3",
             "Подсказка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
