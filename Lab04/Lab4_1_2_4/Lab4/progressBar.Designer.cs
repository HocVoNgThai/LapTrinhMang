namespace Lab4
{
    partial class progressBar
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
            this.Label_Loading = new System.Windows.Forms.Label();
            this.PrgBar = new System.Windows.Forms.ProgressBar();
            this.Label_progress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label_Loading
            // 
            this.Label_Loading.AutoSize = true;
            this.Label_Loading.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Loading.Location = new System.Drawing.Point(224, 51);
            this.Label_Loading.Name = "Label_Loading";
            this.Label_Loading.Size = new System.Drawing.Size(105, 30);
            this.Label_Loading.TabIndex = 0;
            this.Label_Loading.Text = "Loading...";
            // 
            // PrgBar
            // 
            this.PrgBar.Location = new System.Drawing.Point(13, 213);
            this.PrgBar.Name = "PrgBar";
            this.PrgBar.Size = new System.Drawing.Size(520, 36);
            this.PrgBar.TabIndex = 1;
            // 
            // Label_progress
            // 
            this.Label_progress.AutoSize = true;
            this.Label_progress.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_progress.Location = new System.Drawing.Point(257, 220);
            this.Label_progress.Name = "Label_progress";
            this.Label_progress.Size = new System.Drawing.Size(32, 21);
            this.Label_progress.TabIndex = 2;
            this.Label_progress.Text = "0%";
            // 
            // progressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 261);
            this.Controls.Add(this.Label_progress);
            this.Controls.Add(this.PrgBar);
            this.Controls.Add(this.Label_Loading);
            this.Name = "progressBar";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Loading;
        private System.Windows.Forms.ProgressBar PrgBar;
        private System.Windows.Forms.Label Label_progress;
    }
}