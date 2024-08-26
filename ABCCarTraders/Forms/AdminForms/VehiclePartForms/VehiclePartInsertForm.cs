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
    public partial class VehiclePartInsertForm : Form
    {
        private readonly VehiclePartCategoryService _vehiclePartCategoryService;
        private readonly VehicleService _vehicleService;
        public VehiclePartInsertForm()
        {
            InitializeComponent();
            _vehiclePartCategoryService = new VehiclePartCategoryService();
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
            int? category_id = cbCategory.SelectedValue as int?;
            string price = txtPrice.Text;
            string brand = txtBrand.Text;
            string name = txtName.Text;
            string partNo = txtPartNo.Text;
            int qty = int.Parse(txtQty.Text);
            int? vehicleId = cbVehicle.SelectedValue as int?;
            string desctiption = rtxDescription.Text;
        }
    }
}
