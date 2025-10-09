using System;
using System.Windows.Forms;

namespace ComplainManagementSyestem
{
    public partial class ComplainHistory : Form
    {

        private int loggedInUserID;

        public ComplainHistory(int userId)
        {
            InitializeComponent();
            loggedInUserID = userId;
        }
        public ComplainHistory()
        {
            InitializeComponent();
        }

        private void ComplainHistory_Load(object sender, EventArgs e)
        {
            
            this.complainHistoryTableAdapter1.Fill(this.complainManagementSystemDataSet3.ComplainHistory);
            this.complainHistoryTableAdapter.Fill(this.complainManagementSystemDataSet.ComplainHistory);
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            UserPage userPage = new UserPage(loggedInUserID);
            userPage.Show();
            this.Hide(); 
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                
                this.complainHistoryTableAdapter.Fill(this.complainManagementSystemDataSet.ComplainHistory);
                MessageBox.Show("Data refreshed successfully!", "Refresh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error refreshing data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
