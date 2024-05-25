using lab5_5;
using MailKit.Net.Pop3;
using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Show_Invitation : Form
    {
        private List<int> Index_Emails;
        private Pop3Client client;
        public Show_Invitation(Pop3Client client, List<int> Index_Emails)
        {
            InitializeComponent();
            this.client = client;
            this.Index_Emails = Index_Emails;
            Initialize();
            Label_Invitations.Text = $"Bạn có {Index_Emails.Count.ToString()} lời mời đi ăn.";
            this.Text = $"Bạn có {Index_Emails.Count.ToString()} lời mời đi ăn.";
        }
        private void Initialize()
        {
            try
            {
                for (int i = 0; i < Index_Emails.Count; i++)
                {
                    var message = client.GetMessage(Index_Emails[i]);

                    var data = message.HtmlBody;
                    var doc = new HtmlAgilityPack.HtmlDocument();
                    doc.LoadHtml(data);
                    Label Label_Email = new Label();
                    Label_Email.AutoSize = true;
                    Label_Email.Location = new Point(450, 23);
                    Label_Email.Size = new Size(300, 21);
                    Label_Email.TabIndex = 4;
                    Label_Email.Text = message.From.ToString();
                    Label_Email.TextAlign = ContentAlignment.TopRight;
                    // 
                    // Label_Addr
                    // 
                    Label Label_Addr = new Label();
                    Label_Addr.AutoSize = true;
                    Label_Addr.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
                    Label_Addr.Location = new Point(173, 110);
                    Label_Addr.Size = new Size(63, 21);
                    Label_Addr.TabIndex = 3;
                    Label_Addr.Text = "Địa chỉ:    " + doc.GetElementbyId("diaChi").InnerText;
                    // 
                    // Label_Price
                    // 
                    Label Label_Price = new Label();
                    Label_Price.AutoSize = true;
                    Label_Price.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
                    Label_Price.Location = new Point(174, 67);
                    Label_Price.Size = new Size(36, 21);
                    Label_Price.TabIndex = 2;
                    Label_Price.Text = "Giá:    " + doc.GetElementbyId("Gia").InnerText;
                    // 
                    // Label_Name_MonAn
                    // 
                    Label Label_Name_MonAn = new Label();
                    Label_Name_MonAn.AutoSize = true;
                    Label_Name_MonAn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
                    Label_Name_MonAn.ForeColor = Color.IndianRed;
                    Label_Name_MonAn.Location = new Point(165, 23);
                    Label_Name_MonAn.Size = new Size(84, 30);
                    Label_Name_MonAn.TabIndex = 1;
                    Label_Name_MonAn.Text = doc.GetElementbyId("monAn").InnerText;
                    // 
                    // panel_img
                    // 
                    PictureBox panel_img = new PictureBox();
                    panel_img.Location = new Point(0, 0);
                    panel_img.Size = new Size(150, 150);
                    panel_img.TabIndex = 0;
                    panel_img.SizeMode = PictureBoxSizeMode.StretchImage;
                    panel_img.ImageLocation = doc.GetElementbyId("hinhAnh").Attributes["src"].Value;

                    Panel Panel_Carousel = new Panel();
                    Panel_Carousel.Controls.Add(Label_Email);
                    Panel_Carousel.Controls.Add(Label_Addr);
                    Panel_Carousel.Controls.Add(Label_Price);
                    Panel_Carousel.Controls.Add(Label_Name_MonAn);
                    Panel_Carousel.Controls.Add(panel_img);
                    Panel_Carousel.Location = new Point(18, 15 + 150 * i);
                    Panel_Carousel.Size = new Size(908, 150);
                    Panel_Carousel.TabIndex = 0;
                    Panel_Carousel.BorderStyle = BorderStyle.FixedSingle;
                    Panel_Carousel.Click += (sender, e) =>
                    {
                        ReplyMail form = new ReplyMail(Label_Name_MonAn.Text, Label_Price.Text, Label_Addr.Text, panel_img.ImageLocation, message.From.ToString());
                        form.ShowDialog();
                    };

                    Panel_Layout.Controls.Add(Panel_Carousel);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi. Hãy kiểm tra kết nối mạng!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}


