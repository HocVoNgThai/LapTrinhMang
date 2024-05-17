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

namespace btvn_bai2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtAccount.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Không được để trống tài khoản và mật khẩu");
                return;
            }
            var client = new Pop3Client();
            try
            {
                client.Connect("pop.gmail.com", 995, true); // imap host, port, use ssl.
                client.Authenticate(txtAccount.Text, txtPass.Text); // gmail accout, app password.
                Mail mail = new Mail(client, txtAccount.Text, txtPass.Text);
                this.Hide();
                mail.ShowDialog();

            }
            catch
            {
                MessageBox.Show("Đăng nhập thất bại");
                return;
            }
        }
    }
}
