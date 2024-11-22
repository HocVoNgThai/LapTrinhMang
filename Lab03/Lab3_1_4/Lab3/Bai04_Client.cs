using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace W_Lab2
{
    public partial class Bai04_Client : Form
    {
        private string strData="",temp,  name;
        private List<System.Windows.Forms.Button> list_seats;
        List<Movie> list_movies;
        private List<Ticket> list_tickets = new List<Ticket>();
        private TcpClient tcpClient;
        private NetworkStream ns;
        private Thread t;

        int Chosen_Seat = 0;

        public Bai04_Client(string name)
        {

            this.name = name;
            InitializeComponent();

            tcpClient = new TcpClient();
            // 2 Kết nối đến Server với 1 địa chỉ Ip và Port xác định
            IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, 8080);
            tcpClient.Connect(ipEndPoint);

            // chekc tcpClient đã kết nối chưa
            if (!tcpClient.Connected)
            {
                MessageBox.Show("Kết nối không thành công! \n Vui lòng kiểm tra IP và Port");
                return;
            }
            // 3 Tạo luồng để đọc và ghi dữ liệu dựa trên NetworkStream
            ns = tcpClient.GetStream();

            MessageBox.Show("Đang nhận dữ liệu từ Server");
            Task.Run(() =>
            {
                while (true)
                {

                    byte[] file_Length_Bytes = new byte[4];
                    ns.Read(file_Length_Bytes, 0, file_Length_Bytes.Length);
                    int fileLength = BitConverter.ToInt32(file_Length_Bytes, 0);


                    byte[] buffer = new byte[fileLength];
                    int bytesRead = 0, totalBytesRead = 0; ;

                    if (fileLength > 0)
                    {
                        while ((bytesRead = ns.Read(buffer, totalBytesRead, fileLength - totalBytesRead)) > 0 && totalBytesRead != fileLength)
                        {
                            totalBytesRead += bytesRead;
                        }
                        strData = Encoding.UTF8.GetString(buffer);
                        list_movies = JsonConvert.DeserializeObject<List<Movie>>(strData);
                        
                        break;
                    }
                }
            }).Wait();
            MessageBox.Show("Nhận rồi! Đặt vé thôi nào :3");


            //Thread Listen from server
            //t = new Thread(new ThreadStart(Thread_ReadData));
            //t.IsBackground = true;
            //t.Start();

            
            // Tạo list ghế ngồi
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


            /*
            list_movies = new List<Movie>()
             {
                 new Movie(){Name_Movie="Đào, phở và piano", Price_Movie=45000, Theater_Index=new int[]{1,2,3}, },
                 new Movie(){Name_Movie="Mai", Price_Movie=100000, Theater_Index=new int[]{2,3}, },
                 new Movie(){Name_Movie="Gặp lại chị bầu", Price_Movie=70000, Theater_Index=new int[]{1}, },
                 new Movie(){Name_Movie="Tarot", Price_Movie=90000, Theater_Index=new int[]{3},}
             };
            list_movies[0].Theater_Seat.Add(0, Enumerable.Repeat(0, 15).ToArray());
            list_movies[0].Theater_Seat.Add(1, Enumerable.Repeat(0, 15).ToArray());
            list_movies[0].Theater_Seat.Add(2, Enumerable.Repeat(0, 15).ToArray());
            list_movies[1].Theater_Seat.Add(0, Enumerable.Repeat(0, 15).ToArray());
            list_movies[1].Theater_Seat.Add(1, Enumerable.Repeat(0, 15).ToArray());
            list_movies[2].Theater_Seat.Add(0, Enumerable.Repeat(0, 15).ToArray());
            list_movies[3].Theater_Seat.Add(0, Enumerable.Repeat(0, 15).ToArray());



            //  /Initiate Data
            using (StreamWriter sw = new StreamWriter(".\\Source\\" + this.name + ".txt"))
            {
                JsonSerializer js = new JsonSerializer();
                js.Serialize(sw, list_movies);
            }

            */


            CBx_Movie.DataSource = list_movies;
            CBx_Movie.DisplayMember = "Name_Movie";

            CBx_Theater.DataSource = list_movies[0].Theater_Index;
            CBx_Theater.DisplayMember = "";

            Reload();
        }

        public Bai04_Client()
        {
        }

        private void Reload()
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
        /*private void Btn_Disconnect_Click(object sender, EventArgs e)
        {
            Byte[] data = System.Text.Encoding.ASCII.GetBytes("-./;1-q-a[zzwksa]zczcac");
            ns.Write(data, 0, data.Length);


            t.Abort();
            ns.Close();
            tcpClient.Close();
        }*/

        

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
            Reload();
        }

        private void CBx_Theater_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reload();
        }

        private void Btn_Buy_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TBx_Customer.Text)) { MessageBox.Show("Chưa nhập tên khách hàng!"); return; }
            // Check


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
            for (int i = 0; i < 15; i++)
            {
                if (list_seats[i].BackColor == Color.Firebrick
                    && list_movies[CBx_Movie.SelectedIndex].Theater_Seat[CBx_Theater.SelectedIndex][i] == 0)
                {
                    list_movies[CBx_Movie.SelectedIndex].Theater_Seat[CBx_Theater.SelectedIndex][i] = 2;
                    ticket.Chosen_Ticket.Add(((i / 5 == 0) ? "A" : ((i / 5 == 1) ? "B" : "C")) + (i % 5 + 1).ToString());
                    if (i % 5 == 0 || i % 5 == 4) ticket.Bill += list_movies[CBx_Movie.SelectedIndex].Price_Movie * 1 / 4;
                    else if (i / 5 == 0 || i / 5 == 2) ticket.Bill += list_movies[CBx_Movie.SelectedIndex].Price_Movie;
                    else ticket.Bill += list_movies[CBx_Movie.SelectedIndex].Price_Movie * 2;
                    this.list_seats[i].BackColor = System.Drawing.Color.Yellow;
                    this.list_seats[i].ForeColor = System.Drawing.Color.White;
                }
            }

            MessageBox.Show("Đang nhận dữ liệu từ Server");


            // Update to Server
            //CustomerName MovieIndex Theater_Index Theater Seat
            string updated_message = TBx_Customer.Text + "^" + CBx_Movie.SelectedIndex.ToString() + " " + CBx_Theater.SelectedIndex.ToString()
                + " " + string.Join(",", list_movies[CBx_Movie.SelectedIndex].Theater_Seat[CBx_Theater.SelectedIndex]);

            Byte[] data = System.Text.Encoding.UTF8.GetBytes(updated_message + "\n");
            ns.Write(data, 0, data.Length);
            //Task Recv data
            strData = String.Empty;
            Task.Run(() =>
            {
                while (true)
                {
                    byte[] file_Length_Bytes = new byte[4];
                    ns.Read(file_Length_Bytes, 0, file_Length_Bytes.Length);
                    int fileLength = BitConverter.ToInt32(file_Length_Bytes, 0);


                    byte[] buffer = new byte[fileLength];
                    int bytesRead = 0, totalBytesRead = 0; ;

                    if (fileLength > 0)
                    {
                        while ((bytesRead = ns.Read(buffer, totalBytesRead, fileLength - totalBytesRead)) > 0 && totalBytesRead != fileLength)
                        {
                            totalBytesRead += bytesRead;
                        }
                        strData = Encoding.UTF8.GetString(buffer);
                        break;
                    }
                }
            }).Wait();

            // Task Recv data
            strData = String.Empty;
            Task.Run(() =>
            {
                while (true)
                {
                    byte[] file_Length_Bytes = new byte[4];
                    ns.Read(file_Length_Bytes, 0, file_Length_Bytes.Length);
                    int fileLength = BitConverter.ToInt32(file_Length_Bytes, 0);


                    byte[] buffer = new byte[fileLength];
                    int bytesRead = 0, totalBytesRead = 0; ;

                    if (fileLength > 0)
                    {
                        while ((bytesRead = ns.Read(buffer, totalBytesRead, fileLength - totalBytesRead)) > 0 && totalBytesRead != fileLength)
                        {
                            totalBytesRead += bytesRead;
                        }
                        strData = Encoding.UTF8.GetString(buffer);
                        break;
                    }
                }
            }).Wait();

            for (int i=0; i<15; i++)
            {
                if(list_movies[CBx_Movie.SelectedIndex].Theater_Seat[CBx_Theater.SelectedIndex][i] == 2)
                {
                    list_movies[CBx_Movie.SelectedIndex].Theater_Seat[CBx_Theater.SelectedIndex][i] = 1;
                }    
            }
            
            if(checkobject(list_movies, JsonConvert.DeserializeObject<List<Movie>>(strData)))
            {
                list_movies = JsonConvert.DeserializeObject<List<Movie>>(strData);
                MessageBox.Show("Đặt vé không thành công");
                Reload();
                return;
            }    
            MessageBox.Show("Đặt vé thành công!");
           

            // Cập nhật danh sách đã mua trên Client
            list_tickets.Add(ticket);

            ListViewItem item = new ListViewItem((list_tickets.Count).ToString());
            item.SubItems.Add(list_tickets[list_tickets.Count - 1].Customer_Name);
            item.SubItems.Add(string.Join(", ", list_tickets[list_tickets.Count - 1].Chosen_Ticket));
            item.SubItems.Add(list_tickets[list_tickets.Count - 1].Name_Movie);


            item.SubItems.Add(list_tickets[list_tickets.Count - 1].Theater.ToString());
            item.SubItems.Add(list_tickets[list_tickets.Count - 1].Bill.ToString());

            ListView_Bought_Ticket.Items.Add(item);

            Chosen_Seat = 0;

            using (StreamWriter sw = new StreamWriter(".\\Source\\" + this.name + ".txt"))
            {
                JsonSerializer js = new JsonSerializer();
                js.Serialize(sw, list_movies);
            }
        }

        private bool checkobject(List<Movie> movies, List<Movie> temp)
        {
            Console.WriteLine(temp[CBx_Movie.SelectedIndex].Theater_Seat[CBx_Theater.SelectedIndex].Length.ToString());
            for(int i=0; i<15;i++)
            {
  
                Console.WriteLine(movies[CBx_Movie.SelectedIndex].Theater_Seat[CBx_Theater.SelectedIndex][i].ToString() + " " + temp[CBx_Movie.SelectedIndex].Theater_Seat[CBx_Theater.SelectedIndex][i].ToString());
                if (movies[CBx_Movie.SelectedIndex].Theater_Seat[CBx_Theater.SelectedIndex][i] != temp[CBx_Movie.SelectedIndex].Theater_Seat[CBx_Theater.SelectedIndex][i]) return true;
            }
           
            return false;
        }
        private void TBx_Customer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                MessageBox.Show("Không nhập số hoặc kí tự lạ!");
            }
        }
       

        private void Bai04_Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (t != null) t.Abort();
            if (ns != null) ns.Close();
            if (tcpClient != null) tcpClient.Close();
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