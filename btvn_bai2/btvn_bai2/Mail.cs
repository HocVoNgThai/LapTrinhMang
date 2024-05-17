using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Pop3;
using MailKit.Net.Smtp;

namespace btvn_bai2
{
    public partial class Mail : Form
    {
        private string receivedPassword;
        public Mail(Pop3Client client, string account, string password)
        {
            InitializeComponent();
            txtAccount.Text = account;
            var limit = client.GetMessageCount();
            for (int i = limit - 1; i >= 0; i--)
            {
                var message = client.GetMessage(i);
                // xử lý để hiển thị email lên listview: message.Subject; message.From; 
                ListViewItem item = new ListViewItem((limit - i).ToString());
                item.SubItems.Add(message.Subject);
                item.SubItems.Add(message.From.ToString());
                item.SubItems.Add(message.Date.ToString());
                lstMail.Items.Add(item);
                receivedPassword = password;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                SendMail sendMail = new SendMail(txtAccount.Text, receivedPassword);
                sendMail.ShowDialog();
            }
            catch 
            {
                MessageBox.Show("Lỗi kết nối!");
                return;
            }
        }
    }
}
