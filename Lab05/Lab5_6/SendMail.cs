using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab5_6
{
    public partial class SendMail : Form
    {
        public SendMail()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string SMTPHost = Main.SetValueForText1;
            int SMTPPort = Convert.ToInt32(Main.SetValueForText2);
            string username = Main.SetValueForText3;
            string password = Main.SetValueForText4;
            var client = new SmtpClient();
            string name = txtName.Text;
            label1.Text = username;
            string to = txtTo.Text;
            string subject = txtSubject.Text;
            string body = richTextBox1.Text;
            client.Connect(SMTPHost, SMTPPort, true);
            client.Authenticate(username, password);
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(name, username));
            message.To.Add(new MailboxAddress("", to));
            message.Subject = subject;

            if (checkBox1.Checked)
            {
                message.Body = new TextPart("html")
                {
                    Text = body
                };
            }
            else
            {
                message.Body = new TextPart("plain") // gửi ở dạng plain text, hoặc có thể thay bằng “html” nếu muốn gửi email dạng html
                {
                    Text = body
                };
            }
            var builder = new BodyBuilder();
            builder.TextBody = body;
            //builder.Attachments.Add(txtAttachment.Text);
            if (txtAttachment.Text != "")
            {
                builder.Attachments.Add(txtAttachment.Text);
            }
            message.Body = builder.ToMessageBody();
            try
            {
                client.Send(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("Email sent!");


        }
    }
}
