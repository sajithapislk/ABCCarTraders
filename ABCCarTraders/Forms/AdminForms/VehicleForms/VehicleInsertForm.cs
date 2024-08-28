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
    public partial class VehicleInsertForm : Form
    {
        private readonly VehicleTypeService _vehicleTypeService;
        private readonly VehicleBrandService _vehicleBrandService;
        private readonly VehicleService _vehicleService;

        public VehicleInsertForm()
        {
            InitializeComponent();
            _vehicleTypeService = new VehicleTypeService();
            _vehicleBrandService = new VehicleBrandService();
            _vehicleService = new VehicleService();

            getVehicleTypes();
            getVehicleBrands();
        }
        private void getVehicleTypes()
        {
            List<VehicleTypeModel> list = _vehicleTypeService.List();

            cbVehicleType.DataSource = list;
            cbVehicleType.DisplayMember = "Name";
            cbVehicleType.ValueMember = "Id";
        }
        private void getVehicleBrands()
        {
            List<VehicleBrandModel> list = _vehicleBrandService.List();

            cbVehicleBrand.DataSource = list;
            cbVehicleBrand.DisplayMember = "Name";
            cbVehicleBrand.ValueMember = "Id";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string vehicleName = txtVehicleName.Text;
            string vehicleNo = txtVehicleNo.Text;
            int? vehicleType = cbVehicleType.SelectedValue as int?;
            int? vehicleBrand = cbVehicleBrand.SelectedValue as int?;
            string vehicleColor = cbVehicleColor.Text;
            string vehicleYear = txtVehicleYear.Text;
            double price = double.Parse(txtPrice.Text);
            string vehicleEngine = txtVehicleEngine.Text;
            string vehicleEngineCode = txtVehicleEngineCode.Text;
            string vehicleTorque = txtVehicleTorque.Text;
            string vehicleAFC = txtVehicleAFC.Text;
            string vehiclePower = txtVehiclePower.Text;

            bool res = _vehicleService.RegisterVehicle(vehicleName, vehicleNo, vehicleType??0, vehicleBrand??0, vehicleColor, vehicleYear, price, vehicleEngine, vehicleEngineCode, vehicleTorque, vehicleAFC, vehiclePower);

            if (res)
            {
                MessageBox.Show("Successfully Inserted");

                clearData();
            }
            else
            {
                MessageBox.Show("Insert Error");
            }
        }
        public void clearData()
        {
            txtVehicleName.Text = string.Empty;
            txtVehicleNo.Text = string.Empty;
            cbVehicleType.SelectedIndex = -1;
            cbVehicleBrand.SelectedIndex = -1;
            cbVehicleColor.Text = string.Empty;
            txtVehicleYear.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtVehicleEngine.Text = string.Empty;
            txtVehicleEngineCode.Text = string.Empty;
            txtVehicleTorque.Text = string.Empty;
            txtVehicleAFC.Text = string.Empty;
            txtVehiclePower.Text = string.Empty;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearData();
        }
    }
}
