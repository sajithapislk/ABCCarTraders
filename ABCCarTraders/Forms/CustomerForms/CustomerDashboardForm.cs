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
            loadForm(new ShopForm(this));
        }

        private void loadUser()
        {
            SessionManager.LoadSession();
            lblName.Text = SessionManager.CurrentUser.Username;
        }
        public void loadForm(object form)
        {
            if (form == null)
            {
                throw new ArgumentNullException(nameof(form), "The form cannot be null.");
            }


            if (this.mainPenel.Controls.Count > 0)
            {
                this.mainPenel.Controls.RemoveAt(0);
            }
            Form _form = form as Form;
            _form.TopLevel = false;
            _form.Dock = DockStyle.Fill;
            this.mainPenel.Controls.Add(_form);
            this.mainPenel.Tag = _form;
            _form.Show();
        }
        private void btnShop_Click(object sender, EventArgs e)
        {
            loadForm(new ShopForm(this));
        }

        public void btnCart_Click(object sender, EventArgs e)
        {
            loadForm(new CartForm(this));
        }

        private void btnOrderHistory_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //new OrderForm().Show();
            loadForm(new OrderHistoryForm());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            _authService.Logout();
            this.Hide();
            new LoginForm().Show();
        }
    }
}
