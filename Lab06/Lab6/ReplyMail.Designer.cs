namespace Lab6
{
    partial class ReplyMail
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
            lbMonAn = new Label();
            pbHinhAnh = new PictureBox();
            richTextBox1 = new RichTextBox();
            Btn_Send = new Button();
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
            panel1.Controls.Add(lbMonAn);
            panel1.Controls.Add(pbHinhAnh);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1198, 273);
            panel1.TabIndex = 6;
            // 
            // lbDongGop
            // 
            lbDongGop.AutoSize = true;
            lbDongGop.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbDongGop.Location = new Point(757, 200);
            lbDongGop.Name = "lbDongGop";
            lbDongGop.Size = new Size(53, 20);
            lbDongGop.TabIndex = 7;
            lbDongGop.Text = "label8";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(664, 200);
            label7.Name = "label7";
            label7.Size = new Size(87, 20);
            label7.TabIndex = 6;
            label7.Text = "Người gửi:";
            // 
            // lbDiaChi
            // 
            lbDiaChi.AutoSize = true;
            lbDiaChi.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbDiaChi.Location = new Point(312, 200);
            lbDiaChi.Name = "lbDiaChi";
            lbDiaChi.Size = new Size(53, 20);
            lbDiaChi.TabIndex = 5;
            lbDiaChi.Text = "label6";
            // 
            // lbGia
            // 
            lbGia.AutoSize = true;
            lbGia.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbGia.Location = new Point(312, 115);
            lbGia.Name = "lbGia";
            lbGia.Size = new Size(53, 20);
            lbGia.TabIndex = 4;
            lbGia.Text = "label5";
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
            pbHinhAnh.Location = new Point(0, 0);
            pbHinhAnh.Margin = new Padding(3, 4, 3, 4);
            pbHinhAnh.Name = "pbHinhAnh";
            pbHinhAnh.Size = new Size(283, 273);
            pbHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            pbHinhAnh.TabIndex = 0;
            pbHinhAnh.TabStop = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(0, 271);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1197, 312);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = "";
            // 
            // Btn_Send
            // 
            Btn_Send.BackColor = Color.FromArgb(255, 192, 128);
            Btn_Send.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Send.ForeColor = Color.FromArgb(128, 64, 0);
            Btn_Send.Location = new Point(1042, 591);
            Btn_Send.Margin = new Padding(3, 4, 3, 4);
            Btn_Send.Name = "Btn_Send";
            Btn_Send.Size = new Size(122, 56);
            Btn_Send.TabIndex = 9;
            Btn_Send.Text = "Reply";
            Btn_Send.UseVisualStyleBackColor = false;
            Btn_Send.Click += Btn_Send_Click;
            // 
            // ReplyMail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1198, 670);
            Controls.Add(Btn_Send);
            Controls.Add(richTextBox1);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ReplyMail";
            Text = "ReplyMail";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbHinhAnh).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lbDongGop;
        private Label label7;
        private Label lbDiaChi;
        private Label lbGia;
        private Label lbMonAn;
        private PictureBox pbHinhAnh;
        private RichTextBox richTextBox1;
        private Button Btn_Send;
    }
}