namespace lab1
{
    partial class bai7
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
            label2 = new Label();
            txtInput = new TextBox();
            lstOutput = new ListBox();
            btnRun = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(301, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(408, 42);
            label1.TabIndex = 0;
            label1.Text = "Thông tin điểm sinh viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(64, 114);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(133, 23);
            label2.TabIndex = 1;
            label2.Text = "Nhập thông tin";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(207, 107);
            txtInput.Margin = new Padding(4, 3, 4, 3);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(701, 27);
            txtInput.TabIndex = 2;
            // 
            // lstOutput
            // 
            lstOutput.BackColor = Color.NavajoWhite;
            lstOutput.FormattingEnabled = true;
            lstOutput.ItemHeight = 19;
            lstOutput.Location = new Point(64, 297);
            lstOutput.Margin = new Padding(4, 3, 4, 3);
            lstOutput.Name = "lstOutput";
            lstOutput.Size = new Size(844, 308);
            lstOutput.TabIndex = 3;
            // 
            // btnRun
            // 
            btnRun.Location = new Point(226, 223);
            btnRun.Margin = new Padding(4, 3, 4, 3);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(151, 33);
            btnRun.TabIndex = 5;
            btnRun.Text = "Xuất thông tin";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(444, 223);
            btnDelete.Margin = new Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(135, 33);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(642, 223);
            btnExit.Margin = new Padding(4, 3, 4, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(135, 33);
            btnExit.TabIndex = 7;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(207, 163);
            label3.Name = "label3";
            label3.Size = new Size(689, 20);
            label3.TabIndex = 8;
            label3.Text = "(Lưu ý: Nhập tên và điểm các môn học cách nhau bởi dấu phẩy. Điểm trong khoảng từ 0 đến 10)\r\n";
            // 
            // bai7
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(974, 633);
            Controls.Add(label3);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnRun);
            Controls.Add(lstOutput);
            Controls.Add(txtInput);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "bai7";
            Text = "bai7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtInput;
        private ListBox lstOutput;
        private Button btnRun;
        private Button btnDelete;
        private Button btnExit;
        private Label label3;
    }
}