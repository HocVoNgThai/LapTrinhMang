namespace btvn_bai2
{
    partial class Login
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
            btnLogin = new Button();
            txtPass = new TextBox();
            txtAccount = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(255, 224, 192);
            btnLogin.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.FromArgb(128, 128, 255);
            btnLogin.Location = new Point(321, 365);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(140, 64);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.Location = new Point(272, 230);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(340, 27);
            txtPass.TabIndex = 1;
            // 
            // txtAccount
            // 
            txtAccount.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtAccount.Location = new Point(272, 150);
            txtAccount.Name = "txtAccount";
            txtAccount.Size = new Size(340, 27);
            txtAccount.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(142, 236);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 3;
            label1.Text = "Mật khẩu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(142, 156);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 4;
            label2.Text = "Tài khoản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(128, 128, 255);
            label3.Location = new Point(260, 52);
            label3.Name = "label3";
            label3.Size = new Size(266, 38);
            label3.TabIndex = 5;
            label3.Text = "Đăng nhập email\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(102, 290);
            label4.Name = "label4";
            label4.Size = new Size(569, 40);
            label4.TabIndex = 6;
            label4.Text = "Lưu ý: Để sử dụng được tài khoản Gmail chúng ta không thể sử dụng trực tiếp \r\nmật khẩu của tài khoản Google mà phải tạo App password để đăng nhập";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(246, 152);
            label5.Name = "label5";
            label5.Size = new Size(20, 25);
            label5.TabIndex = 7;
            label5.Text = "*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(246, 232);
            label6.Name = "label6";
            label6.Size = new Size(20, 25);
            label6.TabIndex = 8;
            label6.Text = "*";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(772, 537);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtAccount);
            Controls.Add(txtPass);
            Controls.Add(btnLogin);
            MaximizeBox = false;
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox txtPass;
        private TextBox txtAccount;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}