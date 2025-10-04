using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComplainManagementSyestem
{
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddPolice add = new AddPolice();
            add.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Update update = new Update();
            update.Show();
            this.Hide();
        }
    }
}
