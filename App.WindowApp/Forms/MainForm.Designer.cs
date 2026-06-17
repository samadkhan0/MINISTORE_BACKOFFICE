namespace App.WindowApp.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            pnlheader = new Panel();
            flpright = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            labeladmin = new Label();
            flpleft = new FlowLayoutPanel();
            pictureBox2 = new PictureBox();
            pnlContainer = new Panel();
            statusStrip1 = new StatusStrip();
            pnlsidebar = new Panel();
            flpnav = new FlowLayoutPanel();
            btndashboard = new Button();
            btnproducts = new Button();
            btnCustomer = new Button();
            button1 = new Button();
            btnsetting = new Button();
            btnlogs = new Button();
            label2 = new Label();
            pnlheader.SuspendLayout();
            flpright.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flpleft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlsidebar.SuspendLayout();
            flpnav.SuspendLayout();
            SuspendLayout();
            // 
            // pnlheader
            // 
            pnlheader.BackColor = Color.WhiteSmoke;
            pnlheader.Controls.Add(flpright);
            pnlheader.Controls.Add(flpleft);
            pnlheader.Dock = DockStyle.Top;
            pnlheader.Location = new Point(0, 0);
            pnlheader.Margin = new Padding(3, 4, 3, 4);
            pnlheader.Name = "pnlheader";
            pnlheader.Size = new Size(1733, 105);
            pnlheader.TabIndex = 0;
            pnlheader.Paint += pnlheader_Paint;
            // 
            // flpright
            // 
            flpright.Controls.Add(pictureBox1);
            flpright.Controls.Add(labeladmin);
            flpright.Location = new Point(1511, 4);
            flpright.Margin = new Padding(3, 4, 3, 4);
            flpright.Name = "flpright";
            flpright.Size = new Size(222, 101);
            flpright.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 0);
            pictureBox1.Margin = new Padding(3, 0, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new Padding(0, 25, 0, 0);
            pictureBox1.Size = new Size(78, 101);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labeladmin
            // 
            labeladmin.AutoSize = true;
            labeladmin.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labeladmin.Location = new Point(87, 25);
            labeladmin.Margin = new Padding(3, 25, 3, 0);
            labeladmin.Name = "labeladmin";
            labeladmin.Size = new Size(59, 20);
            labeladmin.TabIndex = 1;
            labeladmin.Text = "Admin";
            labeladmin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flpleft
            // 
            flpleft.Controls.Add(pictureBox2);
            flpleft.Location = new Point(0, 0);
            flpleft.Margin = new Padding(3, 4, 3, 4);
            flpleft.Name = "flpleft";
            flpleft.Size = new Size(257, 105);
            flpleft.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 4);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Padding = new Padding(22, 25, 0, 0);
            pictureBox2.Size = new Size(253, 101);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pnlContainer
            // 
            pnlContainer.BackColor = Color.White;
            pnlContainer.Location = new Point(254, 106);
            pnlContainer.Margin = new Padding(3, 4, 3, 4);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(1479, 398);
            pnlContainer.TabIndex = 1;
            pnlContainer.Paint += panel4_Paint;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Location = new Point(0, 533);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(1733, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // pnlsidebar
            // 
            pnlsidebar.Controls.Add(flpnav);
            pnlsidebar.Dock = DockStyle.Left;
            pnlsidebar.Location = new Point(0, 105);
            pnlsidebar.Margin = new Padding(3, 4, 3, 4);
            pnlsidebar.Name = "pnlsidebar";
            pnlsidebar.Size = new Size(257, 428);
            pnlsidebar.TabIndex = 2;
            // 
            // flpnav
            // 
            flpnav.Controls.Add(btndashboard);
            flpnav.Controls.Add(btnproducts);
            flpnav.Controls.Add(btnCustomer);
            flpnav.Controls.Add(button1);
            flpnav.Controls.Add(btnsetting);
            flpnav.Controls.Add(btnlogs);
            flpnav.FlowDirection = FlowDirection.TopDown;
            flpnav.Location = new Point(0, 0);
            flpnav.Margin = new Padding(3, 4, 3, 4);
            flpnav.Name = "flpnav";
            flpnav.Padding = new Padding(22, 25, 0, 0);
            flpnav.Size = new Size(253, 395);
            flpnav.TabIndex = 0;
            // 
            // btndashboard
            // 
            btndashboard.FlatAppearance.BorderSize = 0;
            btndashboard.FlatStyle = FlatStyle.Flat;
            btndashboard.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btndashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btndashboard.Location = new Point(28, 31);
            btndashboard.Margin = new Padding(6);
            btndashboard.Name = "btndashboard";
            btndashboard.Size = new Size(183, 50);
            btndashboard.TabIndex = 0;
            btndashboard.Text = "  Dashboard";
            btndashboard.TextImageRelation = TextImageRelation.TextBeforeImage;
            btndashboard.UseCompatibleTextRendering = true;
            btndashboard.UseVisualStyleBackColor = true;
            btndashboard.Click += btndashboard_Click;
            // 
            // btnproducts
            // 
            btnproducts.FlatAppearance.BorderSize = 0;
            btnproducts.FlatStyle = FlatStyle.Flat;
            btnproducts.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnproducts.ImageAlign = ContentAlignment.MiddleLeft;
            btnproducts.Location = new Point(28, 93);
            btnproducts.Margin = new Padding(6);
            btnproducts.Name = "btnproducts";
            btnproducts.Size = new Size(174, 45);
            btnproducts.TabIndex = 1;
            btnproducts.Text = "Products";
            btnproducts.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnproducts.UseVisualStyleBackColor = true;
            btnproducts.Click += btnproducts_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.FlatAppearance.BorderSize = 0;
            btnCustomer.FlatStyle = FlatStyle.Flat;
            btnCustomer.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomer.Location = new Point(28, 150);
            btnCustomer.Margin = new Padding(6);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(183, 48);
            btnCustomer.TabIndex = 2;
            btnCustomer.Text = "Customer";
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += btnorders_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(28, 210);
            button1.Margin = new Padding(6);
            button1.Name = "button1";
            button1.Size = new Size(183, 48);
            button1.TabIndex = 5;
            button1.Text = "Orders";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnsetting
            // 
            btnsetting.FlatAppearance.BorderSize = 0;
            btnsetting.FlatStyle = FlatStyle.Flat;
            btnsetting.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnsetting.ImageAlign = ContentAlignment.MiddleLeft;
            btnsetting.ImageKey = "(none)";
            btnsetting.Location = new Point(28, 270);
            btnsetting.Margin = new Padding(6);
            btnsetting.Name = "btnsetting";
            btnsetting.Size = new Size(183, 48);
            btnsetting.TabIndex = 4;
            btnsetting.Text = "Setting";
            btnsetting.UseVisualStyleBackColor = true;
            // 
            // btnlogs
            // 
            btnlogs.FlatAppearance.BorderSize = 0;
            btnlogs.FlatStyle = FlatStyle.Flat;
            btnlogs.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnlogs.ImageAlign = ContentAlignment.MiddleLeft;
            btnlogs.Location = new Point(28, 330);
            btnlogs.Margin = new Padding(6);
            btnlogs.Name = "btnlogs";
            btnlogs.Size = new Size(174, 48);
            btnlogs.TabIndex = 3;
            btnlogs.Text = "Logs";
            btnlogs.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(171, 476);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 3;
            label2.Text = "Ready";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1733, 555);
            Controls.Add(label2);
            Controls.Add(pnlsidebar);
            Controls.Add(statusStrip1);
            Controls.Add(pnlContainer);
            Controls.Add(pnlheader);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            pnlheader.ResumeLayout(false);
            flpright.ResumeLayout(false);
            flpright.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flpleft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlsidebar.ResumeLayout(false);
            flpnav.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlheader;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Panel pnlsidebar;
        private System.Windows.Forms.FlowLayoutPanel flpright;
        private System.Windows.Forms.FlowLayoutPanel flpleft;
        private System.Windows.Forms.FlowLayoutPanel flpnav;
        private System.Windows.Forms.Button btndashboard;
        private System.Windows.Forms.Button btnproducts;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnlogs;
        private System.Windows.Forms.Button btnsetting;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labeladmin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label2;
        private Button button1;
    }
}