﻿using ABCCarTraders.Services;
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

namespace ABCCarTraders.Forms
{
    public partial class CustomerRegisterForm : Form
    {
        private readonly CustomerService _customerService;
        public CustomerRegisterForm()
        {
            InitializeComponent();
            _customerService = new CustomerService();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string name = txtName.Text;
            string email = txtEmail.Text;
            string tp = txtTp.Text;

            var res = _customerService.RegisterCustomer(username, password, name, email, tp,false);
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

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }
    }
}
