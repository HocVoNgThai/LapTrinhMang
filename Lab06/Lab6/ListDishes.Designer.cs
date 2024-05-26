namespace lab5_5
{
    partial class ListDishes
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
            lbAuth = new Label();
            panel1 = new Panel();
            btnConfigMail = new Button();
            lbMail = new Label();
            btnGo = new Button();
            txtGoPage = new TextBox();
            btnBack = new Button();
            btnNext = new Button();
            btnRandom = new Button();
            btnCreate = new Button();
            lbCurrentPage = new Label();
            label1 = new Label();
            panel2 = new Panel();
            lbTotalMy = new Label();
            lbTotalAll = new Label();
            tabControl1 = new TabControl();
            tbpAll = new TabPage();
            panelShowAll = new Panel();
            tbpMy = new TabPage();
            pnShowMy = new Panel();
            lbLogOut = new Label();
            label38 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            tbpAll.SuspendLayout();
            tbpMy.SuspendLayout();
            SuspendLayout();
            // 
            // lbAuth
            // 
            lbAuth.AutoSize = true;
            lbAuth.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbAuth.ForeColor = Color.Green;
            lbAuth.Location = new Point(100, 861);
            lbAuth.Name = "lbAuth";
            lbAuth.Size = new Size(124, 22);
            lbAuth.TabIndex = 1;
            lbAuth.Text = "Authentication";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnConfigMail);
            panel1.Controls.Add(lbMail);
            panel1.Controls.Add(btnGo);
            panel1.Controls.Add(txtGoPage);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(btnNext);
            panel1.Controls.Add(btnRandom);
            panel1.Controls.Add(btnCreate);
            panel1.Controls.Add(lbCurrentPage);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(989, 856);
            panel1.TabIndex = 2;
            // 
            // btnConfigMail
            // 
            btnConfigMail.BackColor = Color.FromArgb(224, 224, 224);
            btnConfigMail.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfigMail.ForeColor = Color.FromArgb(128, 128, 255);
            btnConfigMail.Location = new Point(479, 12);
            btnConfigMail.Name = "btnConfigMail";
            btnConfigMail.Size = new Size(172, 46);
            btnConfigMail.TabIndex = 10;
            btnConfigMail.Text = "Config mail";
            btnConfigMail.UseVisualStyleBackColor = false;
            btnConfigMail.Click += btnConfigMail_Click;
            // 
            // lbMail
            // 
            lbMail.AutoSize = true;
            lbMail.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbMail.ForeColor = Color.FromArgb(192, 0, 0);
            lbMail.Location = new Point(723, 22);
            lbMail.Name = "lbMail";
            lbMail.Size = new Size(118, 28);
            lbMail.TabIndex = 9;
            lbMail.Text = "Loading...";
            lbMail.Click += lbMail_Click_1;
            // 
            // btnGo
            // 
            btnGo.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnGo.Location = new Point(301, 129);
            btnGo.Name = "btnGo";
            btnGo.Size = new Size(53, 29);
            btnGo.TabIndex = 8;
            btnGo.Text = "Tới";
            btnGo.UseVisualStyleBackColor = true;
            btnGo.Click += btnGo_Click;
            // 
            // txtGoPage
            // 
            txtGoPage.Location = new Point(240, 130);
            txtGoPage.Name = "txtGoPage";
            txtGoPage.Size = new Size(42, 27);
            txtGoPage.TabIndex = 7;
            txtGoPage.KeyDown += KeyEnter;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.Location = new Point(12, 128);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(73, 29);
            btnBack.TabIndex = 6;
            btnBack.Text = "Trước";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnNext.Location = new Point(146, 128);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(73, 29);
            btnNext.TabIndex = 5;
            btnNext.Text = "Sau";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnRandom
            // 
            btnRandom.BackColor = Color.FromArgb(255, 192, 128);
            btnRandom.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnRandom.ForeColor = Color.FromArgb(128, 64, 64);
            btnRandom.Location = new Point(479, 70);
            btnRandom.Name = "btnRandom";
            btnRandom.Size = new Size(172, 78);
            btnRandom.TabIndex = 4;
            btnRandom.Text = "Chọn món";
            btnRandom.UseVisualStyleBackColor = false;
            btnRandom.Click += btnRandom_Click;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(255, 192, 192);
            btnCreate.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreate.ForeColor = Color.Maroon;
            btnCreate.Location = new Point(723, 70);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(172, 78);
            btnCreate.TabIndex = 3;
            btnCreate.Text = "Thêm món";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // lbCurrentPage
            // 
            lbCurrentPage.AutoSize = true;
            lbCurrentPage.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbCurrentPage.Location = new Point(100, 134);
            lbCurrentPage.Name = "lbCurrentPage";
            lbCurrentPage.Size = new Size(22, 23);
            lbCurrentPage.TabIndex = 3;
            lbCurrentPage.Text = "1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(329, 52);
            label1.TabIndex = 2;
            label1.Text = "Hôm nay ăn gì?";
            // 
            // panel2
            // 
            panel2.Controls.Add(lbTotalMy);
            panel2.Controls.Add(lbTotalAll);
            panel2.Controls.Add(tabControl1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 164);
            panel2.Name = "panel2";
            panel2.Size = new Size(989, 692);
            panel2.TabIndex = 1;
            // 
            // lbTotalMy
            // 
            lbTotalMy.AutoSize = true;
            lbTotalMy.Location = new Point(242, 15);
            lbTotalMy.Name = "lbTotalMy";
            lbTotalMy.Size = new Size(53, 20);
            lbTotalMy.TabIndex = 2;
            lbTotalMy.Text = "label5";
            // 
            // lbTotalAll
            // 
            lbTotalAll.AutoSize = true;
            lbTotalAll.Location = new Point(7, 15);
            lbTotalAll.Name = "lbTotalAll";
            lbTotalAll.Size = new Size(53, 20);
            lbTotalAll.TabIndex = 1;
            lbTotalAll.Text = "label4";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tbpAll);
            tabControl1.Controls.Add(tbpMy);
            tabControl1.Location = new Point(0, 44);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(989, 624);
            tabControl1.TabIndex = 0;
            tabControl1.KeyDown += KeyHandle;
            // 
            // tbpAll
            // 
            tbpAll.AutoScroll = true;
            tbpAll.Controls.Add(panelShowAll);
            tbpAll.Location = new Point(4, 29);
            tbpAll.Margin = new Padding(3, 4, 3, 4);
            tbpAll.Name = "tbpAll";
            tbpAll.Padding = new Padding(3, 4, 3, 4);
            tbpAll.Size = new Size(981, 591);
            tbpAll.TabIndex = 0;
            tbpAll.Text = "All";
            tbpAll.UseVisualStyleBackColor = true;
            // 
            // panelShowAll
            // 
            panelShowAll.AutoScroll = true;
            panelShowAll.Dock = DockStyle.Fill;
            panelShowAll.Location = new Point(3, 4);
            panelShowAll.Name = "panelShowAll";
            panelShowAll.Size = new Size(975, 583);
            panelShowAll.TabIndex = 1;
            // 
            // tbpMy
            // 
            tbpMy.Controls.Add(pnShowMy);
            tbpMy.Location = new Point(4, 29);
            tbpMy.Margin = new Padding(3, 4, 3, 4);
            tbpMy.Name = "tbpMy";
            tbpMy.Padding = new Padding(3, 4, 3, 4);
            tbpMy.Size = new Size(981, 591);
            tbpMy.TabIndex = 1;
            tbpMy.Text = "My";
            tbpMy.UseVisualStyleBackColor = true;
            // 
            // pnShowMy
            // 
            pnShowMy.AutoScroll = true;
            pnShowMy.Dock = DockStyle.Fill;
            pnShowMy.Location = new Point(3, 4);
            pnShowMy.Name = "pnShowMy";
            pnShowMy.Size = new Size(975, 583);
            pnShowMy.TabIndex = 0;
            // 
            // lbLogOut
            // 
            lbLogOut.AutoSize = true;
            lbLogOut.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbLogOut.ForeColor = Color.Blue;
            lbLogOut.Location = new Point(12, 861);
            lbLogOut.Name = "lbLogOut";
            lbLogOut.Size = new Size(65, 22);
            lbLogOut.TabIndex = 3;
            lbLogOut.Text = "Logout";
            lbLogOut.Click += lbLogOut_Click;
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label38.Location = new Point(83, 861);
            label38.Name = "label38";
            label38.Size = new Size(16, 21);
            label38.TabIndex = 4;
            label38.Text = "|";
            // 
            // ListDishes
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 897);
            Controls.Add(label38);
            Controls.Add(lbLogOut);
            Controls.Add(panel1);
            Controls.Add(lbAuth);
            Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "ListDishes";
            Text = "ListDishes";
            FormClosing += ListDishes_FormClosing;
            Load += ListDishes_Load;
            KeyDown += KeyLoading;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabControl1.ResumeLayout(false);
            tbpAll.ResumeLayout(false);
            tbpMy.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbCurrentPage;
        private Label lbAuth;
        private Panel panel1;
        private Button btnRandom;
        private Button btnCreate;
        private Label label1;
        private Panel panel2;
        private TabPage tabPage2;
        private Button btnBack;
        private ListView lstMonAn;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Button btnGo;
        private TextBox txtGoPage;
        private Button btnNext;
        private Label lbLogOut;
        private Label label38;
        private Label lbTotalMy;
        private Label lbTotalAll;
        private Label lbMail;
        private Button btnConfigMail;
        private TabControl tabControl1;
        private TabPage tbpMy;
        private Panel pnShowMy;
        private TabPage tbpAll;
        private Panel panelShowAll;
    }
}