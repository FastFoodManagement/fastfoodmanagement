using QLBanDoAnNhanh.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanDoAnNhanh
{
    public partial class frmItemDetail : Form
    {
        private int _idProduct;
        private int _idEmployee;
        private PosFastFood _posFastFood;
        public frmItemDetail(int idProduct, int idEmployee)
        {
            InitializeComponent();
            _idProduct = idProduct;
            _idEmployee = idEmployee;
        }

        private void frmItemDetail_Load(object sender, EventArgs e)
        {
            _posFastFood = new PosFastFood();
            var productItems = _posFastFood.Products.Find(_idProduct);
            if (productItems != null)
            {
                using (MemoryStream ms = new MemoryStream(productItems.Images))
                {
                    Image image = Image.FromStream(ms);
                    picItem.Image = image;
                }
                lbName.Text = productItems.NameProduct;
                lbPrice.Text = productItems.PriceProduct.Value.ToString("0.0") + "$";
                if (string.IsNullOrEmpty(productItems.Decriptions) == false)
                {
                    lbDecript.Text = productItems.Decriptions;
                }
                else
                {
                    lbDecript.Text = "N/A";
                }
                if (productItems.IsActive == false)
                {
                    btnSoldOut.Text = "UnSold";
                }
            }
        }

        private void btnSoldOut_Click(object sender, EventArgs e)
        {
            var productItems = _posFastFood.Products.Find(_idProduct);
            if (productItems != null)
            {
                using (MemoryStream ms = new MemoryStream(productItems.Images))
                {
                    Image image = Image.FromStream(ms);
                    picItem.Image = image;
                }
                lbName.Text = productItems.NameProduct;
                lbPrice.Text = productItems.PriceProduct.Value.ToString("0.0") + "$";
                if (string.IsNullOrEmpty(productItems.Decriptions) == false)
                {
                    lbDecript.Text = productItems.Decriptions;
                }
                else
                {
                    lbDecript.Text = "N/A";
                }
                if (productItems.IsActive == false)
                {
                    productItems.IsActive = true;
                }
                else
                {
                    productItems.IsActive = false;
                }
                _posFastFood.SaveChanges();
                this.Close();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Form frmedit = new frmEditItem(_idProduct, _posFastFood);
            frmedit.ShowDialog();
            frmItemDetail_Load(sender, e);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var employee = _posFastFood.Employees.Find(_idEmployee);
            if (employee.IdRole == 1 || string.Compare(employee.RoleEmployee.NameRole, "admin", false) == 0)
            {
                var itemProduct = _posFastFood.Products.Find(_idProduct);
                if (itemProduct != null)
                {
                    _posFastFood.Products.Remove(itemProduct);
                    _posFastFood.SaveChanges();
                    DialogResult dialog = MessageBox.Show("Delete success!");
                }
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Please log in as a management account!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
