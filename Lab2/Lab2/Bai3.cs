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
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("input3.txt",
                FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            rtbReadFile.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string[] lines;
            lines = rtbReadFile.Text.Split('\n');
            for (int i = 0; i < lines.Length; i++)
            {
                string[] numbers;
                numbers = lines[i].Split(' ');
                double rlt = double.Parse(numbers[0]);
                for (int j = 0; j < numbers.Length; j++)
                {

                    if (numbers[j] == "+")
                    {
                        rlt += double.Parse(numbers[j + 1]);
                    }
                    else if (numbers[j] == "-")
                    {
                        rlt = rlt - double.Parse(numbers[j + 1]);
                    }
                }
                rtbCalculate.Text += lines[i] + $" = {Math.Round(rlt,1)}";
                if (i != lines.Length - 1)
                {
                    rtbCalculate.Text += "\n";
                }
            }

        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("output3.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(rtbCalculate.Text);
            MessageBox.Show($"Data successfully written to output3.txt", "Successful",
                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
            sw.Close();
        }
    }
}
