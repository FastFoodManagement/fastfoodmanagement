using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanDoAnNhanh
{
    public partial class Item : UserControl
    {
        private int _id;
        private decimal _price;
        private string _name;
        private bool _isActive;
        public Item()
        {
            InitializeComponent();
        }

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public decimal Price
        {
            get { return _price; }
            set { _price = value;}
        }

        public string _Name
        {
            get { return _name; }
            set { _name = value; lbName.Text = value; }
        }

        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; pnSoldout.Visible = value; }
        }
        public bool IsValid
        {
            get { return btnValid.Visible; }
            set { btnValid.Visible = value; }
        }
        public string LablePrice
        {
            set { lbPrice.Text = value; }
        }
    }
}
