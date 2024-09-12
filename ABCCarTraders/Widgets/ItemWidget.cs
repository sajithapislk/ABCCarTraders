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
using System.IO;
using ABCCarTraders.Forms.CustomerForms.InfoForms;

namespace ABCCarTraders.Widgets
{
    public partial class ItemWidget : UserControl
    {
        private readonly TempOrderInfoService _tempOrderInfoService;

        private int _id;
        private string _price;
        private string _title;
        private string _type;
        private string _img;
        [Category("Custom Props")]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        [Category("Custom Props")]
        public string Price
        {
            get { return _price; }
            set { _price = value;lblPrice.Text = value; }
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
            set {
                _type = value;
                pbDp.Image = _type == "Vehicle" ? Properties.Resources.vehicle : Properties.Resources.vehicle1;
                pbDp.Refresh();
            }
        }
        [Category("Custom Props")]
        public string Img
        {
            get { return _img; }
            set {
                _img = value;
                
                if(_img != "")
                {
                    string imagesDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"images\\{_img}");
                    pbDp.ImageLocation = imagesDir;
                }
            }
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

        private void btnView_Click(object sender, EventArgs e)
        {

            if (_type == "Vehicle")
            {
                new VehicleInfoForm(_id).ShowDialog();
            }
            else
            {
                new VehiclePartInfoForm(_id).ShowDialog();
            }
        }
    }
}
