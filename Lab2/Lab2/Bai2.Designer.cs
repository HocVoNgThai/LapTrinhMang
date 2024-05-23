namespace Lab2
{
    partial class Bai2
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
            panel1 = new Panel();
            txtCharacters = new TextBox();
            txtWords = new TextBox();
            txtLines = new TextBox();
            txtPath = new TextBox();
            txtSizes = new TextBox();
            txtFileName = new TextBox();
            btnExit = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnRead = new Button();
            rtbReadFile = new RichTextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GrayText;
            panel1.Controls.Add(txtCharacters);
            panel1.Controls.Add(txtWords);
            panel1.Controls.Add(txtLines);
            panel1.Controls.Add(txtPath);
            panel1.Controls.Add(txtSizes);
            panel1.Controls.Add(txtFileName);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnRead);
            panel1.Dock = DockStyle.Left;
            panel1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(486, 630);
            panel1.TabIndex = 0;
            // 
            // txtCharacters
            // 
            txtCharacters.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtCharacters.ForeColor = Color.FromArgb(64, 64, 64);
            txtCharacters.Location = new Point(187, 482);
            txtCharacters.Name = "txtCharacters";
            txtCharacters.Size = new Size(269, 28);
            txtCharacters.TabIndex = 23;
            // 
            // txtWords
            // 
            txtWords.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtWords.ForeColor = Color.FromArgb(64, 64, 64);
            txtWords.Location = new Point(187, 413);
            txtWords.Name = "txtWords";
            txtWords.Size = new Size(269, 28);
            txtWords.TabIndex = 21;
            // 
            // txtLines
            // 
            txtLines.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtLines.ForeColor = Color.FromArgb(64, 64, 64);
            txtLines.Location = new Point(187, 343);
            txtLines.Name = "txtLines";
            txtLines.Size = new Size(269, 28);
            txtLines.TabIndex = 19;
            // 
            // txtPath
            // 
            txtPath.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtPath.ForeColor = Color.FromArgb(64, 64, 64);
            txtPath.Location = new Point(187, 265);
            txtPath.Name = "txtPath";
            txtPath.Size = new Size(269, 28);
            txtPath.TabIndex = 17;
            // 
            // txtSizes
            // 
            txtSizes.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtSizes.ForeColor = Color.FromArgb(64, 64, 64);
            txtSizes.Location = new Point(187, 195);
            txtSizes.Name = "txtSizes";
            txtSizes.Size = new Size(269, 28);
            txtSizes.TabIndex = 15;
            // 
            // txtFileName
            // 
            txtFileName.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtFileName.ForeColor = Color.FromArgb(64, 64, 64);
            txtFileName.Location = new Point(187, 124);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(269, 28);
            txtFileName.TabIndex = 13;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(192, 192, 255);
            btnExit.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.Olive;
            btnExit.Location = new Point(27, 530);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(429, 67);
            btnExit.TabIndex = 12;
            btnExit.Text = "Thoát chương trình";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.LightBlue;
            label6.Location = new Point(27, 487);
            label6.Name = "label6";
            label6.Size = new Size(81, 23);
            label6.TabIndex = 11;
            label6.Text = "Số ký tự";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.LightBlue;
            label5.Location = new Point(27, 418);
            label5.Name = "label5";
            label5.Size = new Size(55, 23);
            label5.TabIndex = 9;
            label5.Text = "Số từ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.LightBlue;
            label4.Location = new Point(27, 348);
            label4.Name = "label4";
            label4.Size = new Size(76, 23);
            label4.TabIndex = 7;
            label4.Text = "Số dòng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.LightBlue;
            label3.Location = new Point(27, 270);
            label3.Name = "label3";
            label3.Size = new Size(102, 23);
            label3.TabIndex = 5;
            label3.Text = "Đường dẫn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.LightBlue;
            label2.Location = new Point(27, 200);
            label2.Name = "label2";
            label2.Size = new Size(135, 23);
            label2.TabIndex = 3;
            label2.Text = "Kích thước file";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LightBlue;
            label1.Location = new Point(27, 129);
            label1.Name = "label1";
            label1.Size = new Size(74, 23);
            label1.TabIndex = 1;
            label1.Text = "Tên file";
            // 
            // btnRead
            // 
            btnRead.BackColor = Color.Silver;
            btnRead.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnRead.ForeColor = Color.FromArgb(128, 64, 0);
            btnRead.Location = new Point(27, 25);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(429, 52);
            btnRead.TabIndex = 0;
            btnRead.Text = "Đọc file ";
            btnRead.UseVisualStyleBackColor = false;
            btnRead.Click += btnRead_Click;
            // 
            // rtbReadFile
            // 
            rtbReadFile.BackColor = SystemColors.WindowFrame;
            rtbReadFile.Dock = DockStyle.Right;
            rtbReadFile.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rtbReadFile.ForeColor = Color.WhiteSmoke;
            rtbReadFile.Location = new Point(484, 0);
            rtbReadFile.Name = "rtbReadFile";
            rtbReadFile.Size = new Size(607, 630);
            rtbReadFile.TabIndex = 1;
            rtbReadFile.Text = "";
            // 
            // Bai2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1091, 630);
            Controls.Add(rtbReadFile);
            Controls.Add(panel1);
            Name = "Bai2";
            Text = "Bai2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private RichTextBox rtbReadFile;
        private TextBox txtCharacters;
        private TextBox txtWords;
        private TextBox txtLines;
        private TextBox txtPath;
        private TextBox txtSizes;
        private TextBox txtFileName;
        private Button btnExit;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnRead;
    }
}