using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab2
{
    public partial class Bai6 : Form
    {
        public Bai6()
        {
            InitializeComponent();
        }
        private void Bai6_Load(object sender, EventArgs e)
        {
            CheckExists();
        }
        private void btnRandom_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int temp = 0;
            temp = r.Next(treeView.Nodes.Count);
            GetImageFromDataBase(treeView.Nodes[temp].Tag.ToString());
            GetOwnerFromDataBase(treeView.Nodes[temp].Tag.ToString());
            //MessageBox.Show(treeView.Nodes[temp].Tag.ToString());
        }
        private void CheckExists()
        {
            if (!File.Exists("MonAn.db"))
            {
                SQLiteConnection.CreateFile("MonAn.db");
                using (SQLiteConnection conn = new SQLiteConnection(Bai6Database.ConnectionData()))
                {
                    conn.Open();
                    string cmdDishes = "CREATE TABLE Dishes (IDMA NVARCHAR(10), TenMonAn NVARCHAR(50), HinhAnh NVARCHAR(200), IDNCC NVARCHAR(10))";
                    using (SQLiteCommand cmdCreate1 = new SQLiteCommand(cmdDishes, conn))
                    {
                        cmdCreate1.ExecuteNonQuery();
                    }
                    string cmdOwner = "CREATE TABLE Owner (IDNCC NVARCHAR(10), HoVaTen NVARCHAR(50), QuyenHan NVARCHAR(50))";
                    using (SQLiteCommand cmdCreate2 = new SQLiteCommand(cmdOwner, conn))
                    {
                        cmdCreate2.ExecuteNonQuery();
                    }

                }
                InsertDishes("001", "Cơm gà", "ComGa.jpg", "S01");
                InsertDishes("002", "Cơm tấm", "ComTam.jpg", "D01");
                InsertDishes("003", "Phở bò", "PhoBo.jpg", "H01");
                InsertDishes("004", "Sườn nướng", "SuonNuong.jpg", "N01");
                InsertDishes("005", "Bún riêu", "BunRieu.jpg", "H02");
                InsertDishes("006", "Bánh canh", "BanhCanh.jpg", "H01");
                InsertDishes("007", "Lẩu hải sản", "LauHaiSan.jpg", "D01");
                InsertDishes("008", "Bún đậu", "BunDau.jpg", "S01");
                InsertOwner("S01", "Trần Hà Sơn", "Xem");
                InsertOwner("N01", "Lê Nhật Anh", "Xem và Chỉnh");
                InsertOwner("D01", "Thái Vĩnh Đạt", "Xem");
                InsertOwner("H01", "Võ Nguyễn Thái Học", "Toàn quyền");
                InsertOwner("H02", "Võ Nhật Hoàng", "Xem");
            }
            GetDishesFromDataBase();

        }
        private void GetDishesFromDataBase()
        {
            using (SQLiteConnection conn = new SQLiteConnection(Bai6Database.ConnectionData()))
            {
                conn.Open();
                string cmdString = "SELECT TenMonAn FROM Dishes";
                using (SQLiteCommand cmd = new SQLiteCommand(cmdString, conn))
                {

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TreeNode treeNode = new TreeNode(reader.GetString(0));
                            treeNode.Tag = reader.GetString(0);
                            treeView.Nodes.Add(treeNode);
                        }

                    }
                }
            }
        }
        private void GetImageFromDataBase(string TenMonAn)
        {
            using (SQLiteConnection conn = new SQLiteConnection(Bai6Database.ConnectionData()))
            {
                conn.Open();
                string cmdString = $"SELECT HinhAnh FROM Dishes WHERE TenMonAn = '{TenMonAn}'";
                using (SQLiteCommand cmd = new SQLiteCommand(cmdString, conn))
                {
                    //cmd.Parameters.AddWithValue("@ten", TenMonAn);
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Image image = Image.FromFile(reader.GetString(0));
                            // Điều chỉnh độ rộng của ảnh để phù hợp với pictrueBox
                            pictureDishes.SizeMode = PictureBoxSizeMode.Zoom;
                            pictureDishes.Image = image;
                            //MessageBox.Show("D:\\mạng\\lab-project\\Lab2\\input_output\\" + reader.GetString(0));
                        }
                    }
                }
            }
        }
        private void GetOwnerFromDataBase(string TenMonAn)
        {
            rtbInfoDishes.Clear();
            using (SQLiteConnection conn = new SQLiteConnection(Bai6Database.ConnectionData()))
            {
                conn.Open();
                string cmdString = $"SELECT d.TenMonAn, o.HoVaTen FROM Dishes d JOIN Owner o ON d.IDNCC = o.IDNCC WHERE TenMonAn = '{TenMonAn}'";
                using (SQLiteCommand cmd = new SQLiteCommand(cmdString, conn))
                {
                    //cmd.Parameters.AddWithValue("@ten", TenMonAn);
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            rtbInfoDishes.Text += $"Món ăn: {reader.GetString(0)}\n";
                            rtbInfoDishes.Text += $"Người cung cấp: {reader.GetString(1)}";
                        }
                    }
                }
            }
        }
        private void InsertDishes(string id, string name, string image, string idOwner)
        {
            using (SQLiteConnection conn = new SQLiteConnection(Bai6Database.ConnectionData()))
            {
                string cmdString = "INSERT INTO Dishes ([IDMA],[TenMonAn],[HinhAnh],[IDNCC]) VALUES (@IDMA,@TenMonAn,@HinhAnh,@IDNCC)";
                using (SQLiteCommand cmd = new SQLiteCommand(cmdString, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@IDMA", id);
                    cmd.Parameters.AddWithValue("@TenMonAn", name);
                    cmd.Parameters.AddWithValue("@HinhAnh", image);
                    cmd.Parameters.AddWithValue("@IDNCC", idOwner);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void InsertOwner(string id, string name, string authorization)
        {
            using (SQLiteConnection conn = new SQLiteConnection(Bai6Database.ConnectionData()))
            {
                string cmdString = "INSERT INTO Owner ([IDNCC],[HoVaTen],[QuyenHan]) VALUES (@IDNCC,@HoVaTen,@QuyenHan)";
                using (SQLiteCommand cmd = new SQLiteCommand(cmdString, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@IDNCC", id);
                    cmd.Parameters.AddWithValue("@HoVaTen", name);
                    cmd.Parameters.AddWithValue("@QuyenHan", authorization);
                    cmd.ExecuteNonQuery();
                }
            }
        }



    }
}
