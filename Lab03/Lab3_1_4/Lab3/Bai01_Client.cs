using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Bai01_Client : Form
    {
        public Bai01_Client()
        {
            InitializeComponent();
        }

        private void Btn_Send_Click(object sender, EventArgs e)
        {
            //Tạo kết nối UDP
            UdpClient udpClient = new UdpClient();
            //Do ý đồ muốn gởi dữ liệu là “Hello World?” sang bên nhận. Nên cần chuyển chuỗi Hello World sang kiểu byte
             Byte[] sendBytes = Encoding.UTF8.GetBytes(Rtbx_Message.Text);
            //Gởi dữ liệu mà không cần thiết lập kết nối với Server
            try
            {
                udpClient.Send(sendBytes, sendBytes.Length, Tbx_IpHost.Text, int.Parse(Tbx_Port.Text));
                Rtbx_Message.Text=String.Empty;
            }
            catch
            {
                MessageBox.Show("Không thể gửi!");
                return;
            }
        }
    }
}
