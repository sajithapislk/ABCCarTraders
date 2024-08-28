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

namespace ABCCarTraders.Forms.AdminForms.VehicleForms
{
    public partial class VehicleForm : Form
    {
        private readonly VehicleService _vehicleService;
        public VehicleForm()
        {
            InitializeComponent();
            _vehicleService = new VehicleService();
            getVehicles();
        }

        private void getVehicles() {
            List<VehicleModel> list = _vehicleService.List();
            dgvList.DataSource = list;
        }

    }
}
