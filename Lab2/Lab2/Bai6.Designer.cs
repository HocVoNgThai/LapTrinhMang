namespace Lab2
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
            groupBox1 = new GroupBox();
            rtbInfoDishes = new RichTextBox();
            pictureDishes = new PictureBox();
            btnRandom = new Button();
            treeView = new TreeView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureDishes).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rtbInfoDishes);
            groupBox1.Controls.Add(pictureDishes);
            groupBox1.Dock = DockStyle.Right;
            groupBox1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(453, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(589, 602);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kết quả";
            // 
            // rtbInfoDishes
            // 
            rtbInfoDishes.Dock = DockStyle.Fill;
            rtbInfoDishes.Location = new Point(3, 392);
            rtbInfoDishes.Name = "rtbInfoDishes";
            rtbInfoDishes.Size = new Size(583, 207);
            rtbInfoDishes.TabIndex = 1;
            rtbInfoDishes.Text = "";
            // 
            // pictureDishes
            // 
            pictureDishes.Dock = DockStyle.Top;
            pictureDishes.Location = new Point(3, 30);
            pictureDishes.Name = "pictureDishes";
            pictureDishes.Size = new Size(583, 362);
            pictureDishes.TabIndex = 0;
            pictureDishes.TabStop = false;
            // 
            // btnRandom
            // 
            btnRandom.BackColor = Color.FromArgb(192, 192, 255);
            btnRandom.Font = new Font("Maiandra GD", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnRandom.ForeColor = Color.IndianRed;
            btnRandom.Location = new Point(123, 456);
            btnRandom.Name = "btnRandom";
            btnRandom.Size = new Size(202, 83);
            btnRandom.TabIndex = 2;
            btnRandom.Text = "Chọn món";
            btnRandom.UseVisualStyleBackColor = false;
            btnRandom.Click += btnRandom_Click;
            // 
            // treeView
            // 
            treeView.Dock = DockStyle.Top;
            treeView.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            treeView.Location = new Point(0, 0);
            treeView.Name = "treeView";
            treeView.Size = new Size(453, 392);
            treeView.TabIndex = 3;
            // 
            // Bai6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 602);
            Controls.Add(treeView);
            Controls.Add(btnRandom);
            Controls.Add(groupBox1);
            Name = "Bai6";
            Text = "Bai6";
            Load += Bai6_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureDishes).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private RichTextBox rtbInfoDishes;
        private PictureBox pictureDishes;
        private Button btnRandom;
        private TreeView treeView;
    }
}