namespace lab1
{
    partial class bai6
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
            txtOutput = new TextBox();
            label1 = new Label();
            btnTest = new Button();
            dtp1 = new DateTimePicker();
            label2 = new Label();
            btnExit = new Button();
            SuspendLayout();
            // 
            // txtOutput
            // 
            txtOutput.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtOutput.Location = new Point(240, 248);
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.Size = new Size(172, 27);
            txtOutput.TabIndex = 1;
            txtOutput.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(24, 100);
            label1.Name = "label1";
            label1.Size = new Size(177, 19);
            label1.TabIndex = 2;
            label1.Text = "Chọn năm sinh của bạn";
            // 
            // btnTest
            // 
            btnTest.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnTest.Location = new Point(183, 174);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(94, 29);
            btnTest.TabIndex = 3;
            btnTest.Text = "Kiểm tra";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += btnTest_Click;
            // 
            // dtp1
            // 
            dtp1.CalendarFont = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dtp1.CustomFormat = "dd/MM/yyyy";
            dtp1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtp1.Format = DateTimePickerFormat.Custom;
            dtp1.Location = new Point(240, 92);
            dtp1.Name = "dtp1";
            dtp1.Size = new Size(172, 30);
            dtp1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(16, 256);
            label2.Name = "label2";
            label2.Size = new Size(185, 19);
            label2.TabIndex = 6;
            label2.Text = "Cung hoàng đạo của bạn";
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(183, 331);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 7;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // bai6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(472, 430);
            Controls.Add(btnExit);
            Controls.Add(label2);
            Controls.Add(dtp1);
            Controls.Add(btnTest);
            Controls.Add(label1);
            Controls.Add(txtOutput);
            Name = "bai6";
            Text = "bai6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtOutput;
        private Label label1;
        private Button btnTest;
        private DateTimePicker dtp1;
        private Label label2;
        private Button btnExit;
    }
}