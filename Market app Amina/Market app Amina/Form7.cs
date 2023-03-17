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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string secim1 = comboBox1.Text;
            int eded = Convert.ToInt32(textBox1.Text);
            float su = 4.2f;
            float et = 7.2f;
            float corek = 3.5f;
            float adv = 0.15f;
            float sunetice = Convert.ToSingle(eded) * su * adv;
            float coreknetice = Convert.ToSingle(eded) * corek * adv;
            float etnetice = Convert.ToSingle(eded) * et * adv;
            if (secim1=="Et")
            {
                MessageBox.Show(Convert.ToString(etnetice));

            }
            if (secim1 == "Corek")
            {
                MessageBox.Show(Convert.ToString(coreknetice));
            }
            if (secim1 == "Su")
            {
                MessageBox.Show(Convert.ToString(sunetice));
            }
        }
    }
}
