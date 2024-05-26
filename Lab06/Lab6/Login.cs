using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Leaf.xNet;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace lab5_5
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lbSignUp_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            this.Hide();
            signup.ShowDialog();
            this.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            HttpRequest http = new HttpRequest();
            var html = "";
            //http.AddHeader("Authorization", "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1c2VybmFtZSI6InRobmEiLCJleHAiOjE3MTYxNzY3ODN9.QQjeoP7RxXgBuF_MKz0nq0yfV92L3b9DhmGbigYJfzA");

            string userName = txtUsername.Text;
            string password = txtPassword.Text;

            //  string data = "grant_type=password&username=hieutt&password=123456&scope=&client_id=&client_secret=";
            string data = "grant_type=password&username=" + userName + "&password=" + password + "&scope=&client_id=&client_secret=";
            try
            {
                html = http.Post("https://nt106.uitiot.vn/auth/token", data, "application/x-www-form-urlencoded").ToString();
            }
            catch
            {
                MessageBox.Show("Đăng nhập không thành công", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtUsername.Clear();
            txtPassword.Clear();
            this.Hide();
            ListDishes listDishes = new ListDishes(html);
            listDishes.ShowDialog();
            this.Show();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
                btnLogin.PerformClick();

        }
    }
}
