namespace Lab5
{
    partial class Dieuhuong
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
            this.Btn_Bai3 = new System.Windows.Forms.Button();
            this.Btn_Bai4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Bai3
            // 
            this.Btn_Bai3.Location = new System.Drawing.Point(155, 75);
            this.Btn_Bai3.Name = "Btn_Bai3";
            this.Btn_Bai3.Size = new System.Drawing.Size(120, 50);
            this.Btn_Bai3.TabIndex = 2;
            this.Btn_Bai3.Text = "Bài 3";
            this.Btn_Bai3.UseVisualStyleBackColor = true;
            this.Btn_Bai3.Click += new System.EventHandler(this.Btn_Bai3_Click);
            // 
            // Btn_Bai4
            // 
            this.Btn_Bai4.Location = new System.Drawing.Point(454, 75);
            this.Btn_Bai4.Name = "Btn_Bai4";
            this.Btn_Bai4.Size = new System.Drawing.Size(120, 50);
            this.Btn_Bai4.TabIndex = 3;
            this.Btn_Bai4.Text = "Bài 4";
            this.Btn_Bai4.UseVisualStyleBackColor = true;
            this.Btn_Bai4.Click += new System.EventHandler(this.Btn_Bai4_Click);
            // 
            // Dieuhuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lab5.Properties.Resources._0649d50cae396b673228;
            this.ClientSize = new System.Drawing.Size(719, 216);
            this.Controls.Add(this.Btn_Bai4);
            this.Controls.Add(this.Btn_Bai3);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Dieuhuong";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Btn_Bai3;
        private System.Windows.Forms.Button Btn_Bai4;
    }
}