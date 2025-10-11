using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ComplainManagementSyestem
{
    public partial class Profile : Form
    {
        private int loggedInUserId;

        public Profile(int userId)
        {
            InitializeComponent();
            loggedInUserId = userId;
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["UserDb"].ConnectionString;
            string query = "SELECT Name, Email, UserID, Username, Role FROM [User] WHERE UserID = @id";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", loggedInUserId);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        label1.Text = "Name: " + reader["Name"].ToString();
                        label2.Text = "Email: " + reader["Email"].ToString();
                        label3.Text = "UserID: " + reader["UserID"].ToString();
                        label4.Text = "Username: " + reader["Username"].ToString();
                        
                        currentRole = reader["Role"].ToString();
                    }
                }
            }
        }

        private string currentRole; 

        private void backbtn_Click(object sender, EventArgs e)
        {
            if (currentRole == "Admin")
            {
                AdminPage admin = new AdminPage(loggedInUserId);
                admin.Show();
            }
            else if (currentRole == "Police")
            {
                PolicePage police = new PolicePage(loggedInUserId);
                police.Show();
            }
            else 
            {
                UserPage user = new UserPage(loggedInUserId);
                user.Show();
            }

            this.Hide();
        }
    }
}
