namespace Lab2
{
    partial class Bai1
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
            btnRead = new Button();
            rtbReadFile = new RichTextBox();
            btnWrite = new Button();
            SuspendLayout();
            // 
            // btnRead
            // 
            btnRead.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnRead.Location = new Point(50, 28);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(120, 60);
            btnRead.TabIndex = 0;
            btnRead.Text = "Đọc file";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // rtbReadFile
            // 
            rtbReadFile.Dock = DockStyle.Right;
            rtbReadFile.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rtbReadFile.Location = new Point(236, 0);
            rtbReadFile.Name = "rtbReadFile";
            rtbReadFile.Size = new Size(404, 450);
            rtbReadFile.TabIndex = 1;
            rtbReadFile.Text = "\n";
            // 
            // btnWrite
            // 
            btnWrite.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnWrite.Location = new Point(50, 152);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(120, 60);
            btnWrite.TabIndex = 2;
            btnWrite.Text = "Ghi file";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += btnWrite_Click;
            // 
            // Bai1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 450);
            Controls.Add(btnWrite);
            Controls.Add(rtbReadFile);
            Controls.Add(btnRead);
            Name = "Bai1";
            Text = "Bai1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRead;
        private RichTextBox rtbReadFile;
        private Button btnWrite;
    }
}