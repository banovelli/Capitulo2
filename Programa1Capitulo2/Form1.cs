using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa1Capitulo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this is a coment :-)

            String name = "Quentim";
            int x = 3;
            x = x * 17;
            double d = Math.PI / 2;
            MessageBox.Show("nome é " + name
                + "\nx is " + x
                + "\nd is " + d);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = 5;
            if (x == 10)
            {
                MessageBox.Show("x necessita ser 10");
            }
            else
            {
                MessageBox.Show("x não é 10");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int someValue = 4;
            String name = "Bobbo Jr";
            if (someValue < 3 && name.Equals("Joe"))
            {
                MessageBox.Show("x é 3 e nome é joe");
            }
            MessageBox.Show("Essa linha executa em qq caso");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int count = 0;
            while (count < 10)
            {
                count++;
            }
            for (int i = 0; i < 5; i++)
            {
                count--;
            }
            MessageBox.Show("O resultado é: " + count);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                if (label1.BackColor == Color.Red)
                {
                    label1.BackColor = Color.Blue;
                }
                else
                {
                    label1.BackColor = Color.Red;
                }
            }
            else
            {
                MessageBox.Show("A caixa não está marcada");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            while (Visible)
            {
                for (int c = 0; c < 255 && Visible; c++)
                {
                    this.BackColor = Color.FromArgb(c, 255 - c, c);
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(3);
                }
                for (int c = 254; c > 0 && Visible; c--)
                {
                    this.BackColor = Color.FromArgb(c, 255 - c, c);
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(3);
                }
            }
        }
    }
}
