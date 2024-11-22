using Lab5;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Dieuhuong : Form
    {
        public Dieuhuong()
        {
            InitializeComponent();
        }

        private void Btn_Bai1_Click(object sender, EventArgs e)
        {
        }

        private void Btn_Bai2_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_Bai3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai3 form = new Bai3();
            form.ShowDialog();
            form = null;
            this.Show();
        }

        private void Btn_Bai4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai04 form = new Bai04();
            form.ShowDialog();
            form = null;
            this.Show();
        }

        private void Btn_Bai5_Click(object sender, EventArgs e)
        {
        }
    }
}
