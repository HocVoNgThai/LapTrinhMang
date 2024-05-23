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
            public EmailConfig(string Smtp, string Port, string Nickname, string Email, string Password, string Ssl)
            {
                smtp = Smtp;
                port = Port;
                nickname = Nickname;
                email = Email;
                password = Password;
                ssl = Ssl;
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
                string SSL = emailConfig.ssl;
                if (SSL == "True")
                {
                    cbSSL.Checked = true;
                }    
            }
        }

        private void btnTestConnect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSmtp.Text) || string.IsNullOrEmpty(txtPort.Text) || string.IsNullOrEmpty(txtNickname.Text)
                || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Không thể để trống các mục có dấu sao",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var client = new SmtpClient();
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
                client.Authenticate(txtEmail.Text, txtPassword.Text); // gmail account, app password
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
                || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Không thể để trống các mục có dấu sao",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string SSL = "";
            if (cbSSL.Checked)
            {
                SSL = "True";
            }    
            else SSL = "False";
            EmailConfig emailConfig = new EmailConfig(txtSmtp.Text, txtPort.Text, txtNickname.Text, txtEmail.Text, txtPassword.Text, SSL);
            var options = new JsonSerializerOptions();
            options.WriteIndented = true;
            var srl = JsonSerializer.Serialize<EmailConfig>(emailConfig, options);
            File.WriteAllText("setting_mail.txt", srl);
            this.Close();
        }
    }
}
