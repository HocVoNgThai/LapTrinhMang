namespace Lab6
{
    partial class Show_Invitation
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
            Label_Invitations = new Label();
            Panel_Layout = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // Label_Invitations
            // 
            Label_Invitations.AutoSize = true;
            Label_Invitations.Location = new Point(13, 25);
            Label_Invitations.Margin = new Padding(4, 0, 4, 0);
            Label_Invitations.Name = "Label_Invitations";
            Label_Invitations.Size = new Size(0, 28);
            Label_Invitations.TabIndex = 0;
            // 
            // Panel_Layout
            // 
            Panel_Layout.AutoScroll = true;
            Panel_Layout.Dock = DockStyle.Bottom;
            Panel_Layout.Location = new Point(0, 103);
            Panel_Layout.Name = "Panel_Layout";
            Panel_Layout.Size = new Size(913, 508);
            Panel_Layout.TabIndex = 1;
            // 
            // Show_Invitation
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 611);
            Controls.Add(Panel_Layout);
            Controls.Add(Label_Invitations);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Show_Invitation";
            Text = "Show_Invitation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label_Invitations;
        private FlowLayoutPanel Panel_Layout;
    }
}