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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace btvn_bai2
{
    public partial class Mail : Form
    {
        private string receivedPassword;
        private Pop3Client Client;
        public Mail(Pop3Client client, string account, string password)
        {
            InitializeComponent();
            Client = client;
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
        private void listView_MouseClick(object sender, MouseEventArgs e)
        {
            // Lấy thông tin về mục được nhấp chuột
            ListViewHitTestInfo hitInfo = lstMail.HitTest(e.Location);

            // Kiểm tra xem có nhấp chuột vào subitem hay không
            if (hitInfo.SubItem != null)
            {
                // Lấy giá trị của subitem
                string subItemValue = hitInfo.SubItem.Text;
                var limit = Client.GetMessageCount();
                var message = Client.GetMessage(limit - int.Parse(subItemValue));
                string emailHtml = message.HtmlBody ?? message.TextBody ?? "No content";
                Form2 form2 = new Form2(emailHtml);
                form2.ShowDialog();
               
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
