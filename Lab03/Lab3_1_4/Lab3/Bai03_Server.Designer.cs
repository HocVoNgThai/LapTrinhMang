namespace Lab3
{
    partial class Bai03_Server
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
            this.Btn_Listen = new System.Windows.Forms.Button();
            this.Tbx_ListenPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Tbx_Message = new System.Windows.Forms.TextBox();
            this.Btn_SendAll = new System.Windows.Forms.Button();
            this.listViewCommand = new System.Windows.Forms.ListView();
            this.Connection = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RecvText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // Btn_Listen
            // 
            this.Btn_Listen.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Listen.Location = new System.Drawing.Point(653, 24);
            this.Btn_Listen.Name = "Btn_Listen";
            this.Btn_Listen.Size = new System.Drawing.Size(119, 30);
            this.Btn_Listen.TabIndex = 1;
            this.Btn_Listen.Text = "Listen";
            this.Btn_Listen.UseVisualStyleBackColor = true;
            this.Btn_Listen.Click += new System.EventHandler(this.Btn_Listen_Click);
            // 
            // Tbx_ListenPort
            // 
            this.Tbx_ListenPort.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_ListenPort.Location = new System.Drawing.Point(122, 21);
            this.Tbx_ListenPort.Name = "Tbx_ListenPort";
            this.Tbx_ListenPort.Size = new System.Drawing.Size(74, 29);
            this.Tbx_ListenPort.TabIndex = 3;
            this.Tbx_ListenPort.Text = "8080";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Listen Port:";
            // 
            // Tbx_Message
            // 
            this.Tbx_Message.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_Message.Location = new System.Drawing.Point(29, 402);
            this.Tbx_Message.Name = "Tbx_Message";
            this.Tbx_Message.Size = new System.Drawing.Size(618, 29);
            this.Tbx_Message.TabIndex = 5;
            // 
            // Btn_SendAll
            // 
            this.Btn_SendAll.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SendAll.Location = new System.Drawing.Point(653, 402);
            this.Btn_SendAll.Name = "Btn_SendAll";
            this.Btn_SendAll.Size = new System.Drawing.Size(119, 30);
            this.Btn_SendAll.TabIndex = 6;
            this.Btn_SendAll.Text = "Send";
            this.Btn_SendAll.UseVisualStyleBackColor = true;
            this.Btn_SendAll.Click += new System.EventHandler(this.Btn_SendAll_Click);
            // 
            // listViewCommand
            // 
            this.listViewCommand.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Connection,
            this.RecvText});
            this.listViewCommand.HideSelection = false;
            this.listViewCommand.Location = new System.Drawing.Point(12, 60);
            this.listViewCommand.Name = "listViewCommand";
            this.listViewCommand.Size = new System.Drawing.Size(776, 336);
            this.listViewCommand.TabIndex = 7;
            this.listViewCommand.UseCompatibleStateImageBehavior = false;
            this.listViewCommand.View = System.Windows.Forms.View.Details;
            // 
            // Connection
            // 
            this.Connection.Text = "Connection";
            this.Connection.Width = 150;
            // 
            // RecvText
            // 
            this.RecvText.Text = "Received Text";
            this.RecvText.Width = 600;
            // 
            // Bai03_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewCommand);
            this.Controls.Add(this.Btn_SendAll);
            this.Controls.Add(this.Tbx_Message);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tbx_ListenPort);
            this.Controls.Add(this.Btn_Listen);
            this.Name = "Bai03_Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bai03_Server_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_Listen;
        private System.Windows.Forms.TextBox Tbx_ListenPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tbx_Message;
        private System.Windows.Forms.Button Btn_SendAll;
        private System.Windows.Forms.ListView listViewCommand;
        private System.Windows.Forms.ColumnHeader Connection;
        private System.Windows.Forms.ColumnHeader RecvText;
    }
}