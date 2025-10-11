using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ComplainManagementSyestem
{
    public partial class Update : Form
    {
        private int changedByUserId;

        public Update(int userId)
        {
            InitializeComponent();
            changedByUserId = userId;
        }

        private void Update_Load(object sender, EventArgs e)
        {
            LoadAllComplains();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["UserDb"].ConnectionString;
            string roleQuery = "SELECT Role FROM [User] WHERE UserID = @userId";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(roleQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", changedByUserId);
                    conn.Open();

                    object roleObj = cmd.ExecuteScalar();

                    if (roleObj != null)
                    {
                        string role = roleObj.ToString();

                        if (role.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                        {
                            AdminPage admin = new AdminPage(changedByUserId);
                            admin.Show();
                        }
                        else if (role.Equals("Police", StringComparison.OrdinalIgnoreCase))
                        {
                            PolicePage police = new PolicePage(changedByUserId);
                            police.Show();
                        }
                        else
                        {
                            MessageBox.Show("Unknown role assigned to this user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("User role not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving user role: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string complainId = textBox1.Text.Trim();
            if (string.IsNullOrWhiteSpace(complainId))
            {
                MessageBox.Show("Please enter a Complain ID first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = ConfigurationManager.ConnectionStrings["UserDb"].ConnectionString;
            string query = "SELECT * FROM Complain WHERE ComplainID = @cid";

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
                    {
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("No data found for this Complain ID.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string complainId = textBox1.Text.Trim();
            string newStatus = comboBox1.Text.Trim();

            if (string.IsNullOrWhiteSpace(complainId) || string.IsNullOrWhiteSpace(newStatus))
            {
                MessageBox.Show("ComplainID and Status are required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = ConfigurationManager.ConnectionStrings["UserDb"].ConnectionString;
            string getOldStatusQuery = "SELECT CurrentStatus FROM Complain WHERE ComplainID = @cid";
            string updateQuery = "UPDATE Complain SET CurrentStatus = @status WHERE ComplainID = @cid";
            string insertHistoryQuery = @"INSERT INTO ComplainHistory 
                                          (ComplainID, ChangedBy, OldStatus, NewStatus, ChangeDate)
                                          VALUES (@cid, @changedBy, @oldStatus, @newStatus, @changeDate)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string oldStatus = "";
                    using (SqlCommand getOldCmd = new SqlCommand(getOldStatusQuery, conn))
                    {
                        getOldCmd.Parameters.AddWithValue("@cid", complainId);
                        object result = getOldCmd.ExecuteScalar();
                        if (result != null)
                            oldStatus = result.ToString();
                    }

                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                    {
                        updateCmd.Parameters.AddWithValue("@status", newStatus);
                        updateCmd.Parameters.AddWithValue("@cid", complainId);
                        int rows = updateCmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            using (SqlCommand insertCmd = new SqlCommand(insertHistoryQuery, conn))
                            {
                                insertCmd.Parameters.AddWithValue("@cid", complainId);
                                insertCmd.Parameters.AddWithValue("@changedBy", changedByUserId);
                                insertCmd.Parameters.AddWithValue("@oldStatus", oldStatus);
                                insertCmd.Parameters.AddWithValue("@newStatus", newStatus);
                                insertCmd.Parameters.AddWithValue("@changeDate", DateTime.Now);

                                insertCmd.ExecuteNonQuery();
                            }

                            MessageBox.Show("Complain status updated and history recorded successfully!",
                                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No record found to update.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

 
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            comboBox1.SelectedIndex = -1;
            LoadAllComplains();
        }

        private void LoadAllComplains()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["UserDb"].ConnectionString;
            string query = "SELECT * FROM Complain";

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
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
