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

namespace ABCCarTraders.Forms.AdminForms.VehicleBrandForms
{
    public partial class VehicleBrandEditForm : Form
    {
        private readonly VehicleBrandService _vehicleBrandService;

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

        public VehicleBrandEditForm()
        {
            InitializeComponent();
            _vehicleBrandService = new VehicleBrandService();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            bool res = _vehicleBrandService.Update(_id, name);

            if (res)
            {
                MessageBox.Show("Successfully Updated");
                txtName.Text = "";
                this.Hide();
            }
            else
            {
                MessageBox.Show("Insert Error");
            }
        }
    }
}
