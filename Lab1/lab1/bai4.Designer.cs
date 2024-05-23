namespace lab1
{
    partial class bai4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnDatVe = new Button();
            cbPhim = new ComboBox();
            groupBox1 = new GroupBox();
            checklstSoGhe = new CheckedListBox();
            lstThongTinVe = new ListBox();
            panel1 = new Panel();
            panel2 = new Panel();
            label5 = new Label();
            txtSdt = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cbPhongChieu = new ComboBox();
            txtHoTen = new TextBox();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnDatVe
            // 
            btnDatVe.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDatVe.Location = new Point(199, 335);
            btnDatVe.Name = "btnDatVe";
            btnDatVe.Size = new Size(94, 29);
            btnDatVe.TabIndex = 0;
            btnDatVe.Text = "Đặt vé";
            btnDatVe.UseVisualStyleBackColor = true;
            btnDatVe.Click += btnDatVe_Click;
            // 
            // cbPhim
            // 
            cbPhim.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cbPhim.FormattingEnabled = true;
            cbPhim.Items.AddRange(new object[] { "Đào, phở và piano", "Mai", "Gặp lại chị bầu", "Tarot" });
            cbPhim.Location = new Point(199, 92);
            cbPhim.Name = "cbPhim";
            cbPhim.Size = new Size(295, 27);
            cbPhim.TabIndex = 2;
            cbPhim.SelectedIndexChanged += cbPhim_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(192, 192, 255);
            groupBox1.Controls.Add(checklstSoGhe);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(339, 393);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chọn số ghế";
            // 
            // checklstSoGhe
            // 
            checklstSoGhe.BackColor = Color.FromArgb(192, 192, 255);
            checklstSoGhe.Dock = DockStyle.Fill;
            checklstSoGhe.FormattingEnabled = true;
            checklstSoGhe.Items.AddRange(new object[] { "A1", "A2", "A3", "A4", "A5", "B1", "B2", "B3", "B4", "B5", "C1", "C2", "C3", "C4", "C5" });
            checklstSoGhe.Location = new Point(3, 24);
            checklstSoGhe.Name = "checklstSoGhe";
            checklstSoGhe.Size = new Size(333, 366);
            checklstSoGhe.TabIndex = 13;
            // 
            // lstThongTinVe
            // 
            lstThongTinVe.BackColor = Color.FromArgb(192, 192, 255);
            lstThongTinVe.Dock = DockStyle.Bottom;
            lstThongTinVe.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lstThongTinVe.FormattingEnabled = true;
            lstThongTinVe.ItemHeight = 20;
            lstThongTinVe.Location = new Point(0, 393);
            lstThongTinVe.Name = "lstThongTinVe";
            lstThongTinVe.Size = new Size(896, 344);
            lstThongTinVe.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(557, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(339, 393);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 192, 255);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtSdt);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(cbPhongChieu);
            panel2.Controls.Add(txtHoTen);
            panel2.Controls.Add(btnDatVe);
            panel2.Controls.Add(cbPhim);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(559, 393);
            panel2.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(35, 285);
            label5.Name = "label5";
            label5.Size = new Size(105, 19);
            label5.TabIndex = 11;
            label5.Text = "Số điện thoại";
            // 
            // txtSdt
            // 
            txtSdt.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtSdt.Location = new Point(199, 277);
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(295, 27);
            txtSdt.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(129, 24);
            label4.Name = "label4";
            label4.Size = new Size(300, 32);
            label4.TabIndex = 9;
            label4.Text = "Quản lí thông tin đặt vé";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(35, 100);
            label3.Name = "label3";
            label3.Size = new Size(90, 19);
            label3.TabIndex = 8;
            label3.Text = "Chọn phim";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(35, 160);
            label2.Name = "label2";
            label2.Size = new Size(141, 19);
            label2.TabIndex = 7;
            label2.Text = "Chọn phòng chiếu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(35, 223);
            label1.Name = "label1";
            label1.Size = new Size(116, 19);
            label1.TabIndex = 6;
            label1.Text = "Nhập họ và tên";
            // 
            // cbPhongChieu
            // 
            cbPhongChieu.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cbPhongChieu.FormattingEnabled = true;
            cbPhongChieu.Location = new Point(199, 152);
            cbPhongChieu.Name = "cbPhongChieu";
            cbPhongChieu.Size = new Size(151, 27);
            cbPhongChieu.TabIndex = 5;
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtHoTen.Location = new Point(199, 215);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(295, 27);
            txtHoTen.TabIndex = 4;
            // 
            // bai4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 737);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lstThongTinVe);
            Name = "bai4";
            Text = "bai4";
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnDatVe;
        private CheckedListBox A1;
        private ComboBox cbPhim;
        private GroupBox groupBox1;
        private CheckedListBox C2;
        private CheckedListBox C3;
        private CheckedListBox checklstSoGhe;
        private CheckedListBox C4;
        private CheckedListBox C1;
        private CheckedListBox B3;
        private CheckedListBox B2;
        private CheckedListBox B4;
        private CheckedListBox B5;
        private CheckedListBox B1;
        private CheckedListBox A3;
        private CheckedListBox A5;
        private CheckedListBox A4;
        private CheckedListBox A2;
        private ListBox lstThongTinVe;
        private Panel panel1;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cbPhongChieu;
        private TextBox txtHoTen;
        private Label label4;
        private TextBox txtSdt;
        private Label label5;
    }
}