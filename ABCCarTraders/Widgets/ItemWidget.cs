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
    public partial class ItemWidget : UserControl
    {
        public ItemWidget()
        {
            InitializeComponent();
        }

        private string _id;
        private string _title;
        private string _type;
        [Category("Custom Props")]
        public string Id
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
    }
}
