namespace App_UI.Forms
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tblMainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTopMenu = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblOrderCount = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.rdbOrder = new System.Windows.Forms.RadioButton();
            this.rdbDelivery = new System.Windows.Forms.RadioButton();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.ovalShape1 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.pnlPay = new System.Windows.Forms.Panel();
            this.btnPay = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.ovalShape2 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.rectangleShape4 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.pnlBase = new System.Windows.Forms.Panel();
            this.txtSearch = new CustomServerControls.TxtBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.flyLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.shapeContainer3 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.tblCart = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlCart = new System.Windows.Forms.Panel();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.lblCartTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.shapeContainer4 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rdbProducts = new System.Windows.Forms.RadioButton();
            this.uc_CategoryMenu1 = new App_UI.UserControls.uc_CategoryMenu();
            this.tblMainLayout.SuspendLayout();
            this.pnlTopMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlPay.SuspendLayout();
            this.pnlBase.SuspendLayout();
            this.tblCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlCart.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMainLayout
            // 
            this.tblMainLayout.BackColor = System.Drawing.Color.White;
            this.tblMainLayout.ColumnCount = 4;
            this.tblMainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 290F));
            this.tblMainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMainLayout.Controls.Add(this.pnlTopMenu, 1, 0);
            this.tblMainLayout.Controls.Add(this.pnlPay, 2, 2);
            this.tblMainLayout.Controls.Add(this.uc_CategoryMenu1, 1, 2);
            this.tblMainLayout.Controls.Add(this.pnlBase, 1, 1);
            this.tblMainLayout.Controls.Add(this.tblCart, 2, 1);
            this.tblMainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMainLayout.Location = new System.Drawing.Point(0, 0);
            this.tblMainLayout.Margin = new System.Windows.Forms.Padding(0);
            this.tblMainLayout.Name = "tblMainLayout";
            this.tblMainLayout.RowCount = 3;
            this.tblMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tblMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tblMainLayout.Size = new System.Drawing.Size(895, 477);
            this.tblMainLayout.TabIndex = 2;
            // 
            // pnlTopMenu
            // 
            this.pnlTopMenu.BackColor = System.Drawing.Color.Black;
            this.tblMainLayout.SetColumnSpan(this.pnlTopMenu, 3);
            this.pnlTopMenu.Controls.Add(this.rdbProducts);
            this.pnlTopMenu.Controls.Add(this.btnExit);
            this.pnlTopMenu.Controls.Add(this.lblOrderCount);
            this.pnlTopMenu.Controls.Add(this.pictureBox1);
            this.pnlTopMenu.Controls.Add(this.pbLogo);
            this.pnlTopMenu.Controls.Add(this.rdbOrder);
            this.pnlTopMenu.Controls.Add(this.rdbDelivery);
            this.pnlTopMenu.Controls.Add(this.shapeContainer2);
            this.pnlTopMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTopMenu.Location = new System.Drawing.Point(20, 0);
            this.pnlTopMenu.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTopMenu.Name = "pnlTopMenu";
            this.pnlTopMenu.Size = new System.Drawing.Size(875, 59);
            this.pnlTopMenu.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnExit.Location = new System.Drawing.Point(797, 11);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(70, 38);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblOrderCount
            // 
            this.lblOrderCount.AutoSize = true;
            this.lblOrderCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblOrderCount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblOrderCount.ForeColor = System.Drawing.Color.White;
            this.lblOrderCount.Location = new System.Drawing.Point(344, 16);
            this.lblOrderCount.Name = "lblOrderCount";
            this.lblOrderCount.Size = new System.Drawing.Size(19, 21);
            this.lblOrderCount.TabIndex = 5;
            this.lblOrderCount.Text = "0";
            this.lblOrderCount.Click += new System.EventHandler(this.lblOrderCount_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::App_UI.Properties.Resources.downlogo;
            this.pictureBox1.Location = new System.Drawing.Point(149, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::App_UI.Properties.Resources.logoblack;
            this.pbLogo.Location = new System.Drawing.Point(7, 13);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(131, 33);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbLogo.TabIndex = 2;
            this.pbLogo.TabStop = false;
            // 
            // rdbOrder
            // 
            this.rdbOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbOrder.ForeColor = System.Drawing.Color.White;
            this.rdbOrder.Location = new System.Drawing.Point(588, 19);
            this.rdbOrder.Name = "rdbOrder";
            this.rdbOrder.Size = new System.Drawing.Size(102, 25);
            this.rdbOrder.TabIndex = 1;
            this.rdbOrder.Text = "ORDER-IN";
            this.rdbOrder.UseVisualStyleBackColor = true;
            this.rdbOrder.CheckedChanged += new System.EventHandler(this.rdbOrder_CheckedChanged);
            // 
            // rdbDelivery
            // 
            this.rdbDelivery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbDelivery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbDelivery.ForeColor = System.Drawing.Color.White;
            this.rdbDelivery.Location = new System.Drawing.Point(692, 19);
            this.rdbDelivery.Name = "rdbDelivery";
            this.rdbDelivery.Size = new System.Drawing.Size(97, 25);
            this.rdbDelivery.TabIndex = 0;
            this.rdbDelivery.Text = "DELIVERY";
            this.rdbDelivery.UseVisualStyleBackColor = true;
            this.rdbDelivery.CheckedChanged += new System.EventHandler(this.rdbDelivery_CheckedChanged);
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1,
            this.ovalShape1});
            this.shapeContainer2.Size = new System.Drawing.Size(875, 59);
            this.shapeContainer2.TabIndex = 4;
            this.shapeContainer2.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rectangleShape1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.rectangleShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.rectangleShape1.BorderWidth = 2;
            this.rectangleShape1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rectangleShape1.FillColor = System.Drawing.Color.Black;
            this.rectangleShape1.FillGradientColor = System.Drawing.Color.Black;
            this.rectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleShape1.Location = new System.Drawing.Point(795, 8);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(75, 44);
            // 
            // ovalShape1
            // 
            this.ovalShape1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ovalShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ovalShape1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ovalShape1.Location = new System.Drawing.Point(333, 11);
            this.ovalShape1.Name = "ovalShape1";
            this.ovalShape1.Size = new System.Drawing.Size(38, 33);
            this.ovalShape1.Click += new System.EventHandler(this.lblOrderCount_Click);
            // 
            // pnlPay
            // 
            this.pnlPay.Controls.Add(this.btnPay);
            this.pnlPay.Controls.Add(this.shapeContainer1);
            this.pnlPay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPay.Location = new System.Drawing.Point(585, 373);
            this.pnlPay.Margin = new System.Windows.Forms.Padding(0);
            this.pnlPay.Name = "pnlPay";
            this.pnlPay.Size = new System.Drawing.Size(290, 104);
            this.pnlPay.TabIndex = 2;
            // 
            // btnPay
            // 
            this.btnPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPay.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnPay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnPay.Location = new System.Drawing.Point(99, 29);
            this.btnPay.Margin = new System.Windows.Forms.Padding(0);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(186, 52);
            this.btnPay.TabIndex = 1;
            this.btnPay.Text = "PAY";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape3,
            this.ovalShape2,
            this.rectangleShape4});
            this.shapeContainer1.Size = new System.Drawing.Size(290, 104);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lineShape3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lineShape3.BorderWidth = 2;
            this.lineShape3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 23;
            this.lineShape3.X2 = 68;
            this.lineShape3.Y1 = 36;
            this.lineShape3.Y2 = 77;
            this.lineShape3.Click += new System.EventHandler(this.ovalShape2_Click);
            // 
            // ovalShape2
            // 
            this.ovalShape2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ovalShape2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.ovalShape2.BorderWidth = 2;
            this.ovalShape2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ovalShape2.Location = new System.Drawing.Point(8, 27);
            this.ovalShape2.Name = "ovalShape2";
            this.ovalShape2.Size = new System.Drawing.Size(75, 56);
            this.ovalShape2.Click += new System.EventHandler(this.ovalShape2_Click);
            // 
            // rectangleShape4
            // 
            this.rectangleShape4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rectangleShape4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.rectangleShape4.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.rectangleShape4.BorderWidth = 2;
            this.rectangleShape4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rectangleShape4.FillColor = System.Drawing.Color.White;
            this.rectangleShape4.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleShape4.Location = new System.Drawing.Point(96, 25);
            this.rectangleShape4.Name = "rectangleShape4";
            this.rectangleShape4.Size = new System.Drawing.Size(191, 59);
            // 
            // pnlBase
            // 
            this.pnlBase.Controls.Add(this.txtSearch);
            this.pnlBase.Controls.Add(this.btnSearch);
            this.pnlBase.Controls.Add(this.flyLayout);
            this.pnlBase.Controls.Add(this.shapeContainer3);
            this.pnlBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBase.Location = new System.Drawing.Point(20, 59);
            this.pnlBase.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBase.Name = "pnlBase";
            this.pnlBase.Size = new System.Drawing.Size(565, 314);
            this.pnlBase.TabIndex = 5;
            // 
            // txtSearch
            // 
            this.txtSearch.AcceptsReturn = true;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI Semilight", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.Location = new System.Drawing.Point(11, 14);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Search Item";
            this.txtSearch.Size = new System.Drawing.Size(280, 24);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.Tag = "";
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = global::App_UI.Properties.Resources.search_24;
            this.btnSearch.Location = new System.Drawing.Point(299, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(35, 33);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // flyLayout
            // 
            this.flyLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flyLayout.Location = new System.Drawing.Point(3, 53);
            this.flyLayout.Name = "flyLayout";
            this.flyLayout.Size = new System.Drawing.Size(559, 258);
            this.flyLayout.TabIndex = 4;
            // 
            // shapeContainer3
            // 
            this.shapeContainer3.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer3.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer3.Name = "shapeContainer3";
            this.shapeContainer3.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape2});
            this.shapeContainer3.Size = new System.Drawing.Size(565, 314);
            this.shapeContainer3.TabIndex = 6;
            this.shapeContainer3.TabStop = false;
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.rectangleShape2.FillColor = System.Drawing.Color.White;
            this.rectangleShape2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleShape2.Location = new System.Drawing.Point(3, 10);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(293, 34);
            // 
            // tblCart
            // 
            this.tblCart.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblCart.ColumnCount = 1;
            this.tblCart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblCart.Controls.Add(this.dataGridView1, 0, 0);
            this.tblCart.Controls.Add(this.pnlCart, 0, 1);
            this.tblCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblCart.Location = new System.Drawing.Point(585, 59);
            this.tblCart.Margin = new System.Windows.Forms.Padding(0);
            this.tblCart.Name = "tblCart";
            this.tblCart.RowCount = 2;
            this.tblCart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblCart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tblCart.Size = new System.Drawing.Size(290, 314);
            this.tblCart.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(1, 1);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 10;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5, 2, 5, 5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.DividerHeight = 1;
            this.dataGridView1.RowTemplate.Height = 50;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(288, 181);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ProductID";
            this.Column1.HeaderText = "ProductID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ProductName";
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 2, 5, 5);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column2.FillWeight = 150F;
            this.Column2.HeaderText = "Items";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column3.DataPropertyName = "Quantity";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 2, 5, 5);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column3.FillWeight = 50F;
            this.Column3.HeaderText = "Qty";
            this.Column3.MinimumWidth = 50;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.Width = 61;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Price";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 2, 5, 5);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column4.HeaderText = "Price";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // pnlCart
            // 
            this.pnlCart.Controls.Add(this.lblGrandTotal);
            this.pnlCart.Controls.Add(this.lblCartTotal);
            this.pnlCart.Controls.Add(this.lblTax);
            this.pnlCart.Controls.Add(this.label3);
            this.pnlCart.Controls.Add(this.label2);
            this.pnlCart.Controls.Add(this.label1);
            this.pnlCart.Controls.Add(this.shapeContainer4);
            this.pnlCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCart.Location = new System.Drawing.Point(1, 183);
            this.pnlCart.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCart.Name = "pnlCart";
            this.pnlCart.Size = new System.Drawing.Size(288, 130);
            this.pnlCart.TabIndex = 8;
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblGrandTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGrandTotal.Location = new System.Drawing.Point(198, 84);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(69, 37);
            this.lblGrandTotal.TabIndex = 6;
            this.lblGrandTotal.Text = "0.00";
            this.lblGrandTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCartTotal
            // 
            this.lblCartTotal.AutoSize = true;
            this.lblCartTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblCartTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartTotal.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblCartTotal.Location = new System.Drawing.Point(226, 42);
            this.lblCartTotal.Name = "lblCartTotal";
            this.lblCartTotal.Size = new System.Drawing.Size(41, 21);
            this.lblCartTotal.TabIndex = 5;
            this.lblCartTotal.Text = "0.00";
            this.lblCartTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.BackColor = System.Drawing.Color.Transparent;
            this.lblTax.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblTax.Location = new System.Drawing.Point(226, 6);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(41, 21);
            this.lblTax.TabIndex = 4;
            this.lblTax.Text = "0.00";
            this.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(14, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "TOTAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(14, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "TOTAL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(14, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "TAX";
            // 
            // shapeContainer4
            // 
            this.shapeContainer4.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer4.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer4.Name = "shapeContainer4";
            this.shapeContainer4.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer4.Size = new System.Drawing.Size(288, 130);
            this.shapeContainer4.TabIndex = 0;
            this.shapeContainer4.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.lineShape2.BorderWidth = 2;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = -1;
            this.lineShape2.X2 = 289;
            this.lineShape2.Y1 = 71;
            this.lineShape2.Y2 = 71;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.lineShape1.BorderWidth = 2;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 0;
            this.lineShape1.X2 = 290;
            this.lineShape1.Y1 = 34;
            this.lineShape1.Y2 = 34;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem,
            this.toolStripSeparator1,
            this.clearAllToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(136, 62);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(132, 6);
            // 
            // clearAllToolStripMenuItem
            // 
            this.clearAllToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.clearAllToolStripMenuItem.Text = "Clear All";
            this.clearAllToolStripMenuItem.Click += new System.EventHandler(this.clearAllToolStripMenuItem_Click);
            // 
            // rdbProducts
            // 
            this.rdbProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbProducts.Checked = true;
            this.rdbProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbProducts.ForeColor = System.Drawing.Color.White;
            this.rdbProducts.Location = new System.Drawing.Point(518, 18);
            this.rdbProducts.Name = "rdbProducts";
            this.rdbProducts.Size = new System.Drawing.Size(61, 25);
            this.rdbProducts.TabIndex = 7;
            this.rdbProducts.TabStop = true;
            this.rdbProducts.Text = "ALL";
            this.rdbProducts.UseVisualStyleBackColor = true;
            this.rdbProducts.CheckedChanged += new System.EventHandler(this.rdbProducts_CheckedChanged);
            // 
            // uc_CategoryMenu1
            // 
            this.uc_CategoryMenu1.AutoScroll = true;
            this.uc_CategoryMenu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_CategoryMenu1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_CategoryMenu1.Location = new System.Drawing.Point(24, 378);
            this.uc_CategoryMenu1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uc_CategoryMenu1.Name = "uc_CategoryMenu1";
            this.uc_CategoryMenu1.Size = new System.Drawing.Size(557, 94);
            this.uc_CategoryMenu1.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 477);
            this.Controls.Add(this.tblMainLayout);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tblMainLayout.ResumeLayout(false);
            this.pnlTopMenu.ResumeLayout(false);
            this.pnlTopMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlPay.ResumeLayout(false);
            this.pnlBase.ResumeLayout(false);
            this.pnlBase.PerformLayout();
            this.tblCart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlCart.ResumeLayout(false);
            this.pnlCart.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tblMainLayout;
        private System.Windows.Forms.Panel pnlPay;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape4;
        private System.Windows.Forms.Button btnPay;
        private UserControls.uc_CategoryMenu uc_CategoryMenu1;
        private System.Windows.Forms.Panel pnlTopMenu;
        private System.Windows.Forms.Label lblOrderCount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.RadioButton rdbOrder;
        private System.Windows.Forms.RadioButton rdbDelivery;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape1;
        private System.Windows.Forms.Button btnExit;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.FlowLayoutPanel flyLayout;
        private System.Windows.Forms.Panel pnlBase;
        private System.Windows.Forms.Button btnSearch;
        private CustomServerControls.TxtBox txtSearch;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer3;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TableLayoutPanel tblCart;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Panel pnlCart;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblCartTotal;
        private System.Windows.Forms.Label lblGrandTotal;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private System.Windows.Forms.RadioButton rdbProducts;
    }
}