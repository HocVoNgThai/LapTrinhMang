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
using Leaf.xNet;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Runtime.Intrinsics.X86;
using MailKit.Net.Pop3;
using MailKit;
using MimeKit.Tnef;
using Lab6;
using System.Runtime.CompilerServices;

namespace lab5_5
{
    public partial class ListDishes : Form
    {
        string accesstoken;
        string name;
        JObject data;
        string totalCongDong;
        string totalCaNhan;
        Pop3Client Client = new Pop3Client();

        private List<int> index_Emails = new List<int>();
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

            //Load tất cả Dish từ Cộng đồng.
            JObject lstDishesAll = JObject.Parse(html1);
            var users = lstDishesAll["data"].ToArray();

            //Load tất cả Dish từ Cá nhân.
            JObject lstDishesMy = JObject.Parse(html2);
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

            //Clear Panel Controls
            panelShowAll.Controls.Clear();
            pnShowMy.Controls.Clear();

            //Load list đã lưu trong user.
            if (users.Length > 0)
                for (int i = 0; i < users.Length; i++)
                {
                    Label lbAll_Mon, lbAll_DongGop, lbAll_DiaChi, lbAll_Gia, All_DongGop, All_DiaChi, All_Gia;
                    PictureBox pbAll = new PictureBox();

                    // lbAll_Mon
                    lbAll_Mon = new Label();
                    lbAll_Mon.AutoSize = true;
                    lbAll_Mon.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
                    lbAll_Mon.ForeColor = Color.Brown;
                    lbAll_Mon.Location = new Point(230, 21);
                    lbAll_Mon.Name = "lbAll_Mon_4";
                    lbAll_Mon.Size = new Size(0, 22);
                    lbAll_Mon.TabIndex = 14;
                    // 
                    // 
                    lbAll_DongGop = new Label();
                    lbAll_DongGop.AutoSize = true;
                    lbAll_DongGop.Location = new Point(769, 134);
                    lbAll_DongGop.Name = "lbAll_DongGop_4";
                    lbAll_DongGop.Size = new Size(0, 16);
                    lbAll_DongGop.TabIndex = 13;
                    // 
                    // 
                    All_DongGop = new Label();
                    All_DongGop.AutoSize = true;
                    All_DongGop.Location = new Point(612, 134);
                    All_DongGop.Name = "All_DongGop_4";
                    All_DongGop.Size = new Size(0, 16);
                    All_DongGop.TabIndex = 12;
                    // 
                    // 
                    lbAll_Gia = new Label();
                    lbAll_Gia.AutoSize = true;
                    lbAll_Gia.Location = new Point(374, 87);
                    lbAll_Gia.Name = "lbAll_Gia_4";
                    lbAll_Gia.Size = new Size(0, 16);
                    lbAll_Gia.TabIndex = 11;
                    // 
                    // 
                    lbAll_DiaChi = new Label();
                    lbAll_DiaChi.AutoSize = true;
                    lbAll_DiaChi.Location = new Point(374, 134);
                    lbAll_DiaChi.Name = "lbAll_DiaChi_4";
                    lbAll_DiaChi.Size = new Size(0, 16);
                    lbAll_DiaChi.TabIndex = 10;
                    // 
                    // 
                    All_DiaChi = new Label();
                    All_DiaChi.AutoSize = true;
                    All_DiaChi.Location = new Point(230, 134);
                    All_DiaChi.Name = "All_DiaChi_4";
                    All_DiaChi.Size = new Size(0, 16);
                    All_DiaChi.TabIndex = 9;
                    // 
                    // 
                    All_Gia = new Label();
                    All_Gia.AutoSize = true;
                    All_Gia.Location = new Point(230, 87);
                    All_Gia.Name = "All_Gia_4";
                    All_Gia.Size = new Size(0, 16);
                    All_Gia.TabIndex = 8;
                    // 
                    // 
                    pbAll.ImageLocation = "";
                    pbAll.Location = new Point(3, 3);
                    pbAll.Name = "pbAll4";
                    pbAll.Size = new Size(186, 174);
                    pbAll.SizeMode = PictureBoxSizeMode.StretchImage;
                    pbAll.TabIndex = 1;
                    pbAll.TabStop = false;

                    pbAll.ImageLocation = (string)users[i]["hinh_anh"];
                    lbAll_Mon.Text = (string)users[i]["ten_mon_an"];
                    lbAll_Gia.Text = (string)users[i]["gia"];
                    lbAll_DiaChi.Text = (string)users[i]["dia_chi"];
                    lbAll_DongGop.Text = (string)users[i]["nguoi_dong_gop"];
                    All_Gia.Text = "Giá:";
                    All_DongGop.Text = "Người đóng góp:";
                    All_DiaChi.Text = "Địa chỉ:";

                    Panel Panel_Wrap = new Panel();
                    Panel_Wrap.Controls.Add(lbAll_Mon);
                    Panel_Wrap.Controls.Add(lbAll_DongGop);
                    Panel_Wrap.Controls.Add(All_DongGop);
                    Panel_Wrap.Controls.Add(lbAll_Gia);
                    Panel_Wrap.Controls.Add(lbAll_DiaChi);
                    Panel_Wrap.Controls.Add(All_DiaChi);
                    Panel_Wrap.Controls.Add(All_Gia);
                    Panel_Wrap.Controls.Add(pbAll);
                    Panel_Wrap.Location = new Point(6, 6 + 180 * i);
                    Panel_Wrap.Name = "panel5";
                    Panel_Wrap.Size = new Size(950, 180);
                    Panel_Wrap.TabIndex = i + 10;

                    panelShowAll.Controls.Add(Panel_Wrap);
                }



            // Add vào tbpMy (user2)
            //

            if (users2.Length > 0)
                for (int i = 0; i < users2.Length; i++)
                {
                    Label lbAll_Mon, lbAll_DongGop, lbAll_DiaChi, lbAll_Gia, All_DongGop, All_DiaChi, All_Gia;
                    PictureBox pbAll = new PictureBox();

                    // lbAll_Mon
                    lbAll_Mon = new Label();
                    lbAll_Mon.AutoSize = true;
                    lbAll_Mon.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
                    lbAll_Mon.ForeColor = Color.Brown;
                    lbAll_Mon.Location = new Point(230, 21);
                    lbAll_Mon.Name = "lbAll_Mon_4";
                    lbAll_Mon.Size = new Size(0, 22);
                    lbAll_Mon.TabIndex = 14;
                    // 
                    // lbAll_DongGop_4
                    // 
                    lbAll_DongGop = new Label();
                    lbAll_DongGop.AutoSize = true;
                    lbAll_DongGop.Location = new Point(769, 134);
                    lbAll_DongGop.Name = "lbAll_DongGop_4";
                    lbAll_DongGop.Size = new Size(0, 16);
                    lbAll_DongGop.TabIndex = 13;
                    // 
                    // All_DongGop_4
                    // 
                    All_DongGop = new Label();
                    All_DongGop.AutoSize = true;
                    All_DongGop.Location = new Point(612, 134);
                    All_DongGop.Name = "All_DongGop_4";
                    All_DongGop.Size = new Size(0, 16);
                    All_DongGop.TabIndex = 12;
                    // 
                    // lbAll_Gia_4
                    // 
                    lbAll_Gia = new Label();
                    lbAll_Gia.AutoSize = true;
                    lbAll_Gia.Location = new Point(374, 87);
                    lbAll_Gia.Name = "lbAll_Gia_4";
                    lbAll_Gia.Size = new Size(0, 16);
                    lbAll_Gia.TabIndex = 11;
                    // 
                    // lbAll_DiaChi_4
                    // 
                    lbAll_DiaChi = new Label();
                    lbAll_DiaChi.AutoSize = true;
                    lbAll_DiaChi.Location = new Point(374, 134);
                    lbAll_DiaChi.Name = "lbAll_DiaChi_4";
                    lbAll_DiaChi.Size = new Size(0, 16);
                    lbAll_DiaChi.TabIndex = 10;
                    // 
                    // All_DiaChi_4
                    // 
                    All_DiaChi = new Label();
                    All_DiaChi.AutoSize = true;
                    All_DiaChi.Location = new Point(230, 134);
                    All_DiaChi.Name = "All_DiaChi_4";
                    All_DiaChi.Size = new Size(0, 16);
                    All_DiaChi.TabIndex = 9;
                    // 
                    // All_Gia_4
                    // 
                    All_Gia = new Label();
                    All_Gia.AutoSize = true;
                    All_Gia.Location = new Point(230, 87);
                    All_Gia.Name = "All_Gia_4";
                    All_Gia.Size = new Size(0, 16);
                    All_Gia.TabIndex = 8;
                    // 
                    // pbAll4
                    // 
                    pbAll.ImageLocation = "";
                    pbAll.Location = new Point(3, 3);
                    pbAll.Name = "pbAll4";
                    pbAll.Size = new Size(186, 174);
                    pbAll.SizeMode = PictureBoxSizeMode.StretchImage;
                    pbAll.TabIndex = 1;
                    pbAll.TabStop = false;

                    pbAll.ImageLocation = (string)users2[i]["hinh_anh"];
                    lbAll_Mon.Text = (string)users2[i]["ten_mon_an"];
                    lbAll_Gia.Text = (string)users2[i]["gia"];
                    lbAll_DiaChi.Text = (string)users2[i]["dia_chi"];
                    lbAll_DongGop.Text = (string)users2[i]["nguoi_dong_gop"];
                    All_Gia.Text = "Giá:";
                    All_DongGop.Text = "Người đóng góp:";
                    All_DiaChi.Text = "Địa chỉ:";

                    Panel Panel_Wrap = new Panel();
                    Panel_Wrap.Controls.Add(lbAll_Mon);
                    Panel_Wrap.Controls.Add(lbAll_DongGop);
                    Panel_Wrap.Controls.Add(All_DongGop);
                    Panel_Wrap.Controls.Add(lbAll_Gia);
                    Panel_Wrap.Controls.Add(lbAll_DiaChi);
                    Panel_Wrap.Controls.Add(All_DiaChi);
                    Panel_Wrap.Controls.Add(All_Gia);
                    Panel_Wrap.Controls.Add(pbAll);
                    Panel_Wrap.Location = new Point(6, 6 * (i - 1) + 180 * i);
                    Panel_Wrap.Name = "panel5";
                    Panel_Wrap.Size = new Size(950, 180);
                    Panel_Wrap.TabIndex = i + 10;

                    pnShowMy.Controls.Add(Panel_Wrap);
                }


        }
        private void ListDishes_Load(object sender, EventArgs e)
        {
            GetMonAn();
            if (!File.Exists("setting_mail.txt"))
            {
                MessageBox.Show("Thông tin email server chưa được cài đặt để sử dụng tính năng gửi, nhận email",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                GetMail();
            }
        }
        public void GetMail()
        {
            var setting = File.ReadAllText("setting_mail.txt");
            JObject data = new JObject();
            data = JObject.Parse(setting);
            var pop = (string)data["pop"];
            var port = (int)data["popport"];
            var email = (string)data["email"];
            var password = (string)data["password"];
            var ssl = (string)data["popssl"];
            var nickname = (string)data["nickname"];
            var day = (int)data["loadmail"];
            var client = new Pop3Client();
            Client = client;
            try
            {
                if (ssl == "True")
                {
                    client.Connect(pop, port, true);
                }// smtp host, port, use ssl.
                else if (ssl == "False")
                {
                    client.Connect(pop, port, false);
                }
                client.Authenticate(email, password); // gmail account, app password      
            }
            catch
            {
                MessageBox.Show("Kết nối với máy chủ Mail không thành công! Vui lòng cấu hình lại!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                SettingMail settingMail = new SettingMail();
                settingMail.ShowDialog();
                return;
            }

            var limit = client.GetMessageCount();



            //Disable button while checking mail
            btnConfigMail.Enabled = false;
            lbMail.Enabled = false;
            btnRandom.Enabled = false;
            btnCreate.Enabled = false;

            //Tải các mail có subject là NT106 - Các email lời mời đi ăn
            Task.Run(() =>
            {
                int count = 0;
                var yesterday = DateTime.Now.Subtract(TimeSpan.FromDays(day));
                List<int> list = new List<int>();
                try
                {
                    for (int i = limit - 1; i >= 0; i--)
                    {
                        var message = client.GetMessage(i);
                        if (message.Date > yesterday)
                        {
                            // xử lý để hiển thị email lên listview: message.Subject; message.From; 
                            //if (message.Date.ToString("dd/MM/yyyy") != DateTime.Now.ToString("dd/MM/yyyy")) break;
                            if (message.Subject == "NT106")
                            {
                                count++;
                                list.Add(i);
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Lỗi. Vui lòng kiểm tra lại kết nối mạng", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //Invoke để enable các btn từ một thread khác.
                Invoke(() =>
                {
                    index_Emails = list;
                    btnConfigMail.Enabled = true;
                    lbMail.Enabled = true;
                    btnRandom.Enabled = true;
                    btnCreate.Enabled = true;
                    lbMail.Text = $"Bạn có {count} lời mời đi ăn";
                });
            });

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
            if (txtGoPage.Text == string.Empty)
            {
                MessageBox.Show("Nhập trang cần tới!");
                return;
            }
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

        private void btnConfigMail_Click(object sender, EventArgs e)
        {
            SettingMail settingMail = new SettingMail();
            settingMail.ShowDialog();
            if (File.Exists("setting_mail.txt"))
            {
                lbMail.Text = "Loading...";
                GetMail();
            }
        }
        private void lbMail_Click_1(object sender, EventArgs e)
        {
            Show_Invitation form = new Show_Invitation(Client, index_Emails);
            form.ShowDialog();
        }

        private void ListDishes_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultReturn = MessageBox.Show("Bạn có muốn quay lại form login không?", "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (resultReturn == DialogResult.No)
            {
                Environment.Exit(0);
            }
            if (resultReturn == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            if (resultReturn == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
        private void KeyEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnGo.PerformClick();
        }

        private void KeyLoading(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                btnNext.PerformClick();

            }
            else if (e.KeyCode == Keys.Left)
            {
                btnBack.PerformClick();
                e.Handled = true;
            }
        }

        private void KeyHandle(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                e.Handled = true;
            }
        }   
    }
}
