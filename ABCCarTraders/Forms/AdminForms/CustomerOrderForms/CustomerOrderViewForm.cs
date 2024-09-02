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

namespace ABCCarTraders.Forms.AdminForms.CustomerOrderForms
{
    public partial class CustomerOrderViewForm : Form
    {
        private readonly VehicleService _vehicleService;
        private readonly VehiclePartService _vehiclePartService;
        private readonly OrderInfoService _orderInfoService;

        private List<VehiclePartModel> _vehiclePartList;
        private List<VehicleModel> _vehicleList;

        private int _orderId;
        public int OrderId
        {
            get { return _orderId; }
            set { _orderId = value; }
        }

        public CustomerOrderViewForm()
        {
            InitializeComponent();
            _vehicleService = new VehicleService();
            _vehiclePartService = new VehiclePartService();
            _orderInfoService = new OrderInfoService();

            _vehiclePartList = new List<VehiclePartModel>();
            _vehicleList = new List<VehicleModel>();
        }

        private void getVehicles()
        {
            dgvVehicle.ClearSelection();
            dgvVehicle.DataSource = _vehicleList;
        }
        private void getVehicleParts()
        {
            dgvVehiclePart.ClearSelection();
            dgvVehiclePart.DataSource = _vehiclePartList;
        }

        private void LoadData()
        {
            var vehicleList = _vehicleService.List();
            var vehiclePartList = _vehiclePartService.List();

            Dictionary<string, IEnumerable<object>> list = _orderInfoService.FindByOrderId(_orderId);

            var VehicleOrderList = list["VehicleOrderList"] as List<VehicleOrderInfoModel>;
            var VehiclePartOrderList = list["VehiclePartOrderList"] as List<VehiclePartOrderInfoModel>;

            if (VehicleOrderList!=null)
            {
                for (int i = 0; i < VehicleOrderList.Count(); i++)
                {
                    var vehicleOrderInfo = VehicleOrderList.ElementAt(i);
                    if (vehicleOrderInfo != null)
                    {
                        var vehicle = vehicleList.FirstOrDefault(v => v.Id == vehicleOrderInfo.VehicleId) as VehicleModel;
                        _vehicleList.Add(vehicle);
                    }
                }
            }
            if (VehiclePartOrderList!=null)
            {
                for (int i = 0; i < VehiclePartOrderList.Count(); i++)
                {
                    var vehiclePartOrderInfo = VehiclePartOrderList.ElementAt(i);
                    if (vehiclePartOrderInfo != null)
                    {
                        var vehiclePart = vehiclePartList.FirstOrDefault(p => p.Id == vehiclePartOrderInfo.PartId) as VehiclePartModel;
                        _vehiclePartList.Add(vehiclePart);
                    }
                }
            }

            getVehicles();
            getVehicleParts();
        }
        private void CustomerOrderViewForm_Activated(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
