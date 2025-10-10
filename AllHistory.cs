using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ComplainManagementSyestem
{
    public partial class AllHistory : Form
    {
        private int loggedInUserID;
        string connectionString = ConfigurationManager.ConnectionStrings["UserDb"].ConnectionString;


        public AllHistory(int userId)
        {
            InitializeComponent();
            loggedInUserID = userId;
        }

        public AllHistory()
        {
            InitializeComponent();
        }

        private void AllHistory_Load(object sender, EventArgs e)
        {
            LoadAllHistory();
        }


        private void LoadAllHistory()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM ComplainHistory ORDER BY ChangeDate DESC";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading history: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

   
        private void searchbtn_Click(object sender, EventArgs e)
        {
            string complainId = textBox1.Text.Trim();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query;
                    if (string.IsNullOrEmpty(complainId))
                        query = "SELECT * FROM ComplainHistory ORDER BY ChangeDate DESC";
                    else
                        query = "SELECT * FROM ComplainHistory WHERE CAST(ComplainID AS NVARCHAR) = @ComplainID";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ComplainID", complainId);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching history: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

   
        private void refreshbtn_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            LoadAllHistory();
          
        }

     
        private void backbtn_Click(object sender, EventArgs e)
        {
            AdminPage Admin = new AdminPage(loggedInUserID);
            Admin.Show();
            this.Hide();
        }
    }
}
