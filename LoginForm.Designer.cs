namespace Time_Capsule
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel linkRegister;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.linkRegister = new System.Windows.Forms.LinkLabel();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();

            // ======== FORM STYLE ========
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ClientSize = new System.Drawing.Size(400, 380);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Login - Time Capsule";
            this.Load += new System.EventHandler(this.LoginForm_Load);

            // ======== TITLE ========
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(40, 53, 147);
            this.lblTitle.Location = new System.Drawing.Point(140, 25);
            this.lblTitle.Text = "Login";

            // ======== PANEL ========
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContainer.Location = new System.Drawing.Point(50, 90);
            this.panelContainer.Size = new System.Drawing.Size(300, 240);
            this.panelContainer.Padding = new System.Windows.Forms.Padding(10);

            // ======== LABEL: EMAIL ========
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEmail.Text = "Email";
            this.lblEmail.Location = new System.Drawing.Point(25, 20);

            // ======== TEXTBOX: EMAIL ========
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.Location = new System.Drawing.Point(25, 45);
            this.txtEmail.Size = new System.Drawing.Size(240, 25);

            // ======== LABEL: PASSWORD ========
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPassword.Text = "Password";
            this.lblPassword.Location = new System.Drawing.Point(25, 85);

            // ======== TEXTBOX: PASSWORD ========
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.Location = new System.Drawing.Point(25, 110);
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(240, 25);

            // ======== BUTTON: LOGIN ========
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(40, 53, 147);
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Text = "Login";
            this.btnLogin.Location = new System.Drawing.Point(25, 155);
            this.btnLogin.Size = new System.Drawing.Size(240, 35);
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // ======== LINK: REGISTER ========
            this.linkRegister.ActiveLinkColor = System.Drawing.Color.FromArgb(40, 53, 147);
            this.linkRegister.LinkColor = System.Drawing.Color.FromArgb(70, 90, 160);
            this.linkRegister.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.linkRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkRegister.Text = "Don't have an account? Register";
            this.linkRegister.Location = new System.Drawing.Point(25, 200);
            this.linkRegister.Size = new System.Drawing.Size(240, 20);
            this.linkRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRegister_LinkClicked);

            // ======== ADD TO PANEL ========
            this.panelContainer.Controls.Add(this.lblEmail);
            this.panelContainer.Controls.Add(this.txtEmail);
            this.panelContainer.Controls.Add(this.lblPassword);
            this.panelContainer.Controls.Add(this.txtPassword);
            this.panelContainer.Controls.Add(this.btnLogin);
            this.panelContainer.Controls.Add(this.linkRegister);

            // ======== ADD TO FORM ========
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panelContainer);

            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}