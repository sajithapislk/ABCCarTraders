using ABCCarTraders.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCCarTraders.Forms
{
    public partial class CustomerRegisterForm : Form
    {
        private readonly AuthenticationService _authService;
        public CustomerRegisterForm()
        {
            InitializeComponent();
            _authService = new AuthenticationService();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string name = txtName.Text;
            string email = txtEmail.Text;
            string tp = txtTp.Text;

            var res = _authService.RegisterCustomer(username, password, name, email, tp);
            if (res)
            {
                MessageBox.Show("Customer register successfull");
                this.Hide();
                new LoginForm().Show();
            }
            else
            {
                MessageBox.Show("Customer register failled");
            }
        }
    }
}
