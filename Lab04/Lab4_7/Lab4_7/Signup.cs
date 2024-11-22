using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using xNet;

namespace Lab4_7
{
    public partial class Signup : Form
    {
        class DangKy
        {
            public string username { get; set; }
            public string email { get; set; }
            public string password { get; set; }
            public string first_name { get; set; }
            public string last_name { get; set; }
            public int sex { get; set; }
            public string birthday { get; set; }
            public string language { get; set; }
            public string phone { get; set; }
            public DangKy(string Username, string Email, string Password, string First_name, string Last_name, int Sex, string Birthday,
                string Language, string Phone)
            {
                username = Username;
                email = Email;
                password = Password;
                first_name = First_name;
                last_name = Last_name;
                sex = Sex;
                birthday = Birthday;
                language = Language;
                phone = Phone;
            }
        }
        public Signup()
        {
            InitializeComponent();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtEmail.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhone.Clear();
            cbLanguage.SelectedIndex = -1;
            rdbtnMale.Checked = false;
            rdbtnFemale.Checked = false;
            dtpBirthday.ResetText();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "" || txtEmail.Text == "" || txtFirstName.Text == "")
            {
                MessageBox.Show("Không thể để trống các mục có dấu sao",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            HttpRequest http = new HttpRequest();
            var html = "";
            int sexual = 0;
            if (rdbtnFemale.Checked)
                sexual = 1;
            if (rdbtnMale.Checked)
                sexual = 0;
            string language = "";
            if (cbLanguage.SelectedIndex != -1) language = cbLanguage.SelectedItem.ToString();
            DangKy dangky = new DangKy(txtUsername.Text, txtEmail.Text, txtPassword.Text, txtFirstName.Text, txtLastName.Text, sexual, dtpBirthday.Text, language, txtPhone.Text);

            var options = new JsonSerializerOptions();
            options.WriteIndented = true;
            var data = JsonSerializer.Serialize<DangKy>(dangky, options);
            try
            {
                html = http.Post("https://nt106.uitiot.vn/api/v1/user/signup", data, "application/x-www-form-urlencoded").ToString();
            }
            catch (HttpException ex)
            {
                MessageBox.Show(ex.HttpStatusCode.ToString() + ". Có thể username hoặc email đã tồn tại", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Đã đăng ký tài khoản thành công");
        }
    }
}
