using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class bai7 : Form
    {
        public bai7()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            lstOutput.Items.Clear();
            string list = txtInput.Text.Trim();
            string[] infor = list.Split(',');
            if (infor.Length < 2)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
            }
            else
            {
                for (int i = 1; i < infor.Length; i++)
                {
                    float temp;
                    if (float.TryParse(infor[i], out temp) == false)
                    {
                        MessageBox.Show($"Vui lòng nhập đúng định dạng điểm số môn thứ {i}.");
                        return;
                    }
                    else if (float.Parse(infor[i]) > 10 || float.Parse(infor[i]) < 0)
                    {
                        MessageBox.Show($"Số điểm của môn thứ {i} không phù hợp, vui lòng kiểm tra lại.");
                        return;
                    }
                }
                lstOutput.Items.Add("Đã nhập đúng định dạng. Dưới đây là thông tin sinh viên:");
                lstOutput.Items.Add($"Họ và tên: {infor[0]}");
                string listSubjects = "";
                for (int j = 1; j < infor.Length; j++)
                {
                    listSubjects += $"Môn {j}: {infor[j]}   ";
                }
                lstOutput.Items.Add(listSubjects);
                float[] marks = new float[infor.Length - 1];
                for (int j = 1; j < infor.Length; j++)
                {
                    marks[j - 1] = float.Parse(infor[j]);
                }
                lstOutput.Items.Add($"Điểm trung bình môn: {Math.Round(marks.Sum() / marks.Length, 2)}");
                lstOutput.Items.Add($"Điểm môn cao nhất là: {marks.Max()}");
                lstOutput.Items.Add($"Điểm môn thấp nhất là: {marks.Min()}");
                int fail = 0;
                int pass = 0;
                for (int j = 0; j < marks.Length; j++)
                {
                    if (marks[j] < 5)
                        fail++;
                    else pass++;
                }
                lstOutput.Items.Add($"Số môn rớt: {fail}    Số môn đậu: {pass}");
                float average = marks.Sum() / marks.Length;
                if (average >= 8 && marks.All(marks => marks >= 6.5))
                    lstOutput.Items.Add("Sinh viên xếp loại giỏi");
                else if (average >= 6.5 && marks.All(marks => marks >= 5))
                    lstOutput.Items.Add("Sinh viên xếp loại khá");
                else if (average >= 5 && marks.All(marks => marks >= 3.5))
                    lstOutput.Items.Add("Sinh viên xếp loại trung bình");
                else if (average >= 3.5 && marks.All(marks => marks >= 2))
                    lstOutput.Items.Add("Sinh viên xếp loại yếu");
                else lstOutput.Items.Add("Sinh viên xếp loại kém");
            }

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            lstOutput.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
