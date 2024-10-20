using QLBanDoAnNhanh.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QLBanDoAnNhanh
{
    public partial class frmlogin : Form
    {
        private PosFastFood _posFastFood;
        public bool Valid { get; set; } = false;
        public frmlogin()
        {
            InitializeComponent();
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {
            tbPass.PasswordChar = '*';
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {

            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.\w{2,3})+)$";
            Regex regex = new Regex(pattern);
            if (string.IsNullOrEmpty(tbEmail.Text))
            {
                errorCheck.SetError(tbEmail, "Cannot empty!");
            }
            else if (regex.IsMatch(tbEmail.Text) == false)
            {
                errorCheck.SetError(tbEmail, "Not formating email!");
            }
            else
            {
                errorCheck.SetError(tbEmail, "");
            }
        }

        private void tbPass_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbPass.Text))
            {
                errorCheck.SetError(tbPass, "Cannot empty!");
            }
            else
            {
                errorCheck.SetError(tbPass, "");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            _posFastFood = new PosFastFood();
            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.\w{2,3})+)$";
            Regex regex = new Regex(pattern);
            if (string.IsNullOrEmpty(tbEmail.Text))
            {
                errorCheck.SetError(tbEmail, "Cannot empty!");
            }
            else if (regex.IsMatch(tbEmail.Text) == false)
            {
                errorCheck.SetError(tbEmail, "Not formating email!");
            }
            else
            {
                errorCheck.SetError(tbEmail, "");
            }
            if (string.IsNullOrEmpty(tbPass.Text))
            {
                errorCheck.SetError(tbPass, "Cannot empty!");
            }
            else
            {
                errorCheck.SetError(tbPass, "");
            }
            var employee = _posFastFood.Employees.ToList();
            bool checkLogin = false;
            foreach (var emp in employee)
            {
                if (string.Compare(tbEmail.Text, emp.Email, false) == 0 && string.Compare(tbPass.Text, emp.Password, false) == 0)
                {
                    checkLogin = true;
                    Form frmmain = new frmMain(emp.IdEmployee, this);
                    this.Hide();
                    frmmain.Show();
                }
            }
            if (checkLogin == false)
            {
                MessageBox.Show("Login unsuccessful. Please check your username and password!");
            }
        }

        private void tbEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void tbPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void cbShow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShow.Checked == true)
            {
                cbShow.Text = "Hide";
                tbPass.PasswordChar = '\0';
            }
            else
            {
                cbShow.Text = "Show";
                tbPass.PasswordChar = '*';
            }
        }
    }
}
