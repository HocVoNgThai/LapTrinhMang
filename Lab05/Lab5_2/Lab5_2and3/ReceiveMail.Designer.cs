namespace Lab5_2and3
{
    partial class ReceiveMail
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtAccount = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            label1 = new Label();
            label2 = new Label();
            lstEmail = new ListView();
            Number = new ColumnHeader();
            Email = new ColumnHeader();
            From = new ColumnHeader();
            Date = new ColumnHeader();
            label3 = new Label();
            lbTotal = new Label();
            SuspendLayout();
            // 
            // txtAccount
            // 
            txtAccount.Location = new Point(212, 26);
            txtAccount.Name = "txtAccount";
            txtAccount.Size = new Size(327, 27);
            txtAccount.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(212, 82);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(327, 27);
            txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(579, 55);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 33);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 3;
            label1.Text = "Account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 89);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // lstEmail
            // 
            lstEmail.Columns.AddRange(new ColumnHeader[] { Number, Email, From, Date });
            lstEmail.Dock = DockStyle.Bottom;
            lstEmail.Location = new Point(0, 193);
            lstEmail.Name = "lstEmail";
            lstEmail.Size = new Size(1062, 469);
            lstEmail.TabIndex = 5;
            lstEmail.UseCompatibleStateImageBehavior = false;
            lstEmail.View = View.Details;
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
            From.Width = 312;
            // 
            // Date
            // 
            Date.Text = "Date";
            Date.Width = 300;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 141);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 6;
            label3.Text = "Total mail:";
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Location = new Point(181, 141);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(0, 20);
            lbTotal.TabIndex = 7;
            // 
            // ReceiveMail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 662);
            Controls.Add(lbTotal);
            Controls.Add(label3);
            Controls.Add(lstEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtAccount);
            MaximizeBox = false;
            Name = "ReceiveMail";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAccount;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label label1;
        private Label label2;
        private ListView lstEmail;
        private ColumnHeader Number;
        private ColumnHeader Email;
        private ColumnHeader From;
        private ColumnHeader Date;
        private Label label3;
        private Label lbTotal;
    }
}