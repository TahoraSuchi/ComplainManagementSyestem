using System;
using System.Windows.Forms;
using ComplainManagementSyestem;

namespace ComplainManagementSystem
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login()); 
        }
    }
}
