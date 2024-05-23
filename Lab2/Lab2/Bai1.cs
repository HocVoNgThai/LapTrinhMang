using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab2
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, System.EventArgs e)
        {
            FileStream fs = new FileStream("input1.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            rtbReadFile.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {

            FileStream fs = new FileStream("output1.txt", FileMode.Open, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            string input = rtbReadFile.Text.ToUpper();
            sw.Write(input);
            MessageBox.Show($"Data successfully written to output1.txt", "Successful",
                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
            sw.Close();
        }
    }
}
