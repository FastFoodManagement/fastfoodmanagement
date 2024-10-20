using QLBanDoAnNhanh.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanDoAnNhanh
{
    public partial class frmAddItem : Form
    {
        private PosFastFood _posFastFood;
        private int _idEmployee;
        public frmAddItem(int idEmployee)
        {
            InitializeComponent();
            _idEmployee = idEmployee;
        }

        private void frmAddItem_Load(object sender, EventArgs e)
        {
            _posFastFood = new PosFastFood();
            var typeProduct = _posFastFood.TypeProducts.ToList();
            cbType.DataSource = typeProduct;
            cbType.DisplayMember = "NameType";
            cbType.ValueMember = "IdTypeProduct";
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg; *.png; *.bmp)|*.jpg; *.png; *.bmp|All Files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;
                    picProduct.Image = System.Drawing.Image.FromFile(imagePath);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            using (MemoryStream ms = new MemoryStream())
            {
                picProduct.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] imageData = ms.ToArray();
                product.Images = imageData;
            }
            if (string.IsNullOrEmpty(tbName.Text))
            {
                errorCheck.SetError(tbName, "Cannot empty!");
            }
            else
            {
                product.NameProduct = tbName.Text;
                errorCheck.SetError(tbName, "");
            }
            decimal price;
            if (string.IsNullOrEmpty(tbPrice.Text))
            {
                errorCheck.SetError(tbPrice, "Cannot empty!");
            }
            else if (decimal.TryParse(tbPrice.Text, out price) == false)
            {
                errorCheck.SetError(tbPrice, "Only number!");
            }
            else
            {
                product.PriceProduct = price;
                errorCheck.SetError(tbPrice, "");
            }
            product.IdTypeProduct = int.Parse(cbType.SelectedValue.ToString());
            product.IdEmployee = _idEmployee;
            if(string.IsNullOrWhiteSpace(tbDecript.Text) == false)
            {
                product.Decriptions = tbDecript.Text;
            }
            product.IsActive = true;
            if (string.IsNullOrEmpty(errorCheck.GetError(tbName)) == true && string.IsNullOrEmpty(errorCheck.GetError(tbName)) == true)
            {
                DialogResult dialog = MessageBox.Show("Success!", "Notify", MessageBoxButtons.OK);
                if (dialog == DialogResult.OK)
                {
                    _posFastFood.Products.Add(product);
                    _posFastFood.SaveChanges();
                }
            }
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbName.Text))
            {
                errorCheck.SetError(tbName, "Cannot empty!");
            }
            else
            {
                errorCheck.SetError(tbName, "");
            }
        }

        private void tbPrice_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbPrice.Text))
            {
                errorCheck.SetError(tbPrice, "Cannot empty!");
            }
            else if (decimal.TryParse(tbPrice.Text, out _) == false)
            {
                errorCheck.SetError(tbPrice, "Only number!");
            }
            else
            {
                errorCheck.SetError(tbPrice, "");
            }
        }

        private void tbName_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter))
            {
                btnAdd.PerformClick();
            }
        }

        private void tbPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter))
            {
                btnAdd.PerformClick();
            }
        }
    }
}
