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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }        
        private void find_Click(object sender, EventArgs e)
        {
            float temp1, temp2, temp3;
            if(float.TryParse(txtNumber1.Text,out temp1)==false || float.TryParse(txtNumber2.Text,out temp2) == false 
                || float.TryParse(txtNumber3.Text, out temp3) == false) 
            {
                MessageBox.Show("Giá trị nhập vào không hợp lệ");
                return;
            }
            float s1 = float.Parse(txtNumber1.Text);
            float s2 = float.Parse(txtNumber2.Text);
            float s3 = float.Parse(txtNumber3.Text);
            float min, max;
            if (s1 > s2)
            {
                if (s1 > s3)
                {
                    max = s1;
                    if (s2 > s3)
                        min = s3;
                    else
                        min = s2;
                }
                else
                {
                    max = s3;
                    min = s2;
                }
            }
            else
            {
                if (s1 > s3)
                {
                    max = s2;
                    min = s3;
                }
                else
                {
                    min = s1;
                    if (s2 > s3)
                    {
                        max = s2;
                    }
                    else
                        max = s3;
                }
            }
            txtMin.Text = Convert.ToString(min);
            txtMax.Text = Convert.ToString(max);
        }
        private void delete_Click(object sender, EventArgs e)
        {
            txtNumber1.Clear();
            txtNumber2.Clear();
            txtNumber3.Clear();
            txtMax.Clear();
            txtMin.Clear();
        }
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
