using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Leaf.xNet;

namespace lab5_5
{
    public partial class RandomDishCaNhan : Form
    {
        public RandomDishCaNhan(string accesstoken, List<string> idMonAn)
        {
            InitializeComponent();
            HttpRequest http = new HttpRequest();
            var html = "";
            int id = 0;
            Random random = new Random();
            int r = random.Next(idMonAn.Count);
            id = int.Parse(idMonAn[r]);
            http.AddHeader("Authorization", "Bearer " + accesstoken);
            try
            {
                html = http.Get($"https://nt106.uitiot.vn/api/v1/monan/{id}").ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
                return;
            }
            JObject monAn = new JObject();
            monAn = JObject.Parse(html);
            pbHinhAnh.ImageLocation = (string)monAn["hinh_anh"];
            lbMonAn.Text = (string)monAn["ten_mon_an"];
            lbGia.Text = (string)monAn["gia"];
            lbDiaChi.Text = (string)monAn["dia_chi"];
            lbDongGop.Text = (string)monAn["nguoi_dong_gop"];
        }
    }
}
