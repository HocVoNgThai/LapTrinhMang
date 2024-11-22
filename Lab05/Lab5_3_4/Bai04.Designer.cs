namespace Lab5
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
            this.components = new System.ComponentModel.Container();
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.Panel_WebView = new System.Windows.Forms.Panel();
            this.Panel_List = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PrgBar = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Label_Prg = new System.Windows.Forms.Label();
            this.Btn_Home = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            this.Panel_WebView.SuspendLayout();
            this.SuspendLayout();
            // 
            // webView
            // 
            this.webView.AllowExternalDrop = true;
            this.webView.CreationProperties = null;
            this.webView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView.Location = new System.Drawing.Point(4, 5);
            this.webView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.webView.Name = "webView";
            this.webView.Size = new System.Drawing.Size(1017, 820);
            this.webView.TabIndex = 0;
            this.webView.ZoomFactor = 1D;
            // 
            // Panel_WebView
            // 
            this.Panel_WebView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_WebView.Controls.Add(this.webView);
            this.Panel_WebView.Location = new System.Drawing.Point(484, 9);
            this.Panel_WebView.Name = "Panel_WebView";
            this.Panel_WebView.Size = new System.Drawing.Size(952, 835);
            this.Panel_WebView.TabIndex = 9;
            // 
            // Panel_List
            // 
            this.Panel_List.AutoScroll = true;
            this.Panel_List.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_List.Location = new System.Drawing.Point(12, 49);
            this.Panel_List.Name = "Panel_List";
            this.Panel_List.Size = new System.Drawing.Size(466, 794);
            this.Panel_List.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phim Đang Chiếu";
            // 
            // PrgBar
            // 
            this.PrgBar.Location = new System.Drawing.Point(247, 15);
            this.PrgBar.Name = "PrgBar";
            this.PrgBar.Size = new System.Drawing.Size(195, 29);
            this.PrgBar.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Label_Prg
            // 
            this.Label_Prg.AutoSize = true;
            this.Label_Prg.BackColor = System.Drawing.Color.Transparent;
            this.Label_Prg.Location = new System.Drawing.Point(327, 19);
            this.Label_Prg.Name = "Label_Prg";
            this.Label_Prg.Size = new System.Drawing.Size(32, 21);
            this.Label_Prg.TabIndex = 11;
            this.Label_Prg.Text = "0%";
            // 
            // Btn_Home
            // 
            this.Btn_Home.Location = new System.Drawing.Point(448, 15);
            this.Btn_Home.Name = "Btn_Home";
            this.Btn_Home.Size = new System.Drawing.Size(30, 29);
            this.Btn_Home.TabIndex = 12;
            this.Btn_Home.Text = "🏠";
            this.Btn_Home.UseVisualStyleBackColor = true;
            this.Btn_Home.Click += new System.EventHandler(this.Btn_Home_Click);
            // 
            // Bai04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 847);
            this.Controls.Add(this.Btn_Home);
            this.Controls.Add(this.Label_Prg);
            this.Controls.Add(this.PrgBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Panel_List);
            this.Controls.Add(this.Panel_WebView);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Bai04";
            this.Text = "Bài 04- Quản Lí Phòng vé";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bai04_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
            this.Panel_WebView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private System.Windows.Forms.Panel Panel_WebView;
        private System.Windows.Forms.Panel Panel_List;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar PrgBar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Label_Prg;
        private System.Windows.Forms.Button Btn_Home;
    }
}