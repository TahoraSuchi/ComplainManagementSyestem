using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ComplainManagementSyestem
{
    public partial class ManageUser : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["UserDb"].ConnectionString;

        public ManageUser()
        {
            InitializeComponent();
        }

        private void ManageUser_Load(object sender, EventArgs e)
        {
            LoadAllUsers();
        }

        private void LoadAllUsers()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT UserID, Name, Email, Username, Role FROM [User] ORDER BY UserID";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message);
            }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            string userId = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(userId))
            {
                MessageBox.Show("Please enter a UserID to search.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT UserID, Name, Email, Username, Role FROM [User] WHERE UserID = @UserID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserID", userId);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                        dataGridView1.DataSource = dt;
                    else
                        MessageBox.Show("No user found with this UserID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching user: " + ex.Message);
            }
        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            string userId = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(userId))
            {
                MessageBox.Show("Please enter a UserID to remove.");
                return;
            }

            if (!checkBox1.Checked)
            {
                MessageBox.Show("Please check the checkbox to confirm deletion.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to remove this user and all related complaints/history?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        string deleteHistoryQuery = @"DELETE CH 
                                                      FROM ComplainHistory CH
                                                      INNER JOIN Complain C ON CH.ComplainID = C.ComplainID
                                                      WHERE C.UserID = @UserID";
                        SqlCommand cmdHistory = new SqlCommand(deleteHistoryQuery, conn, transaction);
                        cmdHistory.Parameters.AddWithValue("@UserID", userId);
                        cmdHistory.ExecuteNonQuery();

                        string deleteComplainQuery = "DELETE FROM Complain WHERE UserID = @UserID";
                        SqlCommand cmdComplain = new SqlCommand(deleteComplainQuery, conn, transaction);
                        cmdComplain.Parameters.AddWithValue("@UserID", userId);
                        cmdComplain.ExecuteNonQuery();

                        string deleteUserQuery = "DELETE FROM [User] WHERE UserID = @UserID";
                        SqlCommand cmdUser = new SqlCommand(deleteUserQuery, conn, transaction);
                        cmdUser.Parameters.AddWithValue("@UserID", userId);
                        int rows = cmdUser.ExecuteNonQuery();

                        transaction.Commit();

                        if (rows > 0)
                        {
                            MessageBox.Show("User and all related complaints/history removed successfully.",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadAllUsers();
                            textBox1.Clear();
                            checkBox1.Checked = false;
                        }
                        else
                        {
                            MessageBox.Show("No user found to remove.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error removing user: " + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database: " + ex.Message);
            }
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            checkBox1.Checked = false;
            LoadAllUsers();
        
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            AdminPage admin = new AdminPage();
            admin.Show();
            this.Hide();
        }
    }
}
