namespace Lab3
{
    partial class Bai01
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
            this.Btn_UdpServer = new System.Windows.Forms.Button();
            this.Btn_UdpClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_UdpServer
            // 
            this.Btn_UdpServer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_UdpServer.Location = new System.Drawing.Point(57, 67);
            this.Btn_UdpServer.Name = "Btn_UdpServer";
            this.Btn_UdpServer.Size = new System.Drawing.Size(120, 50);
            this.Btn_UdpServer.TabIndex = 0;
            this.Btn_UdpServer.Text = "UDP Server";
            this.Btn_UdpServer.UseVisualStyleBackColor = true;
            this.Btn_UdpServer.Click += new System.EventHandler(this.Btn_UdpServer_Click);
            // 
            // Btn_UdpClient
            // 
            this.Btn_UdpClient.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_UdpClient.Location = new System.Drawing.Point(360, 67);
            this.Btn_UdpClient.Name = "Btn_UdpClient";
            this.Btn_UdpClient.Size = new System.Drawing.Size(120, 50);
            this.Btn_UdpClient.TabIndex = 1;
            this.Btn_UdpClient.Text = "UDP Client";
            this.Btn_UdpClient.UseVisualStyleBackColor = true;
            this.Btn_UdpClient.Click += new System.EventHandler(this.Btn_UdpClient_Click);
            // 
            // Bai01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 194);
            this.Controls.Add(this.Btn_UdpClient);
            this.Controls.Add(this.Btn_UdpServer);
            this.Name = "Bai01";
            this.Text = "Bài 01 - UDP Connection";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bai01_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_UdpServer;
        private System.Windows.Forms.Button Btn_UdpClient;
    }
}