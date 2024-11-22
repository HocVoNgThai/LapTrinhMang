namespace Lab3
{
    partial class Bai01_Client
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
            this.Label_Port = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Tbx_IpHost = new System.Windows.Forms.TextBox();
            this.Tbx_Port = new System.Windows.Forms.TextBox();
            this.Rtbx_Message = new System.Windows.Forms.RichTextBox();
            this.Btn_Send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Remte Host";
            // 
            // Label_Port
            // 
            this.Label_Port.AutoSize = true;
            this.Label_Port.Location = new System.Drawing.Point(457, 26);
            this.Label_Port.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Port.Name = "Label_Port";
            this.Label_Port.Size = new System.Drawing.Size(40, 21);
            this.Label_Port.TabIndex = 1;
            this.Label_Port.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Message";
            // 
            // Tbx_IpHost
            // 
            this.Tbx_IpHost.Location = new System.Drawing.Point(157, 23);
            this.Tbx_IpHost.Name = "Tbx_IpHost";
            this.Tbx_IpHost.Size = new System.Drawing.Size(241, 29);
            this.Tbx_IpHost.TabIndex = 3;
            this.Tbx_IpHost.Text = "127.0.0.1";
            // 
            // Tbx_Port
            // 
            this.Tbx_Port.Location = new System.Drawing.Point(504, 23);
            this.Tbx_Port.Name = "Tbx_Port";
            this.Tbx_Port.Size = new System.Drawing.Size(108, 29);
            this.Tbx_Port.TabIndex = 4;
            this.Tbx_Port.Text = "80";
            // 
            // Rtbx_Message
            // 
            this.Rtbx_Message.Location = new System.Drawing.Point(39, 93);
            this.Rtbx_Message.Name = "Rtbx_Message";
            this.Rtbx_Message.Size = new System.Drawing.Size(573, 167);
            this.Rtbx_Message.TabIndex = 5;
            this.Rtbx_Message.Text = "";
            // 
            // Btn_Send
            // 
            this.Btn_Send.Location = new System.Drawing.Point(39, 266);
            this.Btn_Send.Name = "Btn_Send";
            this.Btn_Send.Size = new System.Drawing.Size(75, 30);
            this.Btn_Send.TabIndex = 6;
            this.Btn_Send.Text = "Send";
            this.Btn_Send.UseVisualStyleBackColor = true;
            this.Btn_Send.Click += new System.EventHandler(this.Btn_Send_Click);
            // 
            // Bai01_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 309);
            this.Controls.Add(this.Btn_Send);
            this.Controls.Add(this.Rtbx_Message);
            this.Controls.Add(this.Tbx_Port);
            this.Controls.Add(this.Tbx_IpHost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Label_Port);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Bai01_Client";
            this.Text = "Bai01_Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label_Port;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Tbx_IpHost;
        private System.Windows.Forms.TextBox Tbx_Port;
        private System.Windows.Forms.RichTextBox Rtbx_Message;
        private System.Windows.Forms.Button Btn_Send;
    }
}