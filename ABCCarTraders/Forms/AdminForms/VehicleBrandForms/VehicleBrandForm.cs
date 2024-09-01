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
    public partial class VehicleBrandForm : Form
    {
        private readonly VehicleBrandService _vehicleBrandService;

        public VehicleBrandForm()
        {
            InitializeComponent();
            _vehicleBrandService = new VehicleBrandService();
            getBrand();

        }

        private void getBrand()
        {
            List<VehicleBrandModel> list = _vehicleBrandService.List();
            dgvList.DataSource = list;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            bool res = _vehicleBrandService.Add(name);

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
