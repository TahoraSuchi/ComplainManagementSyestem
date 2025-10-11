using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ComplainManagementSyestem
{
    public partial class AddEvidence : Form
    {
        private int userId;

        public AddEvidence(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
             
                textBox2.Text = openFileDialog.FileName;
            }
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
         
            string complainIdText = textBox1.Text.Trim();
            string filePath = textBox2.Text.Trim();

         
            if (string.IsNullOrEmpty(complainIdText) || string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Please fill both Complain ID and select a file!",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(complainIdText, out int complainId))
            {
                MessageBox.Show("Invalid Complain ID. Please enter a numeric value.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["UserDb"].ConnectionString;

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"INSERT INTO Evidence (ComplainID, FilePath, UploadDate)
                                     VALUES (@ComplainID, @FilePath, @UploadDate)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ComplainID", complainId);
                        cmd.Parameters.AddWithValue("@FilePath", filePath);
                        cmd.Parameters.AddWithValue("@UploadDate", DateTime.Now);

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Evidence submitted successfully!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            textBox1.Clear();
                            textBox2.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Failed to submit evidence.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void backbtn_Click(object sender, EventArgs e)
        {
            UserPage userPage = new UserPage(userId);
            userPage.Show();
            this.Hide();
        }
    }
}
