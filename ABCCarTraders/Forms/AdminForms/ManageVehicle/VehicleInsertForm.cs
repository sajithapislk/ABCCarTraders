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

namespace ABCCarTraders.Forms.AdminForms.ManageVehicle
{
    public partial class VehicleInsertForm : Form
    {
        private readonly VehicleTypeService _vehicleTypeService;
        private readonly VehicleBrandService _vehicleBrandService;
        public VehicleInsertForm()
        {
            InitializeComponent();
            _vehicleTypeService = new VehicleTypeService();
            _vehicleBrandService = new VehicleBrandService();
            getVehicleTypes();
            getVehicleBrands();
        }
        public void getVehicleTypes()
        {
            List<VehicleTypeModel> list = _vehicleTypeService.List();

            cbVehicleType.DataSource = list;
            cbVehicleType.DisplayMember = "Name";
            cbVehicleType.ValueMember = "Id";
        }
        public void getVehicleBrands()
        {
            List<VehicleBrandModel> list = _vehicleBrandService.List();

            cbVehicleBrand.DataSource = list;
            cbVehicleBrand.DisplayMember = "Name";
            cbVehicleBrand.ValueMember = "Id";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

        }
    }
}
