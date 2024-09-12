using ABCCarTraders.Models;
using ABCCarTraders.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCCarTraders.Forms.CustomerForms.InfoForms
{
    public partial class VehiclePartInfoForm : Form
    {
        private readonly VehiclePartService _vehiclePartService;
        private VehiclePartModel _vehiclePartModel;
        public VehiclePartInfoForm(int id)
        {
            InitializeComponent();
            _vehiclePartService = new VehiclePartService();
            fetchDataById(id);
        }
        private void fetchDataById(int id)
        {
            _vehiclePartModel = _vehiclePartService.FindById(id);
        }
        private void loadData()
        {
            cbCategory.SelectedValue = _vehiclePartModel.CategoryId;
            txtPrice.Text = _vehiclePartModel.Price.ToString();
            txtBrand.Text = _vehiclePartModel.Brand;
            txtName.Text = _vehiclePartModel.Name;
            txtPartNo.Text = _vehiclePartModel.PartNumber;
            cbVehicle.SelectedValue = _vehiclePartModel.VehicleId;
            rtxDescription.Text = _vehiclePartModel.Description;
        
            string _img = _vehiclePartModel.Img;

            if (_img != "")
            {
                string imagesDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"images\\{_img}");
                picItem.ImageLocation = imagesDir;
            }
        }

        private void VehiclePartInfoForm_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
