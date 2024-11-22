namespace lab4_3
{
    partial class Browser
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
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnDownFile = new System.Windows.Forms.Button();
            this.btnDownSource = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.webView = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUrl
            // 
            this.txtUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrl.Location = new System.Drawing.Point(214, 25);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(548, 27);
            this.txtUrl.TabIndex = 1;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(71, 20);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(106, 38);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnDownFile
            // 
            this.btnDownFile.Location = new System.Drawing.Point(793, 14);
            this.btnDownFile.Name = "btnDownFile";
            this.btnDownFile.Size = new System.Drawing.Size(158, 38);
            this.btnDownFile.TabIndex = 3;
            this.btnDownFile.Text = "Download File";
            this.btnDownFile.UseVisualStyleBackColor = true;
            this.btnDownFile.Click += new System.EventHandler(this.btnDownFile_Click);
            // 
            // btnDownSource
            // 
            this.btnDownSource.Location = new System.Drawing.Point(793, 58);
            this.btnDownSource.Name = "btnDownSource";
            this.btnDownSource.Size = new System.Drawing.Size(158, 38);
            this.btnDownSource.TabIndex = 3;
            this.btnDownSource.Text = "Download Source";
            this.btnDownSource.UseVisualStyleBackColor = true;
            this.btnDownSource.Click += new System.EventHandler(this.btnDownSource_Click);
            // 
            // txtPath
            // 
            this.txtPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.Location = new System.Drawing.Point(214, 69);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(548, 27);
            this.txtPath.TabIndex = 5;
            // 
            // webView
            // 
            this.webView.Location = new System.Drawing.Point(3, 126);
            this.webView.MinimumSize = new System.Drawing.Size(20, 20);
            this.webView.Name = "webView";
            this.webView.ScriptErrorsSuppressed = true;
            this.webView.Size = new System.Drawing.Size(1066, 541);
            this.webView.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "File Path ";
            // 
            // Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 665);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.webView);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnDownSource);
            this.Controls.Add(this.btnDownFile);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtUrl);
            this.Name = "Browser";
            this.Text = "Browser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnDownFile;
        private System.Windows.Forms.Button btnDownSource;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.WebBrowser webView;
        private System.Windows.Forms.Label label1;
    }
}

