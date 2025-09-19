using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ComplainManagementSyestem
{
    public partial class Feedback : Form
    {
        
        string connectionString = ConfigurationManager.ConnectionStrings["UserDb"].ConnectionString;

        public Feedback()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserPage userPage = new UserPage();
            userPage.Show();
            this.Hide();
        }

        // Button 2: Submit feedback to the database
        private void button2_Click(object sender, EventArgs e)
        {
            // Get inputs from the form controls
            string complainIdText = textBox1.Text.Trim();  // Complaint ID from TextBox
            string userIdText = textBox2.Text.Trim();      // User ID from TextBox
            string comment = textBox4.Text.Trim();         // Feedback comment from TextBox
            string ratingText = comboBox1.SelectedItem?.ToString();  // Rating from ComboBox

            // Validate inputs
            if (string.IsNullOrWhiteSpace(complainIdText) || string.IsNullOrWhiteSpace(userIdText) ||
                string.IsNullOrWhiteSpace(comment) || string.IsNullOrWhiteSpace(ratingText))
            {
                MessageBox.Show("Please fill in all fields: Complaint ID, User ID, Rating, and Comment.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Convert text inputs to the appropriate types
            int complainId, userId, rating;
            if (!int.TryParse(complainIdText, out complainId) || !int.TryParse(userIdText, out userId) || !int.TryParse(ratingText, out rating))
            {
                MessageBox.Show("Invalid data entered. Please check your Complaint ID, User ID, and Rating.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check rating range (1 to 5)
            if (rating < 1 || rating > 5)
            {
                MessageBox.Show("Rating must be between 1 and 5.", "Rating Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Insert feedback into the database
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "INSERT INTO Feedback (ComplainID, UserID, Rating, Comment) " +
                                   "VALUES (@ComplainID, @UserID, @Rating, @Comment)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@ComplainID", complainId);
                        cmd.Parameters.AddWithValue("@UserID", userId);
                        cmd.Parameters.AddWithValue("@Rating", rating);
                        cmd.Parameters.AddWithValue("@Comment", comment);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Feedback submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Clear the form after successful submission
                            textBox1.Clear();  // Clear Complaint ID
                            textBox2.Clear();  // Clear User ID
                            textBox4.Clear();  // Clear Comment
                            comboBox1.SelectedIndex = -1;  // Clear the selected rating
                        }
                        else
                        {
                            MessageBox.Show("Failed to submit feedback.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error submitting feedback: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
