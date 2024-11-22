using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Policy;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.Sockets;
using HtmlAgilityPack;
using System.CodeDom;
using System.Collections;

namespace Lab4
{
    public partial class Bai04 : Form
    {
        HtmlAgilityPack.HtmlDocument document;
        List<Film> films;
        WebClient myClient;
        public Bai04()
        {
            InitializeComponent();
            this.Resize += new System.EventHandler(this.Form_Resize);


            timer1.Start();
            InitBrowser("https://betacinemas.vn/phim.htm");
            Load_Film_List();
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            Panel_WebView.Size = this.ClientSize - new System.Drawing.Size(Panel_WebView.Location);
            webView.Size = Panel_WebView.Size - new System.Drawing.Size(webView.Location);
        }

        private void Load_Film_List()
        {
            myClient = new WebClient();
            myClient.Encoding = System.Text.Encoding.UTF8;
            Uri uri = new Uri("https://betacinemas.vn/phim.htm");
            Stream replied = myClient.OpenRead(uri);


            string html = myClient.DownloadString(uri);
            document = new HtmlAgilityPack.HtmlDocument();
            document.LoadHtml(html);


            replied.Close();
            myClient.Dispose();


            films = new List<Film>();
            if (document == null) return;
            var film_List = document.DocumentNode.SelectNodes("//*[@id=\"tab-1\"]/div/div/div/div/div/div/img");
            film_List.ToList().ForEach(film =>
            {
                films.Add(new Film { Link_Img = film.Attributes["src"].Value });
            });

            film_List = document.DocumentNode.SelectNodes("//*[@id=\"tab-1\"]/div/div/div/div[2]/div/h3/a");
            var temp_list = film_List.ToList();
            for (int i = 0; i < temp_list.Count; i++)
            {
                films[i].Link_Uri = "https://betacinemas.vn"+temp_list[i].Attributes["href"].Value;
                films[i].Film_Name = temp_list[i].InnerText;
            }

            List<Panel> panels = new List<Panel>();

            for (int i = 0; i < films.Count; i++)
            {
                Label Label_Film_Name = new Label();
                Label_Film_Name.AutoSize = true;
                Label_Film_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                Label_Film_Name.ForeColor = System.Drawing.Color.IndianRed;
                Label_Film_Name.Location = new System.Drawing.Point(133, 15);
                Label_Film_Name.Name = "Label_Film_Name";
                Label_Film_Name.Size = new System.Drawing.Size(86, 30);
                Label_Film_Name.Text = films[i].Film_Name;
                Label_Film_Name.Click += (sender, e) =>
                {
                    Label label=sender as Label;
                    int j = 0;
                    for(; j<films.Count; j++)
                    {
                        if (label.Text.Equals(films[j].Film_Name)) break;
                    }
                    InitBrowser(films[j].Link_Uri);
                };

                Label Label_Link = new Label();
                Label_Link.AutoSize = true;
                Label_Link.Location = new System.Drawing.Point(134, 57);
                Label_Link.Name = "Label_Link";
                Label_Link.Size = new System.Drawing.Size(39, 21);
                Label_Link.Text = films[i].Link_Uri;
                Label_Link.Click += (sender, e) =>
                {
                    Label label = sender as Label;
                    int j = 0;
                    for (; j < films.Count; j++)
                    {
                        if (label.Text.Equals(films[j].Link_Uri)) break;
                    }
                    InitBrowser(films[j].Link_Uri);
                };

                Panel Panel_Image = new Panel();
                Panel_Image.BackgroundImage = DownloadImage(films[i].Link_Img);
                Panel_Image.BackgroundImageLayout = ImageLayout.Stretch;
                Panel_Image.Location = new System.Drawing.Point(3, 3);
                Panel_Image.Name = "Panel_Image";
                Panel_Image.Size = new System.Drawing.Size(131, 162);
                Panel_Image.Click += (sender, e) =>
                {
                    Panel panel = sender as Panel;
                    Control parentPanel = panel.Parent;
                    int j = 0;
                    foreach (Panel temp in panels)
                        if(temp==parentPanel) j=panels.IndexOf(temp);
                    InitBrowser(films[j].Link_Uri);
                };

                Panel Panel_Wrap = new Panel();
                Panel_Wrap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                Panel_Wrap.Controls.Add(Panel_Image);
                Panel_Wrap.Controls.Add(Label_Link);
                Panel_Wrap.Controls.Add(Label_Film_Name);
                Panel_Wrap.Cursor = System.Windows.Forms.Cursors.Hand;
                Panel_Wrap.Location = new System.Drawing.Point(6, 2 + i * 172);
                Panel_Wrap.Name = "Panel_Wrap";
                Panel_Wrap.Size = new System.Drawing.Size(388, 170);
                panels.Add(Panel_Wrap);
                Panel_Wrap.Click += (sender, e) =>
                {
                    Panel panel = sender as Panel;
                    int j = panels.IndexOf(panel);
                    InitBrowser(films[j].Link_Uri);
                };

                Panel_List.Controls.Add(Panel_Wrap);
            }
            //*[@id="tab-1"]/div/div[1]/div
            //*[@id="tab-1"]/div/div[1]/div/div[1]/div/div[1]/img
            PrgBar.Value = 100;
            Label_Prg.Text = PrgBar.Value.ToString()+"%";
            return;
        }

        private System.Drawing.Image DownloadImage(string uri)
        {
            using (WebClient client = new WebClient())
            {
                try
                {
                    // Tải ảnh từ URI
                    byte[] imageData = client.DownloadData(uri);

                    // Chuyển đổi mảng byte thành hình ảnh
                    using (var stream = new System.IO.MemoryStream(imageData))
                    {
                        System.Drawing.Image image = System.Drawing.Image.FromStream(stream);

                        // Đặt hình ảnh làm nền cho panel
                        return image;
                    }
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }

        private async Task Initizated()
        {
            await webView.EnsureCoreWebView2Async(null);
        }

        public async void InitBrowser(string Link_Uri)
        {

            await Initizated();
            webView.CoreWebView2.Navigate(Link_Uri);
        }
        
        public class Film
        {
            public string Link_Img { get; set; }
            public string Link_Uri { get; set; }
            public string Film_Name { get; set; }
        }

        private void Bai04_FormClosing(object sender, FormClosingEventArgs e)
        {
            webView.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(PrgBar.Value > 98)
            {
                timer1.Stop();
                return;
            }
            PrgBar.Value += 1;
            Label_Prg.Text = PrgBar.Value.ToString()+"%";
        }

        private void Btn_Home_Click(object sender, EventArgs e)
        {
            InitBrowser("https://betacinemas.vn/phim.htm");
        }
    }
}

//*[@id="showtimes"]/div/div[4]/div/div/div[1]/a/img
//*[@id="showtimes"]/div/div[4]