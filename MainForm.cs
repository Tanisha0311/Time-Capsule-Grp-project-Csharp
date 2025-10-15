using System;
using System.Windows.Forms;

namespace Time_Capsule
{
    public partial class MainForm : Form
    {
        private int userId;
        private string username;
        private string email;

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(int userId, string username, string email)
        {
            InitializeComponent();
            this.userId = userId;
            this.username = username;
            this.email = email;

            lblWelcome.Text = $"Welcome, {username}";
            lblEmail.Text = $"Email: {email}";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ProfileForm profile = new ProfileForm(userId, username, email);
            profile.Show();
            this.Hide();
        }

        private void btnMemories_Click(object sender, EventArgs e)
        {
            MemoriesForm memories = new MemoriesForm(username, email);
            memories.Show();
            this.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            Timer timer = new Timer();
            timer.Interval = 15;
            timer.Tick += (s, args) =>
            {
                if (this.Opacity < 1)
                    this.Opacity += 0.05;
                else
                    timer.Stop();
            };
            timer.Start();
        }
    }
}
