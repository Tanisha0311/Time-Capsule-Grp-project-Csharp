namespace Time_Capsule
{
    partial class MemoriesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Label lblMood;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.TextBox txtMood;
        private System.Windows.Forms.Button btnAddMemory;
        private System.Windows.Forms.Button btnUpdateMemory;
        private System.Windows.Forms.Button btnDeleteMemory;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dataGridView1;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
        /// Required method for Designer support — do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblContent = new System.Windows.Forms.Label();
            this.lblMood = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.txtMood = new System.Windows.Forms.TextBox();
            this.btnAddMemory = new System.Windows.Forms.Button();
            this.btnUpdateMemory = new System.Windows.Forms.Button();
            this.btnDeleteMemory = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // === lblWelcome ===
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.Location = new System.Drawing.Point(20, 20);
            this.lblWelcome.Text = "Welcome!";

            // === lblEmail ===
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEmail.ForeColor = System.Drawing.Color.Gray;
            this.lblEmail.Location = new System.Drawing.Point(20, 55);
            this.lblEmail.Text = "user@example.com";

            // === lblTitle ===
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 95);
            this.lblTitle.Text = "Title:";

            // === txtTitle ===
            this.txtTitle.Location = new System.Drawing.Point(100, 92);
            this.txtTitle.Size = new System.Drawing.Size(230, 25);

            // === lblContent ===
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblContent.Location = new System.Drawing.Point(20, 135);
            this.lblContent.Text = "Content:";

            // === txtContent ===
            this.txtContent.Location = new System.Drawing.Point(100, 132);
            this.txtContent.Size = new System.Drawing.Size(230, 100);
            this.txtContent.Multiline = true;
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;

            // === lblMood ===
            this.lblMood.AutoSize = true;
            this.lblMood.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMood.Location = new System.Drawing.Point(20, 250);
            this.lblMood.Text = "Mood:";

            // === txtMood ===
            this.txtMood.Location = new System.Drawing.Point(100, 247);
            this.txtMood.Size = new System.Drawing.Size(230, 25);

            // === btnAddMemory ===
            this.btnAddMemory.Text = "Add";
            this.btnAddMemory.Location = new System.Drawing.Point(20, 300);
            this.btnAddMemory.Size = new System.Drawing.Size(75, 30);
            this.btnAddMemory.Click += new System.EventHandler(this.btnAddMemory_Click);

            // === btnUpdateMemory ===
            this.btnUpdateMemory.Text = "Update";
            this.btnUpdateMemory.Location = new System.Drawing.Point(110, 300);
            this.btnUpdateMemory.Size = new System.Drawing.Size(75, 30);
            this.btnUpdateMemory.Click += new System.EventHandler(this.btnUpdateMemory_Click);

            // === btnDeleteMemory ===
            this.btnDeleteMemory.Text = "Delete";
            this.btnDeleteMemory.Location = new System.Drawing.Point(200, 300);
            this.btnDeleteMemory.Size = new System.Drawing.Size(75, 30);
            this.btnDeleteMemory.Click += new System.EventHandler(this.btnDeleteMemory_Click);

            // === btnBack ===
            this.btnBack.Text = "Back";
            this.btnBack.Location = new System.Drawing.Point(290, 300);
            this.btnBack.Size = new System.Drawing.Size(75, 30);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            // === dataGridView1 ===
            this.dataGridView1.Location = new System.Drawing.Point(360, 90);
            this.dataGridView1.Size = new System.Drawing.Size(410, 380);
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(80, 80, 120);
            this.dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);

            // === MemoriesForm ===
            this.BackColor = System.Drawing.Color.FromArgb(240, 240, 250);
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.lblMood);
            this.Controls.Add(this.txtMood);
            this.Controls.Add(this.btnAddMemory);
            this.Controls.Add(this.btnUpdateMemory);
            this.Controls.Add(this.btnDeleteMemory);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridView1);
            this.Text = "My Memories";
            this.Load += new System.EventHandler(this.MemoriesForm_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
