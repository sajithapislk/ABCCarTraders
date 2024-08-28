using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ABCCarTraders.Services;

namespace ABCCarTraders.Widgets
{
    public partial class ItemWidget : UserControl
    {
        private readonly TempOrderInfoService _tempOrderInfoService;

        private int _id;
        private string _title;
        private string _type;
        [Category("Custom Props")]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; lblTitle.Text = value; }
        }
        [Category("Custom Props")]
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public ItemWidget()
        {
            InitializeComponent();
            _tempOrderInfoService = new TempOrderInfoService();
        }
        private void btnAddCart_Click(object sender, EventArgs e)
        {
            pnlQty.Visible = true;
            
        }

        private void btnSaveCart_Click(object sender, EventArgs e)
        {
            int qty = int.Parse(txtQty.Text);
            pnlQty.Visible = false;

            if (_type== "Vehicle")
            {
                _tempOrderInfoService.saveVehicle(_id, qty);
            }else
            {
                _tempOrderInfoService.saveVehiclePart(_id, qty);
            }
        }
    }
}
