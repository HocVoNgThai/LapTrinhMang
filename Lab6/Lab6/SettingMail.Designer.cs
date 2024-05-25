namespace lab5_5
{
    partial class SettingMail
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
            groupBox1 = new GroupBox();
            label20 = new Label();
            label19 = new Label();
            txtDay = new TextBox();
            label18 = new Label();
            cbPopSSL = new CheckBox();
            label12 = new Label();
            label14 = new Label();
            txtPopPort = new TextBox();
            txtPop = new TextBox();
            label15 = new Label();
            label16 = new Label();
            cbSSL = new CheckBox();
            label8 = new Label();
            label13 = new Label();
            txtPort = new TextBox();
            txtSmtp = new TextBox();
            label6 = new Label();
            label5 = new Label();
            groupBox2 = new GroupBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            txtNickname = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnSaveAndExit = new Button();
            btnTestConnect = new Button();
            label7 = new Label();
            label17 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(36, 29);
            label1.Name = "label1";
            label1.Size = new Size(353, 40);
            label1.TabIndex = 0;
            label1.Text = "Email Configuaration ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label20);
            groupBox1.Controls.Add(label19);
            groupBox1.Controls.Add(txtDay);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(cbPopSSL);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(txtPopPort);
            groupBox1.Controls.Add(txtPop);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(cbSSL);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(txtPort);
            groupBox1.Controls.Add(txtSmtp);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(36, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(916, 304);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Email server config";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label20.ForeColor = Color.Red;
            label20.Location = new Point(872, 222);
            label20.Name = "label20";
            label20.Size = new Size(17, 20);
            label20.TabIndex = 38;
            label20.Text = "*";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Cambria", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            label19.Location = new Point(472, 260);
            label19.Name = "label19";
            label19.Size = new Size(404, 20);
            label19.TabIndex = 37;
            label19.Text = "*Số ngày bạn muốn lấy mail trong khoảng thời gian đó";
            // 
            // txtDay
            // 
            txtDay.Location = new Point(603, 215);
            txtDay.Name = "txtDay";
            txtDay.Size = new Size(263, 27);
            txtDay.TabIndex = 36;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(469, 222);
            label18.Name = "label18";
            label18.Size = new Size(115, 20);
            label18.TabIndex = 35;
            label18.Text = "Days load mail";
            // 
            // cbPopSSL
            // 
            cbPopSSL.AutoSize = true;
            cbPopSSL.Location = new Point(603, 167);
            cbPopSSL.Name = "cbPopSSL";
            cbPopSSL.Size = new Size(117, 24);
            cbPopSSL.TabIndex = 34;
            cbPopSSL.Text = "Require SSL";
            cbPopSSL.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(872, 54);
            label12.Name = "label12";
            label12.Size = new Size(17, 20);
            label12.TabIndex = 33;
            label12.Text = "*";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.Red;
            label14.Location = new Point(872, 112);
            label14.Name = "label14";
            label14.Size = new Size(17, 20);
            label14.TabIndex = 32;
            label14.Text = "*";
            // 
            // txtPopPort
            // 
            txtPopPort.Location = new Point(603, 105);
            txtPopPort.Name = "txtPopPort";
            txtPopPort.Size = new Size(263, 27);
            txtPopPort.TabIndex = 31;
            // 
            // txtPop
            // 
            txtPop.Location = new Point(603, 47);
            txtPop.Name = "txtPop";
            txtPop.Size = new Size(263, 27);
            txtPop.TabIndex = 30;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(469, 112);
            label15.Name = "label15";
            label15.Size = new Size(76, 20);
            label15.TabIndex = 29;
            label15.Text = "POP Port";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(469, 54);
            label16.Name = "label16";
            label16.Size = new Size(40, 20);
            label16.TabIndex = 28;
            label16.Text = "POP";
            // 
            // cbSSL
            // 
            cbSSL.AutoSize = true;
            cbSSL.Location = new Point(146, 167);
            cbSSL.Name = "cbSSL";
            cbSSL.Size = new Size(117, 24);
            cbSSL.TabIndex = 27;
            cbSSL.Text = "Require SSL";
            cbSSL.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(415, 54);
            label8.Name = "label8";
            label8.Size = new Size(17, 20);
            label8.TabIndex = 26;
            label8.Text = "*";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.Red;
            label13.Location = new Point(415, 112);
            label13.Name = "label13";
            label13.Size = new Size(17, 20);
            label13.TabIndex = 25;
            label13.Text = "*";
            // 
            // txtPort
            // 
            txtPort.Location = new Point(146, 105);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(263, 27);
            txtPort.TabIndex = 3;
            // 
            // txtSmtp
            // 
            txtSmtp.Location = new Point(146, 47);
            txtSmtp.Name = "txtSmtp";
            txtSmtp.Size = new Size(263, 27);
            txtSmtp.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 112);
            label6.Name = "label6";
            label6.Size = new Size(87, 20);
            label6.TabIndex = 1;
            label6.Text = "SMTP Port";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 54);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 0;
            label5.Text = "SMTP";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtPassword);
            groupBox2.Controls.Add(txtEmail);
            groupBox2.Controls.Add(txtNickname);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(36, 417);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(545, 255);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Account information";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(415, 47);
            label11.Name = "label11";
            label11.Size = new Size(17, 20);
            label11.TabIndex = 27;
            label11.Text = "*";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(415, 114);
            label10.Name = "label10";
            label10.Size = new Size(17, 20);
            label10.TabIndex = 26;
            label10.Text = "*";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(415, 188);
            label9.Name = "label9";
            label9.Size = new Size(17, 20);
            label9.TabIndex = 25;
            label9.Text = "*";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(146, 181);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(263, 27);
            txtPassword.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(146, 107);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(263, 27);
            txtEmail.TabIndex = 4;
            // 
            // txtNickname
            // 
            txtNickname.Location = new Point(146, 40);
            txtNickname.Name = "txtNickname";
            txtNickname.Size = new Size(263, 27);
            txtNickname.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 188);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 2;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 114);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 1;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 47);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 0;
            label2.Text = "Nickname";
            // 
            // btnSaveAndExit
            // 
            btnSaveAndExit.BackColor = Color.FromArgb(255, 224, 192);
            btnSaveAndExit.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveAndExit.ForeColor = Color.FromArgb(128, 64, 0);
            btnSaveAndExit.Location = new Point(714, 430);
            btnSaveAndExit.Name = "btnSaveAndExit";
            btnSaveAndExit.Size = new Size(145, 76);
            btnSaveAndExit.TabIndex = 3;
            btnSaveAndExit.Text = "Save and Exit";
            btnSaveAndExit.UseVisualStyleBackColor = false;
            btnSaveAndExit.Click += btnSaveAndExit_Click;
            // 
            // btnTestConnect
            // 
            btnTestConnect.BackColor = Color.FromArgb(255, 192, 128);
            btnTestConnect.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTestConnect.ForeColor = Color.FromArgb(128, 64, 0);
            btnTestConnect.Location = new Point(694, 531);
            btnTestConnect.Name = "btnTestConnect";
            btnTestConnect.Size = new Size(182, 76);
            btnTestConnect.TabIndex = 4;
            btnTestConnect.Text = "Test connection";
            btnTestConnect.UseVisualStyleBackColor = false;
            btnTestConnect.Click += btnTestConnect_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(669, 451);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 5;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Cambria", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label17.Location = new Point(655, 652);
            label17.Name = "label17";
            label17.Size = new Size(257, 20);
            label17.TabIndex = 6;
            label17.Text = "Lưu ý: Test connect chỉ cho smtp";
            // 
            // SettingMail
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 742);
            Controls.Add(label17);
            Controls.Add(label7);
            Controls.Add(btnTestConnect);
            Controls.Add(btnSaveAndExit);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            MaximizeBox = false;
            Name = "SettingMail";
            Text = "SettingMail";
            FormClosing += CloseForm;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private GroupBox groupBox2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnSaveAndExit;
        private Button btnTestConnect;
        private TextBox txtPort;
        private TextBox txtSmtp;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private TextBox txtNickname;
        private Label label7;
        private Label label8;
        private Label label13;
        private Label label11;
        private Label label10;
        private Label label9;
        private CheckBox cbSSL;
        private CheckBox cbPopSSL;
        private Label label12;
        private Label label14;
        private TextBox txtPopPort;
        private TextBox txtPop;
        private Label label15;
        private Label label16;
        private Label label17;
        private TextBox txtDay;
        private Label label18;
        private Label label20;
        private Label label19;
    }
}