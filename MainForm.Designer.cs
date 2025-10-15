namespace Time_Capsule
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnMemories;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblTitle;

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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnMemories = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // ===== FORM SETTINGS =====
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Name = "MainForm";
            this.Text = "Time Capsule";
            this.BackColor = System.Drawing.Color.FromArgb(30, 30, 46);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Load += new System.EventHandler(this.MainForm_Load);

            // ===== HEADER PANEL =====
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Height = 80;
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(50, 50, 80);

            // ===== TITLE LABEL =====
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Text = "⏳ Time Capsule";
            this.lblTitle.Location = new System.Drawing.Point(180, 20);
            this.headerPanel.Controls.Add(this.lblTitle);

            // ===== lblWelcome =====
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(230, 230, 250);
            this.lblWelcome.Location = new System.Drawing.Point(40, 120);
            this.lblWelcome.Text = "Welcome, User";

            // ===== lblEmail =====
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(200, 200, 220);
            this.lblEmail.Location = new System.Drawing.Point(42, 160);
            this.lblEmail.Text = "Email: user@example.com";

            // ===== btnProfile =====
            this.btnProfile.Text = "👤 Profile";
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProfile.Size = new System.Drawing.Size(200, 45);
            this.btnProfile.Location = new System.Drawing.Point(40, 220);
            this.btnProfile.BackColor = System.Drawing.Color.FromArgb(85, 110, 230);
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);

            // ===== btnMemories =====
            this.btnMemories.Text = "🕰 Memories";
            this.btnMemories.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMemories.Size = new System.Drawing.Size(200, 45);
            this.btnMemories.Location = new System.Drawing.Point(40, 280);
            this.btnMemories.BackColor = System.Drawing.Color.FromArgb(120, 90, 220);
            this.btnMemories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemories.FlatAppearance.BorderSize = 0;
            this.btnMemories.ForeColor = System.Drawing.Color.White;
            this.btnMemories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMemories.Click += new System.EventHandler(this.btnMemories_Click);

            // ===== btnLogout =====
            this.btnLogout.Text = "🚪 Logout";
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.Size = new System.Drawing.Size(200, 45);
            this.btnLogout.Location = new System.Drawing.Point(40, 340);
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(240, 84, 84);
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // ===== ADD CONTROLS =====
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnMemories);
            this.Controls.Add(this.btnLogout);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
