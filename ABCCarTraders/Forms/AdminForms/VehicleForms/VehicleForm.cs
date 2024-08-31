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

namespace ABCCarTraders.Forms.AdminForms.VehicleForms
{
    public partial class VehicleForm : Form
    {
        private readonly VehicleService _vehicleService;
        public VehicleForm()
        {
            InitializeComponent();
            _vehicleService = new VehicleService();
            getVehicles();
        }

        private void getVehicles() {
            List<VehicleModel> list = _vehicleService.List();
            dgvList.ClearSelection();
            dgvList.DataSource = list;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getVehicles();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new VehicleInsertForm().ShowDialog();
        }

        private void VehicleForm_Activated(object sender, EventArgs e)
        {
            getVehicles();
        }

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvList.Columns[e.ColumnIndex].Name == "Update")
            {
                var result = MessageBox.Show("Are you sure you want to update this item?", "Confirm update", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    DataGridViewRow currentRow = dgvList.Rows[e.RowIndex];

                    VehicleModel vehicle = new VehicleModel
                    {
                        Id = int.Parse(currentRow.Cells["Id"].Value.ToString()),
                        Name = currentRow.Cells["Name"].Value.ToString(),
                        Number = currentRow.Cells["Number"].Value.ToString(),
                        Type = int.Parse(currentRow.Cells["Type"].Value.ToString()),
                        Brand = int.Parse(currentRow.Cells["Brand"].Value.ToString()),
                        Color = currentRow.Cells["Color"].Value.ToString(),
                        Year = currentRow.Cells["Year"].Value.ToString(),
                        Price = double.Parse(currentRow.Cells["Price"].Value.ToString()),
                        Engine = currentRow.Cells["Engine"].Value.ToString(),
                        EngineCode = currentRow.Cells["EngineCode"].Value.ToString(),
                        Torque = currentRow.Cells["Torque"].Value.ToString(),
                        AFC = currentRow.Cells["AFC"].Value.ToString(),
                        Power = currentRow.Cells["Power"].Value.ToString(),
                        Qty = int.Parse(currentRow.Cells["Qty"].Value.ToString())
                    };

                    var _form = new VehicleEditForm();
                    _form.VehicleModel = vehicle;

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
                    _vehicleService.DeleteVehicle(_id);
                    getVehicles();
                }
            }
        }
    }
}
