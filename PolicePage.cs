using System;
using System.Windows.Forms;

namespace ComplainManagementSyestem
{
    public partial class PolicePage : Form
    {
        private int loggedInUserId;

        public PolicePage(int userId)
        {
            InitializeComponent();
            loggedInUserId = userId;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Update updateForm = new Update(loggedInUserId);
            updateForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AllComplain AllComplain = new AllComplain(loggedInUserId);
            AllComplain.Show();
            this.Hide();
        }

        private void evbtn_Click(object sender, EventArgs e)
        {
            ShowEvidence showEvidenceForm = new ShowEvidence(loggedInUserId);
            showEvidenceForm.Show();
            this.Hide();
        }

        private void formebtn_Click(object sender, EventArgs e)
        {
            ComplainForPolice ComplainForPolice = new ComplainForPolice(loggedInUserId);
            ComplainForPolice.Show();
            this.Hide();
        }

        private void historybtn_Click(object sender, EventArgs e)
        {
            AllHistory AllHistory = new AllHistory(loggedInUserId);
            AllHistory.Show();
            this.Hide();

        }
    }
}
