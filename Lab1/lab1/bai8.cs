using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class bai8 : Form
    {
        public bai8()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool check = true;
            string str = txtAdd.Text.ToLower();
            char[] array = str.ToCharArray();
            if (array.Length >= 1)
            {
                if (char.IsLower(array[0]))
                {
                    array[0] = char.ToUpper(array[0]);
                }
            }
            str = new string(array);
            if (lstRandom.Items.Contains(str))
            {
                check = false;
            }
            if (!check)
            {
                MessageBox.Show("Món ăn đã có");
            }
            else if (txtAdd.Text != "")
            {
                lstRandom.Items.Add(txtAdd.Text);
            }
            else MessageBox.Show("Vui lòng nhập món ăn muốn thêm");
        }
        private void btnRandom_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int temp = 0;
            temp = r.Next(lstRandom.Items.Count);
            txtRandom.Text = Convert.ToString(lstRandom.Items[temp]);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            for (int i = lstRandom.SelectedItems.Count - 1; i >= 0; i--)
            {
                lstRandom.Items.Remove(lstRandom.SelectedItems[i]);
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
