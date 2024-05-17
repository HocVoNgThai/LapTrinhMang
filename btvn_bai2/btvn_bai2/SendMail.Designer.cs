namespace btvn_bai2
{
    partial class SendMail
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
            label3 = new Label();
            label4 = new Label();
            txtFrom = new TextBox();
            txtDest = new TextBox();
            txtSubject = new TextBox();
            rtbBody = new RichTextBox();
            btnSend = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(97, 38);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 23);
            label1.TabIndex = 0;
            label1.Text = "From";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(97, 131);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(31, 23);
            label2.TabIndex = 1;
            label2.Text = "To";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(97, 229);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(74, 23);
            label3.TabIndex = 2;
            label3.Text = "Subject";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(97, 317);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(53, 23);
            label4.TabIndex = 3;
            label4.Text = "Body";
            // 
            // txtFrom
            // 
            txtFrom.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFrom.Location = new Point(224, 30);
            txtFrom.Margin = new Padding(5);
            txtFrom.Name = "txtFrom";
            txtFrom.ReadOnly = true;
            txtFrom.Size = new Size(591, 30);
            txtFrom.TabIndex = 4;
            // 
            // txtDest
            // 
            txtDest.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDest.Location = new Point(224, 124);
            txtDest.Margin = new Padding(5);
            txtDest.Name = "txtDest";
            txtDest.Size = new Size(591, 30);
            txtDest.TabIndex = 5;
            // 
            // txtSubject
            // 
            txtSubject.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSubject.Location = new Point(224, 222);
            txtSubject.Margin = new Padding(5);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(591, 30);
            txtSubject.TabIndex = 6;
            // 
            // rtbBody
            // 
            rtbBody.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            rtbBody.Location = new Point(224, 315);
            rtbBody.Margin = new Padding(5);
            rtbBody.Name = "rtbBody";
            rtbBody.Size = new Size(938, 383);
            rtbBody.TabIndex = 7;
            rtbBody.Text = "";
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.FromArgb(192, 192, 255);
            btnSend.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSend.Location = new Point(914, 106);
            btnSend.Margin = new Padding(5);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(169, 67);
            btnSend.TabIndex = 8;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(185, 129);
            label5.Name = "label5";
            label5.Size = new Size(20, 25);
            label5.TabIndex = 9;
            label5.Text = "*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(185, 314);
            label6.Name = "label6";
            label6.Size = new Size(20, 25);
            label6.TabIndex = 10;
            label6.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(185, 227);
            label7.Name = "label7";
            label7.Size = new Size(20, 25);
            label7.TabIndex = 11;
            label7.Text = "*";
            // 
            // SendMail
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 697);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnSend);
            Controls.Add(rtbBody);
            Controls.Add(txtSubject);
            Controls.Add(txtDest);
            Controls.Add(txtFrom);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "SendMail";
            Text = "SendMail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtFrom;
        private TextBox txtDest;
        private TextBox txtSubject;
        private RichTextBox rtbBody;
        private Button btnSend;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}