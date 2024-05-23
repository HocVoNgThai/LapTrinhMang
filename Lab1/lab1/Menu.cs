namespace lab1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bai1 b1 = new bai1();
            b1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bai2 b2 = new Bai2();
            b2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bai3 b3 = new bai3();
            b3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bai3_1 bai3_1 = new bai3_1();
            bai3_1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bai4 bai4 = new bai4();
            bai4.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bai6 bai6 = new bai6();
            bai6.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            bai8 bai8 = new bai8();
            bai8.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bai5 bai5 = new bai5();
            bai5.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bai7 bai7 = new bai7();
            bai7.ShowDialog();
        }
    }
}