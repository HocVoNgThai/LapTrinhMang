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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            //in ra nội dụng file
            rtbReadFile.Text = sr.ReadToEnd();
            //tìm tên file
            txtFileName.Text = ofd.SafeFileName.ToString();
            //tìm đường dẫn
            txtPath.Text = fs.Name.ToString();
            //tính kích thước file
            txtSizes.Text = fs.Length.ToString() + " bytes";
            //tính số dòng trong file
            fs.Position = 0;
            int lineCount = 0;
            while (sr.ReadLine() != null)
            {
                lineCount++;
            }
            txtLines.Text = lineCount.ToString();
            //tính số từ
            char[] splitKey = {' ','\n','\t',',','.',';'};
            string[] words;
            words = rtbReadFile.Text.Split(splitKey);
            txtWords.Text = words.Length.ToString();
            //tính số ký tự 
            int characterCount = 0;
            fs.Position = 0;
            while (sr.Read() != -1)
            {
                characterCount++;
            }
            txtCharacters.Text = characterCount.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
