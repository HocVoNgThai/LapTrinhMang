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

namespace btvn_bai1
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }

        Socket listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        List<Socket> clientList = new List<Socket>();
        async void StartUnsafeThread()
        {
            try
            {
                IPEndPoint ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
                listenerSocket.Bind(ipepServer);
                listenerSocket.Listen(-1);
            }
            catch
            {
                MessageBox.Show("Server is already running!!!");
                return;
            }
            rtbMessage.Text += "Server is running on 127.0.0.1:8080\n";
            while (true)
            {
                Socket clientSocket = await listenerSocket.AcceptAsync();
                clientList.Add(clientSocket);
                Thread thr = new Thread(() => HandleClient(clientSocket));
                thr.Start();
            }
        }
        void HandleClient(Socket clientSocket)
        {
            int bytesReceived = 0;
            while (true)
            {
                byte[] recv = new byte[100];

                string text = "";
                do
                {
                    try
                    {
                        bytesReceived = clientSocket.Receive(recv);
                    }
                    catch
                    {
                        clientSocket.Close();
                        clientList.Remove(clientSocket);
                        return;
                    }
                    //MessageBox.Show(bytesReceived.ToString());
                    /*if (bytesReceived == 0)
                    {
                        
                    }*/
                    text += Encoding.UTF8.GetString(recv);
                } while (text.EndsWith("\n"));
                rtbMessage.Text += clientSocket.RemoteEndPoint + ": " + text;
                BroadcastMessage(text);

            }
        }
        void BroadcastMessage(string message)
        {
            byte[] data = Encoding.UTF8.GetBytes(message);
            foreach (Socket client in clientList)
            {
                // Don't send the message back to the sender
                client.Send(data);
            }
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread serverThread = new Thread(new ThreadStart(StartUnsafeThread));
            serverThread.Start();
        }
    }
}
