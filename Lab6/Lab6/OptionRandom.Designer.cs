namespace lab5_5
{
    partial class OptionRandom
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
            btnAll = new Button();
            btnMy = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnAll
            // 
            btnAll.BackColor = Color.FromArgb(255, 192, 128);
            btnAll.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAll.ForeColor = Color.FromArgb(128, 64, 0);
            btnAll.Location = new Point(170, 162);
            btnAll.Margin = new Padding(4, 3, 4, 3);
            btnAll.Name = "btnAll";
            btnAll.Size = new Size(188, 70);
            btnAll.TabIndex = 0;
            btnAll.Text = "Cộng đồng";
            btnAll.UseVisualStyleBackColor = false;
            btnAll.Click += btnAll_Click;
            // 
            // btnMy
            // 
            btnMy.BackColor = Color.FromArgb(255, 192, 128);
            btnMy.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnMy.ForeColor = Color.FromArgb(128, 64, 0);
            btnMy.Location = new Point(508, 162);
            btnMy.Margin = new Padding(4, 3, 4, 3);
            btnMy.Name = "btnMy";
            btnMy.Size = new Size(188, 70);
            btnMy.TabIndex = 1;
            btnMy.Text = "Cá nhân";
            btnMy.UseVisualStyleBackColor = false;
            btnMy.Click += btnMy_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(278, 60);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(327, 47);
            label1.TabIndex = 2;
            label1.Text = "Chọn list món ăn";
            // 
            // OptionRandom
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 361);
            Controls.Add(label1);
            Controls.Add(btnMy);
            Controls.Add(btnAll);
            Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "OptionRandom";
            Text = "OptionRandom";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAll;
        private Button btnMy;
        private Label label1;
    }
}