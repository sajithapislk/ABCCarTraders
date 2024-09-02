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
    public partial class CustomerOrderForm : Form
    {
        private readonly OrderService _vehicleOrderService;

        public CustomerOrderForm()
        {
            InitializeComponent();
            _vehicleOrderService = new OrderService();
            getOrders();

        }
        private void getOrders()
        {
            List<OrderModel> list = _vehicleOrderService.List();
            dgvList.DataSource = list;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getOrders();
        }

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvList.Columns[e.ColumnIndex].Name == "UpdateStatus")
            {
                DataGridViewRow currentRow = dgvList.Rows[e.RowIndex];

                OrderModel order = new OrderModel
                {
                    Id = int.Parse(currentRow.Cells["Id"].Value.ToString()),
                    Address = currentRow.Cells["Address"].Value.ToString(),
                    Amount = decimal.Parse(currentRow.Cells["Amount"].Value.ToString()),
                    CustomerId = int.Parse(currentRow.Cells["CustomerId"].Value.ToString()),
                    Status = currentRow.Cells["Status"].Value.ToString()
                };

                var _form = new CustomerOrderUpdateStateForm();
                _form.Order = order;

                _form.ShowDialog();
            }

            if (e.RowIndex >= 0 && dgvList.Columns[e.ColumnIndex].Name == "View")
            {
                DataGridViewRow currentRow = dgvList.Rows[e.RowIndex];

                var _form = new CustomerOrderViewForm();
                _form.OrderId = int.Parse(currentRow.Cells["Id"].Value.ToString());

                _form.ShowDialog();
            }

        }

        private void CustomerOrderForm_Activated(object sender, EventArgs e)
        {
            getOrders();
        }
    }
}
