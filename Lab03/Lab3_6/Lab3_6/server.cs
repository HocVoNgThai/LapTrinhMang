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

namespace Lab3_6
{
    public partial class server : Form
    {
        public server()
        {
            InitializeComponent();
        }

        Socket listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        List<Socket> clientList = new List<Socket>();
        async void StartUnsafeThread()
        {
            try
            {
                IPEndPoint ipEPServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
                listenerSocket.Bind(ipEPServer);
                listenerSocket.Listen(-1);
            }
            catch
            {
                MessageBox.Show("Server đã được bật");
                return;
            }
            rtbMessage.Text += "Server hoạt động tại IP 127.0.0.1:8080\n";
            while (true)
            {
                Socket clientSocket = await listenerSocket.AcceptAsync();
                clientSocket.Send(Encoding.UTF8.GetBytes(clientSocket.RemoteEndPoint.ToString() + "\n"));
                clientList.Add(clientSocket);


                Thread thr = new Thread(() => HandleClient(clientSocket));
                thr.Start();
            }
        }
        void HandleClient(Socket clientSocket)
        {
            string LstClient = "";
            foreach (Socket client in clientList)
            {
                string[] clientREP = client.RemoteEndPoint.ToString().Split(':');
                LstClient += clientREP[1] + " ";
            }
            LstClient = "List client_port (new): " + LstClient + "\n";
            PublicMessage(LstClient);
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
                    text += Encoding.UTF8.GetString(recv);
                } while (text.EndsWith("\n"));
                string[] txt = text.Split('^');


                rtbMessage.Text += clientSocket.RemoteEndPoint + ": " + text;
                //if(txt[1] == "All")
                //{
                if (txt.Length == 1)
                {
                    PublicMessage("From (" + clientSocket.RemoteEndPoint + ") " + txt[0] + "\n");
                }

                //}
                else
                {

                    int destPort = int.Parse(txt[1]);

                    foreach (var clientDest in clientList)
                    {

                        string[] clientREP = clientDest.RemoteEndPoint.ToString().Split(':');
                        int clientPort = int.Parse(clientREP[1]);
                        if (clientPort == destPort)
                            PrivateMessage("From (" + clientSocket.RemoteEndPoint + " with private chat) " + txt[0] + "\n", clientSocket, clientDest);
                        //MessageBox.Show(client.RemoteEndPoint.ToString());
                    }
                }
            }
        }
        void PublicMessage(string message)
        {
            byte[] data = Encoding.UTF8.GetBytes(message);
            foreach (Socket client in clientList)
            {
                client.Send(data);
            }
        }
        void PrivateMessage(string message, Socket sent, Socket dest)
        {
            byte[] data = Encoding.UTF8.GetBytes(message);
            dest.Send(data);
            sent.Send(data);
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread serverThread = new Thread(new ThreadStart(StartUnsafeThread));
            serverThread.Start();
        }
    }
}
