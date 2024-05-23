using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab2
{
    partial class Bai5
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
            cbFilm = new ComboBox();
            label1 = new Label();
            A_1 = new CheckBox();
            label2 = new Label();
            A_2 = new CheckBox();
            A_3 = new CheckBox();
            A_4 = new CheckBox();
            A_5 = new CheckBox();
            label3 = new Label();
            label4 = new Label();
            B_1 = new CheckBox();
            B_2 = new CheckBox();
            B_3 = new CheckBox();
            B_4 = new CheckBox();
            B_5 = new CheckBox();
            C_1 = new CheckBox();
            C_2 = new CheckBox();
            C_3 = new CheckBox();
            C_4 = new CheckBox();
            C_5 = new CheckBox();
            btnDatVe = new Button();
            lbInfo = new Label();
            cbCine = new ComboBox();
            label6 = new Label();
            rtbInfo = new RichTextBox();
            btnXemInfo = new Button();
            txtName = new TextBox();
            label5 = new Label();
            btnConfirm = new Button();
            rtbDatVe = new RichTextBox();
            SuspendLayout();
            // 
            // cbFilm
            // 
            cbFilm.FormattingEnabled = true;
            cbFilm.Items.AddRange(new object[] { "Phim A", "Phim B", "Phim C", "Phim D" });
            cbFilm.Location = new Point(143, 16);
            cbFilm.Margin = new Padding(4);
            cbFilm.Name = "cbFilm";
            cbFilm.Size = new Size(252, 28);
            cbFilm.TabIndex = 0;
            cbFilm.SelectionChangeCommitted += Bai5_Load;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 24);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 1;
            label1.Text = "Chọn Phim";
            // 
            // A_1
            // 
            A_1.AutoSize = true;
            A_1.BackColor = Color.Yellow;
            A_1.CheckAlign = ContentAlignment.MiddleCenter;
            A_1.Enabled = false;
            A_1.Location = new Point(157, 99);
            A_1.Margin = new Padding(4);
            A_1.Name = "A_1";
            A_1.Size = new Size(22, 24);
            A_1.TabIndex = 2;
            A_1.TabStop = false;
            A_1.Text = "1";
            A_1.TextAlign = ContentAlignment.MiddleCenter;
            A_1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 100);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(22, 20);
            label2.TabIndex = 3;
            label2.Text = "A";
            // 
            // A_2
            // 
            A_2.AutoSize = true;
            A_2.BackColor = Color.Yellow;
            A_2.CheckAlign = ContentAlignment.MiddleCenter;
            A_2.Enabled = false;
            A_2.Location = new Point(210, 99);
            A_2.Margin = new Padding(4);
            A_2.Name = "A_2";
            A_2.Size = new Size(22, 24);
            A_2.TabIndex = 2;
            A_2.TabStop = false;
            A_2.Text = "2";
            A_2.UseVisualStyleBackColor = false;
            // 
            // A_3
            // 
            A_3.AutoSize = true;
            A_3.BackColor = Color.Yellow;
            A_3.CheckAlign = ContentAlignment.MiddleCenter;
            A_3.Enabled = false;
            A_3.Location = new Point(265, 99);
            A_3.Margin = new Padding(4);
            A_3.Name = "A_3";
            A_3.Size = new Size(22, 24);
            A_3.TabIndex = 2;
            A_3.TabStop = false;
            A_3.Text = "3";
            A_3.UseVisualStyleBackColor = false;
            // 
            // A_4
            // 
            A_4.AutoSize = true;
            A_4.BackColor = Color.Yellow;
            A_4.CheckAlign = ContentAlignment.MiddleCenter;
            A_4.Enabled = false;
            A_4.Location = new Point(316, 99);
            A_4.Margin = new Padding(4);
            A_4.Name = "A_4";
            A_4.Size = new Size(22, 24);
            A_4.TabIndex = 2;
            A_4.TabStop = false;
            A_4.Text = "4";
            A_4.UseVisualStyleBackColor = false;
            // 
            // A_5
            // 
            A_5.AutoSize = true;
            A_5.BackColor = Color.Yellow;
            A_5.CheckAlign = ContentAlignment.MiddleCenter;
            A_5.Enabled = false;
            A_5.Location = new Point(367, 99);
            A_5.Margin = new Padding(4);
            A_5.Name = "A_5";
            A_5.Size = new Size(22, 24);
            A_5.TabIndex = 2;
            A_5.TabStop = false;
            A_5.Text = "5";
            A_5.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(104, 132);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(21, 20);
            label3.TabIndex = 3;
            label3.Text = "B";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(104, 168);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(22, 20);
            label4.TabIndex = 3;
            label4.Text = "C";
            // 
            // B_1
            // 
            B_1.AutoSize = true;
            B_1.BackColor = Color.Yellow;
            B_1.CheckAlign = ContentAlignment.MiddleCenter;
            B_1.Enabled = false;
            B_1.Location = new Point(157, 131);
            B_1.Margin = new Padding(4);
            B_1.Name = "B_1";
            B_1.Size = new Size(22, 24);
            B_1.TabIndex = 2;
            B_1.TabStop = false;
            B_1.Text = "1";
            B_1.UseVisualStyleBackColor = false;
            // 
            // B_2
            // 
            B_2.AutoSize = true;
            B_2.BackColor = Color.Yellow;
            B_2.CheckAlign = ContentAlignment.MiddleCenter;
            B_2.Enabled = false;
            B_2.Location = new Point(210, 131);
            B_2.Margin = new Padding(4);
            B_2.Name = "B_2";
            B_2.Size = new Size(22, 24);
            B_2.TabIndex = 2;
            B_2.TabStop = false;
            B_2.Text = "2";
            B_2.UseVisualStyleBackColor = false;
            // 
            // B_3
            // 
            B_3.AutoSize = true;
            B_3.BackColor = Color.Yellow;
            B_3.CheckAlign = ContentAlignment.MiddleCenter;
            B_3.Enabled = false;
            B_3.Location = new Point(265, 131);
            B_3.Margin = new Padding(4);
            B_3.Name = "B_3";
            B_3.Size = new Size(22, 24);
            B_3.TabIndex = 2;
            B_3.TabStop = false;
            B_3.Text = "3";
            B_3.UseVisualStyleBackColor = false;
            // 
            // B_4
            // 
            B_4.AutoSize = true;
            B_4.BackColor = Color.Yellow;
            B_4.CheckAlign = ContentAlignment.MiddleCenter;
            B_4.Enabled = false;
            B_4.Location = new Point(316, 131);
            B_4.Margin = new Padding(4);
            B_4.Name = "B_4";
            B_4.Size = new Size(22, 24);
            B_4.TabIndex = 2;
            B_4.TabStop = false;
            B_4.Text = "4";
            B_4.UseVisualStyleBackColor = false;
            // 
            // B_5
            // 
            B_5.AutoSize = true;
            B_5.BackColor = Color.Yellow;
            B_5.CheckAlign = ContentAlignment.MiddleCenter;
            B_5.Enabled = false;
            B_5.Location = new Point(367, 131);
            B_5.Margin = new Padding(4);
            B_5.Name = "B_5";
            B_5.Size = new Size(22, 24);
            B_5.TabIndex = 2;
            B_5.TabStop = false;
            B_5.Text = "5";
            B_5.UseVisualStyleBackColor = false;
            // 
            // C_1
            // 
            C_1.AutoSize = true;
            C_1.BackColor = Color.Yellow;
            C_1.CheckAlign = ContentAlignment.MiddleCenter;
            C_1.Enabled = false;
            C_1.Location = new Point(157, 167);
            C_1.Margin = new Padding(4);
            C_1.Name = "C_1";
            C_1.Size = new Size(22, 24);
            C_1.TabIndex = 2;
            C_1.TabStop = false;
            C_1.Text = "1";
            C_1.UseVisualStyleBackColor = false;
            // 
            // C_2
            // 
            C_2.AutoSize = true;
            C_2.BackColor = Color.Yellow;
            C_2.CheckAlign = ContentAlignment.MiddleCenter;
            C_2.Enabled = false;
            C_2.Location = new Point(210, 167);
            C_2.Margin = new Padding(4);
            C_2.Name = "C_2";
            C_2.Size = new Size(22, 24);
            C_2.TabIndex = 2;
            C_2.TabStop = false;
            C_2.Text = "2";
            C_2.UseVisualStyleBackColor = false;
            // 
            // C_3
            // 
            C_3.AutoSize = true;
            C_3.BackColor = Color.Yellow;
            C_3.CheckAlign = ContentAlignment.MiddleCenter;
            C_3.Enabled = false;
            C_3.Location = new Point(265, 167);
            C_3.Margin = new Padding(4);
            C_3.Name = "C_3";
            C_3.Size = new Size(22, 24);
            C_3.TabIndex = 2;
            C_3.TabStop = false;
            C_3.Text = "3";
            C_3.UseVisualStyleBackColor = false;
            // 
            // C_4
            // 
            C_4.AutoSize = true;
            C_4.BackColor = Color.Yellow;
            C_4.CheckAlign = ContentAlignment.MiddleCenter;
            C_4.Enabled = false;
            C_4.Location = new Point(316, 167);
            C_4.Margin = new Padding(4);
            C_4.Name = "C_4";
            C_4.Size = new Size(22, 24);
            C_4.TabIndex = 2;
            C_4.TabStop = false;
            C_4.Text = "4";
            C_4.UseVisualStyleBackColor = false;
            // 
            // C_5
            // 
            C_5.AutoSize = true;
            C_5.BackColor = Color.Yellow;
            C_5.CheckAlign = ContentAlignment.MiddleCenter;
            C_5.Enabled = false;
            C_5.Location = new Point(367, 167);
            C_5.Margin = new Padding(4);
            C_5.Name = "C_5";
            C_5.Size = new Size(22, 24);
            C_5.TabIndex = 2;
            C_5.TabStop = false;
            C_5.Text = "5";
            C_5.UseVisualStyleBackColor = false;
            // 
            // btnDatVe
            // 
            btnDatVe.BackColor = Color.FromArgb(192, 192, 255);
            btnDatVe.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnDatVe.Location = new Point(19, 327);
            btnDatVe.Margin = new Padding(4);
            btnDatVe.Name = "btnDatVe";
            btnDatVe.Size = new Size(275, 71);
            btnDatVe.TabIndex = 4;
            btnDatVe.Text = "Đặt vé";
            btnDatVe.UseVisualStyleBackColor = false;
            btnDatVe.Click += btnDatVe_Click;
            // 
            // lbInfo
            // 
            lbInfo.AutoSize = true;
            lbInfo.Location = new Point(19, 287);
            lbInfo.Margin = new Padding(4, 0, 4, 0);
            lbInfo.Name = "lbInfo";
            lbInfo.Size = new Size(0, 20);
            lbInfo.TabIndex = 5;
            // 
            // cbCine
            // 
            cbCine.FormattingEnabled = true;
            cbCine.Location = new Point(143, 55);
            cbCine.Margin = new Padding(4);
            cbCine.Name = "cbCine";
            cbCine.Size = new Size(252, 28);
            cbCine.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 59);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(106, 20);
            label6.TabIndex = 1;
            label6.Text = "Chọn Phòng";
            // 
            // rtbInfo
            // 
            rtbInfo.Dock = DockStyle.Right;
            rtbInfo.Location = new Point(707, 0);
            rtbInfo.Margin = new Padding(4, 3, 4, 3);
            rtbInfo.Name = "rtbInfo";
            rtbInfo.ReadOnly = true;
            rtbInfo.Size = new Size(518, 747);
            rtbInfo.TabIndex = 6;
            rtbInfo.Text = "";
            // 
            // btnXemInfo
            // 
            btnXemInfo.BackColor = Color.FromArgb(192, 192, 255);
            btnXemInfo.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnXemInfo.Location = new Point(386, 327);
            btnXemInfo.Margin = new Padding(4, 3, 4, 3);
            btnXemInfo.Name = "btnXemInfo";
            btnXemInfo.Size = new Size(275, 71);
            btnXemInfo.TabIndex = 7;
            btnXemInfo.Text = "Xem thông tin";
            btnXemInfo.UseVisualStyleBackColor = false;
            btnXemInfo.Click += btnXemInfo_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(143, 218);
            txtName.Margin = new Padding(4, 3, 4, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(252, 28);
            txtName.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 226);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 9;
            label5.Text = "Họ và tên";
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(192, 192, 255);
            btnConfirm.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirm.Location = new Point(449, 16);
            btnConfirm.Margin = new Padding(4, 3, 4, 3);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(212, 67);
            btnConfirm.TabIndex = 10;
            btnConfirm.Text = "Xác nhận chọn";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // rtbDatVe
            // 
            rtbDatVe.Location = new Point(-1, 452);
            rtbDatVe.Margin = new Padding(4, 3, 4, 3);
            rtbDatVe.Name = "rtbDatVe";
            rtbDatVe.ReadOnly = true;
            rtbDatVe.Size = new Size(704, 295);
            rtbDatVe.TabIndex = 11;
            rtbDatVe.Text = "";
            // 
            // Bai5
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1225, 747);
            Controls.Add(rtbDatVe);
            Controls.Add(btnConfirm);
            Controls.Add(label5);
            Controls.Add(txtName);
            Controls.Add(btnXemInfo);
            Controls.Add(rtbInfo);
            Controls.Add(lbInfo);
            Controls.Add(btnDatVe);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(C_5);
            Controls.Add(C_4);
            Controls.Add(B_5);
            Controls.Add(B_4);
            Controls.Add(C_3);
            Controls.Add(A_5);
            Controls.Add(B_3);
            Controls.Add(C_2);
            Controls.Add(A_4);
            Controls.Add(B_2);
            Controls.Add(C_1);
            Controls.Add(A_3);
            Controls.Add(B_1);
            Controls.Add(A_2);
            Controls.Add(A_1);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(cbCine);
            Controls.Add(cbFilm);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Bai5";
            Text = "Bai5";
            Load += Bai5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbFilm;
        private Label label1;
        private CheckBox A_1;
        private Label label2;
        private CheckBox A_2;
        private CheckBox A_3;
        private CheckBox A_4;
        private CheckBox A_5;
        private Label label3;
        private Label label4;
        private CheckBox B_1;
        private CheckBox B_2;
        private CheckBox B_3;
        private CheckBox B_4;
        private CheckBox B_5;
        private CheckBox C_1;
        private CheckBox C_2;
        private CheckBox C_3;
        private CheckBox C_4;
        private CheckBox C_5;
        private Button btnDatVe;
        private Label lbInfo;
        private ComboBox cbCine;
        private Label label6;
        private RichTextBox rtbInfo;
        private Button btnXemInfo;
        private TextBox txtName;
        private Label label5;
        private Button btnConfirm;
        private RichTextBox rtbDatVe;
    }
}