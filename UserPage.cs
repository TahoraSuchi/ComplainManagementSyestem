using System;
using System.Windows.Forms;

namespace ComplainManagementSyestem
{
    public partial class UserPage : Form
    {
        private int loggedInUserId = 1; 

        public UserPage()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            AddComplain addComplainForm = new AddComplain(); 
            addComplainForm.Show();
            this.Hide();
        }

  
        private void button6_Click(object sender, EventArgs e)
        {
            AddComplain addComplainForm = new AddComplain(); 
            addComplainForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ComplainHistory complainHistoryForm = new ComplainHistory();
            complainHistoryForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Feedback feedbackForm = new Feedback();
            feedbackForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }
    }
}
