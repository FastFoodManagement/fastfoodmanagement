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
    public partial class frmMain : Form
    {
        private PosFastFood _posFastFood;
        private int _idEmployee;
        private Item _itemProduct;
        private ItemOrder _itemOrder;
        private decimal _price = 0;
        private int _category = 11;

        private frmlogin _frmlogin = new frmlogin();
        public frmMain(int idEmployee, frmlogin frmlogin)
        {
            InitializeComponent(); // Make sure this is not commented out
            _idEmployee = idEmployee;
            _frmlogin = frmlogin; // Ensure you have these variables defined in your class
            flpOrder.Controls.Clear();

            // Call btnFoods_Click with null parameters
            btnFoods_Click(null, null);

            _posFastFood = new PosFastFood();
            var emp = _posFastFood.Employees.Find(_idEmployee);
            lbUser.Text = emp.NameEmployee;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            flpOrder.Controls.Clear();
            switch (_category)
            {
                case 21:
                    btnFoods.PerformClick(); break;
                case 22:
                    btnDrink.PerformClick(); break;
                case 23:
                    btnSnack.PerformClick(); break;
                case 24:
                    btnDessert.PerformClick(); break;
                case 25:
                    btnCombo.PerformClick(); break;
            }
            _posFastFood = new PosFastFood();
            var emp = _posFastFood.Employees.Find(_idEmployee);
            lbUser.Text = emp.NameEmployee;
        }
        private void LoadProductsByCategory(int categoryId, string categoryName)
        {
            lbCategory.Text = categoryName;
            _category = categoryId;
            flpItems.Controls.Clear();
            _posFastFood = new PosFastFood();
            var productItems = _posFastFood.Products.Where(x => x.IdTypeProduct == categoryId).ToList();

            foreach (var item in productItems)
            {
                _itemProduct = new Item
                {
                    ID = item.IdProduct,
                    _Name = item.NameProduct,
                    Price = (decimal)item.PriceProduct,
                    LablePrice = item.PriceProduct.Value.ToString("0.00") + "$",
                    IsActive = item.IsActive.HasValue && !item.IsActive.Value, // Hoặc
                                                                               // IsActive = !item.IsActive.GetValueOrDefault(), // Sử dụng GetValueOrDefault()
                    Tag = item.IdProduct
                };

                using (MemoryStream ms = new MemoryStream(item.Images))
                {
                    Image image = Image.FromStream(ms);
                    _itemProduct.BackgroundImage = image;
                }

                _itemProduct.Click += new System.EventHandler(this.Item_Click);
                _itemProduct.MouseDown += Item_RightClick;
                flpItems.Controls.Add(_itemProduct);
                CheckItemInOrder();
            }
        }

        private void btnFoods_Click(object sender, EventArgs e)
        {
            ResetButtonColors(); // Reset all button colors

            btnFoods.FillColor = Color.FromArgb(249, 130, 68);
            btnFoods.FillColor2 = Color.FromArgb(247, 72, 115);
            LoadProductsByCategory(21, "Foods");
        }
       
        private void btnDrink_Click(object sender, EventArgs e)
        {
            ResetButtonColors(); // Reset all button colors

            btnDrink.FillColor = Color.FromArgb(249, 130, 68);
            btnDrink.FillColor2 = Color.FromArgb(247, 72, 115);
            LoadProductsByCategory(22, "Drink");
        }

        private void btnSnack_Click(object sender, EventArgs e)
        {
            ResetButtonColors(); // Reset all button colors

            btnSnack.FillColor = Color.FromArgb(249, 130, 68);
            btnSnack.FillColor2 = Color.FromArgb(247, 72, 115);
            LoadProductsByCategory(23, "Snack");
        }

        private void btnDessert_Click(object sender, EventArgs e)
        {
            ResetButtonColors(); // Reset all button colors

            btnDessert.FillColor = Color.FromArgb(249, 130, 68);
            btnDessert.FillColor2 = Color.FromArgb(247, 72, 115);
            LoadProductsByCategory(24, "Dessert");
        }

        private void btnCombo_Click(object sender, EventArgs e)
        {
            ResetButtonColors(); // Reset all button colors

            btnCombo.FillColor = Color.FromArgb(249, 130, 68);
            btnCombo.FillColor2 = Color.FromArgb(247, 72, 115);
            LoadProductsByCategory(25, "Combo");
        }
        private void ResetButtonColors()
        {
            btnFoods.FillColor = Color.Transparent;
            btnFoods.FillColor2 = Color.Transparent;

            btnDrink.FillColor = Color.Transparent;
            btnDrink.FillColor2 = Color.Transparent;

            btnSnack.FillColor = Color.Transparent;
            btnSnack.FillColor2 = Color.Transparent;

            btnDessert.FillColor = Color.Transparent;
            btnDessert.FillColor2 = Color.Transparent;

            btnCombo.FillColor = Color.Transparent;
            btnCombo.FillColor2 = Color.Transparent;

            btnAdditem.FillColor = Color.Transparent;
            btnAdditem.FillColor2 = Color.Transparent;

            btnSetting.FillColor = Color.Transparent;
            btnSetting.FillColor2 = Color.Transparent;
        }

        private void btnAdditem_Click(object sender, EventArgs e)
        {
            btnFoods.FillColor = Color.Transparent;
            btnFoods.FillColor2 = Color.Transparent;
            btnDrink.FillColor = Color.Transparent;
            btnDrink.FillColor2 = Color.Transparent;
            btnSnack.FillColor = Color.Transparent;
            btnSnack.FillColor2 = Color.Transparent;
            btnDessert.FillColor = Color.Transparent;
            btnDessert.FillColor2 = Color.Transparent;
            btnCombo.FillColor = Color.Transparent;
            btnCombo.FillColor2 = Color.Transparent;
            btnAdditem.FillColor = Color.FromArgb(249, 130, 68);
            btnAdditem.FillColor2 = Color.FromArgb(247, 72, 115);
            btnSetting.FillColor = Color.Transparent;
            btnSetting.FillColor2 = Color.Transparent;
            _posFastFood = new PosFastFood();
            var employee = _posFastFood.Employees.Find(_idEmployee);
            if (employee.IdRole == 1 || string.Compare(employee.RoleEmployee.NameRole, "admin", false) == 0)
            {
                Form form = new frmAddItem(_idEmployee);
                form.ShowDialog();
                switch (_category)
                {
                    case 21:
                        btnFoods.PerformClick(); break;
                    case 22:
                        btnDrink.PerformClick(); break;
                    case 23:
                        btnSnack.PerformClick(); break;
                    case 24:
                        btnDessert.PerformClick(); break;
                    case 25:
                        btnCombo.PerformClick(); break;
                }
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Please log in as a management account!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Item_Click(object sender, EventArgs e)
        {
            Item itemControl = (Item)sender;
            if (itemControl.IsValid == false && itemControl.IsActive == false)
            {
                _price = 0;
                itemControl.IsValid = true;
                _itemOrder = new ItemOrder();
                _itemOrder.ID = itemControl.ID;
                _itemOrder._Name = itemControl._Name;
                _itemOrder.Price = itemControl.Price;
                _itemOrder._Date = DateTime.Now.ToString();
                _itemOrder.Quantity = 1;
                _itemOrder.Image = _itemProduct.BackgroundImage;
                _itemOrder.LablePrice = itemControl.Price.ToString("0.00") + "$";
                _itemOrder.Tag = itemControl.ID;
                _itemOrder.upDown.ValueChanged += numQuantity_Valuechanged;
                flpOrder.Controls.Add(_itemOrder);
                foreach (Control control in flpOrder.Controls)
                {
                    if (control is ItemOrder itemOrder)
                    {
                        _price += (itemOrder.Price * itemOrder.Quantity);
                    }
                }
            }
            else
            {
                itemControl.IsValid = false;
                foreach (Control control in flpOrder.Controls)
                {
                    if (control is ItemOrder itemOrder)
                    {
                        if ((int)itemOrder.Tag == (int)itemControl.Tag)
                        {
                            _price -= (itemOrder.Price * itemOrder.Quantity);
                            flpOrder.Controls.Remove(itemOrder);
                        }
                    }
                }
            }
            lbVAT.Text = "+" + ((decimal)0.05 * _price).ToString("0.00") + "$";
            lbTotal.Text = _price.ToString("0.00") + "$";
            lbLastPrice.Text = (_price + ((decimal)0.05 * _price)).ToString("0.00") + "$";
        }
        private void numQuantity_Valuechanged(object sender, EventArgs e)
        {
            NumericUpDown upDown = sender as NumericUpDown;
            _price = 0;
            foreach (Control control in flpOrder.Controls)
            {
                if (control is ItemOrder itemOrder)
                {
                    if ((int)itemOrder.Tag == (int)upDown.Parent.Tag)
                    {
                        itemOrder.Quantity = (int)upDown.Value;
                    }
                    _price += (itemOrder.Price * itemOrder.Quantity);
                    itemOrder.LablePrice = (itemOrder.Price * itemOrder.Quantity).ToString("0.00") + "$";

                }
            }
            lbVAT.Text = "+" + ((decimal)0.05 * _price).ToString("0.00") + "$";
            lbTotal.Text = _price.ToString("0.00") + "$";
            lbLastPrice.Text = (_price + ((decimal)0.05 * _price)).ToString("0.00") + "$";
        }
        private void CheckItemInOrder()
        {
            foreach (Control controlItem in flpItems.Controls)
            {
                if (controlItem is Item item)
                {
                    foreach (Control controlItemOrder in flpOrder.Controls)
                    {
                        if (controlItemOrder is ItemOrder itemOrder)
                        {
                            if ((int)item.Tag == (int)itemOrder.Tag)
                            {
                                item.IsValid = true;
                            }
                        }
                    }
                }
            }
        }
        private void Item_RightClick(object sender, MouseEventArgs e)
        {
            Item itemProduct = (Item)sender;
            if (e.Button == MouseButtons.Right)
            {
                Form form = new frmItemDetail((int)itemProduct.ID, _idEmployee);
                form.ShowDialog();
                switch (_category)
                {
                    case 21:
                        btnFoods.PerformClick(); break;
                    case 22:
                        btnDrink.PerformClick(); break;
                    case 23:
                        btnSnack.PerformClick(); break;
                    case 24:
                        btnDessert.PerformClick(); break;
                    case 25:
                        btnCombo.PerformClick(); break;
                }
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                _posFastFood = new PosFastFood();
                // Trim the search input and use Contains for partial matches
                var productItem = _posFastFood.Products
                    .Where(x => x.IdTypeProduct == _category && x.NameProduct.ToLower().Contains(txtSearch.Text.Trim().ToLower()))
                    .ToList();

                if (productItem.Count > 0)
                {
                    flpItems.Controls.Clear();
                    foreach (var item in productItem)
                    {
                        _itemProduct = new Item();
                        _itemProduct.ID = item.IdProduct;
                        _itemProduct._Name = item.NameProduct;
                        _itemProduct.Price = (decimal)item.PriceProduct;
                        _itemProduct.LablePrice = item.PriceProduct.Value.ToString("0.00") + "$";
                        _itemProduct.IsActive = !(item.IsActive ?? false);


                        using (MemoryStream ms = new MemoryStream(item.Images))
                        {
                            Image image = Image.FromStream(ms);
                            _itemProduct.BackgroundImage = image;
                        }
                        _itemProduct.Tag = item.IdProduct;
                        _itemProduct.Click += new System.EventHandler(this.Item_Click);
                        _itemProduct.MouseDown += Item_RightClick;
                        flpItems.Controls.Add(_itemProduct);
                        CheckItemInOrder();
                    }
                }
                else
                {
                    HandleCategorySwitch();
                    MessageBox.Show("Can't find this item!");
                }
            }
        }

        private void picSearch_Click(object sender, EventArgs e)
        {
           
            _posFastFood = new PosFastFood();
            var productItem = _posFastFood.Products
                .Where(x => x.IdTypeProduct == _category && x.NameProduct.ToLower().Contains(txtSearch.Text.Trim().ToLower()))
                .ToList();

            if (productItem.Count > 0)
            {
                flpItems.Controls.Clear();
                foreach (var item in productItem)
                {
                    _itemProduct = new Item();
                    _itemProduct.ID = item.IdProduct;
                    _itemProduct._Name = item.NameProduct;
                    _itemProduct.Price = (decimal)item.PriceProduct;
                    _itemProduct.LablePrice = item.PriceProduct.Value.ToString("0.00") + "$";
                    _itemProduct.IsActive = !(item.IsActive ?? false);

                    using (MemoryStream ms = new MemoryStream(item.Images))
                    {
                        Image image = Image.FromStream(ms);
                        _itemProduct.BackgroundImage = image;
                    }
                    _itemProduct.Tag = item.IdProduct;
                    _itemProduct.Click += new System.EventHandler(this.Item_Click);
                    _itemProduct.MouseDown += Item_RightClick;
                    flpItems.Controls.Add(_itemProduct);
                    CheckItemInOrder();
                }
            }
            else
            {
                HandleCategorySwitch();
                MessageBox.Show("Can't find this item!");
            }
        }
        private void HandleCategorySwitch()
        {
            switch (_category)
            {
                case 21:
                    btnFoods.PerformClick();
                    break;
                case 22:
                    btnDrink.PerformClick();
                    break;
                case 23:
                    btnSnack.PerformClick();
                    break;
                case 24:
                    btnDessert.PerformClick();
                    break;
                case 25:
                    btnCombo.PerformClick();
                    break;
            }
        }
        private void btnPay_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            int quantity = 0;
            foreach (Control control in flpOrder.Controls)
            {
                if (control is ItemOrder item)
                {
                   quantity += item.Quantity;
                }
            }
            foreach (Control control in flpOrder.Controls)
            {
                if (control is ItemOrder item)
                {
                    Product product = _posFastFood.Products.Find(item.Tag);
                    order.quantity = quantity;
                    order.Total = (_price * (decimal)0.05) + _price;
                    order.CreateDate = DateTime.Now;
                    order.IdEmployee = _idEmployee;

                    OrderDetail orderDetail = new OrderDetail();
                    orderDetail.IdProduct = product.IdProduct;
                    orderDetail.quantity = item.Quantity;
                    order.OrderDetails.Add(orderDetail);
                }
            }
            _posFastFood.Orders.Add(order);
            _posFastFood.SaveChanges();
            MessageBox.Show("Succsess!!");
            frmMain_Load(sender, e);
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            _frmlogin.Show();
            this.Close();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            guna2ControlBox1.PerformClick();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            btnFoods.FillColor = Color.Transparent;
            btnFoods.FillColor2 = Color.Transparent;
            btnDrink.FillColor = Color.Transparent;
            btnDrink.FillColor2 = Color.Transparent;
            btnSnack.FillColor = Color.Transparent;
            btnSnack.FillColor2 = Color.Transparent;
            btnDessert.FillColor = Color.Transparent;
            btnDessert.FillColor2 = Color.Transparent;
            btnCombo.FillColor = Color.Transparent;
            btnCombo.FillColor2 = Color.Transparent;
            btnAdditem.FillColor = Color.Transparent;
            btnAdditem.FillColor2 = Color.Transparent;
            btnSetting.FillColor = Color.FromArgb(249, 130, 68);
            btnSetting.FillColor2 = Color.FromArgb(247, 72, 115);
            Form frmchangePass = new frmChangePass(_idEmployee);
            frmchangePass.ShowDialog();
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            printPreview.Document = printDocument;
            printPreview.ShowDialog();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("KFC", new Font("Arial", 28, FontStyle.Bold), Brushes.Black, new Point(270, 10));
            e.Graphics.DrawString("Invoice", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(350, 50));
            e.Graphics.DrawString("Phone: +8499999999", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(50, 80));
            e.Graphics.DrawString("Email: foods-hori@gmail.com", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(50, 110));
            e.Graphics.DrawString("Address: 140 Le Trong Tan, Tan Phu , Ho Chi Minh City", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(50, 140));
            e.Graphics.DrawString("______________________________________________________________________________________________________________________________________________________", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(0, 160));
            e.Graphics.DrawString("Date: " + DateTime.Now.ToString(), new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(50, 190));
            e.Graphics.DrawString("Employee: ", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(50, 220));
            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(50, 250));
            e.Graphics.DrawString("Item", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(60, 280));
            e.Graphics.DrawString("Qty", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(250, 280));
            e.Graphics.DrawString("Price", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(450, 280));
            e.Graphics.DrawString("Amount", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(660, 280));
            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(50, 310));
            int y = 310;
            decimal price = 0;
            foreach (Control controlOrder in flpOrder.Controls)
            {
                if (controlOrder is ItemOrder order)
                {
                    e.Graphics.DrawString(order._Name, new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(60, y + 30));
                    e.Graphics.DrawString(order.Quantity.ToString(), new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(250, y + 30));
                    e.Graphics.DrawString(order.Price.ToString("0.00") + "$", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(450, y + 30));
                    e.Graphics.DrawString((order.Quantity * order.Price).ToString("0.00") + "$", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(660, y + 30));
                    y += 30;
                    price += (order.Quantity * order.Price);
                }
            }
            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(50, y + 30));
            e.Graphics.DrawString("Bill toal", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(60, y + 60));
            e.Graphics.DrawString(_price.ToString("0.00") + "$", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(660, y + 60));
            e.Graphics.DrawString("VAT(5%)", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(60, y + 90));
            e.Graphics.DrawString("+ " + ((decimal)0.05 * price).ToString("0.00") + "$", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(660, y + 90));
            e.Graphics.DrawString("Last bill", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(60, y + 120));
            e.Graphics.DrawString((((decimal)0.05 * _price) + _price).ToString("0.00") + "$", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(660, y + 120));
        }
    }
}
