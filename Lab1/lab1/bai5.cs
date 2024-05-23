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
    public partial class bai5 : Form
    {
        public bai5()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            lstKetQua.Items.Clear();
            int value1, value2;
            if (Int32.TryParse(txtA.Text, out value1) == false || Int32.TryParse(txtB.Text, out value2) == false)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số nguyên");
                return;
            }
            if (cbPhepTinh.SelectedIndex == 0)
            {
                int temp = Int32.Parse(txtB.Text) - Int32.Parse(txtA.Text);
                if (temp <= 0 || temp >= 10)
                {
                    MessageBox.Show("Giá trị nhập vào không hợp lệ với phương thức tính\n" +
                        "Vui lòng nhập lại hoặc chọn phương thức tính khác");
                }
                else
                {
                    lstKetQua.Items.Add("Bảng cửu chương " + temp.ToString() + ": ");
                    for (int i = 1; i <= 10; i++)
                    {
                        lstKetQua.Items.Add($"{temp} x {i} = {temp * i}");
                    }
                }

            }
            else if (cbPhepTinh.SelectedIndex == 1)
            {
                int temp = Int32.Parse(txtA.Text) - Int32.Parse(txtB.Text);
                int numberA = Int32.Parse(txtA.Text);
                int numberB = Int32.Parse(txtB.Text);
                if (temp <= 0 || numberB <= 0)
                {
                    MessageBox.Show("Giá trị nhập vào không hợp lệ phương thức tính\n" +
                        "Vui lòng nhập lại hoặc chọn phương thức tính khác");
                    return;
                }
                else
                {
                    long rlt1 = 1;
                    long rlt2 = 0;
                    for (int i = 1; i <= temp; i++)
                        rlt1 = rlt1 * i;
                    for (int i = 1; i <= numberB; i++)
                        rlt2 += (long)Math.Pow(numberA, i);
                    lstKetQua.Items.Add("Giá trị các phép tính là: ");
                    lstKetQua.Items.Add($"Giai thừa ({numberA} - {numberB})! = {rlt1}");
                    lstKetQua.Items.Add($"Tổng S = {numberA}^1 + {numberA}^2 + ..... + {numberA}^{numberB} = {rlt2} ");
                }
            }

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            lstKetQua.Items.Clear();
        }
        private void btnXoaHet_Click(object sender, EventArgs e)
        {
            lstKetQua.Items.Clear();
            txtA.Clear();
            txtB.Clear();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
