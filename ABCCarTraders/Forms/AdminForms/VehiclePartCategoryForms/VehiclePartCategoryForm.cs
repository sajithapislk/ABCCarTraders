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
    public partial class VehiclePartCategoryForm : Form
    {
        private readonly VehiclePartCategoryService _vehiclePartCategoryService;

        public VehiclePartCategoryForm()
        {
            InitializeComponent();
            _vehiclePartCategoryService = new VehiclePartCategoryService();
            getCategory();

        }

        private void getCategory()
        {
            List<VehiclePartCategoryModel> list = _vehiclePartCategoryService.List();
            dgvList.DataSource = list;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            bool res = _vehiclePartCategoryService.Add(name);

            if (res)
            {
                MessageBox.Show("Successfully Inserted");
                txtName.Text = "";
                getCategory();
            }
            else
            {
                MessageBox.Show("Insert Error");
            }
        }
    }
}
