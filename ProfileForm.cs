using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Time_Capsule
{
    public partial class ProfileForm : Form
    {
        private int userId;
        private string username;
        private string email;
        DatabaseHelper db = new DatabaseHelper();

        public ProfileForm(int userId, string username, string email)
        {
            InitializeComponent();
            this.userId = userId;
            this.username = username;
            this.email = email;
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            lblName.Text = "Name: " + username;
            lblEmail.Text = "Email: " + email;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm(userId, username, email);
            main.Show();
            this.Hide();
        }

        private void SomeMethod()
        {
            string query = "SELECT COUNT(*) FROM Users";
            SqlParameter[] parameters = new SqlParameter[0];
            object result = db.ExecuteScalar(query, parameters);
        }
    }
}