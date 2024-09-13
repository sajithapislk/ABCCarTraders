using ABCCarTraders.Models;
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

namespace ABCCarTraders.Forms.AdminForms.CustomerForms
{
    public partial class CustomerEditForm : Form
    {
        private readonly CustomerService _customerService;
        private CustomerModel _data;

        public CustomerEditForm(CustomerModel customerModel)
        {
            InitializeComponent();
            _data = customerModel;
            _customerService = new CustomerService();
        }
        private void loadData()
        {
            txtName.Text = _data.Name;
            txtEmail.Text = _data.Email;
            txtTp.Text = _data.Tp;
            txtUsername.Text = _data.Username;
        }

        private void CustomerEditForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string name = txtName.Text;
            string email = txtEmail.Text;
            string tp = txtTp.Text;

            var res = _customerService.UpdateCustomer(_data.Id, username, name, email, tp);
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
