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

namespace ABCCarTraders.Forms.AdminForms.CustomerOrderForms
{
    public partial class CustomerOrderUpdateStateForm : Form
    {
        private readonly VehicleOrderService _vehicleOrderService;
        private OrderModel _order;

        public OrderModel Order
        {
            get { return _order; }
            set { _order = value; }
        }

        public CustomerOrderUpdateStateForm()
        {
            InitializeComponent();
            _vehicleOrderService = new VehicleOrderService();
        }
        private void loadData()
        {
            txtAddress.Text = _order.Address;
            txtAmount.Text = _order.Amount.ToString();
            txtCustomerId.Text = _order.CustomerId.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string status = cbStatus.Text;

            _vehicleOrderService.UpdateStatus(_order.Id, status);

            this.Hide();
        }

        private void CustomerOrderUpdateStateForm_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
