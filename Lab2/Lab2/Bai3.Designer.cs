namespace Lab2
{
    partial class Bai3
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
            btnRead = new Button();
            btnWrite = new Button();
            panel1 = new Panel();
            rtbCalculate = new RichTextBox();
            rtbReadFile = new RichTextBox();
            btnCalculate = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnRead
            // 
            btnRead.BackColor = Color.DarkSalmon;
            btnRead.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            btnRead.ForeColor = Color.FloralWhite;
            btnRead.Location = new Point(88, 64);
            btnRead.Margin = new Padding(3, 4, 3, 4);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(145, 71);
            btnRead.TabIndex = 0;
            btnRead.Text = "Đọc file";
            btnRead.UseVisualStyleBackColor = false;
            btnRead.Click += btnRead_Click;
            // 
            // btnWrite
            // 
            btnWrite.BackColor = Color.DarkSalmon;
            btnWrite.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            btnWrite.ForeColor = Color.FloralWhite;
            btnWrite.Location = new Point(88, 437);
            btnWrite.Margin = new Padding(3, 4, 3, 4);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(145, 71);
            btnWrite.TabIndex = 1;
            btnWrite.Text = "Ghi file";
            btnWrite.UseVisualStyleBackColor = false;
            btnWrite.Click += btnWrite_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(rtbCalculate);
            panel1.Controls.Add(rtbReadFile);
            panel1.Dock = DockStyle.Right;
            panel1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.Location = new Point(332, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(582, 600);
            panel1.TabIndex = 2;
            // 
            // rtbCalculate
            // 
            rtbCalculate.BackColor = SystemColors.ScrollBar;
            rtbCalculate.Dock = DockStyle.Bottom;
            rtbCalculate.Location = new Point(0, 295);
            rtbCalculate.Name = "rtbCalculate";
            rtbCalculate.Size = new Size(582, 305);
            rtbCalculate.TabIndex = 1;
            rtbCalculate.Text = "";
            // 
            // rtbReadFile
            // 
            rtbReadFile.BackColor = SystemColors.ScrollBar;
            rtbReadFile.Dock = DockStyle.Top;
            rtbReadFile.Location = new Point(0, 0);
            rtbReadFile.Name = "rtbReadFile";
            rtbReadFile.Size = new Size(582, 298);
            rtbReadFile.TabIndex = 0;
            rtbReadFile.Text = "";
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.DarkSalmon;
            btnCalculate.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalculate.ForeColor = Color.FloralWhite;
            btnCalculate.Location = new Point(88, 242);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(145, 71);
            btnCalculate.TabIndex = 3;
            btnCalculate.Text = "Tính toán";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // Bai3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(914, 600);
            Controls.Add(btnCalculate);
            Controls.Add(panel1);
            Controls.Add(btnWrite);
            Controls.Add(btnRead);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Bai3";
            Text = "Bai3";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnRead;
        private Button btnWrite;
        private Panel panel1;
        private RichTextBox rtbCalculate;
        private RichTextBox rtbReadFile;
        private Button btnCalculate;
    }
}