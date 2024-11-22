namespace WinFormsApp1
{
    partial class Server
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
            Rtbx_Output = new RichTextBox();
            Tbx_ListenPort = new TextBox();
            label1 = new Label();
            Btn_Listen = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            listView1 = new ListView();
            btnRandom = new Button();
            pictureBox = new PictureBox();
            MonAn = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            NguoiDung = new DataGridView();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MonAn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NguoiDung).BeginInit();
            SuspendLayout();
            // 
            // Rtbx_Output
            // 
            Rtbx_Output.Location = new Point(23, 78);
            Rtbx_Output.Name = "Rtbx_Output";
            Rtbx_Output.Size = new Size(158, 360);
            Rtbx_Output.TabIndex = 0;
            Rtbx_Output.Text = "";
            // 
            // Tbx_ListenPort
            // 
            Tbx_ListenPort.Location = new Point(23, 23);
            Tbx_ListenPort.Name = "Tbx_ListenPort";
            Tbx_ListenPort.Size = new Size(217, 27);
            Tbx_ListenPort.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(266, 26);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 2;
            label1.Text = "Listen Port";
            // 
            // Btn_Listen
            // 
            Btn_Listen.Location = new Point(439, 23);
            Btn_Listen.Name = "Btn_Listen";
            Btn_Listen.Size = new Size(94, 29);
            Btn_Listen.TabIndex = 3;
            Btn_Listen.Text = "Listen";
            Btn_Listen.UseVisualStyleBackColor = true;
            Btn_Listen.Click += Btn_Listen_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(220, 78);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(250, 360);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // listView1
            // 
            listView1.Location = new Point(503, 78);
            listView1.Name = "listView1";
            listView1.Size = new Size(393, 143);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnRandom
            // 
            btnRandom.Location = new Point(285, 571);
            btnRandom.Name = "btnRandom";
            btnRandom.Size = new Size(94, 29);
            btnRandom.TabIndex = 6;
            btnRandom.Text = "Random";
            btnRandom.UseVisualStyleBackColor = true;
            btnRandom.Click += btnRandom_Click;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(23, 480);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(261, 52);
            pictureBox.TabIndex = 7;
            pictureBox.TabStop = false;
            // 
            // MonAn
            // 
            MonAn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MonAn.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            MonAn.Location = new Point(503, 248);
            MonAn.Name = "MonAn";
            MonAn.RowHeadersWidth = 51;
            MonAn.Size = new Size(393, 153);
            MonAn.TabIndex = 8;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Column2";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Column3";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Column4";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // NguoiDung
            // 
            NguoiDung.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            NguoiDung.Columns.AddRange(new DataGridViewColumn[] { Column5, Column6, Column7 });
            NguoiDung.Location = new Point(503, 438);
            NguoiDung.Name = "NguoiDung";
            NguoiDung.RowHeadersWidth = 51;
            NguoiDung.Size = new Size(393, 162);
            NguoiDung.TabIndex = 9;
            // 
            // Column5
            // 
            Column5.HeaderText = "Column5";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Column6";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "Column7";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // Server
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 645);
            Controls.Add(NguoiDung);
            Controls.Add(MonAn);
            Controls.Add(pictureBox);
            Controls.Add(btnRandom);
            Controls.Add(listView1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(Btn_Listen);
            Controls.Add(label1);
            Controls.Add(Tbx_ListenPort);
            Controls.Add(Rtbx_Output);
            Name = "Server";
            Text = "Server";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)MonAn).EndInit();
            ((System.ComponentModel.ISupportInitialize)NguoiDung).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox Rtbx_Output;
        private TextBox Tbx_ListenPort;
        private Label label1;
        private Button Btn_Listen;
        private FlowLayoutPanel flowLayoutPanel1;
        private ListView listView1;
        private Button btnRandom;
        private PictureBox pictureBox;
        private DataGridView MonAn;
        private DataGridView NguoiDung;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}