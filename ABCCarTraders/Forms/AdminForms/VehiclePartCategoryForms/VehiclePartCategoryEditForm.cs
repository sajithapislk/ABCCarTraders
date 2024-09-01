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

namespace ABCCarTraders.Forms.AdminForms.VehiclePartCategoryForms
{
    public partial class VehiclePartCategoryEditForm : Form
    {
        private readonly VehiclePartCategoryService _vehiclePartCategoryService;

        private int _id;
        public int IdValue
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _name;
        public string NameValue
        {
            get { return _name; }
            set { _name = value; }
        }

        public VehiclePartCategoryEditForm()
        {
            InitializeComponent();
            _vehiclePartCategoryService = new VehiclePartCategoryService();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            bool res = _vehiclePartCategoryService.Update(_id, name);

            if (res)
            {
                MessageBox.Show("Successfully Inserted");
                txtName.Text = "";
                this.Hide();
            }
            else
            {
                MessageBox.Show("Insert Error");
            }
        }

        private void VehiclePartCategoryEditForm_Load(object sender, EventArgs e)
        {
            txtName.Text = _name;
        }
    }
}
