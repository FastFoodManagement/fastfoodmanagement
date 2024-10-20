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
    public partial class frmEditItem : Form
    {
        private PosFastFood _posFastFood;
        private int _idProduct;
        public frmEditItem(int idProduct, PosFastFood posFastFood)
        {
            InitializeComponent();
            _idProduct = idProduct;
            _posFastFood = posFastFood;
        }

        private void frmEditItem_Load(object sender, EventArgs e)
        {
            _posFastFood = new PosFastFood();
            var typeProduct = _posFastFood.TypeProducts.ToList();
            cbType.DataSource = typeProduct;
            cbType.DisplayMember = "NameType";
            cbType.ValueMember = "IdTypeProduct";
            var productFood = _posFastFood.Products.Find(_idProduct);
            if (productFood != null)
            {
                cbType.SelectedItem = typeProduct.FirstOrDefault(tp => tp.NameType == productFood.TypeProduct.NameType);
                tbName.Text = productFood.NameProduct;
                tbPrice.Text = productFood.PriceProduct.Value.ToString("0.0");
                if (string.IsNullOrEmpty(productFood.Decriptions) == true)
                {
                    tbDecript.Text = "N/A";
                }
                else
                {
                    tbDecript.Text = productFood.Decriptions;
                }
                using (MemoryStream ms = new MemoryStream(productFood.Images))
                {
                    Image image = Image.FromStream(ms);
                    picProduct.Image = image;
                }
            }
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var product = _posFastFood.Products.Find(_idProduct);
            using (MemoryStream ms = new MemoryStream())
            {
                Image newImage = new Bitmap(picProduct.Image);
                newImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
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
            if (string.IsNullOrWhiteSpace(tbDecript.Text) == false)
            {
                product.Decriptions = tbDecript.Text;
            }
            product.IsActive = true;
            if (string.IsNullOrEmpty(errorCheck.GetError(tbName)) == true && string.IsNullOrEmpty(errorCheck.GetError(tbName)) == true)
            {
                DialogResult dialog = MessageBox.Show("Success!", "Notify", MessageBoxButtons.OK);
                if (dialog == DialogResult.OK)
                {
                    _posFastFood.SaveChanges();
                    this.Close();
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
                btnUpdate.PerformClick();
            }
        }

        private void tbPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter))
            {
                btnUpdate.PerformClick();
            }
        }
    }
}
