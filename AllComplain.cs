using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace ComplainManagementSyestem
{
    public partial class AllComplain : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["UserDb"].ConnectionString;

        public AllComplain()
        {
            InitializeComponent();
        }

        private void AllComplain_Load(object sender, EventArgs e)
        {
            LoadAllComplaints();
        }


        private void LoadAllComplaints()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Complain";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading complaints: " + ex.Message);
            }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            string complainId = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(complainId))
            {
                MessageBox.Show("Please enter a Complain ID to search.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Complain WHERE ComplainID = @ComplainID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ComplainID", complainId);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("No complaint found with this Complain ID.");
                        dataGridView1.DataSource = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching data: " + ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            LoadAllComplaints();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            AdminPage admin = new AdminPage();
            admin.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string searchText = textBox1.Text.Trim();
                    string query;

                    if (string.IsNullOrEmpty(searchText))
                    {
                        // If search box is empty, load all complaints
                        query = "SELECT * FROM Complain";
                    }
                    else
                    {
                        // Search only by ComplainID
                        query = "SELECT * FROM Complain WHERE ComplainID LIKE @SearchText";
                    }

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


    }
}

