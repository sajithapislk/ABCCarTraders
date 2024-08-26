using ABCCarTraders.Models;
using ABCCarTraders.Repositories;
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
    public partial class VehicleReportForm : Form
    {
        private readonly VehicleService _vehicleService;
        public VehicleReportForm()
        {
            InitializeComponent();
            _vehicleService = new VehicleService();
        }

        private void VehicleReportForm_Load(object sender, EventArgs e)
        {
            List<VehicleModel> list = _vehicleService.List();
            var reportDataSource = new Microsoft.Reporting.WinForms.ReportDataSource("VehicleDataset", list);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);

            this.reportViewer1.RefreshReport();
        }
    }
}
