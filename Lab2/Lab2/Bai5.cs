using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Lab2
{
    public partial class Bai5 : Form
    {
        class Phim
        {
            public string Ten { get; set; }
            public int GiaVe { get; set; }
            public int[]? PhongChieu { get; set; }
            public List<string> GheNgoi { get; set; }
            public Phim(string ten, int giaVe, int[]? phongChieu, List<string> gheNgoi)
            {
                Ten = ten;
                GiaVe = giaVe;
                PhongChieu = phongChieu;
                GheNgoi = gheNgoi;
            }

        }
        class DoanhThuPhim
        {
            public string TenPhim { get; set; }
            public int VeBanRa { get; set; }
            public int VeConLai { get; set; }
            public double TileBan { get; set; }
            public int DoanhThu { get; set; }
            public int XepHang { get; set; }
            public DoanhThuPhim(string tenPhim, int veBanRa, int veConLai, double tileBan, int doanhThu, int xepHang)
            {
                TenPhim = tenPhim;
                VeBanRa = veBanRa;
                VeConLai = veConLai;
                TileBan = tileBan;
                DoanhThu = doanhThu;
                XepHang = xepHang;
            }
        }
        List<Phim> phims;
        List<DoanhThuPhim> doanhThuPhims;
        string listGhe;
        private void Insert_DoanhThuPhim(List<Phim> phims)
        {
            doanhThuPhims = new List<DoanhThuPhim>();
            string tenPhim;
            int veBanRa1 = 0, veBanRa2 = 0, veBanRa3 = 0, veBanRa4 = 0;
            int veConLai = 0;
            int doanhThu1 = 0, doanhThu2 = 0, doanhThu3 = 0, doanhThu4 = 0;
            int xepHang1 = 0, xepHang2 = 0, xepHang3 = 0, xepHang4 = 0;
            foreach (var film in phims)
            {

                tenPhim = film.Ten;
                veConLai = film.GheNgoi.Count;
                int tongTien = 0;
                foreach (string gheNgoi in film.GheNgoi)
                {
                    string viTriGhe = gheNgoi.Split("-")[1];
                    string hangGhe = viTriGhe.Split('_')[0];
                    int soGhe = int.Parse(viTriGhe.Split("_")[1]);

                    if (soGhe == 1 || soGhe == 5)
                    {
                        tongTien += film.GiaVe / 4;
                    }
                    else
                    {
                        if (hangGhe.Equals("B"))
                        {
                            tongTien += film.GiaVe * 2;
                        }
                        else
                        {
                            tongTien += film.GiaVe;
                        }
                    }
                }
                if (tenPhim == "Đào, phở và piano")
                {
                    veBanRa1 = 45 - veConLai;
                    doanhThu1 = 3 * 607500 - tongTien;
                }
                else if (tenPhim == "Mai")
                {
                    veBanRa2 = 30 - veConLai;
                    doanhThu2 = 2 * 1350000 - tongTien;
                }
                else if (tenPhim == "Tarrot")
                {
                    veBanRa3 = 15 - veConLai;
                    doanhThu3 = 945000 - tongTien;
                }
                else if (tenPhim == "Gặp lai chị bầu")
                {
                    veBanRa4 = 15 - veConLai;
                    doanhThu4 = 1215000 - tongTien;
                }
            }
            int[] rates = { doanhThu1, doanhThu2, doanhThu3, doanhThu4 };
            Array.Sort(rates);
            Array.Reverse(rates);
            for (int i = 0; i < rates.Length; i++)
            {
                if (doanhThu1 == rates[i]) xepHang1 = i + 1;
                if (doanhThu2 == rates[i]) xepHang2 = i + 1;
                if (doanhThu3 == rates[i]) xepHang3 = i + 1;
                if (doanhThu4 == rates[i]) xepHang4 = i + 1;
            }
            double tiLe1 = (double)veBanRa1 * 100 / 45 ;
            double tiLe2 = (double)(veBanRa2 * 100 / 30 );
            double tiLe3 = (double)(veBanRa3 * 100 / 15 );
            double tiLe4 = (double)(veBanRa4 * 100 / 15 );
            doanhThuPhims.Add(new DoanhThuPhim(phims[0].Ten, veBanRa1, phims[0].GheNgoi.Count, tiLe1, doanhThu1, xepHang1));
            doanhThuPhims.Add(new DoanhThuPhim(phims[1].Ten, veBanRa2, phims[1].GheNgoi.Count, tiLe2, doanhThu2, xepHang2));
            doanhThuPhims.Add(new DoanhThuPhim(phims[2].Ten, veBanRa3, phims[2].GheNgoi.Count, tiLe3, doanhThu3, xepHang3));
            doanhThuPhims.Add(new DoanhThuPhim(phims[3].Ten, veBanRa4, phims[3].GheNgoi.Count, tiLe4, doanhThu4, xepHang4));
        }
        public Bai5()
        {
            InitializeComponent();
            /*List<Phim> phims = new List<Phim>();
            phims.Add(new Phim("Đào, phở và piano", 45000, new int[] { 1, 2, 3 }, new List<string>
            {"1-A_1", "1-A_2", "1-A_3", "1-A_4", "1-A_5", "1-B_1", "1-B_2", "1-B_3", "1-B_4", "1-B_5", "1-C_1", "1-C_2", "1-C_3", "1-C_4", "1-C_5",
             "2-A_1", "2-A_2", "2-A_3", "2-A_4", "2-A_5", "2-B_1", "2-B_2", "2-B_3", "2-B_4", "2-B_5", "2-C_1", "2-C_2", "2-C_3", "2-C_4", "2-C_5",
             "3-A_1", "3-A_2", "3-A_3", "3-A_4", "3-A_5", "3-B_1", "3-B_2", "3-B_3", "3-B_4", "3-B_5", "3-C_1", "3-C_2", "3-C_3", "3-C_4", "3-C_5"}));

            
            phims.Add(new Phim("Mai", 100000, new int[] { 2, 3 }, new List<string>
            {"1-A_1", "1-A_2", "1-A_3", "1-A_4", "1-A_5", "1-B_1", "1-B_2", "1-B_3", "1-B_4", "1-B_5", "1-C_1", "1-C_2", "1-C_3", "1-C_4", "1-C_5",
             "2-A_1", "2-A_2", "2-A_3", "2-A_4", "2-A_5", "2-B_1", "2-B_2", "2-B_3", "2-B_4", "2-B_5", "2-C_1", "2-C_2", "2-C_3", "2-C_4", "2-C_5"}));
            
            phims.Add(new Phim("Tarrot", 70000, new int[] { 1 }, new List<string>
            {"1-A_1", "1-A_2", "1-A_3", "1-A_4", "1-A_5", "1-B_1", "1-B_2", "1-B_3", "1-B_4", "1-B_5", "1-C_1", "1-C_2", "1-C_3", "1-C_4", "1-C_5"}));
            
            phims.Add(new Phim("Gặp lai chị bầu", 90000, new int[] { 3 }, new List<string>
            {"3-A_1", "3-A_2", "3-A_3", "3-A_4", "3-A_5", "3-B_1", "3-B_2", "3-B_3", "3-B_4", "3-B_5", "3-C_1", "3-C_2", "3-C_3", "3-C_4", "3-C_5"}));
            
            var options = new JsonSerializerOptions();
            options.WriteIndented = true;
            var srl = JsonSerializer.Serialize<List<Phim>>(phims, options);
            File.WriteAllText("input5.txt", srl);*/
            phims = new List<Phim>();
            var drl = File.ReadAllText("input5.txt");
            phims = JsonSerializer.Deserialize<List<Phim>>(drl);
            cbFilm.DataSource = phims;
            cbFilm.DisplayMember = "Ten";

            Insert_DoanhThuPhim(phims);
            var options = new JsonSerializerOptions();
            options.WriteIndented = true;
            var srl = JsonSerializer.Serialize<List<DoanhThuPhim>>(doanhThuPhims, options);
            File.WriteAllText("output5.txt", srl);


        }


        private void Bai5_Load(object sender, EventArgs e)
        {
            Phim selectedPhim = cbFilm.SelectedItem as Phim;
            cbCine.DataSource = selectedPhim.PhongChieu;
            lbInfo.Text = selectedPhim.Ten + " | Giá vé chuẩn: " + selectedPhim.GiaVe.ToString();

        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            List<System.Windows.Forms.CheckBox> listCheck = Controls.OfType<System.Windows.Forms.CheckBox>().ToList();
            foreach (System.Windows.Forms.CheckBox check in listCheck)
            {
                check.Enabled = false;
                check.Checked = false;
                check.TabStop = false;
                check.BackColor = Color.Yellow;
            }
            foreach (var Ghe in phims[cbFilm.SelectedIndex].GheNgoi)
            {
                var phongChieu = Int32.Parse(Ghe.Split("-")[0]);
                if (phongChieu == Int32.Parse(cbCine.Text))
                {
                    string gheNgoi = Ghe.Split("-")[1];
                    foreach (var checkBox in listCheck)
                    {
                        if (checkBox.Name == gheNgoi)
                        {
                            checkBox.TabStop = true;
                            checkBox.Enabled = true;
                            checkBox.BackColor = Color.White;
                        }
                    }
                }

            }
        }
        private void btnDatVe_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                listGhe = "";
                List<System.Windows.Forms.CheckBox> listCheck = Controls.OfType<System.Windows.Forms.CheckBox>().ToList();
                int tongTien = 0;
                int giaVe = phims[cbFilm.SelectedIndex].GiaVe;
               
                
                foreach (System.Windows.Forms.CheckBox checkBox in listCheck)
                {
                    if (checkBox.Checked)
                    {
                        //MessageBox.Show(checkBox.Name);
                        string hangGhe = checkBox.Name.Split('_')[0];
                        int soGhe = int.Parse(checkBox.Name.Split("_")[1]);

                        if (soGhe == 1 || soGhe == 5)
                        {
                            tongTien += giaVe / 4;
                        }
                        else
                        {
                            if (hangGhe.Equals("B"))
                            {
                                tongTien += giaVe * 2;
                            }
                            else
                            {
                                tongTien += giaVe;
                            }
                        }
                        checkBox.TabStop = false;
                        checkBox.Enabled = false;
                        checkBox.BackColor = Color.Yellow;
                        listGhe += checkBox.Name + " ";
                        var checkRap = cbCine.Text + "-" + checkBox.Name;
                        if (phims[cbFilm.SelectedIndex].GheNgoi.Contains(checkRap))
                        {
                            phims[cbFilm.SelectedIndex].GheNgoi.Remove(checkRap);
                            
                        }
                    }
                }
                rtbDatVe.Text += "Người đặt vé: " + txtName.Text + "\n";
                rtbDatVe.Text += "Phòng chiếu: " + cbCine.Text + "\nSố ghế: " + listGhe + "\n";
                rtbDatVe.Text += "Tổng tiền vé: " + tongTien.ToString() + "\n";
                var options = new JsonSerializerOptions();
                options.WriteIndented = true;
                var srl = JsonSerializer.Serialize<List<Phim>>(phims, options);
                File.WriteAllText("input5.txt", srl);
                Insert_DoanhThuPhim(phims);
                var srl1 = JsonSerializer.Serialize<List<DoanhThuPhim>>(doanhThuPhims, options);
                File.WriteAllText("output5.txt", srl1);
            }
        }

        private void btnXemInfo_Click(object sender, EventArgs e)
        {
            ProgressBar progressBar = new ProgressBar();
            progressBar.ShowDialog();
            rtbInfo.Clear();
            doanhThuPhims = new List<DoanhThuPhim>();
            var drl = File.ReadAllText("output5.txt");
            doanhThuPhims = JsonSerializer.Deserialize<List<DoanhThuPhim>>(drl);
            foreach (var doanhThu in doanhThuPhims)
            {
                rtbInfo.Text += "Tên phim: " + doanhThu.TenPhim + "\n";
                rtbInfo.Text += "Số vé bán ra: " + doanhThu.VeBanRa + "\n";
                rtbInfo.Text += "Số vé còn lại: " + doanhThu.VeConLai + "\n";
                rtbInfo.Text += "Tỉ lệ bán vé: " + (double)doanhThu.TileBan + "\n";
                rtbInfo.Text += "Doanh thu: " + doanhThu.DoanhThu + "\n";
                rtbInfo.Text += "Xếp hạng doanh thu: " + doanhThu.XepHang + "\n";

            }
        }
    }

}
