namespace Lab5
{
    partial class Bai04_Rapchieuphim
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
            this.CBx_Movie = new System.Windows.Forms.ComboBox();
            this.CBx_Theater = new System.Windows.Forms.ComboBox();
            this.Label_Movie = new System.Windows.Forms.Label();
            this.Label_Theater = new System.Windows.Forms.Label();
            this.Btn_Buy = new System.Windows.Forms.Button();
            this.GrBx_Ticket = new System.Windows.Forms.GroupBox();
            this.Label_Screen = new System.Windows.Forms.Label();
            this.Label_Cus_Name = new System.Windows.Forms.Label();
            this.TBx_Customer = new System.Windows.Forms.TextBox();
            this.ListView_Bought_Ticket = new System.Windows.Forms.ListView();
            this.IDx_Customer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IDx_Customer_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IDx_Ticket_Seat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IDx_Movie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IDx_Theater = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IDx_Bill = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Btn_Export = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Tbx_Customer_Email = new System.Windows.Forms.TextBox();
            this.GrBx_Ticket.SuspendLayout();
            this.SuspendLayout();
            // 
            // CBx_Movie
            // 
            this.CBx_Movie.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBx_Movie.FormattingEnabled = true;
            this.CBx_Movie.Location = new System.Drawing.Point(57, 56);
            this.CBx_Movie.Name = "CBx_Movie";
            this.CBx_Movie.Size = new System.Drawing.Size(292, 25);
            this.CBx_Movie.TabIndex = 0;
            this.CBx_Movie.SelectedIndexChanged += new System.EventHandler(this.CBx_Movie_SelectedIndexChanged);
            // 
            // CBx_Theater
            // 
            this.CBx_Theater.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBx_Theater.FormattingEnabled = true;
            this.CBx_Theater.Location = new System.Drawing.Point(481, 56);
            this.CBx_Theater.Name = "CBx_Theater";
            this.CBx_Theater.Size = new System.Drawing.Size(228, 25);
            this.CBx_Theater.TabIndex = 1;
            this.CBx_Theater.SelectedIndexChanged += new System.EventHandler(this.CBx_Theater_SelectedIndexChanged);
            // 
            // Label_Movie
            // 
            this.Label_Movie.AutoSize = true;
            this.Label_Movie.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Movie.Location = new System.Drawing.Point(53, 32);
            this.Label_Movie.Name = "Label_Movie";
            this.Label_Movie.Size = new System.Drawing.Size(89, 21);
            this.Label_Movie.TabIndex = 2;
            this.Label_Movie.Text = "Chọn phim";
            // 
            // Label_Theater
            // 
            this.Label_Theater.AutoSize = true;
            this.Label_Theater.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Theater.Location = new System.Drawing.Point(477, 32);
            this.Label_Theater.Name = "Label_Theater";
            this.Label_Theater.Size = new System.Drawing.Size(143, 21);
            this.Label_Theater.TabIndex = 3;
            this.Label_Theater.Text = "Chọn phòng chiếu";
            // 
            // Btn_Buy
            // 
            this.Btn_Buy.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Buy.Location = new System.Drawing.Point(686, 366);
            this.Btn_Buy.Name = "Btn_Buy";
            this.Btn_Buy.Size = new System.Drawing.Size(97, 45);
            this.Btn_Buy.TabIndex = 4;
            this.Btn_Buy.Text = "Mua vé";
            this.Btn_Buy.UseVisualStyleBackColor = true;
            this.Btn_Buy.Click += new System.EventHandler(this.Btn_Buy_Click);
            // 
            // GrBx_Ticket
            // 
            this.GrBx_Ticket.Controls.Add(this.Label_Screen);
            this.GrBx_Ticket.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrBx_Ticket.Location = new System.Drawing.Point(163, 106);
            this.GrBx_Ticket.Name = "GrBx_Ticket";
            this.GrBx_Ticket.Size = new System.Drawing.Size(482, 236);
            this.GrBx_Ticket.TabIndex = 5;
            this.GrBx_Ticket.TabStop = false;
            this.GrBx_Ticket.Text = "Ticket";
            // 
            // Label_Screen
            // 
            this.Label_Screen.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Label_Screen.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Screen.Location = new System.Drawing.Point(20, 21);
            this.Label_Screen.Name = "Label_Screen";
            this.Label_Screen.Size = new System.Drawing.Size(443, 30);
            this.Label_Screen.TabIndex = 0;
            this.Label_Screen.Text = "Screen";
            this.Label_Screen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Cus_Name
            // 
            this.Label_Cus_Name.AutoSize = true;
            this.Label_Cus_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Cus_Name.Location = new System.Drawing.Point(8, 359);
            this.Label_Cus_Name.Name = "Label_Cus_Name";
            this.Label_Cus_Name.Size = new System.Drawing.Size(176, 21);
            this.Label_Cus_Name.TabIndex = 6;
            this.Label_Cus_Name.Text = "Họ và Tên (Người mua)";
            // 
            // TBx_Customer
            // 
            this.TBx_Customer.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBx_Customer.Location = new System.Drawing.Point(188, 359);
            this.TBx_Customer.Name = "TBx_Customer";
            this.TBx_Customer.Size = new System.Drawing.Size(473, 25);
            this.TBx_Customer.TabIndex = 7;
            this.TBx_Customer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBx_Customer_KeyPress);
            // 
            // ListView_Bought_Ticket
            // 
            this.ListView_Bought_Ticket.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDx_Customer,
            this.IDx_Customer_Name,
            this.IDx_Ticket_Seat,
            this.IDx_Movie,
            this.IDx_Theater,
            this.IDx_Bill});
            this.ListView_Bought_Ticket.HideSelection = false;
            this.ListView_Bought_Ticket.Location = new System.Drawing.Point(12, 437);
            this.ListView_Bought_Ticket.Name = "ListView_Bought_Ticket";
            this.ListView_Bought_Ticket.Size = new System.Drawing.Size(771, 188);
            this.ListView_Bought_Ticket.TabIndex = 8;
            this.ListView_Bought_Ticket.UseCompatibleStateImageBehavior = false;
            this.ListView_Bought_Ticket.View = System.Windows.Forms.View.Details;
            // 
            // IDx_Customer
            // 
            this.IDx_Customer.Text = "STT";
            this.IDx_Customer.Width = 50;
            // 
            // IDx_Customer_Name
            // 
            this.IDx_Customer_Name.Text = "Họ và Tên";
            this.IDx_Customer_Name.Width = 190;
            // 
            // IDx_Ticket_Seat
            // 
            this.IDx_Ticket_Seat.Text = "Vé";
            this.IDx_Ticket_Seat.Width = 100;
            // 
            // IDx_Movie
            // 
            this.IDx_Movie.Text = "Phim";
            this.IDx_Movie.Width = 120;
            // 
            // IDx_Theater
            // 
            this.IDx_Theater.Text = "Phòng chiếu";
            this.IDx_Theater.Width = 80;
            // 
            // IDx_Bill
            // 
            this.IDx_Bill.Text = "Hóa đơn (Việt Nam Đồng)";
            this.IDx_Bill.Width = 210;
            // 
            // Btn_Export
            // 
            this.Btn_Export.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Export.Location = new System.Drawing.Point(635, 631);
            this.Btn_Export.Name = "Btn_Export";
            this.Btn_Export.Size = new System.Drawing.Size(148, 30);
            this.Btn_Export.TabIndex = 10;
            this.Btn_Export.Text = "Xuất nội dung";
            this.Btn_Export.UseVisualStyleBackColor = true;
            this.Btn_Export.Click += new System.EventHandler(this.Btn_Export_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Email (Người mua)";
            // 
            // Tbx_Customer_Email
            // 
            this.Tbx_Customer_Email.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_Customer_Email.Location = new System.Drawing.Point(188, 395);
            this.Tbx_Customer_Email.Name = "Tbx_Customer_Email";
            this.Tbx_Customer_Email.Size = new System.Drawing.Size(473, 25);
            this.Tbx_Customer_Email.TabIndex = 12;
            // 
            // Bai04_Rapchieuphim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(795, 683);
            this.Controls.Add(this.Tbx_Customer_Email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Export);
            this.Controls.Add(this.ListView_Bought_Ticket);
            this.Controls.Add(this.TBx_Customer);
            this.Controls.Add(this.Label_Cus_Name);
            this.Controls.Add(this.GrBx_Ticket);
            this.Controls.Add(this.Btn_Buy);
            this.Controls.Add(this.Label_Theater);
            this.Controls.Add(this.Label_Movie);
            this.Controls.Add(this.CBx_Theater);
            this.Controls.Add(this.CBx_Movie);
            this.Name = "Bai04_Rapchieuphim";
            this.Text = "Bài 5 - Rạp chiếu phim 2.0";
            this.GrBx_Ticket.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBx_Movie;
        private System.Windows.Forms.ComboBox CBx_Theater;
        private System.Windows.Forms.Label Label_Movie;
        private System.Windows.Forms.Label Label_Theater;
        private System.Windows.Forms.Button Btn_Buy;
        private System.Windows.Forms.GroupBox GrBx_Ticket;
        private System.Windows.Forms.Label Label_Screen;
        private System.Windows.Forms.Label Label_Cus_Name;
        private System.Windows.Forms.TextBox TBx_Customer;
        private System.Windows.Forms.ListView ListView_Bought_Ticket;
        private System.Windows.Forms.ColumnHeader IDx_Customer;
        private System.Windows.Forms.ColumnHeader IDx_Customer_Name;
        private System.Windows.Forms.ColumnHeader IDx_Ticket_Seat;
        private System.Windows.Forms.ColumnHeader IDx_Movie;
        private System.Windows.Forms.ColumnHeader IDx_Theater;
        private System.Windows.Forms.ColumnHeader IDx_Bill;
        private System.Windows.Forms.Button Btn_Export;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tbx_Customer_Email;
    }
}