using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Pop3;
using MailKit.Net.Smtp;

namespace lab5_5
{
    public partial class SettingMail : Form
    {
        class EmailConfig
        {
            public string smtp { get; set; }
            public string port { get; set; }
            public string nickname { get; set; }
            public string email { get; set; }
            public string password { get; set; }
            public string ssl { get; set; }
            public string pop { get; set; }
            public string popport { get; set; }
            public string popssl { get; set; }
            public int loadmail { get; set; }
            public EmailConfig(string Smtp, string Port, string Nickname, string Email, string Password, string Ssl, string pop, string popport, string popssl, int loadmail)
            {
                smtp = Smtp;
                port = Port;
                nickname = Nickname;
                email = Email;
                password = Password;
                ssl = Ssl;
                this.pop = pop;
                this.popport = popport;
                this.popssl = popssl;
                this.loadmail = loadmail;
            }
        }
        public SettingMail()
        {
            InitializeComponent();
            if (File.Exists("setting_mail.txt"))
            {
                EmailConfig emailConfig;
                var drl = File.ReadAllText("setting_mail.txt");
                emailConfig = JsonSerializer.Deserialize<EmailConfig>(drl);
                txtSmtp.Text = emailConfig.smtp;
                txtPort.Text = emailConfig.port;
                txtNickname.Text = emailConfig.nickname;
                txtEmail.Text = emailConfig.email;
                txtPassword.Text = emailConfig.password;
                txtPop.Text = emailConfig.pop;
                txtPopPort.Text = emailConfig.popport;
                string popSSL = emailConfig.popssl;
                string SSL = emailConfig.ssl;
                txtDay.Text = emailConfig.loadmail.ToString();
                if (SSL == "True")
                {
                    cbSSL.Checked = true;
                }
                if (popSSL == "True")
                {
                    cbPopSSL.Checked = true;
                }
            }
        }

        private void btnTestConnect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSmtp.Text) || string.IsNullOrEmpty(txtPort.Text) || string.IsNullOrEmpty(txtNickname.Text)
                || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtPassword.Text)
                || string.IsNullOrEmpty(txtPop.Text) || string.IsNullOrEmpty(txtPopPort.Text) || string.IsNullOrEmpty(txtDay.Text))
            {
                MessageBox.Show("Không thể để trống các mục có dấu sao",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtPort.Text, out int port) || !int.TryParse(txtPopPort.Text, out int popport) ||
                !int.TryParse(txtDay.Text, out int popday))
            {
                MessageBox.Show("Các ô port và day chỉ có thể điền số",
                   "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var client = new SmtpClient();
            var client1 = new Pop3Client();
            try
            {
                if (cbSSL.Checked)
                {
                    client.Connect(txtSmtp.Text, int.Parse(txtPort.Text), true);
                }// smtp host, port, use ssl.
                else
                {
                    client.Connect(txtSmtp.Text, int.Parse(txtPort.Text), false);
                }
                if (cbPopSSL.Checked)
                {
                    client1.Connect(txtPop.Text, int.Parse(txtPopPort.Text), true);
                }// smtp host, port, use ssl.
                else
                {
                    client1.Connect(txtPop.Text, int.Parse(txtPopPort.Text), false);
                }
                client.Authenticate(txtEmail.Text, txtPassword.Text); // gmail account, app password
                client1.Authenticate(txtEmail.Text, txtPassword.Text);
                MessageBox.Show("Kiểm tra kết nối thành công");
            }
            catch
            {
                MessageBox.Show("Kiểm tra kết nối không thành công", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void btnSaveAndExit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSmtp.Text) || string.IsNullOrEmpty(txtPort.Text) || string.IsNullOrEmpty(txtNickname.Text)
                || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtPassword.Text)
                || string.IsNullOrEmpty(txtPop.Text) || string.IsNullOrEmpty(txtPopPort.Text) || string.IsNullOrEmpty(txtDay.Text))
            {
                MessageBox.Show("Không thể để trống các mục có dấu sao",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtPort.Text, out int port) || !int.TryParse(txtPopPort.Text, out int popport) ||
                !int.TryParse(txtDay.Text, out int popday))
            {
                MessageBox.Show("Các ô port và day chỉ có thể điền số",
                   "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string SSL = "";
            string popSSL = "";
            if (cbSSL.Checked)
            {
                SSL = "True";
            }
            else SSL = "False";
            if (cbPopSSL.Checked)
            {
                popSSL = "True";
            }
            else popSSL = "False";
            EmailConfig emailConfig = new EmailConfig(txtSmtp.Text, txtPort.Text, txtNickname.Text, txtEmail.Text, txtPassword.Text, SSL, txtPop.Text, txtPopPort.Text, popSSL, int.Parse(txtDay.Text));
            var options = new JsonSerializerOptions();
            options.WriteIndented = true;
            var srl = JsonSerializer.Serialize<EmailConfig>(emailConfig, options);
            File.WriteAllText("setting_mail.txt", srl);
            this.Close();
        }
        private void CloseForm(object sender, FormClosingEventArgs e)
        {
            if (!File.Exists("setting_mail.txt"))
            {
                if (MessageBox.Show("Chưa lưu lại thông tin! Bạn có chắc là tắt form này?",
                   "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void KeyEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSaveAndExit.PerformClick();
                e.Handled = true;
            }
        }
    }
}