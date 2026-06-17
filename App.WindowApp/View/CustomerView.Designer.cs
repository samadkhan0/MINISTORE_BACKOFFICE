namespace App.WindowApp.View
{
    partial class CustomerView
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerView));
            miniToolStrip = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripLabel1 = new ToolStripLabel();
            toolStripButton2 = new ToolStripButton();
            toolStripLabel2 = new ToolStripLabel();
            toolStripButton3 = new ToolStripButton();
            toolStripLabel3 = new ToolStripLabel();
            toolStripButton4 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripLabel4 = new ToolStripLabel();
            toolStripButton5 = new ToolStripButton();
            toolStripLabel5 = new ToolStripLabel();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            Serachlb = new Label();
            txtSearch = new TextBox();
            lblCount = new Label();
            dgvCustomer = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            ColAddress = new DataGridViewTextBoxColumn();
            toolStrip2 = new ToolStrip();
            tspAdd = new ToolStripButton();
            tspEdit = new ToolStripButton();
            tspView = new ToolStripButton();
            tspDelete = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tspRefresh = new ToolStripButton();
            toolStrip1 = new ToolStrip();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            toolStrip2.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // miniToolStrip
            // 
            miniToolStrip.AccessibleName = "New item selection";
            miniToolStrip.AccessibleRole = AccessibleRole.ButtonDropDown;
            miniToolStrip.AutoSize = false;
            miniToolStrip.CanOverflow = false;
            miniToolStrip.Dock = DockStyle.None;
            miniToolStrip.GripStyle = ToolStripGripStyle.Hidden;
            miniToolStrip.ImageScalingSize = new Size(24, 24);
            miniToolStrip.Location = new Point(459, 2);
            miniToolStrip.Name = "miniToolStrip";
            miniToolStrip.Size = new Size(800, 33);
            miniToolStrip.TabIndex = 0;
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(34, 28);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(46, 28);
            toolStripLabel1.Text = "Add";
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(34, 28);
            toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(42, 28);
            toolStripLabel2.Text = "Edit";
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(34, 28);
            toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripLabel3
            // 
            toolStripLabel3.Name = "toolStripLabel3";
            toolStripLabel3.Size = new Size(49, 28);
            toolStripLabel3.Text = "View";
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(34, 28);
            toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 33);
            // 
            // toolStripLabel4
            // 
            toolStripLabel4.Name = "toolStripLabel4";
            toolStripLabel4.Size = new Size(62, 28);
            toolStripLabel4.Text = "Delete";
            // 
            // toolStripButton5
            // 
            toolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton5.Image = (Image)resources.GetObject("toolStripButton5.Image");
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(34, 28);
            toolStripButton5.Text = "toolStripButton5";
            // 
            // toolStripLabel5
            // 
            toolStripLabel5.Name = "toolStripLabel5";
            toolStripLabel5.Size = new Size(70, 28);
            toolStripLabel5.Text = "Refresh";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 1);
            tableLayoutPanel1.Controls.Add(dgvCustomer, 0, 2);
            tableLayoutPanel1.Controls.Add(toolStrip2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.043478F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.869565F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 76.08696F));
            tableLayoutPanel1.Size = new Size(886, 394);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(Serachlb);
            flowLayoutPanel1.Controls.Add(txtSearch);
            flowLayoutPanel1.Controls.Add(lblCount);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 54);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(880, 36);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // Serachlb
            // 
            Serachlb.AutoSize = true;
            Serachlb.Location = new Point(3, 0);
            Serachlb.Name = "Serachlb";
            Serachlb.Size = new Size(64, 25);
            Serachlb.TabIndex = 0;
            Serachlb.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(73, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(575, 31);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(654, 0);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(84, 25);
            lblCount.TabIndex = 1;
            lblCount.Text = "Count : 0";
            lblCount.Click += label2_Click_1;
            // 
            // dgvCustomer
            // 
            dgvCustomer.AllowUserToAddRows = false;
            dgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomer.BackgroundColor = Color.White;
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomer.Columns.AddRange(new DataGridViewColumn[] { colId, colName, colPhone, colEmail, ColAddress });
            dgvCustomer.Dock = DockStyle.Fill;
            dgvCustomer.Location = new Point(3, 96);
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.ReadOnly = true;
            dgvCustomer.RowHeadersVisible = false;
            dgvCustomer.RowHeadersWidth = 62;
            dgvCustomer.Size = new Size(880, 295);
            dgvCustomer.TabIndex = 1;
            // 
            // colId
            // 
            colId.DataPropertyName = "Id";
            colId.HeaderText = "Id";
            colId.MinimumWidth = 8;
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colName
            // 
            colName.DataPropertyName = "Name";
            colName.HeaderText = "Name";
            colName.MinimumWidth = 8;
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colPhone
            // 
            colPhone.DataPropertyName = "Phone";
            colPhone.HeaderText = "Phone";
            colPhone.MinimumWidth = 8;
            colPhone.Name = "colPhone";
            colPhone.ReadOnly = true;
            // 
            // colEmail
            // 
            colEmail.DataPropertyName = "Email";
            colEmail.HeaderText = "Email";
            colEmail.MinimumWidth = 8;
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            // 
            // ColAddress
            // 
            ColAddress.DataPropertyName = "Address";
            ColAddress.HeaderText = "Address";
            ColAddress.MinimumWidth = 8;
            ColAddress.Name = "ColAddress";
            ColAddress.ReadOnly = true;
            // 
            // toolStrip2
            // 
            toolStrip2.ImageScalingSize = new Size(24, 24);
            toolStrip2.Items.AddRange(new ToolStripItem[] { tspAdd, tspEdit, tspView, tspDelete, toolStripSeparator2, tspRefresh });
            toolStrip2.Location = new Point(0, 3);
            toolStrip2.Margin = new Padding(0, 3, 0, 0);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(886, 34);
            toolStrip2.TabIndex = 2;
            toolStrip2.Text = "toolStrip2";
            // 
            // tspAdd
            // 
            tspAdd.Image = (Image)resources.GetObject("tspAdd.Image");
            tspAdd.ImageTransparentColor = Color.Magenta;
            tspAdd.Name = "tspAdd";
            tspAdd.Size = new Size(74, 29);
            tspAdd.Text = "Add";
            tspAdd.Click += tspAdd_Click;
            // 
            // tspEdit
            // 
            tspEdit.Image = (Image)resources.GetObject("tspEdit.Image");
            tspEdit.ImageTransparentColor = Color.Magenta;
            tspEdit.Name = "tspEdit";
            tspEdit.Size = new Size(70, 29);
            tspEdit.Text = "Edit";
            tspEdit.Click += tspEdit_Click;
            // 
            // tspView
            // 
            tspView.Image = (Image)resources.GetObject("tspView.Image");
            tspView.ImageTransparentColor = Color.Magenta;
            tspView.Name = "tspView";
            tspView.Size = new Size(77, 29);
            tspView.Text = "View";
            tspView.Click += tspView_Click;
            // 
            // tspDelete
            // 
            tspDelete.Image = (Image)resources.GetObject("tspDelete.Image");
            tspDelete.ImageTransparentColor = Color.Magenta;
            tspDelete.Name = "tspDelete";
            tspDelete.Size = new Size(90, 29);
            tspDelete.Text = "Delete";
            tspDelete.Click += tspDelete_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 34);
            // 
            // tspRefresh
            // 
            tspRefresh.Image = (Image)resources.GetObject("tspRefresh.Image");
            tspRefresh.ImageTransparentColor = Color.Magenta;
            tspRefresh.Name = "tspRefresh";
            tspRefresh.Size = new Size(98, 29);
            tspRefresh.Text = "Refresh";
            tspRefresh.Click += tspRefresh_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripLabel1, toolStripButton2, toolStripLabel2, toolStripButton3, toolStripLabel3, toolStripButton4, toolStripSeparator1, toolStripLabel4, toolStripButton5, toolStripLabel5 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 33);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // CustomerView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "CustomerView";
            Size = new Size(886, 394);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolStrip miniToolStrip;
        private ToolStripButton toolStripButton1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripButton toolStripButton2;
        private ToolStripLabel toolStripLabel2;
        private ToolStripButton toolStripButton3;
        private ToolStripLabel toolStripLabel3;
        private ToolStripButton toolStripButton4;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripLabel4;
        private ToolStripButton toolStripButton5;
        private ToolStripLabel toolStripLabel5;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label Serachlb;
        private TextBox txtSearch;
        private Label lblCount;
        private ToolStrip toolStrip1;
        private DataGridView dgvCustomer;
        private ToolStrip toolStrip2;
        private ToolStripButton tspAdd;
        private ToolStripButton tspEdit;
        private ToolStripButton tspView;
        private ToolStripButton tspDelete;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton tspRefresh;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn ColAddress;
    }
}