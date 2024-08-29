using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ABCCarTraders.Models;
using ABCCarTraders.Services;

namespace ABCCarTraders.Forms.CustomerForms
{
    public partial class CartForm : Form
    {
        private readonly VehicleService _vehicleService;
        private readonly VehiclePartService _vehiclePartService;
        private readonly TempOrderInfoService _tempOrderInfoService;
        private readonly TempCartToPermentService _tempCartToPermentService;

        private List<VehicleModel> _vehicleList;
        private List<VehiclePartModel> _vehiclePartList;
        private Dictionary<string, IEnumerable<object>> _tempList;

        public CartForm()
        {
            InitializeComponent();
            _vehicleService = new VehicleService();
            _vehiclePartService = new VehiclePartService();
            _tempOrderInfoService = new TempOrderInfoService();
            _tempCartToPermentService = new TempCartToPermentService();
            LoadData();
        }

        private void LoadData()
        {
            _vehicleList = _vehicleService.List();
            _vehiclePartList = _vehiclePartService.List();
            _tempList = _tempOrderInfoService.List();
            FetchData();
        }

        private void FetchData()
        {
            AddOrdersToGrid("VehicleOrders", true, "Vehicle");
            AddOrdersToGrid("VehiclePartOrders", false, "Part");
        }

        private void AddOrdersToGrid(string orderKey, bool isVehicle, string orderType)
        {
            if (!_tempList.ContainsKey(orderKey)) return;

            foreach (var order in _tempList[orderKey])
            {
                var orderInfo = order as dynamic;
                if (orderInfo != null)
                {
                    var itemInfo = GetItemInfo(isVehicle, isVehicle ? orderInfo.VehicleId : orderInfo.PartId);
                    double price = itemInfo.Price;
                    dgvList.Rows.Add(
                        itemInfo.Name,
                        orderType,
                        price,
                        orderInfo.Qty,
                        price * orderInfo.Qty
                    );
                }
            }
        }

        private object GetItemInfo(bool isVehicle, int id)
        {
            return isVehicle
                ? (object)_vehicleList.FirstOrDefault(v => v.Id == id)
                : _vehiclePartList.FirstOrDefault(p => p.Id == id);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string address = txtAddress.Text;
            _tempCartToPermentService.ConvertList(address);
        }
    }
}
