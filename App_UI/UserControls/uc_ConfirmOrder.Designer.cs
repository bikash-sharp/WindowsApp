namespace App_UI.UserControls
{
    partial class uc_ConfirmOrder
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
            this.tblMainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.OrderNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderStatus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tblMainLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tblMainLayout
            // 
            this.tblMainLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblMainLayout.ColumnCount = 1;
            this.tblMainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMainLayout.Controls.Add(this.dataGridView1, 0, 0);
            this.tblMainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMainLayout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tblMainLayout.Location = new System.Drawing.Point(0, 0);
            this.tblMainLayout.Margin = new System.Windows.Forms.Padding(0);
            this.tblMainLayout.Name = "tblMainLayout";
            this.tblMainLayout.RowCount = 2;
            this.tblMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblMainLayout.Size = new System.Drawing.Size(523, 335);
            this.tblMainLayout.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.ColumnHeadersHeight = 50;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderNo,
            this.OrderType,
            this.OrderTotal,
            this.OrderStatus});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(1, 1);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 10;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.Size = new System.Drawing.Size(521, 282);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // OrderNo
            // 
            this.OrderNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OrderNo.DataPropertyName = "OrderNo";
            this.OrderNo.HeaderText = "Order No";
            this.OrderNo.Name = "OrderNo";
            this.OrderNo.ReadOnly = true;
            // 
            // OrderType
            // 
            this.OrderType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OrderType.DataPropertyName = "OrderType";
            this.OrderType.HeaderText = "Order Type";
            this.OrderType.Name = "OrderType";
            this.OrderType.ReadOnly = true;
            // 
            // OrderTotal
            // 
            this.OrderTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OrderTotal.DataPropertyName = "OrderTotal";
            this.OrderTotal.HeaderText = "Total";
            this.OrderTotal.Name = "OrderTotal";
            this.OrderTotal.ReadOnly = true;
            this.OrderTotal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // OrderStatus
            // 
            this.OrderStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OrderStatus.DataPropertyName = "OrderStatus";
            this.OrderStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderStatus.HeaderText = "Status";
            this.OrderStatus.Name = "OrderStatus";
            this.OrderStatus.ReadOnly = true;
            this.OrderStatus.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.OrderStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // uc_ConfirmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblMainLayout);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "uc_ConfirmOrder";
            this.Size = new System.Drawing.Size(523, 335);
            this.tblMainLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMainLayout;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderType;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderTotal;
        private System.Windows.Forms.DataGridViewButtonColumn OrderStatus;
    }
}
