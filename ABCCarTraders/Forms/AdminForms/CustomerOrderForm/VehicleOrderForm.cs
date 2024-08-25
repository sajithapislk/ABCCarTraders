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

namespace ABCCarTraders.Forms.AdminForms.CustomerOrderForm
{
    public partial class VehicleOrderForm : Form
    {
        private readonly VehicleOrderService _vehicleOrderService;

        public VehicleOrderForm()
        {
            InitializeComponent();
            _vehicleOrderService = new VehicleOrderService();
            getOrders();

        }
        public void getOrders()
        {
            List<VehicleOrderModel> list = _vehicleOrderService.List();
            dgvList.DataSource = list;
        }
    }
}
