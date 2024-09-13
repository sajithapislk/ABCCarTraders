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

namespace ABCCarTraders.Forms.CustomerForms.ReportForms
{
    public partial class OrderSuccessReportForm : Form
    {
        private readonly OrderService _orderService;
        private readonly VehicleService _vehicleService;
        private readonly VehiclePartService _vehiclePartService;
        private readonly OrderInfoService _orderInfoService;

        private List<VehiclePartModel> _vehiclePartList;
        private List<VehicleModel> _vehicleList;
        private OrderModel _order;

        private int _orderId;
        public OrderSuccessReportForm(int orderId)
        {
            InitializeComponent();

            _orderId = orderId;
            _orderService = new OrderService();
            _vehicleService = new VehicleService();
            _vehiclePartService = new VehiclePartService();
            _orderInfoService = new OrderInfoService();

            _vehiclePartList = new List<VehiclePartModel>();
            _vehicleList = new List<VehicleModel>();
        }
        private void passDataToReport()
        {
            List<OrderModel> _orderList = new List<OrderModel> { _order };
            // Create report data sources for each dataset
            var orderDataSource = new Microsoft.Reporting.WinForms.ReportDataSource("OrderDataset", _orderList);
            var vehicleDataSource = new Microsoft.Reporting.WinForms.ReportDataSource("VehicleDataset", _vehicleList);
            var vehiclePartDataSource = new Microsoft.Reporting.WinForms.ReportDataSource("VehiclePartDataset", _vehiclePartList);

            // Clear existing data sources
            this.reportViewer1.LocalReport.DataSources.Clear();

            // Add the new data sources
            this.reportViewer1.LocalReport.DataSources.Add(orderDataSource);
            this.reportViewer1.LocalReport.DataSources.Add(vehicleDataSource);
            this.reportViewer1.LocalReport.DataSources.Add(vehiclePartDataSource);

            // Refresh the report to show the data
            this.reportViewer1.RefreshReport();
        }

        private void loadData()
        {
            _order = _orderService.FindById(_orderId);
            var vehicleList = _vehicleService.List();
            var vehiclePartList = _vehiclePartService.List();

            Dictionary<string, IEnumerable<object>> list = _orderInfoService.FindByOrderId(_orderId);

            var VehicleOrderList = list["VehicleOrderList"] as List<VehicleOrderInfoModel>;
            var VehiclePartOrderList = list["VehiclePartOrderList"] as List<VehiclePartOrderInfoModel>;

            if (VehicleOrderList != null)
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
            if (VehiclePartOrderList != null)
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
        }

        private void OrderSuccessReportForm_Load(object sender, EventArgs e)
        {
            loadData();
            passDataToReport();
        }
    }
}
