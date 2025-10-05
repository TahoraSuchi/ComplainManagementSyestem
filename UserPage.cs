using System;
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

        private void UserPage_Load(object sender, EventArgs e)
        {
         
        }
    }
}
