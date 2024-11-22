namespace Lab4
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
            this.components = new System.ComponentModel.Container();
            this.Tbx_Url = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Btn_Get = new System.Windows.Forms.Button();
            this.Rtbx_Content = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Tbx_Url
            // 
            this.Tbx_Url.Location = new System.Drawing.Point(22, 31);
            this.Tbx_Url.Name = "Tbx_Url";
            this.Tbx_Url.Size = new System.Drawing.Size(790, 29);
            this.Tbx_Url.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Btn_Get
            // 
            this.Btn_Get.Location = new System.Drawing.Point(818, 31);
            this.Btn_Get.Name = "Btn_Get";
            this.Btn_Get.Size = new System.Drawing.Size(150, 30);
            this.Btn_Get.TabIndex = 2;
            this.Btn_Get.Text = "GET";
            this.Btn_Get.UseVisualStyleBackColor = true;
            this.Btn_Get.Click += new System.EventHandler(this.Btn_Get_Click);
            // 
            // Rtbx_Content
            // 
            this.Rtbx_Content.Location = new System.Drawing.Point(25, 67);
            this.Rtbx_Content.Name = "Rtbx_Content";
            this.Rtbx_Content.ReadOnly = true;
            this.Rtbx_Content.Size = new System.Drawing.Size(943, 431);
            this.Rtbx_Content.TabIndex = 3;
            this.Rtbx_Content.Text = "";
            // 
            // Bai01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 523);
            this.Controls.Add(this.Rtbx_Content);
            this.Controls.Add(this.Btn_Get);
            this.Controls.Add(this.Tbx_Url);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Bai01";
            this.Text = "Bài 01 - HTML Content";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tbx_Url;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button Btn_Get;
        private System.Windows.Forms.RichTextBox Rtbx_Content;
    }
}

