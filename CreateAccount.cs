using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ComplainManagementSyestem
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
           
            if (!checkBox1.Checked)
            {
                MessageBox.Show("Please agree to the terms and conditions before creating an account.",
                                "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = textBox1.Text.Trim();
            string email = textBox2.Text.Trim();
            string username = textBox3.Text.Trim();
            string password = textBox4.Text.Trim();
            string role = comboBox1.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("All fields are required.",
                                "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = ConfigurationManager
                .ConnectionStrings["UserDb"]
                .ConnectionString;

            string query =
                "INSERT INTO [User] (Name, Email, Username, Password, Role) " +
                "VALUES (@name, @mail, @user, @pass, @role)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@mail", email);
                    cmd.Parameters.AddWithValue("@user", username);
                    cmd.Parameters.AddWithValue("@pass", password);
                    cmd.Parameters.AddWithValue("@role", role);

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Account created successfully!",
                                        "Success", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                        Login login = new Login();
                        login.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Account creation failed.",
                                        "Error", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message,
                                "Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        // Back button – return to login
        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
