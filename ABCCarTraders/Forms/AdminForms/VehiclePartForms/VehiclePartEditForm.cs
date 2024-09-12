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

namespace ABCCarTraders.Forms.AdminForms.VehiclePartForms
{
    public partial class VehiclePartEditForm : Form
    {
        private readonly VehiclePartCategoryService _vehiclePartCategoryService;
        private readonly VehiclePartService _vehiclePartService;
        private readonly VehicleService _vehicleService;

        private VehiclePartModel _vehiclePartModel;
        //public VehiclePartModel VehiclePartModel
        //{
        //    get { return _vehiclePartModel; }
        //    set { _vehiclePartModel = value; }
        //}

        public VehiclePartEditForm(VehiclePartModel vehiclePartModel)
        {
            InitializeComponent();
            _vehiclePartModel = vehiclePartModel;
            _vehiclePartCategoryService = new VehiclePartCategoryService();
            _vehiclePartService = new VehiclePartService();
            _vehicleService = new VehicleService();
            getCategories();
            getVehicles();
        }
        private void getCategories()
        {
            List<VehiclePartCategoryModel> list = _vehiclePartCategoryService.List();

            cbCategory.DataSource = list;
            cbCategory.DisplayMember = "Name";
            cbCategory.ValueMember = "Id";
        }
        private void getVehicles()
        {
            List<VehicleModel> list = _vehicleService.List();

            cbVehicle.DataSource = list;
            cbVehicle.DisplayMember = "Name";
            cbVehicle.ValueMember = "Id";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int? categoryId = cbCategory.SelectedValue as int?;
            double price = double.Parse(txtPrice.Text);
            string brand = txtBrand.Text;
            string name = txtName.Text;
            string partNo = txtPartNo.Text;
            int qty = int.Parse(txtQty.Text);
            int? vehicleId = cbVehicle.SelectedValue as int?;
            string description = rtxDescription.Text;


            bool res = _vehiclePartService.UpdateVehiclePart(_vehiclePartModel.Id ?? 0, vehicleId, categoryId ?? 0, name, partNo, brand, price, qty, description);

            if (res)
            {
                MessageBox.Show("Successfully Updated");
                clearData();
            }
            else
            {
                MessageBox.Show("Update Error");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void clearData()
        {
            cbCategory.SelectedIndex = -1;
            txtPrice.Text = string.Empty;
            txtBrand.Text = string.Empty;
            txtName.Text = string.Empty;
            txtPartNo.Text = string.Empty;
            txtQty.Text = string.Empty;
            cbVehicle.SelectedIndex = -1;
            rtxDescription.Text = string.Empty;
        }

        private void VehiclePartEditForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            cbCategory.SelectedValue = _vehiclePartModel.CategoryId;
            txtPrice.Text = _vehiclePartModel.Price.ToString();
            txtBrand.Text = _vehiclePartModel.Brand;
            txtName.Text = _vehiclePartModel.Name;
            txtPartNo.Text = _vehiclePartModel.PartNumber;
            txtQty.Text = _vehiclePartModel.Qty.ToString();
            cbVehicle.SelectedValue = _vehiclePartModel.VehicleId;
            rtxDescription.Text = _vehiclePartModel.Description;
        }
    }
}
