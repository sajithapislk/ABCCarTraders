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

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvList.Columns[e.ColumnIndex].Name == "Update")
            {
                var result = MessageBox.Show("Are you sure you want to update this item?", "Confirm update", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    DataGridViewRow currentRow = dgvList.Rows[e.RowIndex];

                    string _name = currentRow.Cells["Name"].Value.ToString();
                    int _id = int.Parse(currentRow.Cells["Id"].Value.ToString());

                    var _form = new VehiclePartCategoryEditForm();
                    _form.IdValue = _id;
                    _form.NameValue = _name;

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
                    _vehiclePartCategoryService.Delete(_id);
                    getCategory();
                }
            }
        }

        private void VehiclePartCategoryForm_Activated(object sender, EventArgs e)
        {
            getCategory();
        }
    }
}
