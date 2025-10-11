using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ComplainManagementSyestem
{
    public partial class AdminPage : Form
    {
        private int loggedInUserId;

        public AdminPage(int userId)
        {
            InitializeComponent();
            loggedInUserId = userId;
            this.Load += AdminPage_Load; 
        }

        public AdminPage()
        {
            InitializeComponent();
            this.Load += AdminPage_Load; 
        }

        private void AdminPage_Load(object sender, EventArgs e)
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
                    label2.Text = result.ToString(); 
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddPolice add = new AddPolice();
            add.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Update update = new Update(loggedInUserId);
            update.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AllComplain allComplain = new AllComplain(loggedInUserId);
            allComplain.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AssignPolice assignPolice = new AssignPolice();
            assignPolice.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ShowFeedback showFeedback = new ShowFeedback();
            showFeedback.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AllHistory allHistory = new AllHistory(loggedInUserId);
            allHistory.Show();
            this.Hide();
        }

        private void managebtn_Click(object sender, EventArgs e)
        {
            ManageUser manageUser = new ManageUser();
            manageUser.Show();
            this.Hide();
        }

        private void profilebtn_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(loggedInUserId);
            profile.Show();
            this.Hide();
        }
    }
}
