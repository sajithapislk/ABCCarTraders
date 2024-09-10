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

namespace ABCCarTraders.Forms.AdminForms.ReportForms
{
    public partial class CustomerOrderReportForm : Form
    {
        private readonly OrderService _orderService;
        public CustomerOrderReportForm()
        {
            InitializeComponent();
            _orderService = new OrderService();
        }

        private void CustomerOrderReportForm_Load(object sender, EventArgs e)
        {
            List<OrderModel> list = _orderService.List();
            var reportDataSource = new Microsoft.Reporting.WinForms.ReportDataSource("CustomerOrderDataset", list);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);

            this.reportViewer1.RefreshReport();
        }
        
    }
}
