using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class bai3 : Form
    {
        public bai3()
        {
            InitializeComponent();
        }
        private void btnRun_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();
            int txtt;
            if (Int32.TryParse(txtInput.Text, out txtt) == false || txtInput.Text.Length > 1)
            {
                txtInput.Clear();
                MessageBox.Show("Vui lòng nhập số từ 0 đến 9");
                return;

            }
            switch (Int32.Parse(txtInput.Text))
            {
                case 0:
                    txtOutput.Text = "Không";
                    break;
                case 1:
                    txtOutput.Text = "Một";
                    break;
                case 2:
                    txtOutput.Text = "Hai";
                    break;
                case 3:
                    txtOutput.Text = "Ba";
                    break;
                case 4:
                    txtOutput.Text = "Bốn";
                    break;
                case 5:
                    txtOutput.Text = "Năm";
                    break;
                case 6:
                    txtOutput.Text = "Sáu";
                    break;
                case 7:
                    txtOutput.Text = "Bảy";
                    break;
                case 8:
                    txtOutput.Text = "Tám";
                    break;
                case 9:
                    txtOutput.Text = "Chín";
                    break;
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            txtOutput.Clear();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
