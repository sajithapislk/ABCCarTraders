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
    public partial class VehicleInfoForm : Form
    {
        private readonly VehicleService _vehicleService;
        private VehicleModel _vehicleModel;

        public VehicleInfoForm(int id)
        {
            InitializeComponent();
            _vehicleService = new VehicleService();
            fetchDataById(id);
        }
        private void fetchDataById(int id)
        {
            _vehicleModel = _vehicleService.FindById(id);
        }
        private void loadData()
        {
            txtVehicleName.Text = _vehicleModel.Name;
            txtVehicleNo.Text = _vehicleModel.Number;
            txtVehicleType.Text = _vehicleModel.Type.ToString();
            txtVehicleBrand.Text = _vehicleModel.Brand.ToString();
            txtVehicleColor.Text = _vehicleModel.Color;
            txtVehicleYear.Text = _vehicleModel.Year;
            txtPrice.Text = _vehicleModel.Price.ToString();
            txtVehicleEngine.Text = _vehicleModel.Engine;
            txtVehicleEngineCode.Text = _vehicleModel.EngineCode;
            txtVehicleTorque.Text = _vehicleModel.Torque;
            txtVehicleAFC.Text = _vehicleModel.AFC;
            txtVehiclePower.Text = _vehicleModel.Power;

            string _img = _vehicleModel.Img;

            if (_img != "")
            {
                string imagesDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"images\\{_img}");
                picItem.ImageLocation = imagesDir;
            }
        }

        private void VehicleInfoForm_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
