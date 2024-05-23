namespace lab1
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
            number1 = new Label();
            number2 = new Label();
            number3 = new Label();
            maxnumber = new Label();
            minnumber = new Label();
            txtNumber3 = new TextBox();
            txtNumber2 = new TextBox();
            txtMax = new TextBox();
            txtNumber1 = new TextBox();
            txtMin = new TextBox();
            btnRun = new Button();
            btnExit = new Button();
            btnDelete = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // number1
            // 
            number1.AutoSize = true;
            number1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            number1.Location = new Point(61, 121);
            number1.Name = "number1";
            number1.Size = new Size(77, 23);
            number1.TabIndex = 0;
            number1.Text = "số thứ 1";
            // 
            // number2
            // 
            number2.AutoSize = true;
            number2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            number2.Location = new Point(420, 121);
            number2.Name = "number2";
            number2.Size = new Size(77, 23);
            number2.TabIndex = 1;
            number2.Text = "số thứ 2";
            // 
            // number3
            // 
            number3.AutoSize = true;
            number3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            number3.Location = new Point(778, 121);
            number3.Name = "number3";
            number3.Size = new Size(77, 23);
            number3.TabIndex = 2;
            number3.Text = "số thứ 3";
            // 
            // maxnumber
            // 
            maxnumber.AutoSize = true;
            maxnumber.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            maxnumber.Location = new Point(754, 286);
            maxnumber.Name = "maxnumber";
            maxnumber.Size = new Size(101, 23);
            maxnumber.TabIndex = 3;
            maxnumber.Text = "số lớn nhất";
            // 
            // minnumber
            // 
            minnumber.AutoSize = true;
            minnumber.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            minnumber.Location = new Point(33, 289);
            minnumber.Name = "minnumber";
            minnumber.Size = new Size(105, 23);
            minnumber.TabIndex = 4;
            minnumber.Text = "số nhỏ nhất";
            // 
            // txtNumber3
            // 
            txtNumber3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtNumber3.Location = new Point(884, 117);
            txtNumber3.Name = "txtNumber3";
            txtNumber3.Size = new Size(189, 30);
            txtNumber3.TabIndex = 5;
            // 
            // txtNumber2
            // 
            txtNumber2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtNumber2.Location = new Point(523, 117);
            txtNumber2.Name = "txtNumber2";
            txtNumber2.Size = new Size(189, 30);
            txtNumber2.TabIndex = 6;
            // 
            // txtMax
            // 
            txtMax.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtMax.Location = new Point(884, 285);
            txtMax.Name = "txtMax";
            txtMax.ReadOnly = true;
            txtMax.Size = new Size(189, 30);
            txtMax.TabIndex = 7;
            // 
            // txtNumber1
            // 
            txtNumber1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtNumber1.Location = new Point(160, 117);
            txtNumber1.Name = "txtNumber1";
            txtNumber1.Size = new Size(189, 30);
            txtNumber1.TabIndex = 8;
            // 
            // txtMin
            // 
            txtMin.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtMin.Location = new Point(160, 285);
            txtMin.Name = "txtMin";
            txtMin.ReadOnly = true;
            txtMin.Size = new Size(189, 30);
            txtMin.TabIndex = 9;
            // 
            // btnRun
            // 
            btnRun.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnRun.Location = new Point(372, 202);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(98, 41);
            btnRun.TabIndex = 10;
            btnRun.Text = "tìm";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += find_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnExit.Location = new Point(688, 202);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(101, 41);
            btnExit.TabIndex = 11;
            btnExit.Text = "thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += exit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnDelete.Location = new Point(535, 202);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(95, 41);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += delete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(402, 27);
            label1.Name = "label1";
            label1.Size = new Size(372, 34);
            label1.TabIndex = 13;
            label1.Text = "Tìm số lớn nhất và nhỏ nhất";
            // 
            // Bai2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1126, 364);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(btnExit);
            Controls.Add(btnRun);
            Controls.Add(txtMin);
            Controls.Add(txtNumber1);
            Controls.Add(txtMax);
            Controls.Add(txtNumber2);
            Controls.Add(txtNumber3);
            Controls.Add(minnumber);
            Controls.Add(maxnumber);
            Controls.Add(number3);
            Controls.Add(number2);
            Controls.Add(number1);
            Name = "Bai2";
            Text = "Bai2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label number1;
        private Label number2;
        private Label number3;
        private Label maxnumber;
        private Label minnumber;
        private TextBox txtNumber3;
        private TextBox txtNumber2;
        private TextBox txtMax;
        private TextBox txtNumber1;
        private TextBox txtMin;
        private Button btnRun;
        private Button btnExit;
        private Button btnDelete;
        private Label label1;
    }
}