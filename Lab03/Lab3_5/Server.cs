using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting;
using System.IO;
using System.Xml.Linq;
using System.Data.SQLite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Server : Form
    {
        private bool IsListening = false;
        private Thread serverThread;
        private Form1 form;
        Socket listenerSocket;
        public Server()
        {
            InitializeComponent();
        }

        public Server(Form1 form)
        {
            InitializeComponent();
            this.form = form;
        }

        int count = 0;

        public void CreateTable_MonAn(SQLiteConnection conn)
        {
            string sql = "CREATE TABLE IF NOT EXISTS MonAn (" +
                        "ID VARCHAR(20) PRIMARY KEY," +
                        "TenMonAn VARCHAR(40)," +
                        "HinhAnh VARCHAR(40)," +
                        "IDNCC VARCHAR(20)," +
                        "FOREIGN KEY (IDNCC) REFERENCES NguoiDung(IDNCC)" +
                        ")";
            var cmd = new SQLiteCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }

        public void CreateTable_NguoiDung(SQLiteConnection conn)
        {
            string sql = "CREATE TABLE IF NOT EXISTS NguoiDung (" +
                        "IDNCC VARCHAR(20) PRIMARY KEY," +
                        "HoVaTen VARCHAR(40)," +
                        "QuyenHan VARCHAR(40)" +
                        ")";
            var cmd = new SQLiteCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }

        public void InsertData_MonAn(SQLiteConnection conn, string id, string tenmonan, string hinhanh, string idncc)
        {
            var sql = "INSERT INTO MonAn(ID, TenMonAn, HinhAnh, IDNCC) " +
                    "VALUES(@id, @tenmonan, @hinhanh, @idncc)";
            var cmd = new SQLiteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@tenmonan", tenmonan);
            cmd.Parameters.AddWithValue("@hinhanh", hinhanh);
            cmd.Parameters.AddWithValue("@idncc", idncc);
            cmd.ExecuteNonQuery();
        }

        public void InsertData_NguoiDung(SQLiteConnection conn, string idncc, string hovaten, string quyenhan)
        {
            var sql = "INSERT INTO NguoiDung(IDNCC, HoVaTen, QuyenHan) " +
                    "VALUES(@idncc, @hovaten, @quyenhan)";
            var cmd = new SQLiteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@idncc", idncc);
            cmd.Parameters.AddWithValue("@hovaten", hovaten);
            cmd.Parameters.AddWithValue("@quyenhan", quyenhan);
            cmd.ExecuteNonQuery();
        }

        private void StartUnsafeThread()
        {
            int bytesReceived = 0;
            // Khởi tạo mảng byte nhận dữ liệu
            byte[] recv = new byte[1];
            // Tạo socket bên gởi Socket clientSocket;

            // Tạo socket bên nhận, socket này là socket lắng nghe các kết nối tới nó tại địa chỉ IP của máy và port 8080.Đây là 1 TCP / IP socket.
            //AddressFamily: trả về họ địa chỉ của địa chỉ IP hiện hành. Ở đây là địa chỉ Ipv4 nên chọn
            // AddressFamily.InterNetwork
            //SocketType: kiểu kết nối socket, ở đây dùng luồng Stream để nhận dữ liệu
            //ProtocolType: sử dụng giao thức kết nối nào, ở đây sử dụng kết nối TCP
            // Ba tham số của hàm đi với nhau khi ta thực hiện kết nối TCP.
            listenerSocket = new Socket(
            AddressFamily.InterNetwork,
            SocketType.Stream,
            ProtocolType.Tcp
            );
            IPEndPoint ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), int.Parse(Tbx_ListenPort.Text));
            // Gán socket lắng nghe tới địa chỉ IP của máy và port 8080
            listenerSocket.Bind(ipepServer);
            // bắt đầu lắng nghe. Socket.Listen(int backlog)
            // với backlog: là độ dài tối đa của hàng đợi các kết nối đang chờ xử lý
            //listenerSocket.Listen(-1);
            listenerSocket.Listen(10);
            Socket clientSocket = listenerSocket.Accept();
            //Đồng ý kết nối
            while (clientSocket.Connected)
            {

                //Nhận dữ liệu

                Rtbx_Output.Text += "New client connected" + System.Environment.NewLine;
                //listViewCommand.Items.Add(new ListViewItem("New client connected"));

                clientSocket.Send(Encoding.ASCII.GetBytes("Connected to 127.0.0.1 - " + Tbx_ListenPort.Text));


                string text = "";
                do
                {
                    bytesReceived = clientSocket.Receive(recv);
                    text += Encoding.UTF8.GetString(recv, 0, bytesReceived);

                } while (text[text.Length - 1] != '\n');

                handleClient(text.Trim());

                if (text == "quit\n") break;



            }
            listenerSocket.Close();
        }

        private void StartListen(object sender, EventArgs e)
        {
            //Xử lý lỗi InvalidOperationException
            CheckForIllegalCrossThreadCalls = false;
            serverThread = new Thread(new ThreadStart(StartUnsafeThread));
            serverThread.Start();
            serverThread.IsBackground = true;
        }

        private void Btn_Listen_Click(object sender, EventArgs e)
        {
            if (!IsListening)
            {
                Btn_Listen.BackColor = System.Drawing.Color.Lime;
                Btn_Listen.Text = "Listening...";
                StartListen(sender, e);
                IsListening = true;
            }
            else
            {

                listenerSocket.Close();
                IsListening = false;
                //serverThread.
                //serverThread.Close();
                serverThread.Abort();
                Btn_Listen.BackColor = System.Drawing.Color.White;
                Btn_Listen.Text = "Listen";
            }
        }

        public void handleClient(string temp)
        {
            string[] arrList = temp.Trim().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            if (arrList.Length < 6)
            {
                MessageBox.Show("Dữ liệu không đủ.", "Thông báo");
                return;
            }


            MonAn.Rows.Add(arrList[0], arrList[1], arrList[2], arrList[3]);
            NguoiDung.Rows.Add(arrList[3], arrList[4], arrList[5]);
            var createDBSQL = "Data Source = Bai5lab3.db";
            //SQLiteConnection.CreateFile(createDBSQL);
            SQLiteConnection conn = new SQLiteConnection(createDBSQL);
            try
            {
                conn.Open();


                    CreateTable_MonAn(conn);
                    CreateTable_NguoiDung(conn);
                    InsertData_MonAn(conn, arrList[0], arrList[1], arrList[2], arrList[3]);
                    InsertData_NguoiDung(conn, arrList[3], arrList[4], arrList[5]);
                    count++;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xử lý dữ liệu: " + ex.Message, "Thông báo");
            }
            finally { conn.Close(); }
        }


        private void Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (listenerSocket != null) listenerSocket.Close();
            if (serverThread != null) serverThread.Abort();
        }

        public void SelectData(SQLiteConnection conn, string temp)
        {
            var sql = "SELECT TenMonAn, HinhAnh, HoVaTen " +
              "FROM NguoiDung, MonAn " +
              "WHERE NguoiDung.IDNCC = MonAn.IDNCC AND ID = @temp";
            var cmd = new SQLiteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@temp", temp);

            flowLayoutPanel1.Controls.Clear();

            using (var reader = cmd.ExecuteReader())
            {
                // Kiểm tra xem có dữ liệu được trả về không
                if (reader.HasRows)
                {
                    listView1.Clear();
                    while (reader.Read())
                    {
                        string tenMonAn = reader.GetString(reader.GetOrdinal("TenMonAn"));
                        string hinhAnh = reader.GetString(reader.GetOrdinal("HinhAnh"));
                        string nguoiDongGop = reader.GetString(reader.GetOrdinal("HoVaTen"));

                        // Hiển thị thông tin món ăn
                        listView1.Items.Add("Ten mon an la: " + tenMonAn + "\n" +
                                             "Nguoi dong gop mon an la: " + nguoiDongGop + "\n");

                        // Tạo một PictureBox để hiển thị hình ảnh
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.Image = Image.FromFile(hinhAnh);
                        pictureBox.Size = new Size(300, 250);
                        // Thiết lập kích thước hình ảnh
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                        // Thêm PictureBox vào FlowLayoutPanel
                        flowLayoutPanel1.Controls.Add(pictureBox);
                    }
                }
                else
                {
                    listView1.Items.Add("Không có dữ liệu phù hợp.");
                }
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int a = r.Next(1, 4);
            MessageBox.Show("Hom nay an " + a.ToString());
            var createDBSQL = "Data Source = bai5lab3.db";
            SQLiteConnection conn = new SQLiteConnection(createDBSQL);
            try
            {
                conn.Open();
                SelectData(conn, a.ToString());
            }
            catch
            {
                MessageBox.Show("Loi", "Thong bao");
            }
            finally
            { conn.Close(); }
        }


    }
}
