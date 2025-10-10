using System;
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
            
        }
        private void lvlname_Click(object sender, EventArgs e)
        {
          
        }


        private void backbtn_Click(object sender, EventArgs e)
        {
            AdminPage admin = new AdminPage(loggedInUserId);
            admin.Show();
            this.Hide();
        }
    }
}
