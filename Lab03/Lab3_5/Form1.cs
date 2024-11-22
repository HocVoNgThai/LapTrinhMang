namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private bool ServerOn = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Show();
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            if (!ServerOn)
            {
                btnServer.Enabled = false;
                btnServer.BackColor = System.Drawing.Color.Red;
                Server form_server = new Server(this);
                form_server.Show();
                form_server = null;
                ServerOn = true;
            }
            else
            {
                btnServer.Enabled = true;
                btnServer.BackColor = System.Drawing.Color.White;
                ServerOn = false;
            }
        }
    }
}
