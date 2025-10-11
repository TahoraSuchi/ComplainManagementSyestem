using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ComplainManagementSyestem
{
    public partial class ShowFeedback : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["UserDb"].ConnectionString;
        private int loggedInUserID;


        public ShowFeedback(int userId)
        {
            InitializeComponent();
            loggedInUserID = userId;
        }

        public ShowFeedback()
        {
            InitializeComponent();
        }

        private void ShowFeedback_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'complainManagementSystemDataSet10.Feedback' table. You can move, or remove it, as needed.
            this.feedbackTableAdapter1.Fill(this.complainManagementSystemDataSet10.Feedback);
            LoadAllFeedback();
        }

 
        private void LoadAllFeedback()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Feedback";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading feedback: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void searchbtn_Click(object sender, EventArgs e)
        {
            string searchText = textBox1.Text.Trim(); 

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query;
                    if (string.IsNullOrEmpty(searchText))
                    {
                        query = "SELECT * FROM Feedback";
                    }
                    else
                    {
                        query = "SELECT * FROM Feedback WHERE ComplainID LIKE @search";
                    }

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@search", "%" + searchText + "%");

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching feedback: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox1.Text.Trim();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query;
                    if (string.IsNullOrEmpty(searchText))
                    {
                        query = "SELECT * FROM Feedback";
                    }
                    else
                    {
                        query = "SELECT * FROM Feedback WHERE ComplainID LIKE @search";
                    }

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@search", "%" + searchText + "%");

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering feedback: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     
        private void refreshbtn_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            LoadAllFeedback();
            MessageBox.Show("Data refreshed successfully!", "Refreshed", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            AdminPage admin = new AdminPage(loggedInUserID);
            admin.Show();
            this.Hide();
        }
    }
}
