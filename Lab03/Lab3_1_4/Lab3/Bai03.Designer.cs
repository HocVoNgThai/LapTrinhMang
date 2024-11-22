namespace Lab3
{
    partial class Bai03
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
            this.Btn_TcpServer = new System.Windows.Forms.Button();
            this.Btn_TcpClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_TcpServer
            // 
            this.Btn_TcpServer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_TcpServer.Location = new System.Drawing.Point(57, 67);
            this.Btn_TcpServer.Name = "Btn_TcpServer";
            this.Btn_TcpServer.Size = new System.Drawing.Size(120, 50);
            this.Btn_TcpServer.TabIndex = 0;
            this.Btn_TcpServer.Text = "TCP Server";
            this.Btn_TcpServer.UseVisualStyleBackColor = true;
            this.Btn_TcpServer.Click += new System.EventHandler(this.Btn_TcpServer_Click);
            // 
            // Btn_TcpClient
            // 
            this.Btn_TcpClient.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_TcpClient.Location = new System.Drawing.Point(360, 67);
            this.Btn_TcpClient.Name = "Btn_TcpClient";
            this.Btn_TcpClient.Size = new System.Drawing.Size(120, 50);
            this.Btn_TcpClient.TabIndex = 1;
            this.Btn_TcpClient.Text = "TCP Client";
            this.Btn_TcpClient.UseVisualStyleBackColor = true;
            this.Btn_TcpClient.Click += new System.EventHandler(this.Btn_TcpClient_Click);
            // 
            // Bai03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 194);
            this.Controls.Add(this.Btn_TcpClient);
            this.Controls.Add(this.Btn_TcpServer);
            this.Name = "Bai03";
            this.Text = "Bài 01 - UDP Connection";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bai03_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_TcpServer;
        private System.Windows.Forms.Button Btn_TcpClient;
    }
}