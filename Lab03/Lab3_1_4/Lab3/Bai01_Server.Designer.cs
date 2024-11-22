namespace Lab3
{
    partial class Bai01_Server
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
            this.Label_Listenport = new System.Windows.Forms.Label();
            this.Label_RcvMess = new System.Windows.Forms.Label();
            this.Tbx_Port = new System.Windows.Forms.MaskedTextBox();
            this.Btn_Listen = new System.Windows.Forms.Button();
            this.Rtbx_RecvMessage = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Label_Listenport
            // 
            this.Label_Listenport.AutoSize = true;
            this.Label_Listenport.Location = new System.Drawing.Point(30, 26);
            this.Label_Listenport.Name = "Label_Listenport";
            this.Label_Listenport.Size = new System.Drawing.Size(87, 21);
            this.Label_Listenport.TabIndex = 0;
            this.Label_Listenport.Text = "Listen Port";
            // 
            // Label_RcvMess
            // 
            this.Label_RcvMess.AutoSize = true;
            this.Label_RcvMess.Location = new System.Drawing.Point(30, 76);
            this.Label_RcvMess.Name = "Label_RcvMess";
            this.Label_RcvMess.Size = new System.Drawing.Size(146, 21);
            this.Label_RcvMess.TabIndex = 1;
            this.Label_RcvMess.Text = "Received Message";
            // 
            // Tbx_Port
            // 
            this.Tbx_Port.Location = new System.Drawing.Point(123, 23);
            this.Tbx_Port.Name = "Tbx_Port";
            this.Tbx_Port.Size = new System.Drawing.Size(100, 29);
            this.Tbx_Port.TabIndex = 2;
            this.Tbx_Port.Text = "80";
            // 
            // Btn_Listen
            // 
            this.Btn_Listen.BackColor = System.Drawing.Color.White;
            this.Btn_Listen.Location = new System.Drawing.Point(573, 21);
            this.Btn_Listen.Name = "Btn_Listen";
            this.Btn_Listen.Size = new System.Drawing.Size(120, 30);
            this.Btn_Listen.TabIndex = 3;
            this.Btn_Listen.Text = "Listen";
            this.Btn_Listen.UseVisualStyleBackColor = false;
            this.Btn_Listen.Click += new System.EventHandler(this.Btn_Listen_Click);
            // 
            // Rtbx_RecvMessage
            // 
            this.Rtbx_RecvMessage.Location = new System.Drawing.Point(34, 100);
            this.Rtbx_RecvMessage.Name = "Rtbx_RecvMessage";
            this.Rtbx_RecvMessage.Size = new System.Drawing.Size(659, 353);
            this.Rtbx_RecvMessage.TabIndex = 4;
            this.Rtbx_RecvMessage.Text = "";
            // 
            // Bai01_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 493);
            this.Controls.Add(this.Rtbx_RecvMessage);
            this.Controls.Add(this.Btn_Listen);
            this.Controls.Add(this.Tbx_Port);
            this.Controls.Add(this.Label_RcvMess);
            this.Controls.Add(this.Label_Listenport);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Bai01_Server";
            this.Text = "UDP Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bai01_Server_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Listenport;
        private System.Windows.Forms.Label Label_RcvMess;
        private System.Windows.Forms.MaskedTextBox Tbx_Port;
        private System.Windows.Forms.Button Btn_Listen;
        private System.Windows.Forms.RichTextBox Rtbx_RecvMessage;
    }
}