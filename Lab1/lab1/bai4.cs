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
    public partial class bai4 : Form
    {
        public bai4()
        {
            InitializeComponent();
        }
        Dictionary<string, string> names = new Dictionary<string, string>();
        private void cbPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPhim.SelectedIndex == 0)
            {
                cbPhongChieu.Items.Clear();
                cbPhongChieu.ResetText();
                cbPhongChieu.Items.Add("Phòng chiếu 1");
                cbPhongChieu.Items.Add("Phòng chiếu 2");
                cbPhongChieu.Items.Add("Phòng chiếu 3");
            }
            else if (cbPhim.SelectedIndex == 1)
            {
                cbPhongChieu.Items.Clear();
                cbPhongChieu.ResetText();
                cbPhongChieu.Items.Add("Phòng chiếu 2");
                cbPhongChieu.Items.Add("Phòng chiếu 3");
            }
            else if (cbPhim.SelectedIndex == 2)
            {
                cbPhongChieu.Items.Clear();
                cbPhongChieu.ResetText();
                cbPhongChieu.Items.Add("Phòng chiếu 1");
            }
            else if (cbPhim.SelectedIndex == 3)
            {
                cbPhongChieu.Items.Clear();
                cbPhongChieu.ResetText();
                cbPhongChieu.Items.Add("Phòng chiếu 3");
            }
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedItemCollection item = checklstSoGhe.CheckedItems;
            int sumTienVe = 0;
            long sdt;
            if (item.Count == 0 || cbPhim.SelectedItem == null || cbPhongChieu.SelectedItem == null 
                || txtHoTen.Text == "" || txtSdt.Text=="" ) 
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            else if(long.TryParse(txtSdt.Text, out sdt) == false)
            {
                MessageBox.Show("Không nhập các kí tự khác ngoài số vào ô Số điện thoại");
            }    
            else
            {

                foreach (string s in item)
                {
                    if (lstThongTinVe.Items.Contains($"Phim {cbPhim.SelectedItem} {cbPhongChieu.SelectedItem} Ghế {s}") == true)
                    {
                        MessageBox.Show($"Ghế {s} đã được chọn");
                        return;
                    }
                }
                if (names.ContainsKey(txtSdt.Text))
                {
                    if (names[txtSdt.Text] != $"Phim {cbPhim.SelectedItem} {cbPhongChieu.SelectedItem}")
                    {
                        MessageBox.Show("Khách hàng không thể mua thêm vé của xuất chiếu khác");
                        return;
                    }
                }
                else
                {
                    names.Add(txtSdt.Text, $"Phim {cbPhim.SelectedItem} {cbPhongChieu.SelectedItem}");
                }
                lstThongTinVe.Items.Add($"Người đặt vé: {txtHoTen.Text}. Thông tin vé: ");
                foreach (string s in item)
                {
                    lstThongTinVe.Items.Add($"Phim {cbPhim.SelectedItem} {cbPhongChieu.SelectedItem} Ghế {s}");
                    if (s == "A1" || s == "A5" || s == "B1" || s == "B5" || s == "C1" || s == "C5")
                    {
                        if (cbPhim.SelectedIndex == 0)
                        {
                            sumTienVe += 45000 / 4;
                        }
                        else if (cbPhim.SelectedIndex == 1)
                        {
                            sumTienVe += 100000 / 4;
                        }
                        else if (cbPhim.SelectedIndex == 2)
                        {
                            sumTienVe += 70000 / 4;
                        }
                        else if (cbPhim.SelectedIndex == 3)
                        {
                            sumTienVe += 90000 / 4;
                        }
                    }
                    else if (s == "A2" || s == "A3" || s == "A4" || s == "C2" || s == "C3" || s == "C4")
                    {
                        if (cbPhim.SelectedIndex == 0)
                        {
                            sumTienVe += 45000;
                        }
                        else if (cbPhim.SelectedIndex == 1)
                        {
                            sumTienVe += 100000;
                        }
                        else if (cbPhim.SelectedIndex == 2)
                        {
                            sumTienVe += 70000;
                        }
                        else if (cbPhim.SelectedIndex == 3)
                        {
                            sumTienVe += 90000;
                        }
                    }
                    else if (s == "B2" || s == "B3" || s == "B4")
                    {
                        if (cbPhim.SelectedIndex == 0)
                        {
                            sumTienVe += 45000 * 2;
                        }
                        else if (cbPhim.SelectedIndex == 1)
                        {
                            sumTienVe += 100000 * 2;
                        }
                        else if (cbPhim.SelectedIndex == 2)
                        {
                            sumTienVe += 70000 * 2;
                        }
                        else if (cbPhim.SelectedIndex == 3)
                        {
                            sumTienVe += 90000 * 2;
                        }
                    }
                }
                lstThongTinVe.Items.Add($"Tổng tiền vé là: {sumTienVe}");
                lstThongTinVe.Items.Add(".....");
            }
        }
    }
}
