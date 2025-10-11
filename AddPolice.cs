using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ComplainManagementSyestem
{
    public partial class AddPolice : Form
    {
        public AddPolice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
                                "Warning", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            string connectionString = ConfigurationManager.ConnectionStrings["UserDb"].ConnectionString;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                   
                    string checkQuery = "SELECT COUNT(*) FROM [User] WHERE Username = @user";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@user", username);
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("This username already exists. Please choose another username.",
                                            "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                  
                    string insertQuery = "INSERT INTO [User] (Name, Email, Username, Password, Role) " +
                                         "VALUES (@name, @mail, @user, @pass, @role)";

                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@name", name);
                        insertCmd.Parameters.AddWithValue("@mail", email);
                        insertCmd.Parameters.AddWithValue("@user", username);
                        insertCmd.Parameters.AddWithValue("@pass", password);
                        insertCmd.Parameters.AddWithValue("@role", role);

                        int rows = insertCmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show($"{role} account created successfully!",
                                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                           
                            textBox1.Clear();
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox4.Clear();
                            comboBox1.SelectedIndex = -1;
                        }
                        else
                        {
                            MessageBox.Show("Account creation failed.",
                                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AdminPage admin = new AdminPage();
            admin.Show();
            this.Hide();
        }
    }
}
