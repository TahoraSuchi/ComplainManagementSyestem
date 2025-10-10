using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ComplainManagementSyestem
{
    public partial class ComplainHistory : Form
    {
        private int loggedInUserID;
        string connectionString = ConfigurationManager.ConnectionStrings["UserDb"].ConnectionString;

        public ComplainHistory(int userId)
        {
            InitializeComponent();
            loggedInUserID = userId;
        }

        public ComplainHistory()
        {
            InitializeComponent();
        }

        private void ComplainHistory_Load(object sender, EventArgs e)
        {
            LoadUserComplainHistory(); 
        }

        private void LoadUserComplainHistory()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                 
                    string query = @"
                        SELECT h.HistoryID, h.ComplainID, h.ChangedBy, h.OldStatus, h.NewStatus, h.ChangeDate
                        FROM ComplainHistory h
                        INNER JOIN Complain c ON h.ComplainID = c.ComplainID
                        WHERE c.UserID = @UserID
                        ORDER BY h.ChangeDate DESC";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserID", loggedInUserID);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading complaint history: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            UserPage userPage = new UserPage(loggedInUserID);
            userPage.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
       
            LoadUserComplainHistory();
            MessageBox.Show("Data refreshed successfully!",
                            "Refreshed", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
