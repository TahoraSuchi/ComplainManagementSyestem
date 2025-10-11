using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ComplainManagementSyestem
{
    public partial class ShowEvidence : Form
    {
        private int currentUserId;

        public ShowEvidence(int userId)
        {
            InitializeComponent();
            currentUserId = userId;
        }

        private void ShowEvidence_Load(object sender, EventArgs e)
        {
            LoadAllEvidence();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            if (currentUserId <= 0)
            {
                MessageBox.Show("Invalid User ID. Cannot determine role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = ConfigurationManager.ConnectionStrings["UserDb"].ConnectionString;
            string roleQuery = "SELECT Role FROM [User] WHERE UserID = @userId";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(roleQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", currentUserId);
                    conn.Open();

                    object roleObj = cmd.ExecuteScalar();

                    if (roleObj == null)
                    {
                        MessageBox.Show("User ID not found in database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string role = roleObj.ToString();

                    if (string.IsNullOrWhiteSpace(role))
                    {
                        MessageBox.Show("User role is not assigned.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (role.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                    {
                        AdminPage admin = new AdminPage(currentUserId);
                        admin.Show();
                        this.Hide();
                    }
                    else if (role.Equals("Police", StringComparison.OrdinalIgnoreCase))
                    {
                        PolicePage police = new PolicePage(currentUserId);
                        police.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Unknown role: " + role, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving user role: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            string complainId = textBox1.Text.Trim();
            if (string.IsNullOrWhiteSpace(complainId))
            {
                MessageBox.Show("Please enter a Complain ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = ConfigurationManager.ConnectionStrings["UserDb"].ConnectionString;
            string query = "SELECT * FROM Evidence WHERE ComplainID = @cid";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@cid", complainId);
                    conn.Open();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                        dataGridView1.DataSource = dt;
                    else
                    {
                        MessageBox.Show("No evidence found for this Complain ID.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching evidence: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            LoadAllEvidence();
        }

        private void LoadAllEvidence()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["UserDb"].ConnectionString;
            string query = "SELECT * FROM Evidence";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading evidence: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
