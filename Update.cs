using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ComplainManagementSyestem
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void Update_Load(object sender, EventArgs e)
        {
          
            this.complainTableAdapter.Fill(this.complainManagementSystemDataSet1.Complain);
        }

    
        private void button1_Click(object sender, EventArgs e)
        {
            AdminPage admin = new AdminPage();
            admin.Show();
            this.Hide();
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            string userId = textBox1.Text.Trim(); 
            if (string.IsNullOrWhiteSpace(userId))
            {
                MessageBox.Show("Please enter a UserID first.", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = ConfigurationManager
                .ConnectionStrings["UserDb"]
                .ConnectionString;

            string query = "SELECT * FROM Complain WHERE UserID = @uid";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@uid", userId);
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
                        MessageBox.Show("No data found for this UserID.",
                                        "Info", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        dataGridView1.DataSource = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message,
                                "Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

   
        private void button3_Click(object sender, EventArgs e)
        {
            string userId = textBox1.Text.Trim();  
            string status = comboBox1.Text.Trim(); 

            if (string.IsNullOrWhiteSpace(userId) || string.IsNullOrWhiteSpace(status))
            {
                MessageBox.Show("UserID and Status are required.", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = ConfigurationManager
                .ConnectionStrings["UserDb"]
                .ConnectionString;

            string query = "UPDATE Complain SET CurrentStatus = @status WHERE UserID = @uid";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@uid", userId);

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Complain status updated successfully!",
                                        "Success", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No record found to update.",
                                        "Info", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating data: " + ex.Message,
                                "Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
            textBox1.Clear();
            comboBox1.SelectedIndex = -1;

            
            string connectionString = ConfigurationManager
                .ConnectionStrings["UserDb"]
                .ConnectionString;

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
                MessageBox.Show("Error loading data: " + ex.Message,
                                "Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
