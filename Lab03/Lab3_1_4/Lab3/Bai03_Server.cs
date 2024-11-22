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
using System.Net.Http;
using System.Runtime.InteropServices.ComTypes;
using W_Lab2;

namespace Lab3
{
    public partial class Bai03_Server : Form
    {
        private bool IsListening = false;
        private Thread serverThread;
        List<Socket> sockets=new List<Socket>();

        private Bai03 form;
        private Socket listenerSocket;


        public Bai03_Server()
        {
            InitializeComponent();
        }

        public Bai03_Server(Bai03 form)
        {
            InitializeComponent();
            this.form = form;
        }

        void StartUnsafeThread()
        {

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
            IPEndPoint ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            // Gán socket lắng nghe tới địa chỉ IP của máy và port 8080
            listenerSocket.Bind(ipepServer);
            // bắt đầu lắng nghe. Socket.Listen(int backlog)
            // với backlog: là độ dài tối đa của hàng đợi các kết nối đang chờ xử lý
            try
            {
                while (true)
                {
                    listenerSocket.Listen(-1);
                    //Đồng ý kết nối

                    Socket clientSocket = listenerSocket.Accept();
                    sockets.Add(clientSocket);
                    //Nhận dữ liệu
                    ListViewItem item = new ListViewItem(clientSocket.RemoteEndPoint.ToString());
                    item.SubItems.Add("Connected");
                    listViewCommand.Items.Add(item);
                    Thread t = new Thread((obj) =>
                    {
                        Recv_From_Client((Socket)obj);
                    });
                    t.IsBackground = true;
                    t.Start(clientSocket);

                }
            }
            catch
            {
                listViewCommand.Items.Add(new ListViewItem("Server Closed"));
                listenerSocket.Close();
            }

        }

        private void Recv_From_Client(Socket client)
        {
            try
            {
                while (true)
                {
                    if (client.Poll(1, SelectMode.SelectRead))
                    {
                        ListViewItem item = new ListViewItem(client.RemoteEndPoint.ToString());
                        item.SubItems.Add("Disconnected!");
                        listViewCommand.Items.Add(item);
                        sockets.Remove(client);
                        client.Shutdown(SocketShutdown.Both);
                        client.Close();
                        break;
                    }    
                    byte[] data = new byte[client.ReceiveBufferSize];
                    client.Receive(data);
                    string text = Encoding.UTF8.GetString(data);
                    // Thêm text vào ListViewItem
                    if (text.Length >0 && text!=" "&& text!="\n")
                    {
                        ListViewItem temp = new ListViewItem(client.RemoteEndPoint.ToString());
                        temp.SubItems.Add(text);
                        listViewCommand.Items.Add(temp);
                    }
                }
               
            }
            catch { }
        }
        private void StartListen(object sender, EventArgs e)
        {
            //Xử lý lỗi InvalidOperationException
            CheckForIllegalCrossThreadCalls = false;
            serverThread = new Thread(new ThreadStart(StartUnsafeThread));
            serverThread.IsBackground = true;
            serverThread.Start();
        }

        public void Bai03_Server_FormClosing(object sender, FormClosingEventArgs e)
        {
           if(listenerSocket!=null) listenerSocket.Close();
            if (serverThread != null) serverThread.Abort();
            this.form.Btn_TcpServer_Click(sender, e);
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
                foreach (Socket client in sockets) { if (client != null) client.Close(); }
                IsListening = false;
                listenerSocket.Close();
                serverThread.Abort();
                Btn_Listen.BackColor = System.Drawing.Color.White;
                Btn_Listen.Text = "Listen";
            }
        }

        private void Btn_SendAll_Click(object sender, EventArgs e)
        {
            Byte[] data = System.Text.Encoding.UTF8.GetBytes(Tbx_Message.Text + "\n");
            foreach(Socket client in sockets)
            {
                if(client!=null) client.Send(data);
            }
            Tbx_Message.Text = String.Empty;
        }
    }
}
