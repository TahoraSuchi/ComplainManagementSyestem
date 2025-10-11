using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ComplainManagementSyestem
{
    public partial class AllHistory : Form
    {
        private int loggedInUserID;
        private string connectionString = ConfigurationManager.ConnectionStrings["UserDb"].ConnectionString;

        public AllHistory(int userId)
        {
            InitializeComponent();
            loggedInUserID = userId;
        }

        private void AllHistory_Load(object sender, EventArgs e)
        {
            LoadAllHistory();
        }

        private void LoadAllHistory()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM ComplainHistory ORDER BY ChangeDate DESC";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading history: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            string complainId = textBox1.Text.Trim();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = string.IsNullOrEmpty(complainId)
                        ? "SELECT * FROM ComplainHistory ORDER BY ChangeDate DESC"
                        : "SELECT * FROM ComplainHistory WHERE CAST(ComplainID AS NVARCHAR) = @ComplainID";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    if (!string.IsNullOrEmpty(complainId))
                        cmd.Parameters.AddWithValue("@ComplainID", complainId);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching history: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            LoadAllHistory();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            if (loggedInUserID <= 0)
            {
                MessageBox.Show("Invalid User ID. Cannot determine role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string roleQuery = "SELECT Role FROM [User] WHERE UserID = @userId";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(roleQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", loggedInUserID);
                    conn.Open();

                    object roleObj = cmd.ExecuteScalar();
                    if (roleObj == null)
                    {
                        MessageBox.Show("User ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        AdminPage admin = new AdminPage(loggedInUserID);
                        admin.Show();
                        this.Hide();
                    }
                    else if (role.Equals("Police", StringComparison.OrdinalIgnoreCase))
                    {
                        PolicePage police = new PolicePage(loggedInUserID);
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
    }
}
