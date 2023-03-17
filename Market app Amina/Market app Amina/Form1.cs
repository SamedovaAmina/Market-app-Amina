namespace Market_app_Amina
{
    public partial class Yoxlama : Form
    {
        public Yoxlama()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ad == textBox1.Text && password == textBox2.Text)
            {
                MessageBox.Show("Duzgundur!");
                Menu form2 = new Menu();
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Duzgun deyil!");
                Application.Exit();
            }
        }
        string ad = "Amina";
        string password = "amina1234";

        
    }
}