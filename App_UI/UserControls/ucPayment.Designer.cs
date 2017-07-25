namespace App_UI.UserControls
{
    partial class ucPayment
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
            this.tblBase = new System.Windows.Forms.TableLayoutPanel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCash = new System.Windows.Forms.Button();
            this.btnCard = new System.Windows.Forms.Button();
            this.pnlBase = new System.Windows.Forms.Panel();
            this.pnlCash = new System.Windows.Forms.Panel();
            this.txtAmount = new CustomServerControls.TxtBox();
            this.btnExactAmount = new System.Windows.Forms.Button();
            this.lblRem = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.lblCardMsg = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rectangleShape3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer3 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape4 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.panel3 = new System.Windows.Forms.Panel();
            this.shapeContainer4 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.btnWallet = new System.Windows.Forms.Button();
            this.tblBase.SuspendLayout();
            this.pnlBase.SuspendLayout();
            this.pnlCash.SuspendLayout();
            this.pnlCard.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblBase
            // 
            this.tblBase.ColumnCount = 4;
            this.tblBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tblBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tblBase.Controls.Add(this.lblTotal, 0, 0);
            this.tblBase.Controls.Add(this.btnPay, 0, 4);
            this.tblBase.Controls.Add(this.btnCancel, 2, 4);
            this.tblBase.Controls.Add(this.pnlBase, 1, 1);
            this.tblBase.Controls.Add(this.panel1, 0, 1);
            this.tblBase.Controls.Add(this.panel2, 0, 2);
            this.tblBase.Controls.Add(this.panel3, 0, 3);
            this.tblBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblBase.Location = new System.Drawing.Point(0, 0);
            this.tblBase.Margin = new System.Windows.Forms.Padding(0);
            this.tblBase.Name = "tblBase";
            this.tblBase.RowCount = 5;
            this.tblBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tblBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tblBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tblBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tblBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblBase.Size = new System.Drawing.Size(504, 419);
            this.tblBase.TabIndex = 0;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Silver;
            this.tblBase.SetColumnSpan(this.lblTotal, 4);
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.Info;
            this.lblTotal.Location = new System.Drawing.Point(0, 0);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(504, 49);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.LimeGreen;
            this.tblBase.SetColumnSpan(this.btnPay, 2);
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(0, 347);
            this.btnPay.Margin = new System.Windows.Forms.Padding(0);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(252, 72);
            this.btnPay.TabIndex = 1;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.tblBase.SetColumnSpan(this.btnCancel, 2);
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(252, 347);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(252, 72);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCash
            // 
            this.btnCash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCash.FlatAppearance.BorderSize = 0;
            this.btnCash.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCash.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCash.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCash.Location = new System.Drawing.Point(7, 7);
            this.btnCash.Margin = new System.Windows.Forms.Padding(1);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(121, 36);
            this.btnCash.TabIndex = 3;
            this.btnCash.Text = "CASH";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // btnCard
            // 
            this.btnCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCard.FlatAppearance.BorderSize = 0;
            this.btnCard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCard.Location = new System.Drawing.Point(9, 8);
            this.btnCard.Margin = new System.Windows.Forms.Padding(1);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(119, 33);
            this.btnCard.TabIndex = 4;
            this.btnCard.Text = "CARD";
            this.btnCard.UseVisualStyleBackColor = true;
            this.btnCard.Click += new System.EventHandler(this.btnCard_Click);
            // 
            // pnlBase
            // 
            this.tblBase.SetColumnSpan(this.pnlBase, 3);
            this.pnlBase.Controls.Add(this.pnlCash);
            this.pnlBase.Controls.Add(this.pnlCard);
            this.pnlBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBase.Location = new System.Drawing.Point(136, 49);
            this.pnlBase.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBase.Name = "pnlBase";
            this.tblBase.SetRowSpan(this.pnlBase, 3);
            this.pnlBase.Size = new System.Drawing.Size(368, 298);
            this.pnlBase.TabIndex = 5;
            // 
            // pnlCash
            // 
            this.pnlCash.Controls.Add(this.txtAmount);
            this.pnlCash.Controls.Add(this.btnExactAmount);
            this.pnlCash.Controls.Add(this.lblRem);
            this.pnlCash.Controls.Add(this.shapeContainer1);
            this.pnlCash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCash.Location = new System.Drawing.Point(0, 0);
            this.pnlCash.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCash.Name = "pnlCash";
            this.pnlCash.Padding = new System.Windows.Forms.Padding(5);
            this.pnlCash.Size = new System.Drawing.Size(368, 298);
            this.pnlCash.TabIndex = 1;
            // 
            // txtAmount
            // 
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.ForeColor = System.Drawing.Color.Gray;
            this.txtAmount.Location = new System.Drawing.Point(18, 19);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PlaceholderText = "Enter Amount";
            this.txtAmount.Size = new System.Drawing.Size(339, 29);
            this.txtAmount.TabIndex = 5;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // btnExactAmount
            // 
            this.btnExactAmount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExactAmount.Location = new System.Drawing.Point(142, 87);
            this.btnExactAmount.Name = "btnExactAmount";
            this.btnExactAmount.Size = new System.Drawing.Size(163, 31);
            this.btnExactAmount.TabIndex = 3;
            this.btnExactAmount.Text = "Exact Amount";
            this.btnExactAmount.UseVisualStyleBackColor = true;
            this.btnExactAmount.Visible = false;
            this.btnExactAmount.Click += new System.EventHandler(this.btnExactAmount_Click);
            // 
            // lblRem
            // 
            this.lblRem.BackColor = System.Drawing.Color.Gainsboro;
            this.lblRem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblRem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRem.Location = new System.Drawing.Point(5, 252);
            this.lblRem.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.lblRem.Name = "lblRem";
            this.lblRem.Size = new System.Drawing.Size(358, 41);
            this.lblRem.TabIndex = 1;
            this.lblRem.Text = "Balance : 0.00";
            this.lblRem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(5, 5);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape2});
            this.shapeContainer1.Size = new System.Drawing.Size(358, 288);
            this.shapeContainer1.TabIndex = 6;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.rectangleShape2.BorderWidth = 2;
            this.rectangleShape2.FillColor = System.Drawing.Color.White;
            this.rectangleShape2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleShape2.Location = new System.Drawing.Point(8, 9);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(348, 40);
            // 
            // pnlCard
            // 
            this.pnlCard.Controls.Add(this.lblCardMsg);
            this.pnlCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCard.Location = new System.Drawing.Point(0, 0);
            this.pnlCard.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(368, 298);
            this.pnlCard.TabIndex = 0;
            // 
            // lblCardMsg
            // 
            this.lblCardMsg.AutoSize = true;
            this.lblCardMsg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardMsg.Location = new System.Drawing.Point(37, 40);
            this.lblCardMsg.Name = "lblCardMsg";
            this.lblCardMsg.Size = new System.Drawing.Size(268, 21);
            this.lblCardMsg.TabIndex = 0;
            this.lblCardMsg.Text = "Click on Pay to complete your order...";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCash);
            this.panel1.Controls.Add(this.shapeContainer2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 51);
            this.panel1.TabIndex = 6;
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer2.Size = new System.Drawing.Size(136, 51);
            this.shapeContainer2.TabIndex = 0;
            this.shapeContainer2.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.rectangleShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.rectangleShape1.BorderWidth = 2;
            this.rectangleShape1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rectangleShape1.Location = new System.Drawing.Point(4, 5);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(128, 42);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCard);
            this.panel2.Controls.Add(this.shapeContainer3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(136, 51);
            this.panel2.TabIndex = 7;
            // 
            // rectangleShape3
            // 
            this.rectangleShape3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.rectangleShape3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.rectangleShape3.BorderWidth = 2;
            this.rectangleShape3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rectangleShape3.Location = new System.Drawing.Point(4, 4);
            this.rectangleShape3.Name = "rectangleShape3";
            this.rectangleShape3.Size = new System.Drawing.Size(128, 42);
            // 
            // shapeContainer3
            // 
            this.shapeContainer3.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer3.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer3.Name = "shapeContainer3";
            this.shapeContainer3.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape3});
            this.shapeContainer3.Size = new System.Drawing.Size(136, 51);
            this.shapeContainer3.TabIndex = 0;
            this.shapeContainer3.TabStop = false;
            // 
            // rectangleShape4
            // 
            this.rectangleShape4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.rectangleShape4.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.rectangleShape4.BorderWidth = 2;
            this.rectangleShape4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rectangleShape4.Location = new System.Drawing.Point(4, 4);
            this.rectangleShape4.Name = "rectangleShape4";
            this.rectangleShape4.Size = new System.Drawing.Size(128, 42);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnWallet);
            this.panel3.Controls.Add(this.shapeContainer4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 151);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(136, 52);
            this.panel3.TabIndex = 8;
            // 
            // shapeContainer4
            // 
            this.shapeContainer4.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer4.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer4.Name = "shapeContainer4";
            this.shapeContainer4.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape4});
            this.shapeContainer4.Size = new System.Drawing.Size(136, 52);
            this.shapeContainer4.TabIndex = 0;
            this.shapeContainer4.TabStop = false;
            // 
            // btnWallet
            // 
            this.btnWallet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWallet.FlatAppearance.BorderSize = 0;
            this.btnWallet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnWallet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnWallet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWallet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWallet.Location = new System.Drawing.Point(7, 7);
            this.btnWallet.Margin = new System.Windows.Forms.Padding(0);
            this.btnWallet.Name = "btnWallet";
            this.btnWallet.Size = new System.Drawing.Size(121, 35);
            this.btnWallet.TabIndex = 1;
            this.btnWallet.Text = "WALLET";
            this.btnWallet.UseVisualStyleBackColor = true;
            // 
            // ucPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tblBase);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucPayment";
            this.Size = new System.Drawing.Size(504, 419);
            this.tblBase.ResumeLayout(false);
            this.tblBase.PerformLayout();
            this.pnlBase.ResumeLayout(false);
            this.pnlCash.ResumeLayout(false);
            this.pnlCash.PerformLayout();
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblBase;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button btnCard;
        private System.Windows.Forms.Panel pnlBase;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Panel pnlCash;
        private System.Windows.Forms.Label lblCardMsg;
        private System.Windows.Forms.Button btnExactAmount;
        private System.Windows.Forms.Label lblRem;
        private CustomServerControls.TxtBox txtAmount;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer3;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape3;
        private System.Windows.Forms.Panel panel3;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer4;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape4;
        private System.Windows.Forms.Button btnWallet;
    }
}
