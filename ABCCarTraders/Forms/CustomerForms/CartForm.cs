using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ABCCarTraders.Models;
using ABCCarTraders.Services;
using System.Data;
using ABCCarTraders.Forms.CustomerForms.ReportForms;

namespace ABCCarTraders.Forms.CustomerForms
{
    public partial class CartForm : Form
    {
        private CustomerDashboardForm _dashboardForm;

        private readonly VehicleService _vehicleService;
        private readonly VehiclePartService _vehiclePartService;
        private readonly TempOrderInfoService _tempOrderInfoService;
        private readonly TempCartToPermentService _tempCartToPermentService;

        private List<VehicleModel> _vehicleList;
        private List<VehiclePartModel> _vehiclePartList;
        private Dictionary<string, IEnumerable<object>> _tempList;

        private double totalAmout = 0.00; 

        public CartForm(CustomerDashboardForm dashboardForm)
        {
            InitializeComponent();
            _dashboardForm = dashboardForm;
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
            dgvList.Rows.Clear();
            dgvList.Refresh();
            AddOrdersToGrid("VehicleOrders", true, "Vehicle");
            AddOrdersToGrid("VehiclePartOrders", false, "Part");
            lblAmount.Text = totalAmout.ToString();
        }

        private void AddOrdersToGrid(string orderKey, bool isVehicle, string orderType)
        {
            if (!_tempList.ContainsKey(orderKey)) return;

            for (int i = 0; i < _tempList[orderKey].Count(); i++)
            {
                var orderInfo = _tempList[orderKey].ElementAt(i) as dynamic;
                if (orderInfo != null)
                {
                    var itemInfo = GetItemInfo(isVehicle, isVehicle ? orderInfo.VehicleId : orderInfo.PartId);
                    double price = itemInfo.Price;
                    dgvList.Rows.Add(
                        i,
                        itemInfo.Name,
                        orderType,
                        price,
                        orderInfo.Qty,
                        price * orderInfo.Qty
                    );
                    totalAmout += price * orderInfo.Qty;
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
            var res = _tempCartToPermentService.ConvertList(address, totalAmout);
            if (res > 0)
            {
                MessageBox.Show("Order placed successfull");
                var form = new OrderHistoryForm();
                new OrderSuccessReportForm(res).ShowDialog();
                _dashboardForm.loadForm(form);
            }
            else
            {
                MessageBox.Show("Order place failled");
            }
        }

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvList.Columns[e.ColumnIndex].Name == "Delete")
            {
                var result = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    DataGridViewRow currentRow = dgvList.Rows[e.RowIndex];

                    int indexValue = int.Parse(currentRow.Cells[0].Value.ToString());
                    string typeValue = currentRow.Cells[2].Value.ToString();
                    _tempOrderInfoService.DeleteIndex(typeValue, indexValue);

                    dgvList.Rows.RemoveAt(e.RowIndex);
                }
            }
        }
    }
}
