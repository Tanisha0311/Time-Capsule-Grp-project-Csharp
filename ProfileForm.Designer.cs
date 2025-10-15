namespace Time_Capsule
{
    partial class ProfileForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnBack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.headerPanel = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // ===== FORM SETTINGS =====
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Name = "ProfileForm";
            this.Text = "Profile - Time Capsule";
            this.BackColor = System.Drawing.Color.FromArgb(30, 30, 46);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Load += new System.EventHandler(this.ProfileForm_Load);

            // ===== HEADER PANEL =====
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Height = 80;
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(50, 50, 80);

            // ===== TITLE LABEL =====
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Text = "👤 Your Profile";
            this.lblTitle.Location = new System.Drawing.Point(200, 20);
            this.headerPanel.Controls.Add(this.lblTitle);

            // ===== lblName =====
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(230, 230, 250);
            this.lblName.Location = new System.Drawing.Point(60, 130);
            this.lblName.Text = "Name: User";

            // ===== lblEmail =====
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(200, 200, 220);
            this.lblEmail.Location = new System.Drawing.Point(62, 170);
            this.lblEmail.Text = "Email: user@example.com";

            // ===== btnBack =====
            this.btnBack.Text = "⬅ Back";
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Size = new System.Drawing.Size(200, 45);
            this.btnBack.Location = new System.Drawing.Point(60, 250);
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(85, 110, 230);
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            // ===== ADD CONTROLS =====
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnBack);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}