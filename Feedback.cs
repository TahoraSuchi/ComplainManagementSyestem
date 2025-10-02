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

      
        private void button2_Click(object sender, EventArgs e)
        {
            
            string complainIdText = textBox1.Text.Trim(); 
            string userIdText = textBox2.Text.Trim();     
            string comment = textBox4.Text.Trim();         
            string ratingText = comboBox1.SelectedItem?.ToString();  
          

            if (string.IsNullOrWhiteSpace(complainIdText) || string.IsNullOrWhiteSpace(userIdText) ||
                string.IsNullOrWhiteSpace(comment) || string.IsNullOrWhiteSpace(ratingText))
            {
                MessageBox.Show("Please fill in all fields: Complaint ID, User ID, Rating, and Comment.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

          
            int complainId, userId, rating;
            if (!int.TryParse(complainIdText, out complainId) || !int.TryParse(userIdText, out userId) || !int.TryParse(ratingText, out rating))
            {
                MessageBox.Show("Invalid data entered. Please check your Complaint ID, User ID, and Rating.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
            if (rating < 1 || rating > 5)
            {
                MessageBox.Show("Rating must be between 1 and 5.", "Rating Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "INSERT INTO Feedback (ComplainID, UserID, Rating, Comment) " +
                                   "VALUES (@ComplainID, @UserID, @Rating, @Comment)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                    
                        cmd.Parameters.AddWithValue("@ComplainID", complainId);
                        cmd.Parameters.AddWithValue("@UserID", userId);
                        cmd.Parameters.AddWithValue("@Rating", rating);
                        cmd.Parameters.AddWithValue("@Comment", comment);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Feedback submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                            textBox1.Clear();  
                            textBox2.Clear();  
                            textBox4.Clear();  
                            comboBox1.SelectedIndex = -1;  
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
