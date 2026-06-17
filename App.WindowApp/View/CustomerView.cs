using App.Core.Contracts;
using App.Core.Models;
using App.WindowApp.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

// <- This is WPF UserControl
using System.Windows.Forms; // WPF

namespace App.WindowApp.View
{
    public partial class CustomerView : UserControl
    {
        private readonly ICustomerService _customerService;
        private BindingSource _bindingSource = new BindingSource();

        public CustomerView(ICustomerService _service)
        {
            InitializeComponent();
            _customerService = _service;
            dgvCustomer.DataSource =  _bindingSource;
            dgvCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LoadCustomer();
        }
        private void LoadCustomer()
        {
            var customers = _customerService.GetAll();
            _bindingSource.DataSource = customers;
            //lblCount.Text = $"Total: {customers.Count}";
            lblCount.Text = $"Total: {customers.Count}";
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tspAdd_Click(object sender, EventArgs e)
        {
            using var form = new CustomerForm(_customerService, CustomerFormModeEnum.Add);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadCustomer();
            }
        }

        private void tspEdit_Click(object sender, EventArgs e)
        {
            var selectedCustomer = _bindingSource.Current as Customer;
            if (selectedCustomer != null)
            {
                using var form = new CustomerForm(_customerService, CustomerFormModeEnum.Edit, selectedCustomer);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadCustomer(); 
                }
            }

        }

     
        private void tspView_Click(object sender, EventArgs e)
        {
            var selectedCustomer = _bindingSource.Current as Customer;
            if (selectedCustomer != null)
            {
                using var form = new CustomerForm(_customerService, CustomerFormModeEnum.View, selectedCustomer);
                form.ShowDialog(); // no need to reload after viewing
            }
        }

        private void tspDelete_Click(object sender, EventArgs e)
        {
            var selectedCustomer = _bindingSource.Current as Customer;
            if (selectedCustomer != null)
            {
                var confirm = MessageBox.Show("Are You sure want to Delete this Customer..!", "Confirm Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    _customerService.Delete(selectedCustomer.Id);
                    LoadCustomer();

                }
            }


        }

        private void tspRefresh_Click(object sender, EventArgs e)
        {
            Serachlb.Text = "";
            LoadCustomer();

        }

        private void Applyfilters()

        {
            var customers = _customerService.Search(txtSearch.Text);
            _bindingSource.DataSource = customers;
            //lblCount.Text = $"Total:(customers.Count)";
            lblCount.Text = $"Total: {customers.Count}";
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Applyfilters();
        }
    }
}
