using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MailKit;
using MailKit.Net.Imap;

namespace Lab5_6
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";
        public static string SetValueForText3 = "";
        public static string SetValueForText4 = "";

        public ImapClient Client = new ImapClient();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var client = new ImapClient();
            string server = txtIMAP.Text; //imap.gmail.com
            int port = Convert.ToInt32(txtImapPort.Text); //993
            string username = txtUser.Text;
            string password = txtPassword.Text; //sokm baew qgfh byfn
            try
            {
                client.Connect(server, port, true); // imap host, port, use ssl.
                client.Authenticate(username, password); // gmail accout, app password.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            Client = client;
            var inbox = client.Inbox;
            inbox.Open(FolderAccess.ReadOnly);
            int limit = inbox.Count > 20 ? 20 : inbox.Count;
            for (int i = 0; i < limit; i++)
            {
                var message = inbox.GetMessage(i);
                // xử lý để hiển thị email lên listview: message.Subject; message.From;message.Date
                WebBrowser webBrowser = new WebBrowser();
                webBrowser.DocumentText = message.TextBody;
                string[] row = { i.ToString(), message.Subject, message.From.ToString(), message.Date.ToString(), };
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);

            };
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            SetValueForText1 = txtSmtp.Text;
            SetValueForText2 = txtSmtpPort.Text;
            SetValueForText3 = txtUser.Text;
            SetValueForText4 = txtPassword.Text;

            SendMail sendMail = new SendMail();
            sendMail.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var client = new ImapClient();
            string server = txtIMAP.Text; //imap.gmail.com
            int port = Convert.ToInt32(txtImapPort.Text); //993
            try
            {
                client.Disconnect(true);
                MessageBox.Show("Logout success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo hitInfo = listView1.HitTest(e.Location);
            if (hitInfo.SubItem != null)
            {
                // Lấy giá trị của subitem
                var inbox = Client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);
                string subItemValue = hitInfo.SubItem.Text;
                var message = inbox.GetMessage(int.Parse(subItemValue));
                var html = message.HtmlBody;

                var subject = message.Subject;
                var from = message.From.ToString();
                var yourEmail = txtUser.Text;
                formEmail form2 = new formEmail(from,yourEmail,subject,html);
                form2.ShowDialog();

            }
        }

    }
}
