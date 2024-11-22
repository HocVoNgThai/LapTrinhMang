﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using xNet;
using System.Net;
using System.Runtime.Intrinsics.X86;

namespace Lab4_7
{
    public partial class ListDishes : Form
    {
        string accesstoken;
        string name;
        JObject data;
        string totalCongDong;
        string totalCaNhan;
        class ListMonAn
        {
            public int current { get; set; }
            public int pageSize { get; set; }
            public ListMonAn(int Current, int pagesize)
            {
                current = Current;
                pageSize = pagesize;
            }
        }
        class MonAn
        {
            //public int id { get; set; }

            // public string mo_ta { get; set; }
            public Image hinh_anh { get; set; }
            public string ten_mon_an { get; set; }
            public int gia { get; set; }
            public string dia_chi { get; set; }
            public string nguoi_dong_gop { get; set; }
            public MonAn(Image hinhAnh, string monAn, int Gia, string diaChi, string dongGop)
            {

                hinh_anh = hinhAnh;
                ten_mon_an = monAn;
                gia = Gia;
                dia_chi = diaChi;
                nguoi_dong_gop = dongGop;
            }
        }
        public ListDishes(string html)
        {
            InitializeComponent();
            data = JObject.Parse(html);
            accesstoken = (string)data["access_token"];
            var user = data["user"];
            name = (string)user["first_name"];
            lbAuth.Text = $"Welcome, {name}";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Create create = new Create(accesstoken);
            create.ShowDialog();
            GetMonAn();
        }
        public void GetMonAn()
        {
            HttpRequest http1 = new HttpRequest();
            HttpRequest http2 = new HttpRequest();
            var html1 = "";
            var html2 = "";
            http1.AddHeader("Authorization", "Bearer " + accesstoken);
            http2.AddHeader("Authorization", "Bearer " + accesstoken);
            ListMonAn listMonAn = new ListMonAn(int.Parse(lbCurrentPage.Text), 5);
            var data = JsonSerializer.Serialize<ListMonAn>(listMonAn);
            var options = new JsonSerializerOptions();
            options.WriteIndented = true;
            try
            {
                html1 = http1.Post("https://nt106.uitiot.vn/api/v1/monan/all", data, "application/x-www-form-urlencoded").ToString();
                html2 = http2.Post("https://nt106.uitiot.vn/api/v1/monan/my-dishes", data, "application/x-www-form-urlencoded").ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
                return;
            }
            JObject lstDishesAll = new JObject();
            lstDishesAll = JObject.Parse(html1);
            var users = lstDishesAll["data"].ToArray();
            JObject lstDishesMy = new JObject();
            lstDishesMy = JObject.Parse(html2);
            var users2 = lstDishesMy["data"].ToArray();
            var totalAll = (string)lstDishesAll["pagination"]["total"];
            var totalMy = (string)lstDishesMy["pagination"]["total"];
            totalCongDong = totalAll;
            totalCaNhan = totalMy;
            lbTotalAll.Text = $"Tổng số món chung: {totalAll}";
            lbTotalMy.Text = $"Tổng số món riêng: {totalMy}";

            /*List<MonAn> monAns = new List<MonAn>();
            foreach (var user in users)
            {
                var hinhMonAn = (string)user["hinh_anh"];
                Image hinhAnh = Image.FromStream(new MemoryStream(new WebClient().DownloadData(hinhMonAn)));
                var monAn = (string)user["ten_mon_an"];
                var Gia = (int)user["gia"];
                var diaChi = (string)user["dia_chi"];
                var dongGop = (string)user["nguoi_dong_gop"];
                MonAn dish = new MonAn(hinhAnh, monAn, Gia, diaChi, dongGop);
                monAns.Add(dish);
            }*/
            if (users.Length > 0)
            {
                pbAll1.ImageLocation = (string)users[0]["hinh_anh"];
                lbAll_Mon_1.Text = (string)users[0]["ten_mon_an"];
                lbAll_Gia_1.Text = (string)users[0]["gia"];
                lbAll_DiaChi_1.Text = (string)users[0]["dia_chi"];
                lbAll_DongGop_1.Text = (string)users[0]["nguoi_dong_gop"];
                All_Gia_1.Text = "Giá:";
                All_DongGop_1.Text = "Người đóng góp:";
                All_DiaChi_1.Text = "Địa chỉ:";

            }
            if (users2.Length > 0)
            {
                pbMy1.ImageLocation = (string)users2[0]["hinh_anh"];
                lbMy_Mon_1.Text = (string)users2[0]["ten_mon_an"];
                lbMy_Gia_1.Text = (string)users2[0]["gia"];
                lbMy_DiaChi_1.Text = (string)users2[0]["dia_chi"];
                lbMy_DongGop_1.Text = (string)users2[0]["nguoi_dong_gop"];
                My_Gia_1.Text = "Giá:";
                My_DongGop_1.Text = "Người đóng góp:";
                My_DiaChi_1.Text = "Địa chỉ:";

            }
            if (users.Length > 1)
            {
                pbAll2.ImageLocation = (string)users[1]["hinh_anh"];
                lbAll_Mon_2.Text = (string)users[1]["ten_mon_an"];
                lbAll_Gia_2.Text = (string)users[1]["gia"];
                lbAll_DiaChi_2.Text = (string)users[1]["dia_chi"];
                lbAll_DongGop_2.Text = (string)users[1]["nguoi_dong_gop"];
                All_Gia_2.Text = "Giá:";
                All_DongGop_2.Text = "Người đóng góp:";
                All_DiaChi_2.Text = "Địa chỉ:";
            }
            if (users2.Length > 1)
            {
                pbMy2.ImageLocation = (string)users2[1]["hinh_anh"];
                lbMy_Mon_2.Text = (string)users2[1]["ten_mon_an"];
                lbMy_Gia_2.Text = (string)users2[1]["gia"];
                lbMy_DiaChi_2.Text = (string)users2[1]["dia_chi"];
                lbMy_DongGop_2.Text = (string)users2[1]["nguoi_dong_gop"];
                My_Gia_2.Text = "Giá:";
                My_DongGop_2.Text = "Người đóng góp:";
                My_DiaChi_2.Text = "Địa chỉ:";
            }
            if (users.Length > 2)
            {
                pbAll3.ImageLocation = (string)users[2]["hinh_anh"];
                lbAll_Mon_3.Text = (string)users[2]["ten_mon_an"];
                lbAll_Gia_3.Text = (string)users[2]["gia"];
                lbAll_DiaChi_3.Text = (string)users[2]["dia_chi"];
                lbAll_DongGop_3.Text = (string)users[2]["nguoi_dong_gop"];
                All_Gia_3.Text = "Giá:";
                All_DongGop_3.Text = "Người đóng góp:";
                All_DiaChi_3.Text = "Địa chỉ:";
            }
            if (users2.Length > 2)
            {
                pbMy3.ImageLocation = (string)users2[2]["hinh_anh"];
                lbMy_Mon_3.Text = (string)users2[2]["ten_mon_an"];
                lbMy_Gia_3.Text = (string)users2[2]["gia"];
                lbMy_DiaChi_3.Text = (string)users2[2]["dia_chi"];
                lbMy_DongGop_3.Text = (string)users2[2]["nguoi_dong_gop"];
                My_Gia_3.Text = "Giá:";
                My_DongGop_3.Text = "Người đóng góp:";
                My_DiaChi_3.Text = "Địa chỉ:";
            }
            if (users.Length > 3)
            {
                pbAll4.ImageLocation = (string)users[3]["hinh_anh"];
                lbAll_Mon_4.Text = (string)users[3]["ten_mon_an"];
                lbAll_Gia_4.Text = (string)users[3]["gia"];
                lbAll_DiaChi_4.Text = (string)users[3]["dia_chi"];
                lbAll_DongGop_4.Text = (string)users[3]["nguoi_dong_gop"];
                All_Gia_4.Text = "Giá:";
                All_DongGop_4.Text = "Người đóng góp:";
                All_DiaChi_4.Text = "Địa chỉ:";
            }
            if (users2.Length > 3)
            {
                pbMy4.ImageLocation = (string)users2[3]["hinh_anh"];
                lbMy_Mon_4.Text = (string)users2[3]["ten_mon_an"];
                lbMy_Gia_4.Text = (string)users2[3]["gia"];
                lbMy_DiaChi_4.Text = (string)users2[3]["dia_chi"];
                lbMy_DongGop_4.Text = (string)users2[3]["nguoi_dong_gop"];
                My_Gia_4.Text = "Giá:";
                My_DongGop_4.Text = "Người đóng góp:";
                My_DiaChi_4.Text = "Địa chỉ:";
            }
            if (users.Length > 4)
            {
                pbAll5.ImageLocation = (string)users[4]["hinh_anh"];
                lbAll_Mon_5.Text = (string)users[4]["ten_mon_an"];
                lbAll_Gia_5.Text = (string)users[4]["gia"];
                lbAll_DiaChi_5.Text = (string)users[4]["dia_chi"];
                lbAll_DongGop_5.Text = (string)users[4]["nguoi_dong_gop"];
                All_Gia_5.Text = "Giá:";
                All_DongGop_5.Text = "Người đóng góp:";
                All_DiaChi_5.Text = "Địa chỉ:";
            }
            if (users2.Length > 4)
            {
                pbMy5.ImageLocation = (string)users2[4]["hinh_anh"];
                lbMy_Mon_5.Text = (string)users2[4]["ten_mon_an"];
                lbMy_Gia_5.Text = (string)users2[4]["gia"];
                lbMy_DiaChi_5.Text = (string)users2[4]["dia_chi"];
                lbMy_DongGop_5.Text = (string)users2[4]["nguoi_dong_gop"];
                My_Gia_5.Text = "Giá:";
                My_DongGop_5.Text = "Người đóng góp:";
                My_DiaChi_5.Text = "Địa chỉ:";
            }
        }
        private void ListDishes_Load(object sender, EventArgs e)
        {
            GetMonAn();
        }

        private void lbLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (int.Parse(lbCurrentPage.Text) == 1)
            {
                MessageBox.Show("Đã là trang đầu tiên",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int current = int.Parse(lbCurrentPage.Text) - 1;
            lbCurrentPage.Text = current.ToString();
            GetMonAn();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (int.Parse(totalCongDong) % 5 == 0)
            {
                if (int.Parse(lbCurrentPage.Text) == (int.Parse(totalCongDong) / 5))
                {
                    MessageBox.Show("Đã là trang cuối cùng",
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else if (int.Parse(totalCongDong) % 5 != 0)
            {
                if (int.Parse(lbCurrentPage.Text) == (int.Parse(totalCongDong) / 5 + 1))
                {
                    MessageBox.Show("Đã là trang cuối cùng",
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            int current = int.Parse(lbCurrentPage.Text) + 1;
            lbCurrentPage.Text = current.ToString();
            GetMonAn();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (int.Parse(totalCongDong) % 5 == 0)
            {
                if (int.Parse(txtGoPage.Text) > (int.Parse(totalCongDong) / 5))
                {
                    MessageBox.Show("Trang không tồn tại",
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else if (int.Parse(totalCongDong) % 5 != 0)
            {
                if (int.Parse(txtGoPage.Text) > (int.Parse(totalCongDong) / 5 + 1))
                {
                    MessageBox.Show("Trang không tồn tại",
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if (int.Parse(txtGoPage.Text) < 1)
            {
                MessageBox.Show("Trang không tồn tại",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int current = int.Parse(txtGoPage.Text);
            lbCurrentPage.Text = current.ToString();
            txtGoPage.Clear();
            GetMonAn();
        }
        private void btnRandom_Click(object sender, EventArgs e)
        {
            OptionRandom optionRandom = new OptionRandom(accesstoken, totalCongDong, totalCaNhan);
            optionRandom.ShowDialog();
        }
    }
}
