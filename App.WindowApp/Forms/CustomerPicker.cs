using App.Core.Contracts;
using App.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.WindowApp.Forms
{
    public partial class CustomerPicker : Form
    {
        private readonly ICustomerService _customerService;
        private BindingSource _bindingsource;
        public Customer SelectedCustomer { get; set; }
        public CustomerPicker(ICustomerService service)
        {
            InitializeComponent();
            _bindingsource = new BindingSource();
            lbCustomer.DataSource = _bindingsource;
            _customerService = service;
            LoadCustomers(string.Empty);

        }
        //private void LoadCustomers(string query)
        //{
        //    var customers = string.IsNullOrWhiteSpace(query) ?
        //        _bindingsource.DataSource = customers:
        //    lbCustomer.DisplayMember = "Name";
        //    lbCustomer.ValueMember = "Id";

        //}

        private void LoadCustomers(string query)
        {
            var customers = string.IsNullOrWhiteSpace(query)
                ? _customerService.GetAll()
                : _customerService.Search(query);             
               _bindingsource. DataSource = customers;
            lbCustomer.DisplayMember = "Name";
            lbCustomer.ValueMember = "Id";
        }

        private void lbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSearchQuery_TextChanged(object sender, EventArgs e)
        {
            LoadCustomers(txtSearchQuery.Text);
        }
        private void SelectCustomer()
        {
            if (lbCustomer.SelectedItem != null && lbCustomer.SelectedItem is Customer)
            {
                SelectedCustomer = (Customer)lbCustomer.SelectedItem;
                this.DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Please Select a Customer ", "Customer Select", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SelectCustomer();

        }

        private void lbCustomer_DoubleClick(object sender, EventArgs e)
        {
            SelectCustomer();

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();

        }
    }
}
