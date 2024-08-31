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
            new VehiclePartInsertForm().ShowDialog();
        }

        private void VehiclePartForm_Activated(object sender, EventArgs e)
        {
            getParts();
        }

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvList.Columns[e.ColumnIndex].Name == "Update")
            {
                var result = MessageBox.Show("Are you sure you want to update this item?", "Confirm update", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    DataGridViewRow currentRow = dgvList.Rows[e.RowIndex];

                    VehiclePartModel vehiclePart = new VehiclePartModel
                    {
                        Id = int.Parse(currentRow.Cells["Id"].Value.ToString()),
                        VehicleId = int.Parse(currentRow.Cells["VehicleId"].Value.ToString()),
                        CategoryId = int.Parse(currentRow.Cells["CategoryId"].Value.ToString()),
                        Name = currentRow.Cells["Name"].Value.ToString(),
                        PartNumber = currentRow.Cells["PartNumber"].Value.ToString(),
                        Brand = currentRow.Cells["Brand"].Value.ToString(),
                        Price = double.Parse(currentRow.Cells["Price"].Value.ToString()),
                        Qty = int.Parse(currentRow.Cells["Qty"].Value.ToString()),
                        Description = currentRow.Cells["Description"].Value.ToString(),
                    };

                    var _form = new VehiclePartEditForm();
                    _form.VehiclePartModel = vehiclePart;

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
                    _vehiclePartService.DeleteVehiclePart(_id);
                    getParts();
                }
            }
        }
    }
}
