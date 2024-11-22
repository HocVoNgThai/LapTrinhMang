using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace WinFormsApp1
{
    public partial class Client : Form
    {
        private TcpClient tcpClient;
        NetworkStream ns;
        Thread t;
        public Client()
        {
            InitializeComponent();
            Btn_Disconnect.Enabled = false;
            Btn_Send.Enabled = false;
        }

        public Client(string name)
        {
            InitializeComponent();
            this.Name = name;
        }

        private void Btn_Send_Click(object sender, EventArgs e)
        {
            string userInput = txtIDMA.Text + "," + txtTenMonAn.Text + "," + txtHinhAnh.Text + "," + txtIDNCC.Text + "," + txtHoVaTen.Text + "," + txtQuyenHan.Text;
            if (userInput == String.Empty) { MessageBox.Show("Nhập dữ liệu!"); return; }
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(userInput + "\n");
            ns.Write(data, 0, data.Length);
            txtIDMA.Text = String.Empty;
            txtTenMonAn.Text = String.Empty;
            txtHinhAnh.Text = String.Empty;
            txtIDNCC.Text = String.Empty;
            txtHoVaTen.Text = String.Empty;
            txtQuyenHan.Text = String.Empty;
            userInput = String.Empty;

        }

        private void Btn_Connect_Click(object sender, EventArgs e)
        {
            if (Tbx_Ip.Text == String.Empty || Tbx_Port.Text == String.Empty) { MessageBox.Show("Thiếu IP or Port!"); return; }
            // 1 Tạo đối tượng TcpClient
            tcpClient = new TcpClient();
            // 2 Kết nối đến Server với 1 địa chỉ Ip và Port xác định
            IPAddress ipAddress = IPAddress.Parse(Tbx_Ip.Text);
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, int.Parse(Tbx_Port.Text));
            tcpClient.Connect(ipEndPoint);


            //
            if (!tcpClient.Connected)
            {
                MessageBox.Show("Kết nối không thành công! \n Vui lòng kiểm tra IP và Port");
                return;
            }
            // 3 Tạo luồng để đọc và ghi dữ liệu dựa trên NetworkStream
            ns = tcpClient.GetStream();

            t = new Thread(new ThreadStart(Thread_ReadData));
            t.IsBackground = true;

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
                if (tcpClient.Connected)
                {
                    if (ns.CanRead)
                    {
                        byte[] bytes = new byte[tcpClient.ReceiveBufferSize];
                        ns.Read(bytes, 0, tcpClient.ReceiveBufferSize);
                        Rtbx_Message.Text += Encoding.ASCII.GetString(bytes);
                    }
                }
            }
            catch
            {

            }
        }

        private void Btn_Disconnect_Click(object sender, EventArgs e)
        {
            Byte[] data = System.Text.Encoding.ASCII.GetBytes("-./;1-q-a[zzwksa]zczcac");
            ns.Write(data, 0, data.Length);


            t.Abort();
            ns.Close();
            tcpClient.Close();

            Btn_Send.Enabled = false;
            Btn_Connect.Enabled = true;
            Btn_Disconnect.Enabled = false;
            Btn_Connect.BackColor = System.Drawing.Color.White;
            Btn_Connect.Text = "Connect";

        }

        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            Byte[] data = System.Text.Encoding.ASCII.GetBytes("-./;1-q-a[zzwksa]zczcac");
            if (ns.CanWrite) ns.Write(data, 0, data.Length);

            if (t != null) t.Abort();
            if (ns != null) ns.Close();
            if (tcpClient != null) tcpClient.Close();
        }
    }
}
   

