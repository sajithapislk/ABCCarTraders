using ABCCarTraders.Forms;
using ABCCarTraders.Forms.AdminForms;
using ABCCarTraders.Forms.AdminForms.ReportForms;
using ABCCarTraders.Forms.AdminForms.VehiclePartForms;
using ABCCarTraders.Forms.CustomerForms;
using ABCCarTraders.Forms.CustomerForms.ReportForms;
using ABCCarTraders.Models;
using ABCCarTraders.Utils;
using System;
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
                if (SessionManager.CurrentUser is AdminModel)
                {
                    Console.WriteLine("Admin");
                    Application.Run(new AdminDashboardForm());
                }
                else if (SessionManager.CurrentUser is CustomerModel)
                {
                    Console.WriteLine("Customer");
                    Application.Run(new CustomerDashboardForm());
                }
            }
            else
            {
                Application.Run(new LoginForm());
            }
        }
    }
}
