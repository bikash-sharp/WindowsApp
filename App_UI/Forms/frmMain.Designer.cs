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
            this.rectangleShape4 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.uc_CategoryMenu1 = new App_UI.UserControls.uc_CategoryMenu();
            this.pnlBase = new System.Windows.Forms.Panel();
            this.txtSearch = new CustomServerControls.TxtBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.flyLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.shapeContainer3 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.lstCart = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tblMainLayout.SuspendLayout();
            this.pnlTopMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlPay.SuspendLayout();
            this.pnlBase.SuspendLayout();
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
            this.tblMainLayout.Controls.Add(this.pnlTopMenu, 0, 0);
            this.tblMainLayout.Controls.Add(this.pnlPay, 2, 2);
            this.tblMainLayout.Controls.Add(this.uc_CategoryMenu1, 1, 2);
            this.tblMainLayout.Controls.Add(this.pnlBase, 1, 1);
            this.tblMainLayout.Controls.Add(this.lstCart, 2, 1);
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
            this.tblMainLayout.SetColumnSpan(this.pnlTopMenu, 4);
            this.pnlTopMenu.Controls.Add(this.btnExit);
            this.pnlTopMenu.Controls.Add(this.lblOrderCount);
            this.pnlTopMenu.Controls.Add(this.pictureBox1);
            this.pnlTopMenu.Controls.Add(this.pbLogo);
            this.pnlTopMenu.Controls.Add(this.rdbOrder);
            this.pnlTopMenu.Controls.Add(this.rdbDelivery);
            this.pnlTopMenu.Controls.Add(this.shapeContainer2);
            this.pnlTopMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTopMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlTopMenu.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTopMenu.Name = "pnlTopMenu";
            this.pnlTopMenu.Size = new System.Drawing.Size(895, 59);
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
            this.btnExit.Location = new System.Drawing.Point(817, 11);
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
            this.rdbOrder.Location = new System.Drawing.Point(608, 19);
            this.rdbOrder.Name = "rdbOrder";
            this.rdbOrder.Size = new System.Drawing.Size(102, 25);
            this.rdbOrder.TabIndex = 1;
            this.rdbOrder.TabStop = true;
            this.rdbOrder.Text = "ORDER-IN";
            this.rdbOrder.UseVisualStyleBackColor = true;
            // 
            // rdbDelivery
            // 
            this.rdbDelivery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbDelivery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbDelivery.ForeColor = System.Drawing.Color.White;
            this.rdbDelivery.Location = new System.Drawing.Point(712, 19);
            this.rdbDelivery.Name = "rdbDelivery";
            this.rdbDelivery.Size = new System.Drawing.Size(97, 25);
            this.rdbDelivery.TabIndex = 0;
            this.rdbDelivery.Text = "DELIVERY";
            this.rdbDelivery.UseVisualStyleBackColor = true;
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1,
            this.ovalShape1});
            this.shapeContainer2.Size = new System.Drawing.Size(895, 59);
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
            this.rectangleShape1.Location = new System.Drawing.Point(815, 8);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(75, 44);
            // 
            // ovalShape1
            // 
            this.ovalShape1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ovalShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ovalShape1.Location = new System.Drawing.Point(333, 11);
            this.ovalShape1.Name = "ovalShape1";
            this.ovalShape1.Size = new System.Drawing.Size(38, 33);
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
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape4});
            this.shapeContainer1.Size = new System.Drawing.Size(290, 104);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
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
            // lstCart
            // 
            this.lstCart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstCart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstCart.FullRowSelect = true;
            this.lstCart.GridLines = true;
            this.lstCart.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstCart.Location = new System.Drawing.Point(585, 69);
            this.lstCart.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lstCart.Name = "lstCart";
            this.lstCart.Size = new System.Drawing.Size(290, 304);
            this.lstCart.TabIndex = 6;
            this.lstCart.UseCompatibleStateImageBehavior = false;
            this.lstCart.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Items";
            this.columnHeader1.Width = 180;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Qty";
            this.columnHeader2.Width = 40;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price";
            this.columnHeader3.Width = 100;
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
        private System.Windows.Forms.ListView lstCart;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private CustomServerControls.TxtBox txtSearch;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer3;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}