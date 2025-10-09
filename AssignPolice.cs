using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace ComplainManagementSyestem
{
    public partial class AssignPolice : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["UserDb"].ConnectionString;

        public AssignPolice()
        {
            InitializeComponent();
        }

        // Back button
        private void backbtn_Click(object sender, EventArgs e)
        {
            AdminPage admin = new AdminPage();
            admin.Show();
            this.Hide();
        }

        // Assign complaint to police
        private void assignbtn_Click(object sender, EventArgs e)
        {
            string complainIdText = textBox1.Text.Trim();
            string policeIdText = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(complainIdText) || string.IsNullOrEmpty(policeIdText))
            {
                MessageBox.Show("Please enter both Complain ID and Police ID.");
                return;
            }

            if (!int.TryParse(complainIdText, out int complainId) || !int.TryParse(policeIdText, out int policeId))
            {
                MessageBox.Show("Complain ID and Police ID must be numeric.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Check if the user has role 'Police'
                    string checkRoleQuery = "SELECT Role FROM [User] WHERE UserID = @PoliceID";
                    SqlCommand roleCmd = new SqlCommand(checkRoleQuery, conn);
                    roleCmd.Parameters.AddWithValue("@PoliceID", policeId);
                    object roleObj = roleCmd.ExecuteScalar();

                    if (roleObj == null)
                    {
                        MessageBox.Show("Police ID not found.");
                        return;
                    }

                    string role = roleObj.ToString();
                    if (role != "Police")
                    {
                        MessageBox.Show("The entered User ID is not a Police officer.");
                        return;
                    }

                    // Optional: Check if complaint is already assigned
                    string checkAssignedQuery = "SELECT COUNT(*) FROM ComplainAssign WHERE ComplainID = @ComplainID";
                    SqlCommand checkAssignedCmd = new SqlCommand(checkAssignedQuery, conn);
                    checkAssignedCmd.Parameters.AddWithValue("@ComplainID", complainId);
                    int count = (int)checkAssignedCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("This complaint has already been assigned to a police officer.");
                        return;
                    }

                    // Insert into ComplainAssign table
                    string insertQuery = "INSERT INTO ComplainAssign (ComplainID, PoliceID, AssignDate) " +
                                         "VALUES (@ComplainID, @PoliceID, @AssignDate)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@ComplainID", complainId);
                    insertCmd.Parameters.AddWithValue("@PoliceID", policeId);
                    insertCmd.Parameters.AddWithValue("@AssignDate", DateTime.Now);

                    int rows = insertCmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Complaint assigned to police successfully!");
                        textBox1.Clear();
                        textBox2.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Failed to assign complaint.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
