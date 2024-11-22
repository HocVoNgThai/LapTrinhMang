namespace Lab5
{
    partial class Bai3
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
            this.Lsv_Mails = new System.Windows.Forms.ListView();
            this.Col_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_Subject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_From = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Label_Total = new System.Windows.Forms.Label();
            this.Label_Recent = new System.Windows.Forms.Label();
            this.Tbx_Email = new System.Windows.Forms.TextBox();
            this.Tbx_Password = new System.Windows.Forms.TextBox();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lsv_Mails
            // 
            this.Lsv_Mails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Col_ID,
            this.Col_Subject,
            this.Col_From,
            this.Col_Date});
            this.Lsv_Mails.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lsv_Mails.HideSelection = false;
            this.Lsv_Mails.Location = new System.Drawing.Point(12, 165);
            this.Lsv_Mails.Name = "Lsv_Mails";
            this.Lsv_Mails.Size = new System.Drawing.Size(828, 318);
            this.Lsv_Mails.TabIndex = 0;
            this.Lsv_Mails.UseCompatibleStateImageBehavior = false;
            this.Lsv_Mails.View = System.Windows.Forms.View.Details;
            // 
            // Col_ID
            // 
            this.Col_ID.Text = "ID";
            // 
            // Col_Subject
            // 
            this.Col_Subject.Text = "Subject";
            this.Col_Subject.Width = 350;
            // 
            // Col_From
            // 
            this.Col_From.Text = "From";
            this.Col_From.Width = 200;
            // 
            // Col_Date
            // 
            this.Col_Date.Text = "Date";
            this.Col_Date.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // Label_Total
            // 
            this.Label_Total.AutoSize = true;
            this.Label_Total.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Total.Location = new System.Drawing.Point(28, 110);
            this.Label_Total.Name = "Label_Total";
            this.Label_Total.Size = new System.Drawing.Size(45, 21);
            this.Label_Total.TabIndex = 3;
            this.Label_Total.Text = "Total";
            // 
            // Label_Recent
            // 
            this.Label_Recent.AutoSize = true;
            this.Label_Recent.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Recent.Location = new System.Drawing.Point(287, 110);
            this.Label_Recent.Name = "Label_Recent";
            this.Label_Recent.Size = new System.Drawing.Size(61, 21);
            this.Label_Recent.TabIndex = 4;
            this.Label_Recent.Text = "Recent";
            // 
            // Tbx_Email
            // 
            this.Tbx_Email.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_Email.Location = new System.Drawing.Point(111, 20);
            this.Tbx_Email.Name = "Tbx_Email";
            this.Tbx_Email.Size = new System.Drawing.Size(282, 25);
            this.Tbx_Email.TabIndex = 5;
            // 
            // Tbx_Password
            // 
            this.Tbx_Password.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_Password.Location = new System.Drawing.Point(111, 60);
            this.Tbx_Password.Name = "Tbx_Password";
            this.Tbx_Password.PasswordChar = '*';
            this.Tbx_Password.Size = new System.Drawing.Size(282, 25);
            this.Tbx_Password.TabIndex = 6;
            // 
            // Btn_Login
            // 
            this.Btn_Login.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Login.Location = new System.Drawing.Point(614, 41);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(120, 40);
            this.Btn_Login.TabIndex = 7;
            this.Btn_Login.Text = "LOGIN";
            this.Btn_Login.UseVisualStyleBackColor = true;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 495);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.Tbx_Password);
            this.Controls.Add(this.Tbx_Email);
            this.Controls.Add(this.Label_Recent);
            this.Controls.Add(this.Label_Total);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lsv_Mails);
            this.Name = "Bai3";
            this.Text = "Bai 03 - Email POP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView Lsv_Mails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label_Total;
        private System.Windows.Forms.Label Label_Recent;
        private System.Windows.Forms.TextBox Tbx_Email;
        private System.Windows.Forms.TextBox Tbx_Password;
        private System.Windows.Forms.Button Btn_Login;
        private System.Windows.Forms.ColumnHeader Col_ID;
        private System.Windows.Forms.ColumnHeader Col_Subject;
        private System.Windows.Forms.ColumnHeader Col_From;
        private System.Windows.Forms.ColumnHeader Col_Date;
    }
}

