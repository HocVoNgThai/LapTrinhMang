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
using System.Threading;
using System.IO.Pipes;

namespace Lab3
{
    public partial class Bai03_Client : Form
    {
        TcpClient tcpClient;
        NetworkStream ns;
        Thread t;
        public Bai03_Client()
        {
            InitializeComponent();
            Btn_Disconnect.Enabled = false;
            Btn_Send.Enabled = false;
        }
        private void Btn_Send_Click(object sender, EventArgs e)
        {
            Byte[] data = System.Text.Encoding.UTF8.GetBytes(Tbx_Message.Text + "\n");
            ns.Write(data, 0, data.Length);
            Tbx_Message.Text = String.Empty;
        }

        private void Btn_Connect_Click(object sender, EventArgs e)
        {
            if (Tbx_Ip.Text == String.Empty || Tbx_Port.Text == String.Empty) { MessageBox.Show("Thiếu IP or Port!"); return; }

            tcpClient = new TcpClient();
                IPAddress ipAddress = IPAddress.Parse(Tbx_Ip.Text);
                IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, int.Parse(Tbx_Port.Text));

            try
            {
                tcpClient.Connect(ipEndPoint);
                ns = tcpClient.GetStream();
            }
            catch
            {
                MessageBox.Show("Không thể kết nối tới Server!");
                return;
            }


            //Thread nhận dữ liệu từ server
            t = new Thread(new ThreadStart(Thread_ReadData));
            t.IsBackground = true;
            t.Start();
            

            //Set trạng thái button
            Btn_Connect.Enabled = false;
            Btn_Connect.BackColor = System.Drawing.Color.Lime;
            Btn_Connect.Text = "Connected";
            Btn_Send.Enabled = true;
            Btn_Disconnect.Enabled = true;
        }

        private void Thread_ReadData()
        {
            try
            {
                while (tcpClient.Connected)
                {
                    byte[] bytes = new byte[tcpClient.ReceiveBufferSize];
                    ns.Read(bytes, 0, tcpClient.ReceiveBufferSize);
                    Rtbx_Message.Text += Encoding.UTF8.GetString(bytes);
                }
            }
            catch
            {
               
                ns.Close();
                tcpClient.Close();
                Btn_Send.Enabled = false;
                Btn_Connect.Enabled = true;
                Btn_Disconnect.Enabled = false;
                Btn_Connect.BackColor = System.Drawing.Color.White;
                Btn_Connect.Text = "Connect";
            }
        }

        private void Btn_Disconnect_Click(object sender, EventArgs e)
        {
            ns.Close(); 
            tcpClient.Close();

            Btn_Send.Enabled = false;
            Btn_Connect.Enabled = true;
            Btn_Disconnect.Enabled = false;
            Btn_Connect.BackColor = System.Drawing.Color.White;
            Btn_Connect.Text = "Connect";
        }

        private void Bai03_Client_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (tcpClient != null) tcpClient.Close();
            if (t != null) t.Abort();
            
        }
    }
}
