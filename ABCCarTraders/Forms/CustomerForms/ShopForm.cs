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
        private List<ProfileWidget> _profileListWidget;

        public ShopForm()
        {
            InitializeComponent();
            _vehicleService = new VehicleService();
            _profileListWidget = new List<ProfileWidget>(); // Initialize the list
            getVehicles();
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

            if (flowLayoutPanel1 != null)
            {
                flowLayoutPanel1.Controls.Clear();
                flowLayoutPanel1.Controls.AddRange(_profileListWidget.ToArray());
            }
        }
    }
}
