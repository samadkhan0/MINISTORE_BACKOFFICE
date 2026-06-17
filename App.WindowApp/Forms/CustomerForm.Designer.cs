namespace App.WindowApp.Forms
{
    partial class CustomerForm
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
            tblCustomeradd = new TableLayoutPanel();
            lbname = new Label();
            lbemail = new Label();
            lbaddress = new Label();
            lbphone = new Label();
            lbid = new Label();
            tbname = new TextBox();
            tbemail = new TextBox();
            tbphone = new TextBox();
            tbaddress = new TextBox();
            tbid = new TextBox();
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnSave = new Button();
            btncancel = new Button();
            tblCustomeradd.SuspendLayout();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tblCustomeradd
            // 
            tblCustomeradd.ColumnCount = 2;
            tblCustomeradd.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tblCustomeradd.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tblCustomeradd.Controls.Add(lbname, 0, 0);
            tblCustomeradd.Controls.Add(lbemail, 0, 1);
            tblCustomeradd.Controls.Add(lbaddress, 0, 3);
            tblCustomeradd.Controls.Add(lbphone, 0, 2);
            tblCustomeradd.Controls.Add(lbid, 0, 4);
            tblCustomeradd.Controls.Add(tbname, 1, 0);
            tblCustomeradd.Controls.Add(tbemail, 1, 1);
            tblCustomeradd.Controls.Add(tbphone, 1, 2);
            tblCustomeradd.Controls.Add(tbaddress, 1, 3);
            tblCustomeradd.Controls.Add(tbid, 1, 4);
            tblCustomeradd.Dock = DockStyle.Top;
            tblCustomeradd.Location = new Point(0, 0);
            tblCustomeradd.Name = "tblCustomeradd";
            tblCustomeradd.RowCount = 5;
            tblCustomeradd.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tblCustomeradd.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tblCustomeradd.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tblCustomeradd.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tblCustomeradd.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tblCustomeradd.Size = new Size(800, 184);
            tblCustomeradd.TabIndex = 0;
            tblCustomeradd.Paint += tblCustomeradd_Paint;
            // 
            // lbname
            // 
            lbname.AutoSize = true;
            lbname.Dock = DockStyle.Fill;
            lbname.Location = new Point(3, 0);
            lbname.Name = "lbname";
            lbname.Size = new Size(114, 35);
            lbname.TabIndex = 0;
            lbname.Text = "Name";
            lbname.Click += lbname_Click;
            // 
            // lbemail
            // 
            lbemail.AutoSize = true;
            lbemail.Dock = DockStyle.Fill;
            lbemail.Location = new Point(3, 35);
            lbemail.Name = "lbemail";
            lbemail.Size = new Size(114, 35);
            lbemail.TabIndex = 1;
            lbemail.Text = "Email";
            lbemail.Click += lbemail_Click;
            // 
            // lbaddress
            // 
            lbaddress.AutoSize = true;
            lbaddress.Dock = DockStyle.Fill;
            lbaddress.Location = new Point(3, 108);
            lbaddress.Name = "lbaddress";
            lbaddress.Size = new Size(114, 38);
            lbaddress.TabIndex = 2;
            lbaddress.Text = "Address";
            lbaddress.Click += lbaddress_Click;
            // 
            // lbphone
            // 
            lbphone.AutoSize = true;
            lbphone.Dock = DockStyle.Fill;
            lbphone.Location = new Point(3, 70);
            lbphone.Name = "lbphone";
            lbphone.Size = new Size(114, 38);
            lbphone.TabIndex = 3;
            lbphone.Text = "Phone";
            lbphone.Click += lbphone_Click;
            // 
            // lbid
            // 
            lbid.AutoSize = true;
            lbid.Dock = DockStyle.Fill;
            lbid.Location = new Point(3, 146);
            lbid.Name = "lbid";
            lbid.Size = new Size(114, 38);
            lbid.TabIndex = 4;
            lbid.Text = "Id";
            lbid.Click += lbid_Click;
            // 
            // tbname
            // 
            tbname.Dock = DockStyle.Fill;
            tbname.Location = new Point(123, 3);
            tbname.Name = "tbname";
            tbname.Size = new Size(674, 31);
            tbname.TabIndex = 5;
            // 
            // tbemail
            // 
            tbemail.Dock = DockStyle.Fill;
            tbemail.Location = new Point(123, 38);
            tbemail.Name = "tbemail";
            tbemail.Size = new Size(674, 31);
            tbemail.TabIndex = 6;
            // 
            // tbphone
            // 
            tbphone.Dock = DockStyle.Fill;
            tbphone.Location = new Point(123, 73);
            tbphone.Name = "tbphone";
            tbphone.Size = new Size(674, 31);
            tbphone.TabIndex = 7;
            // 
            // tbaddress
            // 
            tbaddress.Dock = DockStyle.Fill;
            tbaddress.Location = new Point(123, 111);
            tbaddress.Name = "tbaddress";
            tbaddress.Size = new Size(674, 31);
            tbaddress.TabIndex = 8;
            // 
            // tbid
            // 
            tbid.Dock = DockStyle.Fill;
            tbid.Location = new Point(123, 149);
            tbid.Name = "tbid";
            tbid.ReadOnly = true;
            tbid.Size = new Size(674, 31);
            tbid.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 397);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 53);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnSave);
            flowLayoutPanel1.Controls.Add(btncancel);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(800, 53);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(685, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 1;
            btnSave.Text = "save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btncancel
            // 
            btncancel.Location = new Point(567, 3);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(112, 34);
            btncancel.TabIndex = 0;
            btncancel.Text = "cancel";
            btncancel.UseVisualStyleBackColor = true;
            btncancel.Click += btncancel_Click;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(tblCustomeradd);
            Name = "CustomerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerForm";
            tblCustomeradd.ResumeLayout(false);
            tblCustomeradd.PerformLayout();
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblCustomeradd;
        private Label lbname;
        private Label lbemail;
        private Label lbaddress;
        private Label lbphone;
        private Label lbid;
        private TextBox tbname;
        private TextBox tbemail;
        private TextBox tbphone;
        private TextBox tbaddress;
        private TextBox tbid;
        private Panel panel1;
        private Button btnSave;
        private Button btncancel;




        private void lbid_Click(object sender, EventArgs e)
        {
            // TODO: handle click
        }

        private void lbaddress_Click(object sender, EventArgs e)
        {
            // TODO: handle click
        }

        private void lbemail_Click(object sender, EventArgs e)
        {
            // TODO: handle click
        }
      

        private void lbphone_Click(object sender, EventArgs e)
        {
            // TODO: handle click
        }

        private void lbname_Click(object sender, EventArgs e)
        {
            // TODO: handle click
        }
        private FlowLayoutPanel flowLayoutPanel1;
    }
}