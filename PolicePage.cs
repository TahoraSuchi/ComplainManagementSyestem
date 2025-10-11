using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ComplainManagementSyestem
{
    public partial class PolicePage : Form
    {
        private int loggedInUserId;

        public PolicePage(int userId)
        {
            InitializeComponent();
            loggedInUserId = userId;
            this.Load += PolicePage_Load; 
        }

        private void PolicePage_Load(object sender, EventArgs e)
        {
            if (loggedInUserId <= 0)
                return;

            string connectionString = ConfigurationManager.ConnectionStrings["UserDb"].ConnectionString;
            string query = "SELECT Name FROM [User] WHERE UserID = @id";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", loggedInUserId);
                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    labelUserName.Text =  result.ToString(); 
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Update updateForm = new Update(loggedInUserId);
            updateForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AllComplain allComplain = new AllComplain(loggedInUserId);
            allComplain.Show();
            this.Hide();
        }

        private void evbtn_Click(object sender, EventArgs e)
        {
            ShowEvidence showEvidenceForm = new ShowEvidence(loggedInUserId);
            showEvidenceForm.Show();
            this.Hide();
        }

        private void formebtn_Click(object sender, EventArgs e)
        {
            ComplainForPolice complainForPolice = new ComplainForPolice(loggedInUserId);
            complainForPolice.Show();
            this.Hide();
        }

        private void historybtn_Click(object sender, EventArgs e)
        {
            AllHistory allHistory = new AllHistory(loggedInUserId);
            allHistory.Show();
            this.Hide();
        }
    }
}
