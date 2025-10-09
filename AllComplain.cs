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

        // Load all complaints into DataGridView
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

        // Search complaint by ComplainID
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

        // Reset search and reload all complaints
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            LoadAllComplaints();
        }

        // Back button to AdminPage
        private void backbtn_Click(object sender, EventArgs e)
        {
            AdminPage admin = new AdminPage();
            admin.Show();
            this.Hide();
        }
    }
}
