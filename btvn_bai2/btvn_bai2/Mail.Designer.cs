namespace btvn_bai2
{
    partial class Mail
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
            lstMail = new ListView();
            Number = new ColumnHeader();
            Email = new ColumnHeader();
            From = new ColumnHeader();
            Date = new ColumnHeader();
            btnSend = new Button();
            label1 = new Label();
            label2 = new Label();
            txtAccount = new TextBox();
            SuspendLayout();
            // 
            // lstMail
            // 
            lstMail.Columns.AddRange(new ColumnHeader[] { Number, Email, From, Date });
            lstMail.Dock = DockStyle.Bottom;
            lstMail.Location = new Point(0, 170);
            lstMail.Margin = new Padding(4, 3, 4, 3);
            lstMail.Name = "lstMail";
            lstMail.Size = new Size(1100, 499);
            lstMail.TabIndex = 0;
            lstMail.UseCompatibleStateImageBehavior = false;
            lstMail.View = View.Details;
            lstMail.MouseDoubleClick += listView_MouseClick;
            // 
            // Number
            // 
            Number.Text = "Number";
            Number.Width = 100;
            // 
            // Email
            // 
            Email.Text = "Email";
            Email.Width = 350;
            // 
            // From
            // 
            From.Text = "From";
            From.Width = 350;
            // 
            // Date
            // 
            Date.Text = "Date";
            Date.Width = 300;
            // 
            // btnSend
            // 
            btnSend.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSend.Location = new Point(921, 48);
            btnSend.Margin = new Padding(4, 3, 4, 3);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(135, 47);
            btnSend.TabIndex = 1;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(727, 60);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(155, 23);
            label1.TabIndex = 2;
            label1.Text = "Gửi email tại đây";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(35, 60);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(94, 23);
            label2.TabIndex = 3;
            label2.Text = "Tài khoản";
            // 
            // txtAccount
            // 
            txtAccount.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtAccount.Location = new Point(169, 53);
            txtAccount.Margin = new Padding(4, 3, 4, 3);
            txtAccount.Name = "txtAccount";
            txtAccount.ReadOnly = true;
            txtAccount.Size = new Size(405, 30);
            txtAccount.TabIndex = 4;
            // 
            // Mail
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 669);
            Controls.Add(txtAccount);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSend);
            Controls.Add(lstMail);
            Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Mail";
            Text = "Mail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lstMail;
        private ColumnHeader Number;
        private ColumnHeader Email;
        private ColumnHeader From;
        private ColumnHeader Date;
        private Button btnSend;
        private Label label1;
        private Label label2;
        private TextBox txtAccount;
    }
}