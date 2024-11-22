using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Collections.Generic;
using MailKit.Net.Imap;
using MimeKit;
using MailKit;

namespace Lab5_2and3
{
    public partial class ReceiveMail : Form
    {
        public ReceiveMail()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtAccount.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var client = new ImapClient();
            client.Connect("imap.gmail.com", 993, true); // imap host, port, use ssl.
            try
            {
                client.Authenticate(txtAccount.Text, txtPassword.Text);
            }// gmail accout, app password.
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối đến server","Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var inbox = client.Inbox;
            inbox.Open(FolderAccess.ReadOnly);
            var limit = inbox.Count;
            lbTotal.Text = limit.ToString();
            for (int i = 0; i < limit; i++)
            {
                var message = inbox.GetMessage(i);
                // xử lý để hiển thị email lên listview: message.Subject; message.From; 
                ListViewItem item = new ListViewItem((i + 1).ToString());
                item.SubItems.Add(message.Subject);
                item.SubItems.Add(message.From.ToString());
                item.SubItems.Add(message.Date.ToString());
                lstEmail.Items.Add(item);
            }
        }
    }
}