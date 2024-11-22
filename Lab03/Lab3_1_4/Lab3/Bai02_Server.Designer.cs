namespace Lab3
{
    partial class Bai02_Server
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
            this.listViewCommand = new System.Windows.Forms.ListView();
            this.Connection = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Text = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            // listViewCommand
            // 
            this.listViewCommand.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Connection,
            this.Text});
            this.listViewCommand.HideSelection = false;
            this.listViewCommand.Location = new System.Drawing.Point(25, 60);
            this.listViewCommand.Name = "listViewCommand";
            this.listViewCommand.Size = new System.Drawing.Size(747, 357);
            this.listViewCommand.TabIndex = 0;
            this.listViewCommand.UseCompatibleStateImageBehavior = false;
            this.listViewCommand.View = System.Windows.Forms.View.Details;
            // 
            // Connection
            // 
            this.Connection.Text = "Connection";
            this.Connection.Width = 200;
            // 
            // Text
            // 
            this.Text.Text = "Received Text";
            this.Text.Width = 500;
            // 
            // Bai02_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Listen);
            this.Controls.Add(this.listViewCommand);
            this.Name = "Bai02_Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bai02_Server_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Btn_Listen;
        private System.Windows.Forms.ListView listViewCommand;
        private System.Windows.Forms.ColumnHeader Connection;
        private System.Windows.Forms.ColumnHeader Text;
    }
}