using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Imap;
using MailKit;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using MailKit.Security;
using MimeKit;
using MailKit.Search;
using System.Net;
using MailKit.Net.Smtp;

namespace Lab5
{
    public partial class Bai04_Rapchieuphim : Form
    {
        private List<System.Windows.Forms.Button> list_seats;
        List<Movie> list_movies;
        List<Ticket> list_tickets = new List<Ticket>();
        List<Film> films = new List<Film>();
        private int Chosen_Seat = 0;

        public Bai04_Rapchieuphim(List<Film> films, int index_movie)
        {

            InitializeComponent();
            this.list_seats = new List<System.Windows.Forms.Button>();
            for (int i = 0; i < 15; i++)
            {

                System.Windows.Forms.Button temp = new System.Windows.Forms.Button();
                temp.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                temp.Location = new System.Drawing.Point(20 + (i % 5) * 100, 70 + (i / 5) * 50);
                temp.Name = "Seat" + i.ToString();
                temp.Size = new System.Drawing.Size(40, 30);
                temp.TabIndex = 5;
                temp.Text = ((i / 5 == 0) ? "A" : ((i / 5 == 1) ? "B" : "C")) + (i % 5 + 1).ToString();
                temp.UseVisualStyleBackColor = true;
                temp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.list_seats_click);
                list_seats.Add(temp);
                GrBx_Ticket.Controls.Add(temp);
            }

            //Load data
            list_movies = new List<Movie>();

            using (FileStream fs = new FileStream(".\\Source\\input04.txt", FileMode.OpenOrCreate))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    string JsonContent = sr.ReadToEnd();
                    list_movies = JsonConvert.DeserializeObject<List<Movie>>(JsonContent);
                }
            }


            CBx_Movie.DataSource = list_movies;
            CBx_Movie.DisplayMember = "Name_Movie";

            CBx_Theater.DataSource = list_movies[0].Theater_Index;
            CBx_Theater.DisplayMember = "";

            //Set Selected Index Cbx_Movie
            this.films = films;
            CBx_Movie.SelectedIndex = index_movie;

            //Initialize
            for (int i = 0; i < 15; i++)
            {
                this.list_seats[i].TabStop = true;
                this.list_seats[i].Enabled = true;
                this.list_seats[i].BackColor = System.Drawing.SystemColors.Control;
                this.list_seats[i].ForeColor = System.Drawing.SystemColors.ControlText;
                if (list_movies[CBx_Movie.SelectedIndex].Theater_Seat[CBx_Theater.SelectedIndex][i] == 1)
                {
                    this.list_seats[i].BackColor = System.Drawing.Color.Yellow;
                    this.list_seats[i].ForeColor = System.Drawing.Color.White;
                    this.list_seats[i].TabStop = false;
                    this.list_seats[i].Enabled = false;
                }
            }
            

        }

        private void list_seats_click(object sender, System.EventArgs e)
        {
            Button this_button = sender as Button;

            if (this_button.BackColor == System.Drawing.SystemColors.Control)
            {
                this_button.BackColor = System.Drawing.Color.Firebrick;
                this_button.ForeColor = System.Drawing.Color.White;

            }
            else
            {
                this_button.BackColor = System.Drawing.SystemColors.Control;
                this_button.ForeColor = System.Drawing.SystemColors.ControlText;
            }
        }

        private void CBx_Movie_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBx_Theater.DataSource = list_movies[CBx_Movie.SelectedIndex].Theater_Index;
            CBx_Theater.DisplayMember = "";
            for (int i = 0; i < 15; i++)
            {
                this.list_seats[i].TabStop = true;
                this.list_seats[i].Enabled = true;
                this.list_seats[i].BackColor = System.Drawing.SystemColors.Control;
                this.list_seats[i].ForeColor = System.Drawing.SystemColors.ControlText;
                if (list_movies[CBx_Movie.SelectedIndex].Theater_Seat[CBx_Theater.SelectedIndex][i] == 1)
                {
                    this.list_seats[i].BackColor = System.Drawing.Color.Yellow;
                    this.list_seats[i].ForeColor = System.Drawing.Color.White;
                    this.list_seats[i].TabStop = false;
                    this.list_seats[i].Enabled = false;
                }
            }

        }

        private void CBx_Theater_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 15; i++)
            {
                this.list_seats[i].TabStop = true;
                this.list_seats[i].Enabled = true;
                this.list_seats[i].BackColor = System.Drawing.SystemColors.Control;
                this.list_seats[i].ForeColor = System.Drawing.SystemColors.ControlText;
                if (list_movies[CBx_Movie.SelectedIndex].Theater_Seat[CBx_Theater.SelectedIndex][i] == 1)
                {
                    this.list_seats[i].BackColor = System.Drawing.Color.Yellow;
                    this.list_seats[i].ForeColor = System.Drawing.Color.White;
                    this.list_seats[i].TabStop = false;
                    this.list_seats[i].Enabled = false;
                }
            }
        }

        private void Btn_Buy_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TBx_Customer.Text)) { MessageBox.Show("Chưa nhập tên khách hàng!"); return; }
            for (int i = 0; i < 15; i++)
            {
                if (list_seats[i].BackColor == Color.Firebrick && list_movies[CBx_Movie.SelectedIndex].Theater_Seat[CBx_Theater.SelectedIndex][i] == 0)
                {

                    this.list_seats[i].TabStop = false;
                    this.list_seats[i].Enabled = false;
                    Chosen_Seat += 1;
                }

            }

            if (Chosen_Seat == 0) { MessageBox.Show("Chưa chọn vé!"); return; }

            Ticket ticket = new Ticket() { Bill = 0, };
            ticket.Customer_Name = TBx_Customer.Text;
            ticket.Name_Movie = list_movies[CBx_Movie.SelectedIndex].Name_Movie;
            ticket.Theater = list_movies[CBx_Movie.SelectedIndex].Theater_Index[CBx_Theater.SelectedIndex];


            // 
            for (int i = 0; i < 15; i++)
            {
                if (list_seats[i].BackColor == Color.Firebrick
                    && list_movies[CBx_Movie.SelectedIndex].Theater_Seat[CBx_Theater.SelectedIndex][i] == 0)
                {
                    list_movies[CBx_Movie.SelectedIndex].Theater_Seat[CBx_Theater.SelectedIndex][i] = 1;
                    ticket.Chosen_Ticket.Add(((i / 5 == 0) ? "A" : ((i / 5 == 1) ? "B" : "C")) + (i % 5 + 1).ToString());
                    if (i % 5 == 0 || i % 5 == 4) ticket.Bill += list_movies[CBx_Movie.SelectedIndex].Price_Movie * 1 / 4;
                    else if (i / 5 == 0 || i / 5 == 2) ticket.Bill += list_movies[CBx_Movie.SelectedIndex].Price_Movie;
                    else ticket.Bill += list_movies[CBx_Movie.SelectedIndex].Price_Movie * 2;
                    this.list_seats[i].BackColor = System.Drawing.Color.Yellow;
                    this.list_seats[i].ForeColor = System.Drawing.Color.White;
                }
            }

            list_tickets.Add(ticket);

            ListViewItem item = new ListViewItem((list_tickets.Count).ToString());
            item.SubItems.Add(list_tickets[list_tickets.Count - 1].Customer_Name);
            item.SubItems.Add(string.Join(", ", list_tickets[list_tickets.Count - 1].Chosen_Ticket));
            item.SubItems.Add(list_tickets[list_tickets.Count - 1].Name_Movie);


            item.SubItems.Add(list_tickets[list_tickets.Count - 1].Theater.ToString());
            item.SubItems.Add(list_tickets[list_tickets.Count - 1].Bill.ToString());

            ListView_Bought_Ticket.Items.Add(item);


            Chosen_Seat = 0;
            using (StreamWriter sw = new StreamWriter(".\\Source\\input04.txt"))
            {
                JsonSerializer js = new JsonSerializer();
                js.Serialize(sw, list_movies);
            }

            Send_Email_To_Client();
            return;
        }

        private void Send_Email_To_Client()
        {
            foreach(char c in Tbx_Customer_Email.Text)
            {
                if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || c == '.' || c == '@') continue;
                else return;
            }
            string smtpClient = "smtp.gmail.com";
            string username = "vonhathoangg@gmail.com";
            string password = "dfag tukb koqu bwby";
            int smtpPort = 465;

            string uri_img = films[CBx_Movie.SelectedIndex].Link_Img;
            string Bought_Seat = string.Join(", ", list_tickets[list_tickets.Count - 1].Chosen_Ticket);
            string Movie_Name = list_tickets[list_tickets.Count - 1].Name_Movie;

            //message
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("", username));
            message.To.Add(new MailboxAddress("", Tbx_Customer_Email.Text));
            message.Subject = "[BETA CINEMAS] - Trạng thái đặt vé";
            var bodyBuilder = new BodyBuilder();
            
            bodyBuilder.HtmlBody = $@"
<body style=""width: 100vw; height: 800px; justify-content: center; align-items:center;display:flex;"">

        <div class=""Panel"" style=""width: 50%;
        height: 100%;
        margin: auto;
        overflow: hidden;
        justify-content: center;
        align-items: center;
        "">
            <div class=""Image"" style="" height: 100%;
            object-fit:cover;
            object-position: center;
            height: 80%;
            width: 100%;
            overflow: hidden;"">
                <img src=""{uri_img}"">
            </div>
            <div class=""Title"" style="" font-size: 20px;
            font-weight: bold;
            margin-top: 10px;
            margin-left: 5px;
            "">
                <div class=""Title_Thanks"">Cảm ơn quý khách đã đặt vé tại BetaCinemas</div>
                <div class=""Title_Name"">Phim: {Movie_Name}</div>
                <div class=""Title_Seat"" style=""font-size: 15px;"">Ghế đã chọn: {Bought_Seat}</div>
            </div>
        </div>
    </body>
            ";

            
            message.Body = bodyBuilder.ToMessageBody();

            // Kết nối và gửi email qua IMAP
            try
            {
                var client = new SmtpClient();
                client.Connect(smtpClient, smtpPort, true);
                client.Authenticate(username, password);


                // Gửi email
                client.Send(message);
                client.Disconnect(true);
                MessageBox.Show("Gửi thành công!");
            }
            catch
            {
                MessageBox.Show("Kết nối không thành công");
            }
        }

        private void TBx_Customer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                MessageBox.Show("Không nhập số hoặc kí tự lạ!");
            }
        }

        private void Btn_Export_Click(object sender, EventArgs e)
        {
            List<Movie> export_list = list_movies;
            for (int i = 0; i < export_list.Count; i++)
            {
                for (int j = 0; j < export_list[i].Theater_Index.Length; j++)
                {
                    for (int a = 0; a < 15; a++)
                    {
                        if (export_list[i].Theater_Seat[j][a] == 1)
                        {
                            export_list[i].Sell_Ticket += 1;
                        }
                        else
                            export_list[i].Stock_Ticket += 1;
                        if (a % 5 == 0 || a % 5 == 4) export_list[i].Revenue += list_movies[CBx_Movie.SelectedIndex].Price_Movie * 1 / 4;
                        else if (a / 5 == 0 || a / 5 == 2) export_list[i].Revenue += list_movies[CBx_Movie.SelectedIndex].Price_Movie;
                        else export_list[i].Revenue += list_movies[CBx_Movie.SelectedIndex].Price_Movie * 2;
                    }
                }
                export_list[i].Ticket_Selling_Rate = (float)export_list[i].Sell_Ticket / (float)(export_list[i].Theater_Index.Length * 15);
            }

            using (StreamWriter sw = new StreamWriter(".\\Source\\output04.txt"))
            {
                JsonSerializer js = new JsonSerializer();
                js.Serialize(sw, export_list);
            }
        }

    }

    public class Movie
    {
        public string Name_Movie { get; set; }
        public int[] Theater_Index;
        public float Price_Movie { get; set; }
        public Dictionary<int, int[]> Theater_Seat = new Dictionary<int, int[]>();

        public int Sell_Ticket, Stock_Ticket;
        public float Ticket_Selling_Rate;
        public float Revenue;
    }

    public class Ticket
    {
        public string Customer_Name { get; set; }
        public List<string> Chosen_Ticket = new List<string>();
        public string Name_Movie { get; set; }
        public int Theater { get; set; }
        public float Bill { get; set; }
    }
}
