using ABCCarTraders.Models;
using ABCCarTraders.Services;
using ABCCarTraders.Widgets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCCarTraders.Forms.CustomerForms
{
    public partial class ShopForm : Form
    {
        private readonly VehicleService _vehicleService;
        private readonly VehiclePartService _vehiclepartService;
        private List<ProfileWidget> _profileListWidget = new List<ProfileWidget>();

        public ShopForm()
        {
            InitializeComponent();

            _vehicleService = new VehicleService();
            _vehiclepartService = new VehiclePartService();

            getList();
        }
        private void getList()
        {
            if (flowLayoutPanel1 == null)
            {
                MessageBox.Show("null");
                return;
            }
            _profileListWidget.Clear();
            getVehicles();
            getParts();
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.AddRange(_profileListWidget.ToArray());
        }
        private void getVehicles()
        {
            List<VehicleModel> list = _vehicleService.List();

            foreach (VehicleModel vehicle in list)
            {
                ProfileWidget widget = new ProfileWidget
                {
                    Title = vehicle.Name
                };

                _profileListWidget.Add(widget);
            }
        }
        private void getParts()
        {
            List<VehiclePartModel> list = _vehiclepartService.List();

            foreach (VehiclePartModel part in list)
            {
                ProfileWidget widget = new ProfileWidget
                {
                    Title = part.Name
                };

                _profileListWidget.Add(widget);
            }
        }
        private void FilterWidgetsByName(string filterText)
        {
            if (flowLayoutPanel1 == null)
            {
                MessageBox.Show("null");
                return;
            }

            string lowercaseFilter = filterText.Trim().ToLower();

            var filteredWidgets = _profileListWidget
                .Where(widget => string.IsNullOrEmpty(lowercaseFilter) ||
                                 widget.Title.ToLower().Contains(lowercaseFilter)).ToList();

            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.AddRange(filteredWidgets.ToArray());
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            FilterWidgetsByName(txtSearch.Text);
        }
    }
}
