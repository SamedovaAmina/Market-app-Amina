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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void eylenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void hesablamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string secim1 = comboBox1.Text;
            if (secim1=="black")
            {
                this.BackColor = Color.Black;
            }
            if (secim1 == "red")
            {
                this.BackColor = Color.Red;
            }
            if (secim1 == "pink")
            {
                this.BackColor = Color.Pink;
            }
            if (secim1 == "green")
            {
                this.BackColor = Color.Green;
            }
            if (secim1 == "yellow")
            {
                this.BackColor = Color.Yellow;
            }
            if (secim1 == "purple")
            {
                this.BackColor = Color.Purple;
            }
            if (secim1 == "orange")
            {
                this.BackColor = Color.Orange;
            }
        }

        private void ickilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }

        private void musiqiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.ShowDialog();
        }

        private void advProsesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.ShowDialog();
        }

        private void resmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.ShowDialog();
        }

        private void yemeklerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.ShowDialog();
        }
    }
}
