namespace lab5_5
{
    partial class RandomDishCaNhan
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
            panel1 = new Panel();
            lbDongGop = new Label();
            label7 = new Label();
            lbDiaChi = new Label();
            lbGia = new Label();
            label4 = new Label();
            label3 = new Label();
            lbMonAn = new Label();
            pbHinhAnh = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbHinhAnh).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lbDongGop);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(lbDiaChi);
            panel1.Controls.Add(lbGia);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lbMonAn);
            panel1.Controls.Add(pbHinhAnh);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 132);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1052, 273);
            panel1.TabIndex = 3;
            // 
            // lbDongGop
            // 
            lbDongGop.AutoSize = true;
            lbDongGop.Location = new Point(862, 200);
            lbDongGop.Name = "lbDongGop";
            lbDongGop.Size = new Size(50, 20);
            lbDongGop.TabIndex = 7;
            lbDongGop.Text = "label8";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(678, 200);
            label7.Name = "label7";
            label7.Size = new Size(124, 20);
            label7.TabIndex = 6;
            label7.Text = "Người đóng góp:";
            // 
            // lbDiaChi
            // 
            lbDiaChi.AutoSize = true;
            lbDiaChi.Location = new Point(444, 200);
            lbDiaChi.Name = "lbDiaChi";
            lbDiaChi.Size = new Size(50, 20);
            lbDiaChi.TabIndex = 5;
            lbDiaChi.Text = "label6";
            // 
            // lbGia
            // 
            lbGia.AutoSize = true;
            lbGia.Location = new Point(444, 113);
            lbGia.Name = "lbGia";
            lbGia.Size = new Size(50, 20);
            lbGia.TabIndex = 4;
            lbGia.Text = "label5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(312, 200);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 3;
            label4.Text = "Địa chỉ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(312, 113);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 2;
            label3.Text = "Giá:";
            // 
            // lbMonAn
            // 
            lbMonAn.AutoSize = true;
            lbMonAn.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbMonAn.ForeColor = Color.Brown;
            lbMonAn.Location = new Point(312, 35);
            lbMonAn.Name = "lbMonAn";
            lbMonAn.Size = new Size(116, 36);
            lbMonAn.TabIndex = 1;
            lbMonAn.Text = "Món ăn";
            // 
            // pbHinhAnh
            // 
            pbHinhAnh.Location = new Point(3, 0);
            pbHinhAnh.Margin = new Padding(3, 4, 3, 4);
            pbHinhAnh.Name = "pbHinhAnh";
            pbHinhAnh.Size = new Size(267, 270);
            pbHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            pbHinhAnh.TabIndex = 0;
            pbHinhAnh.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(398, 43);
            label1.Name = "label1";
            label1.Size = new Size(327, 52);
            label1.TabIndex = 2;
            label1.Text = "Ăn món này đi!";
            // 
            // RandomDishCaNhan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 405);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "RandomDishCaNhan";
            Text = "RandomDishCaNhan";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbHinhAnh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lbDongGop;
        private Label label7;
        private Label lbDiaChi;
        private Label lbGia;
        private Label label4;
        private Label label3;
        private Label lbMonAn;
        private PictureBox pbHinhAnh;
        private Label label1;
    }
}