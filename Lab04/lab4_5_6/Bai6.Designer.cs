namespace Lab4
{
    partial class Bai6
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
            richTextBox1 = new RichTextBox();
            txtURL = new TextBox();
            button1 = new Button();
            button2 = new Button();
            richTextBox2 = new RichTextBox();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtToken = new TextBox();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 79);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(601, 206);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // txtURL
            // 
            txtURL.Location = new Point(12, 12);
            txtURL.Name = "txtURL";
            txtURL.PlaceholderText = "URL";
            txtURL.Size = new Size(601, 27);
            txtURL.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(861, 185);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(772, 488);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 4;
            button2.Text = "Get user";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(12, 328);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(601, 228);
            richTextBox2.TabIndex = 5;
            richTextBox2.Text = "";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(665, 135);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(150, 27);
            txtUser.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(665, 235);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(150, 27);
            txtPassword.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(665, 95);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 8;
            label1.Text = "username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(665, 194);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 9;
            label2.Text = "password";
            // 
            // txtToken
            // 
            txtToken.Location = new Point(645, 416);
            txtToken.Name = "txtToken";
            txtToken.PlaceholderText = "token";
            txtToken.Size = new Size(379, 27);
            txtToken.TabIndex = 10;
            // 
            // Bai6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 580);
            Controls.Add(txtToken);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(richTextBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtURL);
            Controls.Add(richTextBox1);
            Name = "Bai6";
            Text = "Bai6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox richTextBox1;
        private TextBox txtURL;
        private Button button1;
        private Button button2;
        private RichTextBox richTextBox2;
        private TextBox txtUser;
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
        private TextBox txtToken;
    }
}