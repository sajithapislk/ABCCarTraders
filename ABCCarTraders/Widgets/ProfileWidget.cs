using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCCarTraders.Widgets
{
    public partial class ProfileWidget : UserControl
    {
        public ProfileWidget()
        {
            InitializeComponent();
        }

        private string _title;
        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; lblTitle.Text = value; }
        }
    }
}
