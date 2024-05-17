using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btvn_bai1
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }
        TcpClient tcpClient = new TcpClient();
        NetworkStream ns = null;


        private async void btnConnect_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên người dùng");
                return;
            }
            IPEndPoint server = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            try
            {
                tcpClient = new TcpClient();
                tcpClient.Connect(server);
                ns = tcpClient.GetStream();
            }
            catch
            {
                MessageBox.Show("Không thể kết nối đến server!");
                return;
            }

            sendMessage(txtName.Text + $" đã gia nhập đoạn chat\n");
            btnConnect.Enabled = false;
            btnConnect.BackColor = Color.YellowGreen;
            btnConnect.Text = "Connected";
            btnSend.Enabled = true;
            btnDisconnect.Enabled = true;
            await Task.Run(() => ReceiveMessage());
        }
        void sendMessage(string message) //txtMessage
        {
            byte[] data = Encoding.UTF8.GetBytes(message);
            ns.Write(data, 0, data.Length);
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtMessage.Text == "")
            {
                MessageBox.Show("Không thể để trống phần message");
                return;
            }
            string sentData = txtName.Text + ": " + txtMessage.Text + "" + "\n";
            sendMessage(sentData);
            txtMessage.Text = "";
        }
        private async void ReceiveMessage()
        {
            while (tcpClient.Connected)
            {
                try
                {
                    if (ns.DataAvailable)
                    {
                        byte[] buffer = new byte[tcpClient.ReceiveBufferSize];
                        await ns.ReadAsync(buffer, 0, (int)tcpClient.ReceiveBufferSize);
                        string recvMess = Encoding.UTF8.GetString(buffer);
                        rtbListMessage.Text += recvMess + "\n";
                    }
                }
                catch
                {
                    return;
                }
            }
        }
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            sendMessage(txtName.Text + " đã rời khỏi đoạn chat\n");
            tcpClient.Close();
            ns.Close();
            rtbListMessage.Text = string.Empty;
            btnConnect.Enabled = true;
            btnConnect.BackColor = Client.DefaultBackColor;
            btnConnect.Text = "Connect";
            btnSend.Enabled = false;
            btnDisconnect.Enabled = false;
        }

        private void CloseTask(object sender, FormClosedEventArgs e)
        {
            if (tcpClient.Connected)
            {
                sendMessage(txtName.Text + " đã rời khỏi đoạn chat\n");
                tcpClient.Close();
                ns.Close();
            }
        }
    }
}
