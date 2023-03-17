using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace Market_app_Amina
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        int leftDog, leftLion, leftHorse;
        Random rnd = new Random();




        
       

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            int widthDog = pictureBox2.Width;
            int widthLion = pictureBox3.Width;
            int widthHorse = pictureBox1.Width;
            int start = label1.Left;
            pictureBox1.Left = pictureBox1.Left + rnd.Next(5, 16);
            pictureBox2.Left = pictureBox2.Left + rnd.Next(5, 16);
            pictureBox3.Left = pictureBox3.Left + rnd.Next(5, 16);
            if (pictureBox1.Left > pictureBox2.Left + 5 && pictureBox1.Left > pictureBox3.Left + 5)
            {
                netice.Text = "Horse faster";
            }
            if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5)
            {
                netice.Text = "Dog faster";
            }
            if (pictureBox3.Left > pictureBox1.Left + 5 && pictureBox3.Left > pictureBox2.Left + 5)
            {
                netice.Text = "Lion faster";
            }
            if (widthHorse + pictureBox1.Left >= start)
            {
                timer1.Enabled = false;
                netice.Text = "Horse win";
            }
            if (widthDog + pictureBox2.Left >= start)
            {
                timer1.Enabled = false;
                netice.Text = "Dog win";
            }
            if (widthLion + pictureBox3.Left >= start)
            {
                timer1.Enabled = false;
                netice.Text = "Lion win";
            }

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string secim1 = comboBox1.Text;
            if (secim1 == "Horse win" && secim1 == netice.Text)
            {
                MessageBox.Show("You win");
            }
            
            else if (secim1 == "Dog win" && secim1 == netice.Text)
            {
                MessageBox.Show("You win");
            }
            
            else if (secim1 == "Lion win" && secim1 == netice.Text)
            {
                MessageBox.Show("You win");
            }
            else
            {
                MessageBox.Show("You lose");
            }
        }

   
    }
    
}
