using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ComplainManagementSyestem
{
    public partial class UserPage : Form
    {
        private int loggedInUserID;

        public UserPage(int userId)
        {
            InitializeComponent();
            loggedInUserID = userId;
        }

        private void UserPage_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["UserDb"].ConnectionString;
            string query = "SELECT Name FROM [User] WHERE UserID = @id";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", loggedInUserID);
                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    labelUserName.Text = result.ToString(); 
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddComplain addComplainForm = new AddComplain(loggedInUserID);
            addComplainForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ComplainHistory complainHistoryForm = new ComplainHistory(loggedInUserID);
            complainHistoryForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Feedback feedbackForm = new Feedback(loggedInUserID);
            feedbackForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddEvidence AddEvidence = new AddEvidence(loggedInUserID);
            AddEvidence.Show();
            this.Hide();
        }
    }
}
