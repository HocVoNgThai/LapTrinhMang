using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace Lab2
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }
        public bool check_txtWrite(string name, string id, string phone,
                                        string course1, string course2, string course3)
        {
            if (name == "" || id == "" || phone == "" || course1 == "" || course2 == "" || course3 == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (id.Length != 8)
            {
                MessageBox.Show("Số ID có chính xác 8 ký tự", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (phone.Length != 10)
            {
                MessageBox.Show("Vui lòng nhập Sđt có 10 chữ số", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (phone[0] != '0')
            {
                MessageBox.Show("Vui lòng nhập Sđt bắt đầu bằng số 0", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (float.Parse(course1) > 10 || float.Parse(course1) < 0)
            {
                MessageBox.Show("Vui lòng nhập điểm môn thứ nhất trong khoảng 0-10", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (float.Parse(course2) > 10 || float.Parse(course2) < 0)
            {
                MessageBox.Show("Vui lòng nhập điểm môn thứ hai trong khoảng 0-10", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (float.Parse(course3) > 10 || float.Parse(course3) < 0)
            {
                MessageBox.Show("Vui lòng nhập điểm môn thứ ba trong khoảng 0-10", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public void ListObject(int pos)
        {
            
            float avarage = (float.Parse(sinhvien[pos].Course1) +
            float.Parse(sinhvien[pos].Course2) + float.Parse(sinhvien[pos].Course3)) / 3;
            txtNameRead.Text = sinhvien[pos].Name;
            txtIdRead.Text = sinhvien[pos].ID;
            txtPhoneRead.Text = sinhvien[pos].Phone;
            txt1Read.Text = sinhvien[pos].Course1;
            txt2Read.Text = sinhvien[pos].Course2;
            txt3Read.Text = sinhvien[pos].Course3;
            txtAvarage.Text = Convert.ToString(Math.Round(avarage, 2));
        }
        [Serializable]
        public class SinhVien
        {
            public string Name { get; set; }
            public string ID { get; set; }
            public string Phone { get; set; }
            public string Course1 { get; set; }
            public string Course2 { get; set; }
            public string Course3 { get; set; }

            public SinhVien(string hoten, string id, string phone, string c1, string c2, string c3)
            {
                Name = hoten;
                ID = id;
                Phone = phone;
                Course1 = c1;
                Course2 = c2;
                Course3 = c3;
            }
        }
        static void SerializeToFileStream(string filePath, List<SinhVien> sinhvien, int check)
        {

            try
            {
                // Create a new StreamWriter and FileStream
                FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    // Write each object to the file
                    foreach (var sv in sinhvien)
                    {
                        if (check == 0)
                        {
                            sw.WriteLine($"{sv.Name},{sv.ID},{sv.Phone},{sv.Course1},{sv.Course2},{sv.Course3}");
                        }
                        else if (check == 1)
                        {
                            float avarage = (float.Parse(sv.Course1) + float.Parse(sv.Course2) + float.Parse(sv.Course3)) / 3;
                            sw.WriteLine($"{sv.Name},{sv.ID},{sv.Phone},{sv.Course1},{sv.Course2},{sv.Course3},{Math.Round(avarage, 2)}");
                        }
                    }
                }
                MessageBox.Show($"Serialized data successfully written to {filePath}", "Successful",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred while serializing data: {ex.Message}", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        static List<SinhVien> DeserializeFromFileStream(string filePath)
        {
            List<SinhVien> sinhViens = new List<SinhVien>();
            try
            {
                // Create a new StreamReader and FileStream
                FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                using (StreamReader sr = new StreamReader(fs))
                {
                    string line;
                    // Read each line from the file and create a Person object
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 6)
                        {
                            string name = parts[0];
                            string id = parts[1];
                            string phone = parts[2];
                            string c1 = parts[3];
                            string c2 = parts[4];
                            string c3 = parts[5];
                            sinhViens.Add(new SinhVien(name, id, phone, c1, c2, c3));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred while deserializing data: {ex.Message}", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return sinhViens;
        }

        List<SinhVien> sinhvien = new List<SinhVien>();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (check_txtWrite(txtNameWrite.Text, txtIdWrite.Text, txtPhoneWrite.Text,
                                        txt1Write.Text, txt2Write.Text, txt3Write.Text))
            {
                rtbFileInfor.Text += txtNameWrite.Text + "\n"
                                        + txtIdWrite.Text + "\n"
                                        + txtPhoneWrite.Text + "\n"
                                        + txt1Write.Text + "\n"
                                        + txt2Write.Text + "\n"
                                        + txt3Write.Text + "\n";
                SinhVien sv = new SinhVien(txtNameWrite.Text, txtIdWrite.Text, txtPhoneWrite.Text,
                                            txt1Write.Text, txt2Write.Text, txt3Write.Text);
                txtNameWrite.Text = txtIdWrite.Text = txtPhoneWrite.Text =
                    txt1Write.Text = txt2Write.Text = txt3Write.Text = "";
                sinhvien.Add(sv);
            }
        }
        private void btnWrite_Click(object sender, EventArgs e)
        {
            SerializeToFileStream("input4.txt", sinhvien, 0);
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            sinhvien = DeserializeFromFileStream("input4.txt");
            if (sinhvien.Count < 1)
            {
                MessageBox.Show("Danh sách rỗng", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                SerializeToFileStream("output4.txt", sinhvien, 1);
                ListObject(0);
            }
            

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            int currentObject = Int32.Parse(lbIndex.Text);
            if (currentObject == 0)
            {
                MessageBox.Show("Danh sách đang ở vị trí bắt đầu", "Error",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                ListObject(currentObject - 1);
                lbIndex.Text = Convert.ToString(currentObject - 1);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int currentObject = Int32.Parse(lbIndex.Text);
            if (currentObject == sinhvien.Count-1)
            {
                MessageBox.Show("Danh sách đang ở vị trí cuối cùng", "Error",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                ListObject(currentObject + 1);
                lbIndex.Text = Convert.ToString(currentObject + 1);
            }
        }
    }
}
