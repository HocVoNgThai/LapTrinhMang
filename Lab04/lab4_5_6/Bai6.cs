using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xNet;
using Newtonsoft.Json.Linq;

namespace Lab4
{
    public partial class Bai6 : Form
    {
        public Bai6()
        {
            InitializeComponent();
        }

        private string getHTML(string szUrl)
        {
            // Create a request for the URL.
            WebRequest request = WebRequest.Create(szUrl);
            // Get the response.
            WebResponse response = request.GetResponse();
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            // Close the response.
            response.Close();
            return responseFromServer;
        }

        string PostData(HttpRequest http, string url, string data = null, string contentType = null, string userArgent = "", string cookie = null)
        {
            if (http == null)
            {
                http = new HttpRequest();
                http.Cookies = new CookieDictionary();
            }

            if (!string.IsNullOrEmpty(userArgent))
            {
                http.UserAgent = userArgent;
            }

            string html = http.Post(url, data, contentType).ToString();
            return html;
        }

        string GetData(HttpRequest http, string url, string userArgent = "", string cookie = null)
        {
            if (http == null)
            {
                http = new HttpRequest();
                http.Cookies = new CookieDictionary();
            }

            if (!string.IsNullOrEmpty(userArgent))
            {
                http.UserAgent = userArgent;
            }

            string html = http.Get(url).ToString();
            return html;
        }

        public static string GetAccessToken(string jsonString)
        {
            JObject data = JObject.Parse(jsonString);
            string accessToken = (string)data["access_token"];
            return accessToken;
        }

        //Login button
        private void button1_Click(object sender, EventArgs e)
        {
            HttpRequest http = new HttpRequest();
            http.Cookies = new CookieDictionary();
            string userArgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/69.0.3497.100 Safari/537.36";

            var html = "";
            try
            {

                string userName = txtUser.Text;
                string password = txtPassword.Text;
                //  string data = "grant_type=password&username=hieutt&password=123456&scope=&client_id=&client_secret=";
                string data = "grant_type=password&username=" + userName + "&password=" + password + "&scope=&client_id=&client_secret=";
                html = PostData(http, txtURL.Text, data, "application/x-www-form-urlencoded").ToString();

            }
            catch (Exception ex)
            {
                richTextBox1.Text = "Dang nhap that bai";
                return;
            }
            string res = GetAccessToken(html);
            richTextBox1.Text = "bearer: " + res + "\nDang nhap thanh cong";
        }

        //Get user info button
        private void button2_Click(object sender, EventArgs e)
        {
            HttpRequest http = new HttpRequest();
            http.Cookies = new CookieDictionary();
            string userArgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/69.0.3497.100 Safari/537.36";

            var html = "";
            try
            {
                string token = txtToken.Text;
                http.AddHeader("Authorization", "Bearer " + token);

                // string token = GetLoginDataToken(html);

                string data = "grant_type=password&username=hieutt&password=123456&scope=&client_id=&client_secret=";
                html = GetData(http, txtURL.Text, data, "application/x-www-form-urlencoded").ToString();
                //var res = http.Response.ToString();
            }
            catch (Exception ex)
            {
                richTextBox2.Text = "Lay thong tin that bai";
                return;
            }

            //File.WriteAllText("res.html", html);
            richTextBox2.Text = html;
        }
    }
}
