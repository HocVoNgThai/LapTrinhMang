namespace Lab5
{
    partial class Bai1
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
            btnSend = new Button();
            txtFrom = new TextBox();
            txtTo = new TextBox();
            txtSubject = new TextBox();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnSend
            // 
            btnSend.Location = new Point(45, 44);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(102, 60);
            btnSend.TabIndex = 0;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // txtFrom
            // 
            txtFrom.Location = new Point(309, 44);
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new Size(341, 27);
            txtFrom.TabIndex = 1;
            // 
            // txtTo
            // 
            txtTo.Location = new Point(309, 98);
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(341, 27);
            txtTo.TabIndex = 2;
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(89, 169);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(642, 27);
            txtSubject.TabIndex = 3;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(89, 221);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(642, 299);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(220, 44);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 5;
            label1.Text = "From";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(220, 101);
            label2.Name = "label2";
            label2.Size = new Size(25, 20);
            label2.TabIndex = 6;
            label2.Text = "To";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 172);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 7;
            label3.Text = "Subject";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 221);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 8;
            label4.Text = "Body:";
            // 
            // Bai1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 532);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(txtSubject);
            Controls.Add(txtTo);
            Controls.Add(txtFrom);
            Controls.Add(btnSend);
            Name = "Bai1";
            Text = "Bai1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSend;
        private TextBox txtFrom;
        private TextBox txtTo;
        private TextBox txtSubject;
        private RichTextBox richTextBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}