using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ComplainManagementSyestem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.",
                                "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = ConfigurationManager
                .ConnectionStrings["UserDb"]
                .ConnectionString;

            string query = "SELECT Role FROM [User] WHERE Username = @user AND Password = @pass";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@user", username);
                    cmd.Parameters.AddWithValue("@pass", password);

                    conn.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string role = result.ToString();

                        MessageBox.Show("Login Successful!", "Welcome",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                      
                        Form nextForm = null;

                        switch (role.ToLower())
                        {
                            case "user":
                                nextForm = new UserPage();
                                break;
                            case "police":
                                nextForm = new PolicePage();
                                break;
                            case "admin":
                                nextForm = new AdminPage();
                                break;
                            default:
                                MessageBox.Show("Unknown role: " + role,
                                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                        }

                        nextForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.",
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
     
            textBox2.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            CreateAccount regForm = new CreateAccount();
            regForm.Show();
            this.Hide();
        }
    }
}
