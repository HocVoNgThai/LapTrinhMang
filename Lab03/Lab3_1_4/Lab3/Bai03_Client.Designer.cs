namespace Lab3
{
    partial class Bai03_Client
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
            this.Tbx_Ip = new System.Windows.Forms.TextBox();
            this.Tbx_CliName = new System.Windows.Forms.TextBox();
            this.Tbx_Port = new System.Windows.Forms.TextBox();
            this.Rtbx_Message = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_Send = new System.Windows.Forms.Button();
            this.Btn_Connect = new System.Windows.Forms.Button();
            this.Btn_Disconnect = new System.Windows.Forms.Button();
            this.Tbx_Message = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Tbx_Ip
            // 
            this.Tbx_Ip.Location = new System.Drawing.Point(139, 42);
            this.Tbx_Ip.Name = "Tbx_Ip";
            this.Tbx_Ip.Size = new System.Drawing.Size(140, 29);
            this.Tbx_Ip.TabIndex = 0;
            this.Tbx_Ip.Text = "127.0.0.1";
            // 
            // Tbx_CliName
            // 
            this.Tbx_CliName.Location = new System.Drawing.Point(668, 42);
            this.Tbx_CliName.Name = "Tbx_CliName";
            this.Tbx_CliName.Size = new System.Drawing.Size(191, 29);
            this.Tbx_CliName.TabIndex = 1;
            this.Tbx_CliName.Text = "Client";
            // 
            // Tbx_Port
            // 
            this.Tbx_Port.Location = new System.Drawing.Point(335, 42);
            this.Tbx_Port.Name = "Tbx_Port";
            this.Tbx_Port.Size = new System.Drawing.Size(94, 29);
            this.Tbx_Port.TabIndex = 2;
            this.Tbx_Port.Text = "8080";
            // 
            // Rtbx_Message
            // 
            this.Rtbx_Message.Location = new System.Drawing.Point(12, 126);
            this.Rtbx_Message.Name = "Rtbx_Message";
            this.Rtbx_Message.ReadOnly = true;
            this.Rtbx_Message.Size = new System.Drawing.Size(698, 291);
            this.Rtbx_Message.TabIndex = 3;
            this.Rtbx_Message.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP remote host:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Port:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(564, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Client Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Message";
            // 
            // Btn_Send
            // 
            this.Btn_Send.Location = new System.Drawing.Point(716, 420);
            this.Btn_Send.Name = "Btn_Send";
            this.Btn_Send.Size = new System.Drawing.Size(147, 33);
            this.Btn_Send.TabIndex = 8;
            this.Btn_Send.Text = "Send";
            this.Btn_Send.UseVisualStyleBackColor = true;
            this.Btn_Send.Click += new System.EventHandler(this.Btn_Send_Click);
            // 
            // Btn_Connect
            // 
            this.Btn_Connect.Location = new System.Drawing.Point(716, 381);
            this.Btn_Connect.Name = "Btn_Connect";
            this.Btn_Connect.Size = new System.Drawing.Size(147, 33);
            this.Btn_Connect.TabIndex = 9;
            this.Btn_Connect.Text = "Connect";
            this.Btn_Connect.UseVisualStyleBackColor = true;
            this.Btn_Connect.Click += new System.EventHandler(this.Btn_Connect_Click);
            // 
            // Btn_Disconnect
            // 
            this.Btn_Disconnect.Location = new System.Drawing.Point(716, 342);
            this.Btn_Disconnect.Name = "Btn_Disconnect";
            this.Btn_Disconnect.Size = new System.Drawing.Size(147, 33);
            this.Btn_Disconnect.TabIndex = 10;
            this.Btn_Disconnect.Text = "Disconnect";
            this.Btn_Disconnect.UseVisualStyleBackColor = true;
            this.Btn_Disconnect.Click += new System.EventHandler(this.Btn_Disconnect_Click);
            // 
            // Tbx_Message
            // 
            this.Tbx_Message.Location = new System.Drawing.Point(12, 423);
            this.Tbx_Message.Name = "Tbx_Message";
            this.Tbx_Message.Size = new System.Drawing.Size(698, 29);
            this.Tbx_Message.TabIndex = 11;
            // 
            // Bai03_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 474);
            this.Controls.Add(this.Tbx_Message);
            this.Controls.Add(this.Btn_Disconnect);
            this.Controls.Add(this.Btn_Connect);
            this.Controls.Add(this.Btn_Send);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Rtbx_Message);
            this.Controls.Add(this.Tbx_Port);
            this.Controls.Add(this.Tbx_CliName);
            this.Controls.Add(this.Tbx_Ip);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Bai03_Client";
            this.Text = "Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bai03_Client_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tbx_Ip;
        private System.Windows.Forms.TextBox Tbx_CliName;
        private System.Windows.Forms.TextBox Tbx_Port;
        private System.Windows.Forms.RichTextBox Rtbx_Message;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_Send;
        private System.Windows.Forms.Button Btn_Connect;
        private System.Windows.Forms.Button Btn_Disconnect;
        private System.Windows.Forms.TextBox Tbx_Message;
    }
}