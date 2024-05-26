using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Leaf.xNet;

namespace lab5_5
{
    public partial class Create : Form
    {
        class TaoMonAn
        {
            public string ten_mon_an { get; set; }
            public int gia { get; set; }
            public string mo_ta { get; set; }
            public string hinh_anh { get; set; }
            public string dia_chi { get; set; }
            public TaoMonAn(string tenmonan, int Gia, string mota, string hinhanh, string diachi)
            {
                ten_mon_an = tenmonan;
                gia = Gia;
                mo_ta = mota;
                hinh_anh = hinhanh;
                dia_chi = diachi;
            }
        }
        string auth_token;
        public Create(string accesstoken)
        {
            InitializeComponent();
            auth_token = accesstoken;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTenMonAn.Clear();
            txtDiaChi.Clear();
            txtGia.Clear();
            txtHinhAnh.Clear();
            rtbMoTa.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtDiaChi.Text == "" || txtGia.Text == "" || txtHinhAnh.Text == ""
                || txtTenMonAn.Text == "")
            {
                MessageBox.Show("Không thể để trống các ô có dấu sao",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            HttpRequest http = new HttpRequest();
            var html = "";
            http.AddHeader("Authorization", "Bearer " + auth_token);
            TaoMonAn taoMonAn = new TaoMonAn(txtTenMonAn.Text, int.Parse(txtGia.Text), rtbMoTa.Text, txtHinhAnh.Text, txtDiaChi.Text);
            var options = new JsonSerializerOptions();
            options.WriteIndented = true;
            var data = JsonSerializer.Serialize<TaoMonAn>(taoMonAn, options);
            try
            {
                html = http.Post("https://nt106.uitiot.vn/api/v1/monan/add", data, "application/x-www-form-urlencoded").ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Thêm món thất bại!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Đã thêm món thành công");
        }

        private void KeyEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd.PerformClick();
                e.Handled = true; // Ngăn chặn việc xử lý phím Enter tiếp theo
            }
        }
    }
}
