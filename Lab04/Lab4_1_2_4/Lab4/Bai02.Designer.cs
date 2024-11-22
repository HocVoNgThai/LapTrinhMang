namespace Lab4
{
    partial class Bai02
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
            this.Tbx_Url = new System.Windows.Forms.TextBox();
            this.Btn_Get = new System.Windows.Forms.Button();
            this.Rtbx_Content = new System.Windows.Forms.RichTextBox();
            this.Tbx_fileUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PrgBar = new System.Windows.Forms.ProgressBar();
            this.Label_Progress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Tbx_Url
            // 
            this.Tbx_Url.Location = new System.Drawing.Point(102, 31);
            this.Tbx_Url.Name = "Tbx_Url";
            this.Tbx_Url.Size = new System.Drawing.Size(710, 29);
            this.Tbx_Url.TabIndex = 0;
            // 
            // Btn_Get
            // 
            this.Btn_Get.Location = new System.Drawing.Point(818, 31);
            this.Btn_Get.Name = "Btn_Get";
            this.Btn_Get.Size = new System.Drawing.Size(150, 30);
            this.Btn_Get.TabIndex = 2;
            this.Btn_Get.Text = "DownLoad";
            this.Btn_Get.UseVisualStyleBackColor = true;
            this.Btn_Get.Click += new System.EventHandler(this.Btn_Get_Click);
            // 
            // Rtbx_Content
            // 
            this.Rtbx_Content.Location = new System.Drawing.Point(25, 101);
            this.Rtbx_Content.Name = "Rtbx_Content";
            this.Rtbx_Content.ReadOnly = true;
            this.Rtbx_Content.Size = new System.Drawing.Size(943, 397);
            this.Rtbx_Content.TabIndex = 3;
            this.Rtbx_Content.Text = "";
            // 
            // Tbx_fileUrl
            // 
            this.Tbx_fileUrl.Location = new System.Drawing.Point(102, 66);
            this.Tbx_fileUrl.Name = "Tbx_fileUrl";
            this.Tbx_fileUrl.Size = new System.Drawing.Size(710, 29);
            this.Tbx_fileUrl.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "File Path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "URL:";
            // 
            // PrgBar
            // 
            this.PrgBar.Location = new System.Drawing.Point(818, 66);
            this.PrgBar.Name = "PrgBar";
            this.PrgBar.Size = new System.Drawing.Size(150, 29);
            this.PrgBar.TabIndex = 8;
            // 
            // Label_Progress
            // 
            this.Label_Progress.AutoSize = true;
            this.Label_Progress.BackColor = System.Drawing.Color.Transparent;
            this.Label_Progress.Location = new System.Drawing.Point(877, 69);
            this.Label_Progress.Name = "Label_Progress";
            this.Label_Progress.Size = new System.Drawing.Size(32, 21);
            this.Label_Progress.TabIndex = 9;
            this.Label_Progress.Text = "0%";
            // 
            // Bai02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 523);
            this.Controls.Add(this.Label_Progress);
            this.Controls.Add(this.PrgBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tbx_fileUrl);
            this.Controls.Add(this.Rtbx_Content);
            this.Controls.Add(this.Btn_Get);
            this.Controls.Add(this.Tbx_Url);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Bai02";
            this.Text = "Bài 01 - HTML Content";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tbx_Url;
        private System.Windows.Forms.Button Btn_Get;
        private System.Windows.Forms.RichTextBox Rtbx_Content;
        private System.Windows.Forms.TextBox Tbx_fileUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar PrgBar;
        private System.Windows.Forms.Label Label_Progress;
    }
}