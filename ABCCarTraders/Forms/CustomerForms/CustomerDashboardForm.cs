using ABCCarTraders.Models;
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
        public CustomerDashboardForm()
        {
            InitializeComponent();
            loadUser();
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
    }
}
