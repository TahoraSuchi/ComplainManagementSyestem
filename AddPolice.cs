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
                     
                        MessageBox.Show($"{role} account created successfully!",
                                        "Success", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                   
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        comboBox1.SelectedIndex = -1;
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


        private void button2_Click_1(object sender, EventArgs e)
        {
            AdminPage admin = new AdminPage();
            admin.Show();
            this.Hide();
        }
    }
}
