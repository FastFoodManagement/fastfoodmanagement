using QLBanDoAnNhanh.Models;
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
    public partial class frmChangePass : Form
    {
        private PosFastFood _posFastFood;
        private int _idEmployee;
        public frmChangePass(int idEmployee)
        {
            InitializeComponent();
            _idEmployee = idEmployee;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfr_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbNewpass.Text) == true)
            {
                errorProvider.SetError(tbNewpass, "Not empty!");
            }
            else
            {
                errorProvider.SetError(tbNewpass, "");
            }
            if (string.IsNullOrWhiteSpace(tbOldpass.Text) == true)
            {
                errorProvider.SetError(tbOldpass, "Not empty!");
            }
            else
            {
                errorProvider.SetError(tbOldpass, "");
            }
            _posFastFood = new PosFastFood();
            var emp = _posFastFood.Employees.Find(_idEmployee);
            if (string.IsNullOrEmpty(errorProvider.GetError(tbNewpass)) == true && string.IsNullOrEmpty(errorProvider.GetError(tbOldpass)) == true)
            {
                if (string.Compare(tbOldpass.Text, emp.Password, false) == 0)
                {
                    if (emp != null)
                    {
                        emp.Password = tbNewpass.Text;
                    }
                    _posFastFood.SaveChanges();
                    MessageBox.Show("Changing success!!");
                }
                else
                {
                    MessageBox.Show("Old password not correct!!");
                }
            }
        }

        private void cbShow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShow.Checked == true)
            {
                cbShow.Text = "Hide";
                tbNewpass.PasswordChar = '\0';
                tbOldpass.PasswordChar = '\0';
            }
            else
            {
                cbShow.Text = "Show";
                tbNewpass.PasswordChar = '*';
                tbOldpass.PasswordChar = '*';
            }
        }
    }
}
