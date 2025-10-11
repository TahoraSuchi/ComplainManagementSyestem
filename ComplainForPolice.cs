using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace ComplainManagementSyestem
{
    public partial class ComplainForPolice : Form
    {
        private int loggedInUserId;
        private string connectionString = ConfigurationManager.ConnectionStrings["UserDb"].ConnectionString;

        public ComplainForPolice(int userId)
        {
            InitializeComponent();
            loggedInUserId = userId;
        }

        private void ComplainForPolice_Load(object sender, EventArgs e)
        {
            LoadAssignedComplaints();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            PolicePage policePage = new PolicePage(loggedInUserId);
            policePage.Show();
            this.Hide();
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            LoadAssignedComplaints();
        }

        private void LoadAssignedComplaints()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM ComplainAssign WHERE PoliceID = @policeId";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@policeId", loggedInUserId);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading complaints: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
