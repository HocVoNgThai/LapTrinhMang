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
    public partial class bai1 : Form
    {
        public bai1()
        {
            InitializeComponent();
        }     
        private void btnRun_Click(object sender, EventArgs e)
        {
            int temp1;
            if (Int32.TryParse(txtNumber1.Text, out temp1) == false)
            {
                MessageBox.Show("Vui lòng nhập vào số nguyên ở ô số thứ nhất");
                txtNumber1.Clear();
                return;
            }
            int temp2;
            if (Int32.TryParse(txtNumber2.Text, out temp2) == false)
            {
                MessageBox.Show("Vui lòng nhập vào số nguyên ở ô thứ hai");
                txtNumber2.Clear();
                return;
            }
            int sum = 0;
            int num1 = Int32.Parse(txtNumber1.Text);
            int num2 = Int32.Parse(txtNumber2.Text);
            sum = num1 + num2;
            btnSum.Text = Convert.ToString(sum);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
