namespace lab5_5
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
            btnConfig = new Button();
            label1 = new Label();
            txtEmail = new TextBox();
            btnAdd = new Button();
            btnSend = new Button();
            lbCheckConnect = new Label();
            label3 = new Label();
            label4 = new Label();
            lstEmail = new ListBox();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // btnConfig
            // 
            btnConfig.BackColor = Color.FromArgb(255, 224, 192);
            btnConfig.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfig.ForeColor = Color.FromArgb(128, 64, 0);
            btnConfig.Location = new Point(588, 340);
            btnConfig.Name = "btnConfig";
            btnConfig.Size = new Size(136, 47);
            btnConfig.TabIndex = 0;
            btnConfig.Text = "Config mail ";
            btnConfig.UseVisualStyleBackColor = false;
            btnConfig.Click += btnConfig_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 173);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 1;
            label1.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(83, 166);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(476, 27);
            txtEmail.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(255, 224, 192);
            btnAdd.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.FromArgb(128, 64, 0);
            btnAdd.Location = new Point(588, 161);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(136, 37);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add mail";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.FromArgb(255, 224, 192);
            btnSend.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSend.ForeColor = Color.FromArgb(128, 64, 0);
            btnSend.Location = new Point(588, 450);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(136, 47);
            btnSend.TabIndex = 5;
            btnSend.Text = "Send mail";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // lbCheckConnect
            // 
            lbCheckConnect.AutoSize = true;
            lbCheckConnect.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbCheckConnect.ForeColor = Color.Firebrick;
            lbCheckConnect.Location = new Point(8, 559);
            lbCheckConnect.Name = "lbCheckConnect";
            lbCheckConnect.Size = new Size(233, 21);
            lbCheckConnect.TabIndex = 6;
            lbCheckConnect.Text = "Email Server Disconnected";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.IndianRed;
            label3.Location = new Point(176, 32);
            label3.Name = "label3";
            label3.Size = new Size(370, 40);
            label3.TabIndex = 7;
            label3.Text = "Gửi món ăn cho bạn bè";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(83, 206);
            label4.Name = "label4";
            label4.Size = new Size(358, 20);
            label4.TabIndex = 8;
            label4.Text = "*Nhập các email bạn muốn gửi thông tin món ăn\r\n";
            // 
            // lstEmail
            // 
            lstEmail.FormattingEnabled = true;
            lstEmail.ItemHeight = 20;
            lstEmail.Location = new Point(12, 249);
            lstEmail.Name = "lstEmail";
            lstEmail.Size = new Size(547, 284);
            lstEmail.TabIndex = 9;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 224, 192);
            btnDelete.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.FromArgb(128, 64, 0);
            btnDelete.Location = new Point(588, 249);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(136, 37);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete mail";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // SendMail
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 588);
            Controls.Add(btnDelete);
            Controls.Add(lstEmail);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lbCheckConnect);
            Controls.Add(btnSend);
            Controls.Add(btnAdd);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Controls.Add(btnConfig);
            Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "SendMail";
            Text = "SendMail";
            Load += SendMail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfig;
        private Label label1;
        private TextBox txtEmail;
        private Button btnAdd;
        private Button btnSend;
        private Label lbCheckConnect;
        private Label label3;
        private Label label4;
        private ListBox lstEmail;
        private Button btnDelete;
    }
}