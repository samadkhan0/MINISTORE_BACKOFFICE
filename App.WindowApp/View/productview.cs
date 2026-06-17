using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Core.Contracts;
using App.Core.Utilities;
using App.Core.Models;
using App.WindowApp.Forms;

namespace App.WindowApp.View
{
    public partial class productview : UserControl

    {
        BindingSource dgvBindingSource = new BindingSource();
        IProductService _service;
        public productview(IProductService _ser)
        {
            _service = _ser;
            InitializeComponent();
            dgvProducts.DataSource = dgvBindingSource;
        }

        private void pnlfilters_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void productview_Load(object sender, EventArgs e)
        {
            // CATEGORY
            var categories = new List<object> { "--ALL--" };
            categories.AddRange(Enum.GetValues(typeof(ProductCategoryEnum)).Cast<object>());
            cmbcategory.DataSource = categories;

            // STATUS
            var statuses = new List<object> { "--ALL--" };
            statuses.AddRange(Enum.GetValues(typeof(ProductCategoryStatus)).Cast<object>());
            cmbstockstatus.DataSource = statuses;

            cmbcategory.SelectedIndexChanged += txtseaarch_TextChanged;
            cmbstockstatus.SelectedIndexChanged += txtseaarch_TextChanged;

            if (_service == null) return;

            dgvBindingSource.DataSource = _service.GetAll();
        }
        private void btnedit_Click(object sender, EventArgs e)
        {
            Product? selectedProduct = dgvBindingSource.Current as Product;
            if (selectedProduct != null)
            {
                ProductForm productForm = new ProductForm(ProductFormModeEnum.Edit, selectedProduct, _service);
                productForm.ShowDialog();
                RefreshGrid();
            }



        }

        private void btnview_Click(object sender, EventArgs e)
        {
            Product? selectedProduct = dgvBindingSource.Current as Product;
            if (selectedProduct != null)
            {
                ProductForm productForm = new ProductForm(ProductFormModeEnum.View, selectedProduct, _service);
                productForm.ShowDialog();
            }

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm(ProductFormModeEnum.Add, null, _service);
            productForm.ShowDialog();
            RefreshGrid();
        }
        private void RefreshGrid()
        {
            dgvBindingSource.DataSource = _service.GetAll();
        }

        private void txtseaarch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtseaarch.Text;

            ProductCategoryEnum? selectedCategory = null;

            if (cmbcategory.SelectedItem != null &&
                cmbcategory.SelectedItem.ToString() != "--ALL--")
            {
                selectedCategory = (ProductCategoryEnum)cmbcategory.SelectedItem;
            }

            ProductCategoryStatus? selectedStatus = null;

            if (cmbstockstatus.SelectedItem != null &&
                cmbstockstatus.SelectedItem.ToString() != "--ALL--")
            {
                selectedStatus = (ProductCategoryStatus)cmbstockstatus.SelectedItem;
            }

            dgvBindingSource.DataSource =
                _service.Search(searchText, selectedCategory, selectedStatus);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Product? selectedProduct = dgvBindingSource.Current as Product;
            if (selectedProduct != null)
            {
                _service.Delete(selectedProduct.Id);
                RefreshGrid();
            }
        }
    }
}
