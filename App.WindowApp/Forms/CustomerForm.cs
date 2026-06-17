using App.Core.Contracts;
using App.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace App.WindowApp.Forms
{
    public partial class CustomerForm : Form
    {
        private ICustomerService _customerService;
        private Customer _customer;
        private CustomerFormModeEnum _mode;

        // all methods here


        public CustomerForm(ICustomerService customerService, CustomerFormModeEnum mode, Customer customer = null)
        {
            InitializeComponent();

            _customerService = customerService;   // ✅ correct
            _mode = mode;
            _customer = customer ?? new Customer(); // ✅ correct

            SetupMode();
            PopulateFields();
        }
        private void PopulateFields()
        {
            tbname.Text = _customer.Name;
            tbphone.Text = _customer.Phone;
            tbemail.Text = _customer.Email;
            tbid.Text = _customer.Id;
            tbaddress.Text = _customer.Address;
        }
        private void SetupMode()
        {
            switch (_mode)
            {
                case CustomerFormModeEnum.Add:
                    this.Text = "Add Customer";
                    tbid.ReadOnly = true;
                    tbname.ReadOnly = false;
                    tbaddress.ReadOnly = false;
                    tbphone.ReadOnly = false;
                    tbemail.ReadOnly = false;
                    break;
                case CustomerFormModeEnum.Edit:
                    this.Text = "Add Customer";
                    tbid.ReadOnly = true;
                    tbname.ReadOnly = false;
                    tbaddress.ReadOnly = false;
                    tbphone.ReadOnly = false;
                    tbemail.ReadOnly = false;
                    break;
                case CustomerFormModeEnum.View:
                    this.Text = "View Customer";
                    tbid.ReadOnly = true;
                    tbname.ReadOnly = true;
                    tbaddress.ReadOnly = true;
                    tbphone.ReadOnly = true;
                    tbemail.ReadOnly = true;
                    btnSave.Visible = false;
                    break;
            }
        }
        private bool validateData()
        {
            if (string.IsNullOrWhiteSpace(tbname.Text))
            {
                MessageBox.Show("Name can not be empty", "validating data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbphone.Text))
            {
                MessageBox.Show("Phone  can not be empty", "validating data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void tblCustomeradd_Paint(object sender, PaintEventArgs e)
        {
            // your code (or leave empty)
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (validateData())
                {
                    _customer.Name = tbname.Text;
                    _customer.Phone = tbphone.Text;
                    _customer.Address = tbaddress.Text;
                    _customer.Email = tbemail.Text;

                    if (_mode == CustomerFormModeEnum.Add)
                    {
                        _customerService.Add(_customer);

                    }
                    else
                    {
                        _customerService.Update(_customer);
                    }
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in saving customer :(ex.Message)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
