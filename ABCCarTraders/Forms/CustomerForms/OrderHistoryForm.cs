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

namespace ABCCarTraders.Forms.CustomerForms
{
    public partial class OrderHistoryForm : Form
    {
        private readonly OrderService _orderService;
        public OrderHistoryForm()
        {
            InitializeComponent();
            _orderService = new OrderService();
            getOrder();
        }
        private void getOrder()
        {
            List<OrderModel> list = _orderService.AllByCustomer();
            dgvList.DataSource = list;
        }
    }
}
