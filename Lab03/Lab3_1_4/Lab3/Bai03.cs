using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Bai03 : Form
    {
        private bool ServerOn = false;
        public Bai03()
        {
            InitializeComponent();
        }

        public void Btn_TcpServer_Click(object sender, EventArgs e)
        {
            if (!ServerOn)
            {
                Btn_TcpServer.Enabled = false;
                Btn_TcpServer.BackColor = System.Drawing.Color.Red;
                Bai03_Server form_server = new Bai03_Server(this);
                form_server.Show();
                form_server = null;
                ServerOn = true;
            }
            else
            {
                Btn_TcpServer.Enabled = true;
                Btn_TcpServer.BackColor = System.Drawing.Color.White;
                ServerOn = false;
            }

        }

        private void Btn_TcpClient_Click(object sender, EventArgs e)
        {

            Bai03_Client form = new Bai03_Client();
            form.Show();
            form = null;
        }

        private void Bai03_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form client in Application.OpenForms.Cast<Form>().Where(form => form.Visible).ToList())
            {
                if (client != null && (client is Bai03_Client || client is Bai03_Server))
                {
                    client.Close();
                    client.Dispose();
                }

            }
        }
    }
}
