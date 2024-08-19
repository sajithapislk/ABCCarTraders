using ABCCarTraders.Forms;
using ABCCarTraders.Models;
using ABCCarTraders.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCCarTraders
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            SessionManager.LoadSession();

            if (SessionManager.IsLoggedIn())
            {
                if (SessionManager.CurrentUser is Admin)
                {
                    Console.WriteLine("Admin");
                }
                else if (SessionManager.CurrentUser is Customer)
                {
                    Console.WriteLine("Customer");
                }
            }
            else
            {
                Application.Run(new LoginForm());
            }
        }
    }
}
