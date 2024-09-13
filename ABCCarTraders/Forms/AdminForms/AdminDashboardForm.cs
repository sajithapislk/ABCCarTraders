using ABCCarTraders.Forms.AdminForms.CustomerForms;
using ABCCarTraders.Forms.AdminForms.CustomerOrderForms;
using ABCCarTraders.Forms.AdminForms.VehicleForms;
using ABCCarTraders.Forms.AdminForms.VehiclePartCategoryForms;
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
            loadForm(new VehicleForm());
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            loadForm(new CustomerForm());
        }

        private void btnOrderHistory_Click(object sender, EventArgs e)
        {
            loadForm(new VehiclePartForm());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadForm(new CustomerOrderForm());
        }

        private void btnVehiclePartCategory_Click(object sender, EventArgs e)
        {
            loadForm(new VehiclePartCategoryForm());
        }

        private void btnVehicleBrand_Click(object sender, EventArgs e)
        {
            loadForm(new VehicleBrandForm());
        }

        private void btnVehicleType_Click(object sender, EventArgs e)
        {
            loadForm(new VehicleTypeForm());
        }
        private void loadForm(object form)
        {
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
    }
}
