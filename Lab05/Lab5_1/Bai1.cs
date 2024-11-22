using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
// using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using MailKit.Net.Smtp;
using MimeKit;

namespace Lab5
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            var client = new SmtpClient();
            string SMTPHost = "smtp.gmail.com";
            int SMTPPort = 465;
            string username = "22520444@gm.uit.edu.vn";
            string password = "sokm baew qgfh byfn";
            string name = "";
            string from = txtFrom.Text;
            string to = txtTo.Text;
            string subject = txtSubject.Text;
            string body = richTextBox1.Text;

            client.Connect(SMTPHost, SMTPPort, true); // smtp host, port, use ssl.
            client.Authenticate(username, password); // gmail account, app password
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(name, from));
            message.To.Add(new MailboxAddress("", to));
            message.Subject = subject;
            message.Body = new TextPart("plain") // gửi ở dạng plain text, hoặc có thể thay bằng “html” nếu muốn gửi email dạng html
            {
                Text = body
            };
            client.Send(message);
        }
    }
}
