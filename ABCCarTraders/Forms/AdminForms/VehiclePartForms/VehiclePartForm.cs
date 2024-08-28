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

namespace ABCCarTraders.Forms.AdminForms.VehiclePartForms
{
    public partial class VehiclePartForm : Form
    {
        private readonly VehiclePartService _vehiclePartService;

        public VehiclePartForm()
        {
            InitializeComponent();
            _vehiclePartService = new VehiclePartService();
            getParts();

        }

        private void getParts()
        {
            List<VehiclePartModel> list = _vehiclePartService.List();
            dgvList.DataSource = list;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getParts();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new VehiclePartInsertForm().Show();
        }
    }
}
