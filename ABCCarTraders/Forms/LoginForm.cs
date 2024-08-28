using ABCCarTraders.Services;
using System;
using System.Windows.Forms;
using ABCCarTraders.Models;
using ABCCarTraders.Forms.AdminForms;
using ABCCarTraders.Forms.CustomerForms;

namespace ABCCarTraders.Forms
{
    public partial class LoginForm : Form
    {
        private readonly AuthenticationService _authService;
        public LoginForm()
        {
            InitializeComponent();
            _authService = new AuthenticationService();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            var user = _authService.Login(username, password);
            if (user != null)
            {
                if (user is AdminModel)
                {
                    this.Hide();
                    new AdminDashboardForm().Show();
                }
                else
                {
                    this.Hide();
                    new CustomerDashboardForm().Show();
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CustomerRegisterForm().Show();
        }
    }
}
