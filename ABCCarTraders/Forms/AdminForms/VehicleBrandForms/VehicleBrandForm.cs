using ABCCarTraders.Forms.AdminForms.VehicleBrandForms;
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

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvList.Columns[e.ColumnIndex].Name == "Update")
            {
                var result = MessageBox.Show("Are you sure you want to update this item?", "Confirm update", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    DataGridViewRow currentRow = dgvList.Rows[e.RowIndex];

                    string Name = currentRow.Cells["Name"].Value.ToString();
                    int Id = int.Parse(currentRow.Cells["Id"].Value.ToString());

                    var _form = new VehicleBrandEditForm();
                    _form.IdValue = Id;
                    _form.NameValue = Name;

                    _form.ShowDialog();

                }
            }
            if (e.RowIndex >= 0 && dgvList.Columns[e.ColumnIndex].Name == "Delete")
            {
                var result = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    DataGridViewRow currentRow = dgvList.Rows[e.RowIndex];
                    int _id = int.Parse(currentRow.Cells["Id"].Value.ToString());
                    //_vehicleService.DeleteVehicle(_id);
                    //getVehicles();
                }
            }
        }

        private void VehicleBrandForm_Activated(object sender, EventArgs e)
        {
            getBrand();
        }
    }
}
