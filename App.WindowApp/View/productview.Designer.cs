namespace App.WindowApp.View
{
    partial class productview
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(productview));
            tblproducts = new TableLayoutPanel();
            pnltoolbar = new Panel();
            toolStrip = new ToolStrip();
            btnadd = new ToolStripButton();
            btnedit = new ToolStripButton();
            btnview = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButton6 = new ToolStripButton();
            pnlfilters = new Panel();
            tblfilter = new TableLayoutPanel();
            lblsearch = new Label();
            lblcategory = new Label();
            lblstock = new Label();
            txtseaarch = new TextBox();
            cmbcategory = new ComboBox();
            cmbstockstatus = new ComboBox();
            pnlgrid = new Panel();
            dgvProducts = new DataGridView();
            ColId = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colprice = new DataGridViewTextBoxColumn();
            colstock = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            tblproducts.SuspendLayout();
            pnltoolbar.SuspendLayout();
            toolStrip.SuspendLayout();
            pnlfilters.SuspendLayout();
            tblfilter.SuspendLayout();
            pnlgrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // tblproducts
            // 
            tblproducts.ColumnCount = 1;
            tblproducts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblproducts.Controls.Add(pnltoolbar, 0, 0);
            tblproducts.Controls.Add(pnlfilters, 0, 1);
            tblproducts.Controls.Add(pnlgrid, 0, 2);
            tblproducts.Dock = DockStyle.Fill;
            tblproducts.Location = new Point(0, 0);
            tblproducts.Margin = new Padding(2, 3, 2, 3);
            tblproducts.Name = "tblproducts";
            tblproducts.Padding = new Padding(14, 16, 14, 16);
            tblproducts.RowCount = 3;
            tblproducts.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tblproducts.RowStyles.Add(new RowStyle(SizeType.Absolute, 94F));
            tblproducts.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblproducts.Size = new Size(924, 607);
            tblproducts.TabIndex = 0;
            // 
            // pnltoolbar
            // 
            pnltoolbar.BackColor = Color.White;
            pnltoolbar.Controls.Add(toolStrip);
            pnltoolbar.Dock = DockStyle.Fill;
            pnltoolbar.Location = new Point(16, 19);
            pnltoolbar.Margin = new Padding(2, 3, 2, 3);
            pnltoolbar.Name = "pnltoolbar";
            pnltoolbar.Size = new Size(892, 50);
            pnltoolbar.TabIndex = 0;
            // 
            // toolStrip
            // 
            toolStrip.Dock = DockStyle.Fill;
            toolStrip.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip.ImageScalingSize = new Size(24, 24);
            toolStrip.Items.AddRange(new ToolStripItem[] { btnadd, btnedit, btnview, toolStripButton4, toolStripSeparator1, toolStripButton6 });
            toolStrip.Location = new Point(0, 0);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(892, 50);
            toolStrip.TabIndex = 0;
            toolStrip.Text = "toolStrip1";
            // 
            // btnadd
            // 
            btnadd.Image = (Image)resources.GetObject("btnadd.Image");
            btnadd.ImageTransparentColor = Color.Magenta;
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(65, 47);
            btnadd.Text = "Add";
            btnadd.Click += btnadd_Click;
            // 
            // btnedit
            // 
            btnedit.Image = (Image)resources.GetObject("btnedit.Image");
            btnedit.ImageTransparentColor = Color.Magenta;
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(63, 47);
            btnedit.Text = "Edit";
            btnedit.Click += btnedit_Click;
            // 
            // btnview
            // 
            btnview.Image = (Image)resources.GetObject("btnview.Image");
            btnview.ImageTransparentColor = Color.Magenta;
            btnview.Name = "btnview";
            btnview.Size = new Size(69, 47);
            btnview.Text = "View";
            btnview.Click += btnview_Click;
            // 
            // toolStripButton4
            // 
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(81, 47);
            toolStripButton4.Text = "Delete";
            toolStripButton4.Click += toolStripButton4_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 50);
            // 
            // toolStripButton6
            // 
            toolStripButton6.Image = (Image)resources.GetObject("toolStripButton6.Image");
            toolStripButton6.ImageTransparentColor = Color.Magenta;
            toolStripButton6.Name = "toolStripButton6";
            toolStripButton6.Size = new Size(86, 47);
            toolStripButton6.Text = "Refresh";
            // 
            // pnlfilters
            // 
            pnlfilters.BackColor = Color.White;
            pnlfilters.Controls.Add(tblfilter);
            pnlfilters.Dock = DockStyle.Fill;
            pnlfilters.Location = new Point(16, 75);
            pnlfilters.Margin = new Padding(2, 3, 2, 3);
            pnlfilters.Name = "pnlfilters";
            pnlfilters.Padding = new Padding(10, 10, 10, 12);
            pnlfilters.Size = new Size(892, 88);
            pnlfilters.TabIndex = 1;
            pnlfilters.Paint += pnlfilters_Paint;
            // 
            // tblfilter
            // 
            tblfilter.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tblfilter.BackColor = Color.Transparent;
            tblfilter.ColumnCount = 3;
            tblfilter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tblfilter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tblfilter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tblfilter.Controls.Add(lblsearch, 0, 0);
            tblfilter.Controls.Add(lblcategory, 1, 0);
            tblfilter.Controls.Add(lblstock, 2, 0);
            tblfilter.Controls.Add(txtseaarch, 0, 1);
            tblfilter.Controls.Add(cmbcategory, 1, 1);
            tblfilter.Controls.Add(cmbstockstatus, 2, 1);
            tblfilter.Dock = DockStyle.Fill;
            tblfilter.Location = new Point(10, 10);
            tblfilter.Margin = new Padding(2, 3, 2, 3);
            tblfilter.Name = "tblfilter";
            tblfilter.RowCount = 2;
            tblfilter.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblfilter.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblfilter.Size = new Size(872, 66);
            tblfilter.TabIndex = 0;
            // 
            // lblsearch
            // 
            lblsearch.AutoSize = true;
            lblsearch.Dock = DockStyle.Fill;
            lblsearch.Location = new Point(2, 0);
            lblsearch.Margin = new Padding(2, 0, 2, 0);
            lblsearch.Name = "lblsearch";
            lblsearch.Size = new Size(344, 33);
            lblsearch.TabIndex = 0;
            lblsearch.Text = "Search";
            // 
            // lblcategory
            // 
            lblcategory.AutoSize = true;
            lblcategory.Dock = DockStyle.Fill;
            lblcategory.Location = new Point(350, 0);
            lblcategory.Margin = new Padding(2, 0, 2, 0);
            lblcategory.Name = "lblcategory";
            lblcategory.Size = new Size(257, 33);
            lblcategory.TabIndex = 1;
            lblcategory.Text = "Category";
            // 
            // lblstock
            // 
            lblstock.AutoSize = true;
            lblstock.Dock = DockStyle.Fill;
            lblstock.Location = new Point(611, 0);
            lblstock.Margin = new Padding(2, 0, 2, 0);
            lblstock.Name = "lblstock";
            lblstock.Size = new Size(259, 33);
            lblstock.TabIndex = 2;
            lblstock.Text = "Stock Status";
            // 
            // txtseaarch
            // 
            txtseaarch.Dock = DockStyle.Fill;
            txtseaarch.Location = new Point(2, 36);
            txtseaarch.Margin = new Padding(2, 3, 2, 3);
            txtseaarch.Name = "txtseaarch";
            txtseaarch.Size = new Size(344, 27);
            txtseaarch.TabIndex = 3;
            txtseaarch.TextChanged += txtseaarch_TextChanged;
            // 
            // cmbcategory
            // 
            cmbcategory.Dock = DockStyle.Fill;
            cmbcategory.FormattingEnabled = true;
            cmbcategory.Location = new Point(350, 36);
            cmbcategory.Margin = new Padding(2, 3, 2, 3);
            cmbcategory.Name = "cmbcategory";
            cmbcategory.Size = new Size(257, 28);
            cmbcategory.TabIndex = 4;
            // 
            // cmbstockstatus
            // 
            cmbstockstatus.Dock = DockStyle.Fill;
            cmbstockstatus.FormattingEnabled = true;
            cmbstockstatus.Location = new Point(611, 36);
            cmbstockstatus.Margin = new Padding(2, 3, 2, 3);
            cmbstockstatus.Name = "cmbstockstatus";
            cmbstockstatus.Size = new Size(259, 28);
            cmbstockstatus.TabIndex = 5;
            // 
            // pnlgrid
            // 
            pnlgrid.BackColor = Color.White;
            pnlgrid.Controls.Add(dgvProducts);
            pnlgrid.Dock = DockStyle.Fill;
            pnlgrid.Location = new Point(16, 169);
            pnlgrid.Margin = new Padding(2, 3, 2, 3);
            pnlgrid.Name = "pnlgrid";
            pnlgrid.Padding = new Padding(10, 12, 10, 12);
            pnlgrid.Size = new Size(892, 419);
            pnlgrid.TabIndex = 2;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { ColId, colName, colCategory, colprice, colstock, colStatus });
            dgvProducts.Dock = DockStyle.Top;
            dgvProducts.Location = new Point(10, 12);
            dgvProducts.Margin = new Padding(2, 3, 2, 3);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.RowHeadersWidth = 62;
            dgvProducts.RowTemplate.Height = 28;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(872, 218);
            dgvProducts.TabIndex = 0;
            dgvProducts.CellContentClick += dgvProducts_CellContentClick;
            // 
            // ColId
            // 
            ColId.DataPropertyName = "ID";
            ColId.HeaderText = "ID";
            ColId.MinimumWidth = 8;
            ColId.Name = "ColId";
            ColId.ReadOnly = true;
            // 
            // colName
            // 
            colName.DataPropertyName = "Name";
            colName.HeaderText = "Name";
            colName.MinimumWidth = 8;
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colCategory
            // 
            colCategory.DataPropertyName = "Category";
            colCategory.HeaderText = "Category";
            colCategory.MinimumWidth = 8;
            colCategory.Name = "colCategory";
            colCategory.ReadOnly = true;
            // 
            // colprice
            // 
            colprice.DataPropertyName = "Price";
            colprice.HeaderText = "Price";
            colprice.MinimumWidth = 8;
            colprice.Name = "colprice";
            colprice.ReadOnly = true;
            // 
            // colstock
            // 
            colstock.DataPropertyName = "Stock";
            colstock.HeaderText = "Stock";
            colstock.MinimumWidth = 8;
            colstock.Name = "colstock";
            colstock.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.DataPropertyName = "Status";
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 8;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // productview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblproducts);
            Margin = new Padding(2, 3, 2, 3);
            Name = "productview";
            Size = new Size(924, 607);
            Load += productview_Load;
            tblproducts.ResumeLayout(false);
            pnltoolbar.ResumeLayout(false);
            pnltoolbar.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            pnlfilters.ResumeLayout(false);
            tblfilter.ResumeLayout(false);
            tblfilter.PerformLayout();
            pnlgrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblproducts;
        private System.Windows.Forms.Panel pnltoolbar;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton btnadd;
        private System.Windows.Forms.ToolStripButton btnedit;
        private System.Windows.Forms.ToolStripButton btnview;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.Panel pnlfilters;
        private System.Windows.Forms.TableLayoutPanel tblfilter;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.Label lblcategory;
        private System.Windows.Forms.Label lblstock;
        private System.Windows.Forms.TextBox txtseaarch;
        private System.Windows.Forms.ComboBox cmbcategory;
        private System.Windows.Forms.ComboBox cmbstockstatus;
        private System.Windows.Forms.Panel pnlgrid;
        private System.Windows.Forms.DataGridView dgvProducts;
        private DataGridViewTextBoxColumn ColId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colprice;
        private DataGridViewTextBoxColumn colstock;
        private DataGridViewTextBoxColumn colStatus;
    }
}
