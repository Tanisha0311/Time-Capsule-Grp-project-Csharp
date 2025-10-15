using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Time_Capsule
{
    public partial class MemoriesForm : Form
    {
        private string loggedInUserName;
        private string loggedInUserEmail;
        private int loggedInUserId;
        private int selectedMemoryId = -1;
        DatabaseHelper dbHelper = new DatabaseHelper();

        public MemoriesForm(string userName, string userEmail)
        {
            InitializeComponent();
            loggedInUserName = userName;
            loggedInUserEmail = userEmail;
        }

        private void MemoriesForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome, {loggedInUserName}!";
            lblEmail.Text = $"Email: {loggedInUserEmail}";

            // get user id
            string query = "SELECT Id FROM Users WHERE Email=@Email";
            SqlParameter[] parameters = { new SqlParameter("@Email", loggedInUserEmail) };
            object result = dbHelper.ExecuteScalar(query, parameters);
            loggedInUserId = result != null ? Convert.ToInt32(result) : 0;

            LoadMemories();
        }

        private void LoadMemories()
        {
            string query = "SELECT Id, Title, Mood, CreatedAt FROM Memories WHERE UserId=@UserId ORDER BY CreatedAt DESC";
            SqlParameter[] parameters = { new SqlParameter("@UserId", loggedInUserId) };
            DataTable dt = dbHelper.GetDataTable(query, parameters);
            dataGridView1.DataSource = dt;
            if (dataGridView1.Columns.Contains("Id"))
                dataGridView1.Columns["Id"].Visible = false;
        }

        private void ClearFields()
        {
            txtTitle.Text = "";
            txtContent.Text = "";
            txtMood.Text = "";
            selectedMemoryId = -1;
        }

        private void btnAddMemory_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();
            string content = txtContent.Text.Trim();
            string mood = txtMood.Text.Trim();

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(content))
            {
                MessageBox.Show("Title and Content are required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO Memories (UserId, Title, Content, Mood) VALUES (@UserId, @Title, @Content, @Mood)";
            SqlParameter[] parameters = {
                new SqlParameter("@UserId", loggedInUserId),
                new SqlParameter("@Title", title),
                new SqlParameter("@Content", content),
                new SqlParameter("@Mood", mood)
            };

            dbHelper.ExecuteNonQuery(query, parameters);
            MessageBox.Show("Memory added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearFields();
            LoadMemories();
        }

        private void btnUpdateMemory_Click(object sender, EventArgs e)
        {
            if (selectedMemoryId == -1)
            {
                MessageBox.Show("Please select a memory to update.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string title = txtTitle.Text.Trim();
            string content = txtContent.Text.Trim();
            string mood = txtMood.Text.Trim();

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(content))
            {
                MessageBox.Show("Title and Content are required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "UPDATE Memories SET Title=@Title, Content=@Content, Mood=@Mood WHERE Id=@Id AND UserId=@UserId";
            SqlParameter[] parameters = {
                new SqlParameter("@Title", title),
                new SqlParameter("@Content", content),
                new SqlParameter("@Mood", mood),
                new SqlParameter("@Id", selectedMemoryId),
                new SqlParameter("@UserId", loggedInUserId)
            };

            dbHelper.ExecuteNonQuery(query, parameters);
            MessageBox.Show("Memory updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearFields();
            LoadMemories();
        }

        private void btnDeleteMemory_Click(object sender, EventArgs e)
        {
            if (selectedMemoryId == -1)
            {
                MessageBox.Show("Please select a memory to delete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this memory?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM Memories WHERE Id=@Id AND UserId=@UserId";
                SqlParameter[] parameters = {
                    new SqlParameter("@Id", selectedMemoryId),
                    new SqlParameter("@UserId", loggedInUserId)
                };
                dbHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Memory deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadMemories();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                selectedMemoryId = Convert.ToInt32(row.Cells["Id"].Value);

                string query = "SELECT Title, Content, Mood FROM Memories WHERE Id=@Id";
                SqlParameter[] parameters = { new SqlParameter("@Id", selectedMemoryId) };
                DataTable dt = dbHelper.GetDataTable(query, parameters);

                if (dt.Rows.Count > 0)
                {
                    txtTitle.Text = dt.Rows[0]["Title"].ToString();
                    txtContent.Text = dt.Rows[0]["Content"].ToString();
                    txtMood.Text = dt.Rows[0]["Mood"].ToString();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm(0, loggedInUserName, loggedInUserEmail);
            main.Show();
        }
    }
}
