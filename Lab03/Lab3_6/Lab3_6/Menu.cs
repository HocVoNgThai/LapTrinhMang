﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_6
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            server server = new server();
            Task.Run(() => server.ShowDialog());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            client client = new client();
            Task.Run(() => client.ShowDialog());
        }
    }
}
