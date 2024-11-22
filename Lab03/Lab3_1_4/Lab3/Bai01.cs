using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Bai01 : Form
    {
        private bool ServerOn = false;
        public Bai01()
        {
            InitializeComponent();

        }

        public void Btn_UdpServer_Click(object sender, EventArgs e)
        {
            if (!ServerOn)
            {
                Btn_UdpServer.Enabled = false;
                Btn_UdpServer.BackColor = System.Drawing.Color.Red;
                Bai01_Server form_server = new Bai01_Server(this);
                form_server.Show();
                form_server = null;
                ServerOn = true;
            }
            else
            {
                Btn_UdpServer.Enabled = true;
                Btn_UdpServer.BackColor = System.Drawing.Color.White;
                ServerOn = false;
            } 
                
        }

        private void Btn_UdpClient_Click(object sender, EventArgs e)
        {

                Bai01_Client form = new Bai01_Client();
                form.Show();
                form = null;
        }

        private void Bai01_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form client in Application.OpenForms.Cast<Form>().Where(form => form.Visible) .ToList())
            {
                if (client != null && (client is Bai01_Client || client is Bai01_Server))
                {
                    client.Close();
                    client.Dispose();
                }
                 
            }
        }
    }
}
