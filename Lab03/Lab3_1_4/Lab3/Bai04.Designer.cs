namespace Lab3
{
    partial class Bai04
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
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_NewClient = new System.Windows.Forms.Button();
            this.STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ticket = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Movie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Theater = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bill = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListView_Bought_Ticket = new System.Windows.Forms.ListView();
            this.Btn_ResetData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server is on";
            // 
            // Btn_NewClient
            // 
            this.Btn_NewClient.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_NewClient.Location = new System.Drawing.Point(871, 13);
            this.Btn_NewClient.Name = "Btn_NewClient";
            this.Btn_NewClient.Size = new System.Drawing.Size(150, 35);
            this.Btn_NewClient.TabIndex = 1;
            this.Btn_NewClient.Text = "New Client";
            this.Btn_NewClient.UseVisualStyleBackColor = true;
            this.Btn_NewClient.Click += new System.EventHandler(this.Btn_NewClient_Click);
            // 
            // STT
            // 
            this.STT.Text = "STT";
            // 
            // FullName
            // 
            this.FullName.Text = "Họ và Tên";
            this.FullName.Width = 350;
            // 
            // Ticket
            // 
            this.Ticket.Text = "Vé";
            this.Ticket.Width = 150;
            // 
            // Movie
            // 
            this.Movie.Text = "Phim";
            this.Movie.Width = 200;
            // 
            // Theater
            // 
            this.Theater.Text = "Phòng chiếu";
            this.Theater.Width = 100;
            // 
            // Bill
            // 
            this.Bill.Text = "Hóa đơn(Việt Nam Đồng)";
            this.Bill.Width = 200;
            // 
            // ListView_Bought_Ticket
            // 
            this.ListView_Bought_Ticket.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.FullName,
            this.Ticket,
            this.Movie,
            this.Theater,
            this.Bill});
            this.ListView_Bought_Ticket.HideSelection = false;
            this.ListView_Bought_Ticket.Location = new System.Drawing.Point(12, 54);
            this.ListView_Bought_Ticket.Name = "ListView_Bought_Ticket";
            this.ListView_Bought_Ticket.Size = new System.Drawing.Size(1009, 482);
            this.ListView_Bought_Ticket.TabIndex = 2;
            this.ListView_Bought_Ticket.UseCompatibleStateImageBehavior = false;
            this.ListView_Bought_Ticket.View = System.Windows.Forms.View.Details;
            this.ListView_Bought_Ticket.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Btn_ResetData
            // 
            this.Btn_ResetData.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ResetData.Location = new System.Drawing.Point(715, 13);
            this.Btn_ResetData.Name = "Btn_ResetData";
            this.Btn_ResetData.Size = new System.Drawing.Size(150, 35);
            this.Btn_ResetData.TabIndex = 3;
            this.Btn_ResetData.Text = "Reset data";
            this.Btn_ResetData.UseVisualStyleBackColor = true;
            this.Btn_ResetData.Click += new System.EventHandler(this.Btn_ResetData_Click);
            // 
            // Bai04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 548);
            this.Controls.Add(this.Btn_ResetData);
            this.Controls.Add(this.ListView_Bought_Ticket);
            this.Controls.Add(this.Btn_NewClient);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Bai04";
            this.Text = "Bài 04 - Quản lí phóng vé v3.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bai03_Server_FormClosing);
            this.Load += new System.EventHandler(this.Bai04_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_NewClient;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader FullName;
        private System.Windows.Forms.ColumnHeader Ticket;
        private System.Windows.Forms.ColumnHeader Movie;
        private System.Windows.Forms.ColumnHeader Theater;
        private System.Windows.Forms.ColumnHeader Bill;
        private System.Windows.Forms.ListView ListView_Bought_Ticket;
        private System.Windows.Forms.Button Btn_ResetData;
    }
}