using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Time_Capsule
{
    public partial class LoginForm : Form
    {
        DatabaseHelper db = new DatabaseHelper();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Optional: any initialization logic
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (email == "" || password == "")
            {
                MessageBox.Show("Please enter both email and password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "SELECT Id, Name, Email FROM Users WHERE Email = @Email AND Password = @Password";
            SqlParameter[] parameters = {
                new SqlParameter("@Email", email),
                new SqlParameter("@Password", password)
            };

            DataTable dt = db.GetDataTable(query, parameters);
            if (dt.Rows.Count > 0)
            {
                int userId = Convert.ToInt32(dt.Rows[0]["Id"]);
                string username = dt.Rows[0]["Name"].ToString();
                string userEmail = dt.Rows[0]["Email"].ToString();

                MainForm main = new MainForm(userId, username, userEmail);
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid login credentials.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm reg = new RegisterForm();
            reg.Show();
            this.Hide();
        }
    }
}