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
        private List<ItemWidget> _profileListWidget = new List<ItemWidget>();

        public ShopForm()
        {
            InitializeComponent();

            _vehicleService = new VehicleService();
            _vehiclepartService = new VehiclePartService();

            getList();
        }
        private void getList()
        {
            if (flpList == null)
            {
                MessageBox.Show("null");
                return;
            }
            _profileListWidget.Clear();
            getVehicles();
            getParts();
            flpList.Controls.Clear();
            flpList.Controls.AddRange(_profileListWidget.ToArray());
        }
        private void getVehicles()
        {
            List<VehicleModel> list = _vehicleService.List();

            foreach (VehicleModel vehicle in list)
            {
                ItemWidget widget = new ItemWidget
                {
                    Id = vehicle.Id ?? 0,
                    Price = vehicle.Price.ToString(),
                    Title = vehicle.Name,
                    Type = "Vehicle"
                };

                _profileListWidget.Add(widget);
            }
        }
        private void getParts()
        {
            List<VehiclePartModel> list = _vehiclepartService.List();

            foreach (VehiclePartModel part in list)
            {
                ItemWidget widget = new ItemWidget
                {
                    Id = part.Id ?? 0,
                    Price = part.Price.ToString(),
                    Title = part.Name,
                    Type="VehiclePart"
                };

                _profileListWidget.Add(widget);
            }
        }
        private void FilterWidgetsByName(string filterText)
        {
            if (flpList == null)
            {
                MessageBox.Show("null");
                return;
            }

            string lowercaseFilter = filterText.Trim().ToLower();
            bool filterByVehicle = cbVehicle.Checked;
            bool filterByVehiclePart = cbVehiclePart.Checked;

            List<ItemWidget> filteredWidgets;


            if (filterByVehicle == true && filterByVehiclePart == true)
            {
                filteredWidgets = _profileListWidget
                    .Where(widget => (string.IsNullOrEmpty(lowercaseFilter) ||
                    widget.Title.ToLower().Contains(lowercaseFilter)))
                    .ToList();
            }
            else if (filterByVehicle) filteredWidgets = _profileListWidget
                .Where(widget => (string.IsNullOrEmpty(lowercaseFilter) ||
                                 widget.Title.ToLower().Contains(lowercaseFilter)) &&
                                (!filterByVehicle || widget.Type == "Vehicle"))
                .ToList();

            else if (filterByVehiclePart)
            {
                filteredWidgets = _profileListWidget
                    .Where(widget => (string.IsNullOrEmpty(lowercaseFilter) ||
                                     widget.Title.ToLower().Contains(lowercaseFilter)) &&
                                    (!filterByVehiclePart || widget.Type == "VehiclePart"))
                    .ToList();
            }
            else 
            {
                filteredWidgets = _profileListWidget
                    .Where(widget => (string.IsNullOrEmpty(lowercaseFilter) ||
                    widget.Title.ToLower().Contains(lowercaseFilter)))
                    .ToList();
            }
            flpList.Controls.Clear();
            flpList.Controls.AddRange(filteredWidgets.ToArray());
        
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            FilterWidgetsByName(txtSearch.Text);
        }

        private void cbVehicle_Click(object sender, EventArgs e)
        {
            FilterWidgetsByName(txtSearch.Text);
        }

        private void cbVehiclePart_Click(object sender, EventArgs e)
        {
            FilterWidgetsByName(txtSearch.Text);
        }

        private void btnViewCart_Click(object sender, EventArgs e)
        {

        }
    }
}
