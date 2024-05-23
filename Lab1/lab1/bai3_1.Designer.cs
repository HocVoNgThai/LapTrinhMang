namespace lab1
{
    partial class bai3_1
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
            read = new Button();
            delete = new Button();
            exit = new Button();
            label1 = new Label();
            inputtext = new TextBox();
            label2 = new Label();
            resulttext = new TextBox();
            SuspendLayout();
            // 
            // read
            // 
            read.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            read.Location = new Point(614, 53);
            read.Name = "read";
            read.Size = new Size(92, 51);
            read.TabIndex = 0;
            read.Text = "Đọc";
            read.UseVisualStyleBackColor = true;
            read.Click += read_Click;
            // 
            // delete
            // 
            delete.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            delete.Location = new Point(614, 131);
            delete.Name = "delete";
            delete.Size = new Size(92, 51);
            delete.TabIndex = 1;
            delete.Text = "Xóa\r\n";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // exit
            // 
            exit.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            exit.Location = new Point(614, 207);
            exit.Name = "exit";
            exit.Size = new Size(92, 51);
            exit.TabIndex = 2;
            exit.Text = "Thoát";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(57, 69);
            label1.Name = "label1";
            label1.Size = new Size(152, 19);
            label1.TabIndex = 3;
            label1.Text = "Nhập vào số nguyên";
            // 
            // inputtext
            // 
            inputtext.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            inputtext.Location = new Point(238, 61);
            inputtext.Name = "inputtext";
            inputtext.Size = new Size(301, 27);
            inputtext.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(57, 181);
            label2.Name = "label2";
            label2.Size = new Size(65, 19);
            label2.TabIndex = 5;
            label2.Text = "Kết quả";
            // 
            // resulttext
            // 
            resulttext.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            resulttext.Location = new Point(57, 231);
            resulttext.Name = "resulttext";
            resulttext.ReadOnly = true;
            resulttext.Size = new Size(482, 27);
            resulttext.TabIndex = 6;
            // 
            // bai3_1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Peru;
            ClientSize = new Size(800, 450);
            Controls.Add(resulttext);
            Controls.Add(label2);
            Controls.Add(inputtext);
            Controls.Add(label1);
            Controls.Add(exit);
            Controls.Add(delete);
            Controls.Add(read);
            Name = "bai3_1";
            Text = "bai3_1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button read;
        private Button delete;
        private Button exit;
        private Label label1;
        private TextBox inputtext;
        private Label label2;
        private TextBox resulttext;
    }
}