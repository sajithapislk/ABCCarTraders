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
    public partial class VehicleEditForm : Form
    {
        private VehicleModel _vehicleModel;

        //public VehicleModel VehicleModel
        //{
        //    get { return _vehicleModel; }
        //    set { _vehicleModel = value; }
        //}

        private readonly VehicleTypeService _vehicleTypeService;
        private readonly VehicleBrandService _vehicleBrandService;
        private readonly VehicleService _vehicleService;
        public VehicleEditForm(VehicleModel vehicleModel)
        {
            InitializeComponent();
            _vehicleModel = vehicleModel;
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

        private void loadData()
        {
            txtVehicleName.Text = _vehicleModel.Name;
            txtVehicleNo.Text = _vehicleModel.Number;
            cbVehicleType.SelectedValue = _vehicleModel.Type;
            cbVehicleBrand.SelectedValue = _vehicleModel.Brand;
            cbVehicleColor.Text = _vehicleModel.Color;
            txtVehicleYear.Text = _vehicleModel.Year;
            txtPrice.Text = _vehicleModel.Price.ToString();
            txtVehicleEngine.Text = _vehicleModel.Engine;
            txtVehicleEngineCode.Text = _vehicleModel.EngineCode;
            txtVehicleTorque.Text = _vehicleModel.Torque;
            txtVehicleAFC.Text = _vehicleModel.AFC;
            txtVehiclePower.Text = _vehicleModel.Power;
            txtQty.Text = _vehicleModel.Qty.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
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
            int qty = int.Parse(txtQty.Text);

            bool res = _vehicleService.UpdateVehicle(_vehicleModel.Id ?? 0,vehicleName, vehicleNo, vehicleType ?? 0, vehicleBrand ?? 0, vehicleColor, vehicleYear, price, vehicleEngine, vehicleEngineCode, vehicleTorque, vehicleAFC, vehiclePower, qty);

            if (res)
            {
                MessageBox.Show("Successfully updated");

                this.Hide();
            }
            else
            {
                MessageBox.Show("Update Error");
            }
        }

        private void VehicleEditForm_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
