namespace Lab2
{
    partial class Bai7
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
            treeView1 = new TreeView();
            btnOpen = new Button();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.BackColor = Color.FromArgb(255, 255, 192);
            treeView1.Dock = DockStyle.Left;
            treeView1.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            treeView1.ForeColor = Color.Gray;
            treeView1.Location = new Point(0, 0);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(639, 562);
            treeView1.TabIndex = 0;
            // 
            // btnOpen
            // 
            btnOpen.BackColor = Color.FromArgb(192, 192, 255);
            btnOpen.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnOpen.ForeColor = Color.FromArgb(128, 128, 255);
            btnOpen.Location = new Point(733, 201);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(188, 127);
            btnOpen.TabIndex = 2;
            btnOpen.Text = "Mở File";
            btnOpen.UseVisualStyleBackColor = false;
            btnOpen.Click += btnOpen_Click;
            // 
            // Bai7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1005, 562);
            Controls.Add(btnOpen);
            Controls.Add(treeView1);
            Name = "Bai7";
            Text = "Bai7";
            Load += Bai7_Load;
            ResumeLayout(false);
        }

        #endregion
        private TreeView treeView1;
        private Button btnOpen;
    }
}