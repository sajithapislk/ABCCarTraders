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

namespace ABCCarTraders.Forms.AdminForms.CustomerForms
{
    public partial class CustomerForm : Form
    {
        private readonly CustomerService _customerService;
        public CustomerForm()
        {
            InitializeComponent();
            _customerService = new CustomerService();
            getVehicles();
        }

        private void getVehicles()
        {
            List<CustomerModel> list = _customerService.List();
            dgvList.DataSource = list;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
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

                    var model = new CustomerModel {
                        Id = int.Parse(currentRow.Cells["Id"].Value.ToString()),
                        Email = currentRow.Cells["email"].Value.ToString(),
                        Tp = currentRow.Cells["tp"].Value.ToString(),
                        Name = currentRow.Cells["name"].Value.ToString(),
                        Username = currentRow.Cells["username"].Value.ToString(),
                    };
                    var _form = new CustomerEditForm(model);

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
                    _customerService.Delete(_id);
                    getVehicles();
                }
            }
        }
    }
}
