using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ComplainManagementSyestem
{
    public partial class AddComplain : Form
    {
        private int loggedInUserID;

        public AddComplain(int userId)
        {
            InitializeComponent();
            loggedInUserID = userId;
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            string title = textBox1.Text.Trim();
            string description = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Please enter both Title and Description.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = ConfigurationManager.ConnectionStrings["UserDb"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = @"INSERT INTO Complain (UserID, Title, Description, SubmittedDate, CurrentStatus) 
                                     VALUES (@UserID, @Title, @Description, @DateCreated, @CurrentStatus)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", loggedInUserID);
                        cmd.Parameters.AddWithValue("@Title", title);
                        cmd.Parameters.AddWithValue("@Description", description);
                        cmd.Parameters.AddWithValue("@DateCreated", DateTime.Now);
                        cmd.Parameters.AddWithValue("@CurrentStatus", "Pending");

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Complain submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textBox1.Clear();
                            textBox2.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Failed to submit complain.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserPage userPage = new UserPage(loggedInUserID);
            userPage.Show();
        }
    }
}
