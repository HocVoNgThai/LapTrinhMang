using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Bai01_Server : Form
    {
        public string mess;
        Thread thdUDPServer =null;
        bool IsListening = false;
        UdpClient udpClient;
        Bai01 form;
        public Bai01_Server()
        {
            InitializeComponent();

        }
        public Bai01_Server(Bai01 form)
        {
            InitializeComponent();
            this.form = form;
        }

        public void serverThread()
        {
            udpClient = new UdpClient(int.Parse(Tbx_Port.Text));
            while (true)
            {
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                string returnData = Encoding.UTF8.GetString(receiveBytes);
                string mess = RemoteIpEndPoint.Address.ToString() + "-" + RemoteIpEndPoint.Port + ": " + returnData; 
                 returnData.ToString();

                //Viết hàm InfoMessage để hiển thị thông điệp lên List View
                //InfoMessage(mess);

                Rtbx_RecvMessage.Text += mess+ System.Environment.NewLine;
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            //Xử lý lỗi InvalidOperationException
            CheckForIllegalCrossThreadCalls = false;
            thdUDPServer = new Thread(new ThreadStart(serverThread));
            thdUDPServer.Name = "Thread_One";
            thdUDPServer.IsBackground = true;
            thdUDPServer.Start();
        }

        public void Bai01_Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(udpClient!=null) udpClient.Close();
            if(thdUDPServer != null) thdUDPServer.Abort();
            this.form.Btn_UdpServer_Click(sender, e);
        }

        private void Btn_Listen_Click(object sender, EventArgs e)
        {
            if(!IsListening)
            {
                Btn_Listen.BackColor = System.Drawing.Color.Lime;
                Btn_Listen.Text = "Listening...";
                Form2_Load(sender, e);
                IsListening = true;
            }
            else
            {
                IsListening = false;
                udpClient.Close();
                thdUDPServer.Abort();
                Btn_Listen.BackColor = System.Drawing.Color.White;
                Btn_Listen.Text = "Listen";
            } 
                
            
        }
    }
}