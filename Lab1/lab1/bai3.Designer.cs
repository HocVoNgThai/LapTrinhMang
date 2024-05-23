namespace lab1
{
    partial class bai3
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
            input = new Label();
            txtInput = new TextBox();
            btnDelete = new Button();
            btnRun = new Button();
            btnExit = new Button();
            txtOutput = new TextBox();
            result = new Label();
            SuspendLayout();
            // 
            // input
            // 
            input.AutoSize = true;
            input.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            input.Location = new Point(32, 78);
            input.Name = "input";
            input.Size = new Size(250, 20);
            input.TabIndex = 0;
            input.Text = "Nhập vào số nguyên từ 0 đến 9";
            // 
            // txtInput
            // 
            txtInput.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtInput.Location = new Point(306, 71);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(175, 28);
            txtInput.TabIndex = 1;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(533, 148);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 36);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRun
            // 
            btnRun.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnRun.ForeColor = SystemColors.ControlText;
            btnRun.Location = new Point(533, 69);
            btnRun.Name = "btnRun";
            btnRun.RightToLeft = RightToLeft.No;
            btnRun.Size = new Size(94, 36);
            btnRun.TabIndex = 3;
            btnRun.Text = "Đọc";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(533, 228);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 36);
            btnExit.TabIndex = 4;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtOutput
            // 
            txtOutput.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtOutput.Location = new Point(306, 234);
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.Size = new Size(175, 28);
            txtOutput.TabIndex = 5;
            // 
            // result
            // 
            result.AutoSize = true;
            result.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            result.Location = new Point(195, 242);
            result.Name = "result";
            result.Size = new Size(71, 20);
            result.TabIndex = 6;
            result.Text = "Kết quả";
            // 
            // bai3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Peru;
            ClientSize = new Size(769, 450);
            Controls.Add(result);
            Controls.Add(txtOutput);
            Controls.Add(btnExit);
            Controls.Add(btnRun);
            Controls.Add(btnDelete);
            Controls.Add(txtInput);
            Controls.Add(input);
            Name = "bai3";
            Text = "bai3";
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Label input;
        private TextBox txtInput;
        private Button btnDelete;
        private Button btnRun;
        private Button btnExit;
        private TextBox txtOutput;
        private Label result;
    }
}