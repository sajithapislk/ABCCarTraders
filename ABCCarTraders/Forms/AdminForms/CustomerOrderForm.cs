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
    public partial class CustomerOrderForm : Form
    {
        private readonly VehicleOrderService _vehicleOrderService;

        public CustomerOrderForm()
        {
            InitializeComponent();
            _vehicleOrderService = new VehicleOrderService();
            getOrders();

        }
        private void getOrders()
        {
            List<VehicleOrderModel> list = _vehicleOrderService.List();
            dgvList.DataSource = list;
        }
    }
}
