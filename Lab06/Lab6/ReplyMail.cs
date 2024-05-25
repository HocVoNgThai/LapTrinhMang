using MailKit.Net.Pop3;
using MimeKit;
using MailKit.Net.Smtp;
using Newtonsoft.Json.Linq;
using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Lab6
{
    public partial class ReplyMail : Form
    {
        private string Send;
        public ReplyMail(string MonAn, string Gia, string Addr, string link_img, string sender)
        {
            InitializeComponent();
            pbHinhAnh.ImageLocation = link_img;
            lbMonAn.Text = MonAn;
            lbGia.Text = Gia;
            lbDiaChi.Text = Addr;
            lbDongGop.Text = sender;
            this.Send = sender;
        }

        private void Btn_Send_Click(object sender, EventArgs e)
        {
            var setting = File.ReadAllText("setting_mail.txt");
            JObject data = new JObject();
            data = JObject.Parse(setting);
            var smtp = (string)data["smtp"];
            var port = (int)data["port"];
            var email = (string)data["email"];
            var password = (string)data["password"];
            var ssl = (string)data["ssl"];
            var nickname = (string)data["nickname"];
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
            message.Subject = "RE: NT106";
            message.Body = new TextPart("plain")
            {
                Text = richTextBox1.Text
            };
            string temp = Send.Split('<')[1];
            temp = temp.Substring(0, temp.Length - 1);
            message.To.Add(new MailboxAddress("", temp));
            try
            {
                client.Send(message);
            }
            catch
            {
                MessageBox.Show("Lỗi. Vui lòng kiểm tra lại kết nối mạng", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Gửi email thành công");
        }
    }
}
