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
    public partial class bai6 : Form
    {
        public bai6()
        {
            InitializeComponent();
        }
        private void btnTest_Click(object sender, EventArgs e)
        {
            if (dtp1.Value.Month == 1)
            {
                if (dtp1.Value.Day >= 1 && dtp1.Value.Day <= 20)
                {
                    txtOutput.Text = "Cung Ma kết";
                }
                else
                {
                    txtOutput.Text = "Cung Bảo Bình";
                }
            }
            else if (dtp1.Value.Month == 2)
            {
                if (dtp1.Value.Day >= 1 && dtp1.Value.Day <= 19)
                {
                    txtOutput.Text = "Cung Bảo Bình";
                }
                else
                {
                    txtOutput.Text = "Cung Song Ngư";
                }
            }
            else if (dtp1.Value.Month == 3)
            {
                if (dtp1.Value.Day >= 1 && dtp1.Value.Day <= 20)
                {
                    txtOutput.Text = "Cung Song Ngư";
                }
                else
                {
                    txtOutput.Text = "Cung Bạch Dương";
                }
            }
            else if (dtp1.Value.Month == 4)
            {
                if (dtp1.Value.Day >= 1 && dtp1.Value.Day <= 20)
                {
                    txtOutput.Text = "Cung Bạch Dương";
                }
                else
                {
                    txtOutput.Text = "Cung Kim Ngưu";
                }
            }
            else if (dtp1.Value.Month == 5)
            {
                if (dtp1.Value.Day >= 1 && dtp1.Value.Day <= 21)
                {
                    txtOutput.Text = "Cung Kim Ngưu";
                }
                else
                {
                    txtOutput.Text = "Cung Song Tử";
                }
            }
            else if (dtp1.Value.Month == 6)
            {
                if (dtp1.Value.Day >= 1 && dtp1.Value.Day <= 21)
                {
                    txtOutput.Text = "Cung Song Tử";
                }
                else
                {
                    txtOutput.Text = "Cung Cự Giải";
                }
            }
            else if (dtp1.Value.Month == 7)
            {
                if (dtp1.Value.Day >= 1 && dtp1.Value.Day <= 22)
                {
                    txtOutput.Text = "Cung Cự Giải";
                }
                else
                {
                    txtOutput.Text = "Cung Sư Tử";
                }
            }
            else if (dtp1.Value.Month == 8)
            {
                if (dtp1.Value.Day >= 1 && dtp1.Value.Day <= 22)
                {
                    txtOutput.Text = "Cung Sư Tử";
                }
                else
                {
                    txtOutput.Text = "Cung Xử Nữ";
                }
            }
            else if (dtp1.Value.Month == 9)
            {
                if (dtp1.Value.Day >= 1 && dtp1.Value.Day <= 23)
                {
                    txtOutput.Text = "Cung Xử Nữ";
                }
                else
                {
                    txtOutput.Text = "Cung Thiên Bình";
                }
            }
            else if (dtp1.Value.Month == 10)
            {
                if (dtp1.Value.Day >= 1 && dtp1.Value.Day <= 23)
                {
                    txtOutput.Text = "Cung Thiên Bình";
                }
                else
                {
                    txtOutput.Text = "Cung Thần Nông";
                }
            }
            else if (dtp1.Value.Month == 11)
            {
                if (dtp1.Value.Day >= 1 && dtp1.Value.Day <= 22)
                {
                    txtOutput.Text = "Cung Thần Nông";
                }
                else
                {
                    txtOutput.Text = "Cung Nhân Mã";
                }
            }
            else if (dtp1.Value.Month == 12)
            {
                if (dtp1.Value.Day >= 1 && dtp1.Value.Day <= 21)
                {
                    txtOutput.Text = "Cung Nhân Mã";
                }
                else
                {
                    txtOutput.Text = "Cung Ma Kết";
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
