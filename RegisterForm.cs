using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Time_Capsule
{
    public partial class RegisterForm : Form
    {
        DatabaseHelper db = new DatabaseHelper();

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            // Optional initialization
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (name == "" || email == "" || password == "")
            {
                MessageBox.Show("Please fill all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO Users (Name, Email, Password) VALUES (@Name, @Email, @Password)";
            SqlParameter[] parameters = {
                new SqlParameter("@Name", name),
                new SqlParameter("@Email", email),
                new SqlParameter("@Password", password)
            };

            try
            {
                int result = db.ExecuteNonQuery(query, parameters);
                if (result > 0)
                {
                    MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoginForm login = new LoginForm();
                    login.Show();
                    this.Hide();
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627) // unique constraint violation
                    MessageBox.Show("This email is already registered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }
    }
}