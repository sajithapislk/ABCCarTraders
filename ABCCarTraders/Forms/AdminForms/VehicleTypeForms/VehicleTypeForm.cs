using ABCCarTraders.Models;
using ABCCarTraders.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCCarTraders.Forms.AdminForms.VehiclePartCategoryForms
{
    public partial class VehicleTypeForm : Form
    {
        private readonly VehicleTypeService _vehicleTypeService;

        public VehicleTypeForm()
        {
            InitializeComponent();
            _vehicleTypeService = new VehicleTypeService();
            getBrand();

        }

        private void getBrand()
        {
            List<VehicleTypeModel> list = _vehicleTypeService.List();
            dgvList.DataSource = list;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            bool res = _vehicleTypeService.Add(name);

            if (res)
            {
                MessageBox.Show("Successfully Inserted");
                txtName.Text = "";
                getBrand();
            }
            else
            {
                MessageBox.Show("Insert Error");
            }
        }
    }
}
