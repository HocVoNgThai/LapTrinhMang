using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using W_Lab2;
using Newtonsoft.Json;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab3
{
    public partial class Bai04 : Form
    {
        private Thread serverThread;


        List<Movie> list_movies;
        List<Ticket> list_tickets=new List<Ticket>();

        Socket listenerSocket;
        IPEndPoint ipepServer;

        List<Bai04_Client> forms = new List<Bai04_Client>();
        List<Socket> clientSockets=new List<Socket>();
        public Bai04()
        {
            InitializeComponent();
            //Load
            ReLoad();
        }
        private void ReLoad()
        {
            using (FileStream fs = new FileStream(".\\Source\\input_server.txt", FileMode.OpenOrCreate))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    string JsonContent = sr.ReadToEnd();
                    list_movies = JsonConvert.DeserializeObject<List<Movie>>(JsonContent);
                }
            }
            using (FileStream fs = new FileStream(".\\Source\\bought_Tickets_server.txt", FileMode.OpenOrCreate))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    string JsonContent = sr.ReadToEnd();
                    list_tickets = JsonConvert.DeserializeObject<List<Ticket>>(JsonContent);
                }
            }
            
                for (int i = 0; i < list_tickets.Count; i++)
                {
                    ListViewItem item = new ListViewItem((i+1).ToString());
                    item.SubItems.Add(list_tickets[i].Customer_Name);
                    item.SubItems.Add(string.Join(", ", list_tickets[i].Chosen_Ticket));
                    item.SubItems.Add(list_tickets[i].Name_Movie);
                    item.SubItems.Add(list_tickets[i].Theater.ToString());
                    item.SubItems.Add(list_tickets[i].Bill.ToString());

                    ListView_Bought_Ticket.Items.Add(item);
                }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StartUnsafeThread()
        {
            listenerSocket = new Socket(
            AddressFamily.InterNetwork,
            SocketType.Stream,
            ProtocolType.Tcp
            );

            ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            // Gán socket lắng nghe tới địa chỉ IP của máy và port 8080
            listenerSocket.Bind(ipepServer);
            
            
            //Đồng ý kết nối
            try
            {
                while (true)
                {
                    listenerSocket.Listen(10);
                    Socket clientSocket = listenerSocket.Accept();
                    //Nhận dữ liệu
                    //listViewCommand.Items.Add(new ListViewItem("New client connected"));
                    clientSockets.Add(clientSocket);
                    Send_Data_ToAllClients();
                    Send_Data_ToAllClients();
                    if (clientSocket.Connected)
                    {
                        Thread t = new Thread((obj) =>
                        {
                            handleClient((Socket)obj);
                        });
                        t.IsBackground = true;
                        t.Start(clientSocket);
                    }
                }
            }
            catch
            {
                listenerSocket = new Socket(
                        AddressFamily.InterNetwork,
                        SocketType.Stream,
                        ProtocolType.Tcp
                    );
                ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            }
        }

        private void Send_Data_ToAllClients()
        {
            //UTF8
            string fileData = File.ReadAllText(".\\Source\\input_server.txt", Encoding.UTF8);
            byte[] fileDataBytes = Encoding.UTF8.GetBytes(fileData);
            byte[] fileLengthBytes = BitConverter.GetBytes(fileDataBytes.Length);
            foreach (Socket client in clientSockets)
            {
                client.Send(fileLengthBytes);
                client.Send(fileDataBytes);
            }
            return;
        }    
        private void handleClient(Socket client)
        {
            try
            {
                var stream = new NetworkStream(client);
                var reader = new StreamReader(stream);
                while (true)
                {
                    
                    string text = reader.ReadLine();
                    Task.Run(() =>
                    {
                        if (text.Length > 0) Update_Data(text);
                    }).Wait();
                    
                }
                
            }
            catch
            {
                clientSockets.Remove(client);
                client.Close();
            }
        }

        private void Update_Data(string input)
        {
            list_movies= new List<Movie>();
            using (FileStream fs = new FileStream(".\\Source\\input_server.txt", FileMode.OpenOrCreate))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    string JsonContent = sr.ReadToEnd();
                    list_movies = JsonConvert.DeserializeObject<List<Movie>>(JsonContent);
                }
            }

            //Lưu tập update vào biến mới.
            string[] initiate = input.Split('^');
            string[] changes = initiate[1].Split(' ');
            int movie_index = int.Parse(changes[0]), theater_index = int.Parse(changes[1]);
            string[] theater_seats = changes[2].Split(',');
            int[] theaterseats_int=Array.ConvertAll(theater_seats, int.Parse);
            
            
            Ticket ticket = new Ticket() { Bill = 0, };
            ticket.Customer_Name = initiate[0];
            ticket.Name_Movie = list_movies[movie_index].Name_Movie;
            ticket.Theater = list_movies[movie_index].Theater_Index[theater_index];

            for (int i = 0; i < 15; i++)
                // Check lỗi đã đặt rồi
                if (list_movies[movie_index].Theater_Seat[theater_index][i] == 1 && theaterseats_int[i] == 2)
                {
                    Send_Data_ToAllClients();
                    Send_Data_ToAllClients();
                    return;
                }
                //// Không trùng lặp
                else if (theaterseats_int[i] == 2)
                {

                    ticket.Chosen_Ticket.Add(((i / 5 == 0) ? "A" : ((i / 5 == 1) ? "B" : "C")) + (i % 5 + 1).ToString());
                    if (i % 5 == 0 || i % 5 == 4) ticket.Bill += list_movies[movie_index].Price_Movie * 1 / 4;
                    else if (i / 5 == 0 || i / 5 == 2) ticket.Bill += list_movies[movie_index].Price_Movie;
                    else ticket.Bill += list_movies[movie_index].Price_Movie * 2;
                    theaterseats_int[i] = 1;
                
                }
            

            list_movies[movie_index].Theater_Seat[theater_index] = theaterseats_int;

            //Load to ListsView
            list_tickets.Add(ticket);

            ListViewItem item = new ListViewItem((list_tickets.Count).ToString());
            item.SubItems.Add(list_tickets[list_tickets.Count - 1].Customer_Name);
            item.SubItems.Add(string.Join(", ", list_tickets[list_tickets.Count - 1].Chosen_Ticket));
            item.SubItems.Add(list_tickets[list_tickets.Count - 1].Name_Movie);
            item.SubItems.Add(list_tickets[list_tickets.Count - 1].Theater.ToString());
            item.SubItems.Add(list_tickets[list_tickets.Count - 1].Bill.ToString());
            ListView_Bought_Ticket.Items.Add(item);


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
                        if (a % 5 == 0 || a % 5 == 4) export_list[i].Revenue += list_movies[i].Price_Movie * 1 / 4;
                        else if (a / 5 == 0 || a / 5 == 2) export_list[i].Revenue += list_movies[i].Price_Movie;
                        else export_list[i].Revenue += list_movies[i].Price_Movie * 2;
                    }
                }
                export_list[i].Ticket_Selling_Rate = (float)export_list[i].Sell_Ticket / (float)(export_list[i].Theater_Index.Length * 15);
            }


            //Export
            using (StreamWriter sw = new StreamWriter(".\\Source\\bought_Tickets_server.txt"))
            {
                JsonSerializer js = new JsonSerializer();
                js.Formatting = Formatting.Indented;
                js.Serialize(sw, list_tickets);
            }

            using (StreamWriter sw = new StreamWriter(".\\Source\\input_server.txt"))
            {
                JsonSerializer js = new JsonSerializer();
                js.Formatting = Formatting.Indented;
                js.Serialize(sw, export_list);
            }
            


            Send_Data_ToAllClients();
            Send_Data_ToAllClients();
            return;
        }

       
            /* Export information
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

           using (StreamWriter sw = new StreamWriter(".\\Source\\output5.txt"))
           {
               JsonSerializer js = new JsonSerializer();
               js.Serialize(sw, export_list);
           }

           //Create new form with progress bar
           this.Hide();
           ProgressBarMessage form = new ProgressBarMessage();
           form.ShowDialog();
           form = null;
           this.Show();

       }
       */

        private void StartListen(object sender, EventArgs e)
        {
            //Xử lý lỗi InvalidOperationException
            CheckForIllegalCrossThreadCalls = false;
            serverThread = new Thread(new ThreadStart(StartUnsafeThread));
            serverThread.IsBackground = true;
            serverThread.Start();
        }

        private void Bai03_Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form client in Application.OpenForms.Cast<Form>().Where(form => form.Visible).ToList())
            {
                if (client != null && client is Bai04_Client)
                {
                    client.Close();
                    client.Dispose();
                }

            }
            if (listenerSocket != null) listenerSocket.Close();
            if (serverThread != null) serverThread.Abort();
        }

        private void Btn_NewClient_Click(object sender, EventArgs e)
        {
            Bai04_Client client = new Bai04_Client("Client "+(clientSockets.Count+1).ToString());
            client.Show();
            client = null;
        }

        private void Bai04_Load(object sender, EventArgs e)
        {
            StartListen(sender, e);
        }

        private void Btn_ResetData_Click(object sender, EventArgs e)
        {
            list_movies = new List<Movie>()
             {
                 new Movie(){Name_Movie="Đào, phở và piano", Price_Movie=45000, Theater_Index=new int[]{1,2,3},Sell_Ticket=0, Stock_Ticket=0, Ticket_Selling_Rate=0, Revenue=0 },
                 new Movie(){Name_Movie="Mai", Price_Movie=100000, Theater_Index=new int[]{2,3}, Sell_Ticket=0, Stock_Ticket=0, Ticket_Selling_Rate=0, Revenue=0},
                 new Movie(){Name_Movie="Gặp lại chị bầu", Price_Movie=70000, Theater_Index=new int[]{1}, Sell_Ticket=0, Stock_Ticket=0, Ticket_Selling_Rate=0, Revenue=0},
                 new Movie(){Name_Movie="Tarot", Price_Movie=90000, Theater_Index=new int[]{3},Sell_Ticket=0, Stock_Ticket=0, Ticket_Selling_Rate=0, Revenue=0}
             };
            list_movies[0].Theater_Seat.Add(0, Enumerable.Repeat(0, 15).ToArray());
            list_movies[0].Theater_Seat.Add(1, Enumerable.Repeat(0, 15).ToArray());
            list_movies[0].Theater_Seat.Add(2, Enumerable.Repeat(0, 15).ToArray());
            list_movies[1].Theater_Seat.Add(0, Enumerable.Repeat(0, 15).ToArray());
            list_movies[1].Theater_Seat.Add(1, Enumerable.Repeat(0, 15).ToArray());
            list_movies[2].Theater_Seat.Add(0, Enumerable.Repeat(0, 15).ToArray());
            list_movies[3].Theater_Seat.Add(0, Enumerable.Repeat(0, 15).ToArray());



            //  /Initiate Data
            using (StreamWriter sw = new StreamWriter(".\\Source\\input_server.txt"))
            {
                JsonSerializer js = new JsonSerializer();
                js.Serialize(sw, list_movies);
            }

            list_tickets = new List<Ticket>();
            using (StreamWriter sw = new StreamWriter(".\\Source\\bought_Tickets_server.txt"))
            {
                JsonSerializer js = new JsonSerializer();
                js.Serialize(sw, list_tickets);
            }
            ListView_Bought_Ticket.Clear();
        }
    }
}
public class Movie
{
    public string Name_Movie { get; set; }
    public int[] Theater_Index;
    public float Price_Movie { get; set; }
    public Dictionary<int, int[]> Theater_Seat = new Dictionary<int, int[]>();
    public int Sell_Ticket { get; set; }
    public int Stock_Ticket { get; set; }
    public float Ticket_Selling_Rate { get; set; }
    public float Revenue { get; set;}
}



public class Ticket
{
    public string Customer_Name { get; set; }
    public List<string> Chosen_Ticket = new List<string>();
    public string Name_Movie { get; set; }
    public int Theater { get; set; }
    public float Bill { get; set; }
}
