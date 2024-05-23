namespace lab1
{
    partial class bai5
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
            btnTinh = new Button();
            btnXoa = new Button();
            label1 = new Label();
            label2 = new Label();
            cbPhepTinh = new ComboBox();
            grKetQua = new GroupBox();
            lstKetQua = new ListBox();
            bthThoat = new Button();
            txtB = new TextBox();
            txtA = new TextBox();
            btnXoaHet = new Button();
            grKetQua.SuspendLayout();
            SuspendLayout();
            // 
            // btnTinh
            // 
            btnTinh.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnTinh.Location = new Point(137, 198);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(94, 35);
            btnTinh.TabIndex = 0;
            btnTinh.Text = "Tính";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += btnTinh_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.Location = new Point(300, 198);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(110, 35);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa kết quả";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(118, 55);
            label1.Name = "label1";
            label1.Size = new Size(61, 19);
            label1.TabIndex = 2;
            label1.Text = "Nhập A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(489, 55);
            label2.Name = "label2";
            label2.Size = new Size(63, 19);
            label2.TabIndex = 3;
            label2.Text = "Nhập B";
            // 
            // cbPhepTinh
            // 
            cbPhepTinh.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cbPhepTinh.FormattingEnabled = true;
            cbPhepTinh.Items.AddRange(new object[] { "Bảng cửu chương", "Tính toán giá trị" });
            cbPhepTinh.Location = new Point(376, 127);
            cbPhepTinh.Name = "cbPhepTinh";
            cbPhepTinh.Size = new Size(176, 27);
            cbPhepTinh.TabIndex = 5;
            // 
            // grKetQua
            // 
            grKetQua.BackColor = Color.Azure;
            grKetQua.Controls.Add(lstKetQua);
            grKetQua.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            grKetQua.Location = new Point(118, 277);
            grKetQua.Name = "grKetQua";
            grKetQua.Size = new Size(627, 342);
            grKetQua.TabIndex = 6;
            grKetQua.TabStop = false;
            grKetQua.Text = "Kết quả";
            // 
            // lstKetQua
            // 
            lstKetQua.Dock = DockStyle.Fill;
            lstKetQua.FormattingEnabled = true;
            lstKetQua.ItemHeight = 19;
            lstKetQua.Location = new Point(3, 23);
            lstKetQua.Name = "lstKetQua";
            lstKetQua.Size = new Size(621, 316);
            lstKetQua.TabIndex = 0;
            // 
            // bthThoat
            // 
            bthThoat.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            bthThoat.Location = new Point(630, 198);
            bthThoat.Name = "bthThoat";
            bthThoat.Size = new Size(94, 35);
            bthThoat.TabIndex = 7;
            bthThoat.Text = "Thoát";
            bthThoat.UseVisualStyleBackColor = true;
            bthThoat.Click += btnThoat_Click;
            // 
            // txtB
            // 
            txtB.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtB.Location = new Point(571, 47);
            txtB.Name = "txtB";
            txtB.Size = new Size(174, 27);
            txtB.TabIndex = 8;
            // 
            // txtA
            // 
            txtA.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtA.Location = new Point(199, 47);
            txtA.Name = "txtA";
            txtA.Size = new Size(174, 27);
            txtA.TabIndex = 9;
            // 
            // btnXoaHet
            // 
            btnXoaHet.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoaHet.Location = new Point(469, 198);
            btnXoaHet.Name = "btnXoaHet";
            btnXoaHet.Size = new Size(94, 35);
            btnXoaHet.TabIndex = 10;
            btnXoaHet.Text = "Xóa hết";
            btnXoaHet.UseVisualStyleBackColor = true;
            btnXoaHet.Click += btnXoaHet_Click;
            // 
            // bai5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(864, 651);
            Controls.Add(btnXoaHet);
            Controls.Add(txtA);
            Controls.Add(txtB);
            Controls.Add(bthThoat);
            Controls.Add(grKetQua);
            Controls.Add(cbPhepTinh);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnXoa);
            Controls.Add(btnTinh);
            ForeColor = SystemColors.ControlText;
            Name = "bai5";
            Text = "bai5";
            grKetQua.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Button btnTinh;
        private Button btnXoa;
        private Label label1;
        private Label label2;
        private ComboBox cbPhepTinh;
        private GroupBox grKetQua;
        private Button bthThoat;
        private TextBox txtB;
        private TextBox txtA;
        private ListBox lstKetQua;
        private Button btnXoaHet;
    }
}