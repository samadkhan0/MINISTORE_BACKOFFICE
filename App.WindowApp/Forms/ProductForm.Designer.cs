namespace App.WindowApp.Forms
{
    partial class ProductForm
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
            pnlCountaner = new Panel();
            pnltoolstrip = new Panel();
            flpfooter = new FlowLayoutPanel();
            btnsave = new Button();
            btncancel = new Button();
            pnlform = new Panel();
            tblform = new TableLayoutPanel();
            lblname = new Label();
            lblcategory = new Label();
            lblprice = new Label();
            lblstock = new Label();
            lblstatus = new Label();
            lblid = new Label();
            txtname = new TextBox();
            cmbcategory = new ComboBox();
            numprice = new NumericUpDown();
            numstock = new NumericUpDown();
            cmbstatus = new ComboBox();
            txtid = new TextBox();
            label1 = new Label();
            pnlCountaner.SuspendLayout();
            pnltoolstrip.SuspendLayout();
            flpfooter.SuspendLayout();
            pnlform.SuspendLayout();
            tblform.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numprice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numstock).BeginInit();
            SuspendLayout();
            // 
            // pnlCountaner
            // 
            pnlCountaner.Controls.Add(pnltoolstrip);
            pnlCountaner.Controls.Add(pnlform);
            pnlCountaner.Dock = DockStyle.Fill;
            pnlCountaner.Location = new Point(0, 0);
            pnlCountaner.Margin = new Padding(2);
            pnlCountaner.Name = "pnlCountaner";
            pnlCountaner.Size = new Size(640, 360);
            pnlCountaner.TabIndex = 0;
            // 
            // pnltoolstrip
            // 
            pnltoolstrip.Controls.Add(flpfooter);
            pnltoolstrip.Dock = DockStyle.Bottom;
            pnltoolstrip.Location = new Point(0, 282);
            pnltoolstrip.Margin = new Padding(2);
            pnltoolstrip.Name = "pnltoolstrip";
            pnltoolstrip.Size = new Size(640, 78);
            pnltoolstrip.TabIndex = 1;
            // 
            // flpfooter
            // 
            flpfooter.Anchor = AnchorStyles.Bottom;
            flpfooter.AutoScroll = true;
            flpfooter.AutoSize = true;
            flpfooter.Controls.Add(btnsave);
            flpfooter.Controls.Add(btncancel);
            flpfooter.Location = new Point(0, 31);
            flpfooter.Margin = new Padding(2, 80, 2, 2);
            flpfooter.Name = "flpfooter";
            flpfooter.RightToLeft = RightToLeft.Yes;
            flpfooter.Size = new Size(630, 46);
            flpfooter.TabIndex = 0;
            flpfooter.Paint += flowLayoutPanel1_Paint;
            // 
            // btnsave
            // 
            btnsave.Anchor = AnchorStyles.Right;
            btnsave.Location = new Point(538, 2);
            btnsave.Margin = new Padding(2);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(90, 27);
            btnsave.TabIndex = 1;
            btnsave.Text = "save";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;
            // 
            // btncancel
            // 
            btncancel.Anchor = AnchorStyles.Right;
            btncancel.Location = new Point(444, 2);
            btncancel.Margin = new Padding(2);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(90, 27);
            btncancel.TabIndex = 0;
            btncancel.Text = "cancel";
            btncancel.UseVisualStyleBackColor = true;
            btncancel.Click += btncancel_Click_1;
            // 
            // pnlform
            // 
            pnlform.Controls.Add(tblform);
            pnlform.Controls.Add(label1);
            pnlform.Dock = DockStyle.Top;
            pnlform.Location = new Point(0, 0);
            pnlform.Margin = new Padding(2);
            pnlform.Name = "pnlform";
            pnlform.Size = new Size(640, 248);
            pnlform.TabIndex = 0;
            pnlform.Paint += panel2_Paint;
            // 
            // tblform
            // 
            tblform.ColumnCount = 2;
            tblform.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.3907547F));
            tblform.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 83.6092453F));
            tblform.Controls.Add(lblname, 0, 0);
            tblform.Controls.Add(lblcategory, 0, 1);
            tblform.Controls.Add(lblprice, 0, 2);
            tblform.Controls.Add(lblstock, 0, 3);
            tblform.Controls.Add(lblstatus, 0, 4);
            tblform.Controls.Add(lblid, 0, 5);
            tblform.Controls.Add(txtname, 1, 0);
            tblform.Controls.Add(cmbcategory, 1, 1);
            tblform.Controls.Add(numprice, 1, 2);
            tblform.Controls.Add(numstock, 1, 3);
            tblform.Controls.Add(cmbstatus, 1, 4);
            tblform.Controls.Add(txtid, 1, 5);
            tblform.Dock = DockStyle.Fill;
            tblform.Location = new Point(0, 0);
            tblform.Margin = new Padding(2);
            tblform.Name = "tblform";
            tblform.RowCount = 6;
            tblform.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tblform.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblform.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblform.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblform.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblform.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblform.Size = new Size(640, 248);
            tblform.TabIndex = 1;
            tblform.Paint += tblform_Paint;
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Dock = DockStyle.Fill;
            lblname.Location = new Point(2, 0);
            lblname.Margin = new Padding(2, 0, 2, 0);
            lblname.Name = "lblname";
            lblname.Padding = new Padding(8);
            lblname.Size = new Size(100, 41);
            lblname.TabIndex = 0;
            lblname.Text = "Name";
            // 
            // lblcategory
            // 
            lblcategory.AutoSize = true;
            lblcategory.Dock = DockStyle.Top;
            lblcategory.Location = new Point(2, 41);
            lblcategory.Margin = new Padding(2, 0, 2, 0);
            lblcategory.Name = "lblcategory";
            lblcategory.Padding = new Padding(8);
            lblcategory.Size = new Size(100, 36);
            lblcategory.TabIndex = 7;
            lblcategory.Text = "Category";
            // 
            // lblprice
            // 
            lblprice.AutoSize = true;
            lblprice.Dock = DockStyle.Top;
            lblprice.Location = new Point(2, 82);
            lblprice.Margin = new Padding(2, 0, 2, 0);
            lblprice.Name = "lblprice";
            lblprice.Padding = new Padding(8);
            lblprice.Size = new Size(100, 36);
            lblprice.TabIndex = 8;
            lblprice.Text = "Price";
            // 
            // lblstock
            // 
            lblstock.AutoSize = true;
            lblstock.Dock = DockStyle.Top;
            lblstock.Location = new Point(2, 123);
            lblstock.Margin = new Padding(2, 0, 2, 0);
            lblstock.Name = "lblstock";
            lblstock.Padding = new Padding(8);
            lblstock.Size = new Size(100, 36);
            lblstock.TabIndex = 9;
            lblstock.Text = "Stock";
            // 
            // lblstatus
            // 
            lblstatus.AutoSize = true;
            lblstatus.Dock = DockStyle.Top;
            lblstatus.Location = new Point(2, 164);
            lblstatus.Margin = new Padding(2, 0, 2, 0);
            lblstatus.Name = "lblstatus";
            lblstatus.Padding = new Padding(8);
            lblstatus.Size = new Size(100, 36);
            lblstatus.TabIndex = 10;
            lblstatus.Text = "Status";
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Dock = DockStyle.Top;
            lblid.Location = new Point(2, 205);
            lblid.Margin = new Padding(2, 0, 2, 0);
            lblid.Name = "lblid";
            lblid.Padding = new Padding(8);
            lblid.Size = new Size(100, 36);
            lblid.TabIndex = 11;
            lblid.Text = "ID";
            // 
            // txtname
            // 
            txtname.Dock = DockStyle.Fill;
            txtname.Location = new Point(106, 2);
            txtname.Margin = new Padding(2);
            txtname.Name = "txtname";
            txtname.Size = new Size(532, 27);
            txtname.TabIndex = 0;
            // 
            // cmbcategory
            // 
            cmbcategory.Dock = DockStyle.Fill;
            cmbcategory.FormattingEnabled = true;
            cmbcategory.Location = new Point(106, 43);
            cmbcategory.Margin = new Padding(2);
            cmbcategory.Name = "cmbcategory";
            cmbcategory.Size = new Size(532, 28);
            cmbcategory.TabIndex = 1;
            // 
            // numprice
            // 
            numprice.Dock = DockStyle.Fill;
            numprice.Location = new Point(106, 84);
            numprice.Margin = new Padding(2);
            numprice.Name = "numprice";
            numprice.Size = new Size(532, 27);
            numprice.TabIndex = 5;
            // 
            // numstock
            // 
            numstock.Dock = DockStyle.Fill;
            numstock.Location = new Point(106, 125);
            numstock.Margin = new Padding(2);
            numstock.Name = "numstock";
            numstock.Size = new Size(532, 27);
            numstock.TabIndex = 3;
            // 
            // cmbstatus
            // 
            cmbstatus.Dock = DockStyle.Fill;
            cmbstatus.FormattingEnabled = true;
            cmbstatus.Location = new Point(106, 166);
            cmbstatus.Margin = new Padding(2);
            cmbstatus.Name = "cmbstatus";
            cmbstatus.Size = new Size(532, 28);
            cmbstatus.TabIndex = 4;
            // 
            // txtid
            // 
            txtid.Dock = DockStyle.Fill;
            txtid.Location = new Point(106, 207);
            txtid.Margin = new Padding(2);
            txtid.Name = "txtid";
            txtid.ReadOnly = true;
            txtid.Size = new Size(532, 27);
            txtid.TabIndex = 5;
            txtid.TextChanged += txtid_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 8);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(pnlCountaner);
            Margin = new Padding(2);
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterParent;
            Load += ProductForm_Load;
            pnlCountaner.ResumeLayout(false);
            pnltoolstrip.ResumeLayout(false);
            pnltoolstrip.PerformLayout();
            flpfooter.ResumeLayout(false);
            pnlform.ResumeLayout(false);
            pnlform.PerformLayout();
            tblform.ResumeLayout(false);
            tblform.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numprice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numstock).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCountaner;
        private Panel pnlform;
        private Label label1;
        private TableLayoutPanel tblform;
        private Label lblname;
        private Label lblcategory;
        private Label lblprice;
        private Label lblstock;
        private Label lblstatus;
        private Label lblid;
        private TextBox txtname;
        private Panel pnltoolstrip;
        private ComboBox cmbcategory;
        private NumericUpDown numprice;
        private NumericUpDown numstock;
        private ComboBox cmbstatus;
        private TextBox txtid;
        private Button btncancel;
        private Button btnsave;
        private FlowLayoutPanel flpfooter;
    }
}