namespace Time_Capsule
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.LinkLabel linkLogin;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;

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
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.linkLogin = new System.Windows.Forms.LinkLabel();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();

            // Form background
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(40, 53, 147);
            this.lblTitle.Location = new System.Drawing.Point(110, 20);
            this.lblTitle.Text = "Register";

            // panelContainer
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContainer.Controls.Add(this.lblName);
            this.panelContainer.Controls.Add(this.lblEmail);
            this.panelContainer.Controls.Add(this.lblPassword);
            this.panelContainer.Controls.Add(this.txtName);
            this.panelContainer.Controls.Add(this.txtEmail);
            this.panelContainer.Controls.Add(this.txtPassword);
            this.panelContainer.Controls.Add(this.btnRegister);
            this.panelContainer.Controls.Add(this.linkLogin);
            this.panelContainer.Location = new System.Drawing.Point(50, 80);
            this.panelContainer.Size = new System.Drawing.Size(300, 300);
            this.panelContainer.Padding = new System.Windows.Forms.Padding(10);

            // lblName
            this.lblName.AutoSize = true;
            this.lblName.Text = "Full Name";
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblName.Location = new System.Drawing.Point(25, 20);

            // txtName
            this.txtName.Location = new System.Drawing.Point(25, 45);
            this.txtName.Size = new System.Drawing.Size(240, 25);
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10F);

            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Text = "Email";
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEmail.Location = new System.Drawing.Point(25, 85);

            // txtEmail
            this.txtEmail.Location = new System.Drawing.Point(25, 110);
            this.txtEmail.Size = new System.Drawing.Size(240, 25);
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);

            // lblPassword
            this.lblPassword.AutoSize = true;
            this.lblPassword.Text = "Password";
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPassword.Location = new System.Drawing.Point(25, 150);

            // txtPassword
            this.txtPassword.Location = new System.Drawing.Point(25, 175);
            this.txtPassword.Size = new System.Drawing.Size(240, 25);
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);

            // btnRegister
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(40, 53, 147);
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRegister.Location = new System.Drawing.Point(25, 220);
            this.btnRegister.Size = new System.Drawing.Size(240, 35);
            this.btnRegister.Text = "Register";
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);

            // linkLogin
            this.linkLogin.ActiveLinkColor = System.Drawing.Color.FromArgb(40, 53, 147);
            this.linkLogin.LinkColor = System.Drawing.Color.FromArgb(70, 90, 160);
            this.linkLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLogin.Text = "Already have an account? Login";
            this.linkLogin.Location = new System.Drawing.Point(25, 265);
            this.linkLogin.Size = new System.Drawing.Size(240, 20);
            this.linkLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.linkLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLogin_LinkClicked);

            // RegisterForm
            this.ClientSize = new System.Drawing.Size(400, 420);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "RegisterForm";
            this.Text = "Register - Time Capsule";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}