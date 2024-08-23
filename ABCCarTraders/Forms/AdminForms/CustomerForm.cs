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

namespace ABCCarTraders.Forms.AdminForms
{
    public partial class CustomerForm : Form
    {
        private readonly CustomerService _customerService;
        public CustomerForm()
        {
            InitializeComponent();
            _customerService = new CustomerService();
            getVehicles();
        }

        public void getVehicles()
        {
            List<CustomerModel> list = _customerService.List();
            dgvList.DataSource = list;
        }
    }
}
