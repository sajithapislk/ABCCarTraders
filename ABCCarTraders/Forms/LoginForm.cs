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
using ABCCarTraders.Models;

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
                    MessageBox.Show("Admin Dashboard");
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
    }
}
