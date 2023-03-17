using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_app_Amina
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        string number = "";
        int reqem1 = 0;
        int reqem2 = 0;
        string emeliyyat = "";

        private void btn1_Click(object sender, EventArgs e)
        {
            WriteTextBox(btn1.Text);
        }
        void WriteTextBox(string num)
        {
            number = textBox1.Text;
            number = number + num;
            textBox1.Text = number;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            WriteTextBox(btn2.Text);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            WriteTextBox(btn3.Text);
        }

        private void btnvurma_Click(object sender, EventArgs e)
        {
            var res = Hesabla(btnvurma.Text);
            label1.Text = res.ToString();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            WriteTextBox(btn4.Text);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            WriteTextBox(btn5.Text);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            WriteTextBox(btn6.Text);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            WriteTextBox(btn7.Text);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            WriteTextBox(btn8.Text);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            WriteTextBox(btn9.Text);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            WriteTextBox(btn0.Text);
        }
        int Hesabla(string _emel)
        {
            if (reqem1==0)
            {
                reqem1 = Convert.ToInt32(textBox1.Text);
                label1.Text=reqem1+ _emel;
                textBox1.Clear();
                emeliyyat = _emel;
            }
            else if (reqem2==0)
            {
                reqem2 = Convert.ToInt32(textBox1.Text);
                textBox1.Clear();
            }
            if (emeliyyat!="" && reqem1!=0 && reqem2!=0)
            {
                switch (emeliyyat)
                {
                    case "+":
                        reqem1 = reqem1 + reqem2;
                        reqem2 = 0;
                        break;
                    case "-":
                        reqem1 = reqem1 - reqem2;
                        reqem2 = 0;
                        break;
                    case "*":
                        reqem1 = reqem1 * reqem2;
                        reqem2 = 0;
                        break;
                    case "/":
                        reqem1 = reqem1 / reqem2;
                        reqem2 = 0;
                        break;
                }
            }
            return reqem1;
        }

        private void btnslash_Click(object sender, EventArgs e)
        {
            var res = Hesabla(btnslash.Text);
            label1.Text = res.ToString();
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            var res = Hesabla(btnplus.Text);
            label1.Text = res.ToString();
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            var res = Hesabla(btnminus.Text);
            label1.Text = res.ToString();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            var res = Hesabla(btnberaber.Text);
            label1.Text = res.ToString();
        }

       
    }
}
