using ABCCarTraders.Models;
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

namespace ABCCarTraders.Forms.CustomerForms
{
    public partial class CustomerDashboardForm : Form
    {
        private readonly AuthenticationService _authService;
        public CustomerDashboardForm()
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

        private void btnShop_Click(object sender, EventArgs e)
        {
            new ShopForm().Show();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            new CartForm().Show();
        }

        private void btnOrderHistory_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //new OrderForm().Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            _authService.Logout();
            this.Hide();
            new LoginForm().Show();
        }
    }
}
