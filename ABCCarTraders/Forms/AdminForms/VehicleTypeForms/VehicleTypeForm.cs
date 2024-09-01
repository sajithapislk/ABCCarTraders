using ABCCarTraders.Forms.AdminForms.VehicleTypeForms;
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

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvList.Columns[e.ColumnIndex].Name == "Update")
            {
                var result = MessageBox.Show("Are you sure you want to update this item?", "Confirm update", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    DataGridViewRow currentRow = dgvList.Rows[e.RowIndex];

                    int Id = int.Parse(currentRow.Cells["Id"].Value.ToString());
                    string Name = currentRow.Cells["Name"].Value.ToString();
                    var _form = new VehicleTypeEditForm();
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
                    //_vehicleTypeService.DeleteVehicle(_id);
                    //getVehicles();
                }
            }
        }

        private void VehicleTypeForm_Activated(object sender, EventArgs e)
        {
            getBrand();
        }
    }
}
