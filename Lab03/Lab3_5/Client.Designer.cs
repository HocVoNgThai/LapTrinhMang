namespace WinFormsApp1
{
    partial class Client
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
            Btn_Disconnect = new Button();
            Btn_Send = new Button();
            Tbx_Ip = new TextBox();
            label2 = new Label();
            Tbx_Port = new TextBox();
            label3 = new Label();
            Rtbx_Message = new RichTextBox();
            Btn_Connect = new Button();
            txtIDMA = new TextBox();
            label1 = new Label();
            txtTenMonAn = new TextBox();
            label4 = new Label();
            txtHinhAnh = new TextBox();
            txtIDNCC = new TextBox();
            txtHoVaTen = new TextBox();
            txtQuyenHan = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // Btn_Disconnect
            // 
            Btn_Disconnect.Location = new Point(59, 496);
            Btn_Disconnect.Name = "Btn_Disconnect";
            Btn_Disconnect.Size = new Size(94, 29);
            Btn_Disconnect.TabIndex = 0;
            Btn_Disconnect.Text = "Disconnect";
            Btn_Disconnect.UseVisualStyleBackColor = true;
            Btn_Disconnect.Click += Btn_Disconnect_Click;
            // 
            // Btn_Send
            // 
            Btn_Send.Location = new Point(566, 496);
            Btn_Send.Name = "Btn_Send";
            Btn_Send.Size = new Size(94, 29);
            Btn_Send.TabIndex = 1;
            Btn_Send.Text = "Send";
            Btn_Send.UseVisualStyleBackColor = true;
            Btn_Send.Click += Btn_Send_Click;
            // 
            // Tbx_Ip
            // 
            Tbx_Ip.Location = new Point(12, 15);
            Tbx_Ip.Name = "Tbx_Ip";
            Tbx_Ip.Size = new Size(141, 27);
            Tbx_Ip.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(193, 18);
            label2.Name = "label2";
            label2.Size = new Size(21, 20);
            label2.TabIndex = 5;
            label2.Text = "IP";
            // 
            // Tbx_Port
            // 
            Tbx_Port.Location = new Point(12, 79);
            Tbx_Port.Name = "Tbx_Port";
            Tbx_Port.Size = new Size(141, 27);
            Tbx_Port.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(193, 86);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 7;
            label3.Text = "Port";
            // 
            // Rtbx_Message
            // 
            Rtbx_Message.Location = new Point(12, 142);
            Rtbx_Message.Name = "Rtbx_Message";
            Rtbx_Message.Size = new Size(237, 214);
            Rtbx_Message.TabIndex = 8;
            Rtbx_Message.Text = "";
            // 
            // Btn_Connect
            // 
            Btn_Connect.Location = new Point(59, 413);
            Btn_Connect.Name = "Btn_Connect";
            Btn_Connect.Size = new Size(94, 29);
            Btn_Connect.TabIndex = 9;
            Btn_Connect.Text = "Connect";
            Btn_Connect.UseVisualStyleBackColor = true;
            Btn_Connect.Click += Btn_Connect_Click;
            // 
            // txtIDMA
            // 
            txtIDMA.Location = new Point(413, 58);
            txtIDMA.Name = "txtIDMA";
            txtIDMA.Size = new Size(156, 27);
            txtIDMA.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(629, 61);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 11;
            label1.Text = "ID Món ăn";
            // 
            // txtTenMonAn
            // 
            txtTenMonAn.Location = new Point(413, 123);
            txtTenMonAn.Name = "txtTenMonAn";
            txtTenMonAn.Size = new Size(156, 27);
            txtTenMonAn.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(629, 126);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 13;
            label4.Text = "Tên món ăn";
            // 
            // txtHinhAnh
            // 
            txtHinhAnh.Location = new Point(413, 197);
            txtHinhAnh.Name = "txtHinhAnh";
            txtHinhAnh.Size = new Size(156, 27);
            txtHinhAnh.TabIndex = 14;
            // 
            // txtIDNCC
            // 
            txtIDNCC.Location = new Point(413, 273);
            txtIDNCC.Name = "txtIDNCC";
            txtIDNCC.Size = new Size(156, 27);
            txtIDNCC.TabIndex = 15;
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Location = new Point(413, 351);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(156, 27);
            txtHoVaTen.TabIndex = 16;
            // 
            // txtQuyenHan
            // 
            txtQuyenHan.Location = new Point(413, 424);
            txtQuyenHan.Name = "txtQuyenHan";
            txtQuyenHan.Size = new Size(156, 27);
            txtQuyenHan.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(629, 200);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 18;
            label5.Text = "Hình ảnh";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(629, 276);
            label6.Name = "label6";
            label6.Size = new Size(131, 20);
            label6.TabIndex = 19;
            label6.Text = "ID người cung cấp";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(629, 354);
            label7.Name = "label7";
            label7.Size = new Size(73, 20);
            label7.TabIndex = 20;
            label7.Text = "Họ và tên";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(629, 427);
            label8.Name = "label8";
            label8.Size = new Size(79, 20);
            label8.TabIndex = 21;
            label8.Text = "Quyền hạn";
            // 
            // Client
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 558);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtQuyenHan);
            Controls.Add(txtHoVaTen);
            Controls.Add(txtIDNCC);
            Controls.Add(txtHinhAnh);
            Controls.Add(label4);
            Controls.Add(txtTenMonAn);
            Controls.Add(label1);
            Controls.Add(txtIDMA);
            Controls.Add(Btn_Connect);
            Controls.Add(Rtbx_Message);
            Controls.Add(label3);
            Controls.Add(Tbx_Port);
            Controls.Add(label2);
            Controls.Add(Tbx_Ip);
            Controls.Add(Btn_Send);
            Controls.Add(Btn_Disconnect);
            Name = "Client";
            Text = "Client";
            FormClosing += Client_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_Disconnect;
        private Button Btn_Send;
        private TextBox Tbx_Ip;
        private Label label2;
        private TextBox Tbx_Port;
        private Label label3;
        private RichTextBox Rtbx_Message;
        private Button Btn_Connect;
        private TextBox txtIDMA;
        private Label label1;
        private TextBox txtTenMonAn;
        private Label label4;
        private TextBox txtHinhAnh;
        private TextBox txtIDNCC;
        private TextBox txtHoVaTen;
        private TextBox txtQuyenHan;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}