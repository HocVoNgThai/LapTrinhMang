using Newtonsoft.Json.Linq;
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

namespace Lab4_7
{
    public partial class OptionRandom : Form
    {
        string accesstoken;
        string totalAll;
        string totalMy;
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
        public OptionRandom(string token, string totalCongDong, string totalCaNhan)
        {
            InitializeComponent();
            accesstoken = token;
            totalAll = totalCongDong;
            totalMy = totalCaNhan;
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            HttpRequest http = new HttpRequest();
            var html = "";
            http.AddHeader("Authorization", "Bearer " + accesstoken);
            ListMonAn listMonAn = new ListMonAn(1, int.Parse(totalAll));
            var data = JsonSerializer.Serialize<ListMonAn>(listMonAn);
            var options = new JsonSerializerOptions();
            options.WriteIndented = true;
            try
            {
                html = http.Post("https://nt106.uitiot.vn/api/v1/monan/all", data, "application/x-www-form-urlencoded").ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
                return;
            }
            JObject lstDishesAll = new JObject();
            lstDishesAll = JObject.Parse(html);
            var users = lstDishesAll["data"].ToArray();
            List<string> idMonAn = new List<string>();
            foreach (var user in users)
            {
                var id = (string)user["id"];
                idMonAn.Add(id);
            }
            RandomDish randomDishCongDong = new RandomDish(accesstoken, idMonAn);
            randomDishCongDong.ShowDialog();
            this.Show();
        }

        private void btnMy_Click(object sender, EventArgs e)
        {
            HttpRequest http = new HttpRequest();
            var html = "";
            http.AddHeader("Authorization", "Bearer " + accesstoken);
            ListMonAn listMonAn = new ListMonAn(1, int.Parse(totalMy));
            var data = JsonSerializer.Serialize<ListMonAn>(listMonAn);
            var options = new JsonSerializerOptions();
            options.WriteIndented = true;
            try
            {
                html = http.Post("https://nt106.uitiot.vn/api/v1/monan/my-dishes", data, "application/x-www-form-urlencoded").ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
                return;
            }
            JObject lstDishesMy = new JObject();
            lstDishesMy = JObject.Parse(html);
            var users = lstDishesMy["data"].ToArray();
            List<string> idMonAn = new List<string>();
            foreach (var user in users)
            {
                var id = (string)user["id"];
                idMonAn.Add(id);
            }
            if (idMonAn.Count < 1)
            {
                MessageBox.Show("Bạn chưa thêm món ăn nào vào danh sách!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            RandomDish randomDishCaNhan = new RandomDish(accesstoken, idMonAn);
            randomDishCaNhan.ShowDialog();
            this.Show();
        }
    }
}
