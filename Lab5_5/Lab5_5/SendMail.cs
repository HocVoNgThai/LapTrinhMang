using MimeKit;
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
using MailKit.Net.Smtp;

namespace lab5_5
{
    public partial class SendMail : Form
    {
        string hinhAnh;
        string monAn;
        string Gia;
        string diaChi;
        public SendMail(string hinhanh, string monan, string gia, string diachi)
        {
            InitializeComponent();
            hinhAnh = hinhanh;
            monAn = monan;
            Gia = gia;
            diaChi = diachi;
        }
        //List<string> mails = new List<string>();      
        string smtp;
        int port;
        string email;
        string ssl;
        string password;
        string nickname;
        private void SendMail_Load(object sender, EventArgs e)
        {
            var setting = File.ReadAllText("setting_mail.txt");
            JObject data = new JObject();
            data = JObject.Parse(setting);
            smtp = (string)data["smtp"];
            port = (int)data["port"];
            email = (string)data["email"];
            password = (string)data["password"];
            ssl = (string)data["ssl"];
            nickname = (string)data["nickname"];
            var client = new SmtpClient();
            try
            {
                if (ssl == "True")
                {
                    client.Connect(smtp, port, true);
                }// smtp host, port, use ssl.
                else if (ssl == "False")
                {
                    client.Connect(smtp, port, false);
                }
                client.Authenticate(email, password); // gmail account, app password
                MessageBox.Show("Kết nối thành công");
                lbCheckConnect.Text = "Email Server Connected";
                lbCheckConnect.ForeColor = Color.ForestGreen;
            }
            catch
            {
                MessageBox.Show("Kết nối không thành công, vui lòng kiểm tra lại cài đặt", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbCheckConnect.Text = "Email Server Disconnected";
                lbCheckConnect.ForeColor = Color.Firebrick;
                return;
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            for (int i = lstEmail.SelectedItems.Count - 1; i >= 0; i--)
            {
                lstEmail.Items.Remove(lstEmail.SelectedItems[i]);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập email muốn thêm", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }    
            lstEmail.Items.Add(txtEmail.Text);
            txtEmail.Clear();
        }
        private void btnConfig_Click(object sender, EventArgs e)
        {
            SettingMail settingMail = new SettingMail();
            settingMail.ShowDialog();
            this.SendMail_Load(sender, e);
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (lstEmail.Items.Count < 1)
            {
                MessageBox.Show("Vui lòng thêm email bạn muốn gửi thư đến", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var client = new SmtpClient();
            try
            {
                if (ssl == "True")
                {
                    client.Connect(smtp, port, true);
                }// smtp host, port, use ssl.
                else if (ssl == "False")
                {
                    client.Connect(smtp, port, false);
                }
                client.Authenticate(email, password); // gmail account, app password 
            }
            catch
            {
                MessageBox.Show("Kết nối không thành công, vui lòng kiểm tra lại cài đặt", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(nickname, email));
            message.Subject = "Bạn có một lời mời đi ăn";
            message.Body = new TextPart("html")
            {
                Text = $"<div><p style = \"font-family:'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;font-size:40px;text-align: center\" ><b> {monAn}</b></p><p style = \"font-family:'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;font-size:30px;text-align: center\" >{Gia}<br>{diaChi}</p></div><p style= \"text-align: center; \"><img src = \"{hinhAnh}\"  style = \"border-radius: 10%\" width = \"500\" height = \"360\"></p>"
            };
            foreach (var item in lstEmail.Items)
            {
                message.To.Add(new MailboxAddress("", item.ToString()));
            }
            client.Send(message);
            MessageBox.Show("Gửi email thành công");
        }

        
    }
}
