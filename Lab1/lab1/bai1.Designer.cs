namespace lab1
{
    partial class bai1
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
            label1 = new Label();
            txtNumber1 = new TextBox();
            label2 = new Label();
            txtNumber2 = new TextBox();
            label3 = new Label();
            btnRun = new Button();
            btnExit = new Button();
            label4 = new Label();
            btnSum = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(166, 89);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 0;
            label1.Text = "Số thứ nhất";
            // 
            // txtNumber1
            // 
            txtNumber1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtNumber1.Location = new Point(271, 85);
            txtNumber1.Name = "txtNumber1";
            txtNumber1.Size = new Size(204, 27);
            txtNumber1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(166, 165);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 2;
            label2.Text = "Số thứ hai";
            // 
            // txtNumber2
            // 
            txtNumber2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtNumber2.Location = new Point(271, 158);
            txtNumber2.Name = "txtNumber2";
            txtNumber2.Size = new Size(204, 27);
            txtNumber2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(181, 25);
            label3.Name = "label3";
            label3.Size = new Size(304, 32);
            label3.TabIndex = 4;
            label3.Text = "Tính tổng hai số nguyên";
            // 
            // btnRun
            // 
            btnRun.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnRun.Location = new Point(271, 213);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(94, 29);
            btnRun.TabIndex = 5;
            btnRun.Text = "Tính ";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(381, 213);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 6;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(166, 275);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 7;
            label4.Text = "Kết quả";
            // 
            // btnSum
            // 
            btnSum.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSum.Location = new Point(271, 268);
            btnSum.Name = "btnSum";
            btnSum.ReadOnly = true;
            btnSum.Size = new Size(204, 27);
            btnSum.TabIndex = 8;
            // 
            // bai1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(682, 432);
            Controls.Add(btnSum);
            Controls.Add(label4);
            Controls.Add(btnExit);
            Controls.Add(btnRun);
            Controls.Add(label3);
            Controls.Add(txtNumber2);
            Controls.Add(label2);
            Controls.Add(txtNumber1);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "bai1";
            Text = "bai1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumber1;
        private Label label2;
        private TextBox txtNumber2;
        private Label label3;
        private Button btnRun;
        private Button btnExit;
        private Label label4;
        private TextBox btnSum;
    }
}