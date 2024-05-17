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
using MimeKit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace btvn_bai2
{
    public partial class SendMail : Form
    {
        string receivedAccount, receivedPassword;
        public SendMail(string account, string password)
        {
            InitializeComponent();
            receivedPassword = password;
            receivedAccount = account;
            txtFrom.Text = receivedAccount;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtDest.Text == "" || txtSubject.Text == "" || rtbBody.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            var client = new SmtpClient();
            try
            {
                client.Connect("smtp.gmail.com", 465, true); // smtp host, port, use ssl.
                client.Authenticate(receivedAccount, receivedPassword); // gmail account, app password
            }
            catch
            {
                MessageBox.Show("Gửi không thành công");
                return;
            }
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("", receivedAccount));
            message.To.Add(new MailboxAddress("", txtDest.Text));
            message.Subject = txtSubject.Text;
            message.Body = new TextPart("plain")
            {
                Text = rtbBody.Text
            };
            client.Send(message);
            MessageBox.Show("Gửi email thành công");
        }
    }
}
