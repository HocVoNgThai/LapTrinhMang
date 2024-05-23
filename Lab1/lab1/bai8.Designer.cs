namespace lab1
{
    partial class bai8
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
            txtAdd = new TextBox();
            lstRandom = new ListBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            label2 = new Label();
            txtRandom = new TextBox();
            btnRandom = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(38, 73);
            label1.Name = "label1";
            label1.Size = new Size(108, 19);
            label1.TabIndex = 0;
            label1.Text = "Nhập món ăn ";
            // 
            // txtAdd
            // 
            txtAdd.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtAdd.Location = new Point(179, 66);
            txtAdd.Name = "txtAdd";
            txtAdd.Size = new Size(188, 27);
            txtAdd.TabIndex = 1;
            // 
            // lstRandom
            // 
            lstRandom.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lstRandom.FormattingEnabled = true;
            lstRandom.ItemHeight = 20;
            lstRandom.Items.AddRange(new object[] { "Bún riêu", "Bún thịt nướng", "Phở bò", "Cơm gà" });
            lstRandom.Location = new Point(416, 66);
            lstRandom.Name = "lstRandom";
            lstRandom.Size = new Size(248, 184);
            lstRandom.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(273, 137);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(92, 40);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(307, 293);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(92, 40);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(492, 293);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(92, 40);
            btnExit.TabIndex = 6;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(282, 354);
            label2.Name = "label2";
            label2.Size = new Size(147, 19);
            label2.TabIndex = 7;
            label2.Text = "Món ăn hôm nay là";
            // 
            // txtRandom
            // 
            txtRandom.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtRandom.Location = new Point(250, 376);
            txtRandom.Name = "txtRandom";
            txtRandom.ReadOnly = true;
            txtRandom.Size = new Size(213, 27);
            txtRandom.TabIndex = 8;
            txtRandom.TextAlign = HorizontalAlignment.Center;
            // 
            // btnRandom
            // 
            btnRandom.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnRandom.Location = new Point(114, 293);
            btnRandom.Name = "btnRandom";
            btnRandom.Size = new Size(92, 40);
            btnRandom.TabIndex = 9;
            btnRandom.Text = "Tìm món";
            btnRandom.UseVisualStyleBackColor = true;
            btnRandom.Click += btnRandom_Click;
            // 
            // bai8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(717, 457);
            Controls.Add(btnRandom);
            Controls.Add(txtRandom);
            Controls.Add(label2);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(lstRandom);
            Controls.Add(txtAdd);
            Controls.Add(label1);
            Name = "bai8";
            Text = "bai8";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAdd;
        private ListBox lstRandom;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnExit;
        private Label label2;
        private TextBox txtRandom;
        private Button btnRandom;
    }
}