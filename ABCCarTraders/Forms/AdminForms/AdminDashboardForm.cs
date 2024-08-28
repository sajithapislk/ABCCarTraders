using ABCCarTraders.Forms.AdminForms.VehicleForms;
using ABCCarTraders.Forms.AdminForms.VehiclePartForms;
using ABCCarTraders.Services;
using ABCCarTraders.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCCarTraders.Forms.AdminForms
{
    public partial class AdminDashboardForm : Form
    {
        private readonly AuthenticationService _authService;
        public AdminDashboardForm()
        {
            InitializeComponent();
            loadUser();
            _authService = new AuthenticationService();
        }

        private void loadUser()
        {
            SessionManager.LoadSession();
            lblName.Text = SessionManager.CurrentUser.Username;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            _authService.Logout();
            this.Hide();
            new LoginForm().Show();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            new VehicleForm().Show();
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            new CustomerForm().Show();
        }

        private void btnOrderHistory_Click(object sender, EventArgs e)
        {
            new VehiclePartForm().Show();
        }
    }
}
