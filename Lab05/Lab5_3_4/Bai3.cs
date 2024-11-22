using System;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using MailKit;
using MimeKit;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using MailKit.Net.Imap;
using MailKit.Net.Pop3;

namespace Lab5
{
    public partial class Bai3 : Form
    {
        private string true_password;
        public Bai3()
        {
            InitializeComponent();
        }


        private void Btn_Login_Click(object sender, EventArgs e)
        {
            Btn_Login.Enabled = false;
            var client = new Pop3Client();
            try
            {
                client.Connect("pop.gmail.com", 995, true); // imap host, port, use ssl.
                client.Authenticate(Tbx_Email.Text, Tbx_Password.Text); // gmail accout, app password.
            }
            catch
            {
                MessageBox.Show("Lỗi!");
                Btn_Login.Enabled=true;
                return;
            }

            int limit = client.GetMessageCount();
            Label_Total.Text="Total:        "+ limit.ToString();
            Label_Recent.Text="Recent:         "+5.ToString();
            for (int i = limit-1; i >= limit-5; i--)
            {
                var message = client.GetMessage(i);
                // xử lý để hiển thị email lên listview: message.Subject; message.From; message.Date
                ListViewItem item = new ListViewItem((limit-i).ToString());
                item.SubItems.Add(message.Subject);
                item.SubItems.Add(message.From.ToString());
                item.SubItems.Add(message.Date.ToString());
                Lsv_Mails.Items.Add(item);
            }
            Btn_Login.Enabled = true;
        }
    }
}