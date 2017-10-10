using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App_Wrapper;
using System.Web.Script.Serialization;
using App_BAL;
using System.Windows.Forms.VisualStyles;
using App_UI.Forms;

namespace App_UI.UserControls
{
    public partial class uc_ConfirmOrder : UserControl
    {
        public static EmGridType _gridType;
        public uc_ConfirmOrder()
        {
            InitializeComponent();
        }

        public void BindReservations()
        {
            // dataGridView1.Columns.Clear();
            if (_gridType == EmGridType.Reservation)
            {
                //Load with Reservations
                string URL = Program.BaseUrl;
                string ChangeOrdStatusURL = URL + "/pendingreservations?acess_token=" + Program.Token;

                var GetStatus = DataProviderWrapper.Instance.GetData(ChangeOrdStatusURL, Verbs.GET, "");
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                var result = serializer.Deserialize<ReservationListAPICL>(GetStatus);

                if (result.data.Count > 0)
                {
                    var dataLst = result.data;
                    Program.Reservations = dataLst.Select(p => new ReservationCL()
                    {

                        TableId = p.Tableorder.id,
                        TableNo ="0",
                        RestrauntId = p.Tableorder.restaurent_id,
                        DinerName = p.Tableorder.diner_name,
                        GuestCount = p.Tableorder.guests,
                        MobileNo = p.Tableorder.mobile,
                        ReservationDate = p.Tableorder.bookingDate,
                        ReservationStatus = p.Tableorder.status
                    }).ToList();


                    var source = new BindingSource(Program.Reservations, null);
                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.DataSource = source;
                    dataGridView1.ClearSelection();
                    //UpdateGridColumnType(EmGridType.Reservation);
                }
            }

            //Clear All DatabBindings and Columns
            lblOrderTotal.Visible = false;
            label2.Visible = false;
            lblOrderTotal.DataBindings.Clear();
        }

        public void BindData(bool? IsOrderConfirmed = null)
        {
            //GetPendingOrders();
            var OrderLst = Program.PlacedOrders.Where(p => IsOrderConfirmed == null ? true : p.IsOrderConfirmed == IsOrderConfirmed.Value).ToList();
            //Clear All DatabBindings and Columns
            lblOrderTotal.DataBindings.Clear();
            lblOrderTotal.Visible = true;
            label2.Visible = true;
            
            if (IsOrderConfirmed.Value)
            {
                var OrderSum = new Binding("Text", Program.OrderBindings, "SumConfirmedAmountTotal", true, DataSourceUpdateMode.Never, "0", "F");
                lblOrderTotal.DataBindings.Add(OrderSum);

            }
            else
            {
                var OrderSum = new Binding("Text", Program.OrderBindings, "SumUnconfirmedAmountTotal", true, DataSourceUpdateMode.Never, "0.00", "F");
                lblOrderTotal.DataBindings.Add(OrderSum);
            }
            if (_gridType == EmGridType.Delivery || _gridType == EmGridType.OrderIn)
            {
                var source = new BindingSource(OrderLst, null);
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = source;
                dataGridView1.ClearSelection();
            }

        }


        //private void CreateControl(App_BAL.CartCL itm)
        //{
        //    Panel pnl = new Panel();
        //    pnl.Height = 60;
        //    //pnl.Width = flyLayout.Width - 10;
        //    pnl.BackColor = Color.LightGray;

        //    Label lbl = new Label();
        //    lbl.Text = itm.OrderNo;
        //    lbl.AutoSize = false;
        //    lbl.Height = 50;
        //    lbl.Width = 200;
        //    lbl.Location = new Point(10, 5);
        //    lbl.TextAlign = ContentAlignment.MiddleCenter;
        //    pnl.Controls.Add(lbl);

        //    Button btn = new Button();
        //    if (itm.IsOrderConfirmed)
        //    {
        //        btn.Text = "Delivered";
        //        btn.Enabled = false;
        //    }
        //    else
        //    {
        //        btn.Text = "Confirm";
        //        btn.Click += btn_Click;
        //    }
        //    btn.Location = new Point(pnl.Width - 130, 15);
        //    btn.Font = new Font("Segoe UI Semilight", 12, FontStyle.Bold);
        //    btn.Tag = itm.OrderNo;
        //    btn.Height = 35;
        //    btn.Width = 120;
        //    btn.Cursor = Cursors.Hand;
        //    btn.FlatStyle = FlatStyle.Flat;
        //    btn.FlatAppearance.BorderColor = Color.FromArgb(251, 51, 51);
        //    btn.FlatAppearance.BorderSize = 2;
        //    btn.FlatAppearance.MouseOverBackColor = Color.White;
        //    btn.FlatAppearance.MouseDownBackColor = Color.White;
        //    pnl.Controls.Add(btn);

        //    //flyLayout.Controls.Add(pnl);
        //}

        //void btn_Click(object sender, EventArgs e)
        //{
        //    if (sender is Button)
        //    {
        //        var OrderNo = (sender as Button).Tag.ToString();
        //        var itm = Program.PlacedOrders.Where(p => p.OrderNo == OrderNo).FirstOrDefault();
        //        if (itm != null)
        //        {
        //            string URL = Program.BaseUrl;
        //            string ChangeOrdStatusURL = URL + "/confirmorder?order_id=" + OrderNo + "&order_status=completed&acess_token=" + Program.Token;

        //            var GetStatus = DataProviderWrapper.Instance.GetData(ChangeOrdStatusURL, Verbs.GET, "");
        //            JavaScriptSerializer serializer = new JavaScriptSerializer();
        //            var result = serializer.Deserialize<MessageCL>(GetStatus);
        //            itm.IsOrderConfirmed = true;
        //            BindData(false);
        //            Program.OrderCount();
        //        }
        //    }
        //}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (this.dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    if (_gridType == EmGridType.OrderIn)
                    {
                        if (row != null)
                        {
                            string OrderNo = row.Cells["OrderNo"].Value.ToString();
                            if (!string.IsNullOrEmpty(OrderNo))
                            {
                                var itm = Program.PlacedOrders.Where(p => p.OrderNo == OrderNo).FirstOrDefault();
                                if (itm != null)
                                {
                                    string URL = Program.BaseUrl;
                                    string ChangeOrdStatusURL = URL + "/confirmorder?order_id=" + OrderNo + "&order_status=in_progress&acess_token=" + Program.Token;

                                    var GetStatus = DataProviderWrapper.Instance.GetData(ChangeOrdStatusURL, Verbs.GET, "");
                                    JavaScriptSerializer serializer = new JavaScriptSerializer();
                                    var result = serializer.Deserialize<MessageCL>(GetStatus);
                                    itm.IsOrderConfirmed = true;
                                    itm.OrderStatus = EmOrderStatus.Delivered;
                                    BindData(false);
                                    Program.OrderCount();
                                }
                            }
                        }
                    }
                    else if (_gridType == EmGridType.Reservation)
                    {
                        if (row != null)
                        {
                            string status = row.Cells["ReservationStatus"].Value.ToString();
                            if (status.ToLower().Trim() == "pending")
                            {
                               
                                string TableId = row.Cells["TableId"].Value.ToString();
                                if (!string.IsNullOrEmpty(TableId))
                                {

                                    var itm = Program.Reservations.FirstOrDefault(p => p.TableId == TableId);
                                    if (itm != null)
                                    {
                                        frmAssign objAssign = new frmAssign();
                                        frmAssign.GuestCount = int.Parse(itm.GuestCount);
                                        objAssign.ShowDialog();
                                        if (!String.IsNullOrEmpty(frmAssign.TableNo))
                                        {
                                            itm.ReservationStatus = EmOrderStatus.Confirmed.ToString();
                                            itm.TableNo = frmAssign.TableNo;

                                            string URL = Program.BaseUrl;
                                            string ChangeReservationStatusURL = URL + "/changereservationstatus?res_id=" + itm.RestrauntId + "&status=Completed&acess_token=" + Program.Token;
                                            var GetStatus = DataProviderWrapper.Instance.GetData(ChangeReservationStatusURL, Verbs.GET, "");
                                            JavaScriptSerializer serializer = new JavaScriptSerializer();
                                            var result = serializer.Deserialize<MessageCL>(GetStatus);
                                            if (result.status)
                                            {
                                                itm.ReservationStatus = EmOrderStatus.Confirmed.ToString();
                                            }
                                        }
                                        
                                    }
                                }
                            }

                        }
                    }


                }
            }
        }

        public void UpdateGridColumns(EmGridType type)
        {
            //Remove all Columns initially
            dataGridView1.Columns.Clear();
            _gridType = type;
            // Create Columns based on Reservations or Order-In/Delivery
            //Do the Bindings.
            if (type == EmGridType.Reservation)
            {
                //Columns
                DataGridViewTextBoxColumn txtid = new DataGridViewTextBoxColumn();
                txtid.DataPropertyName = "TableId";
                txtid.HeaderText = "ID";
                txtid.Resizable = DataGridViewTriState.False;
                txtid.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns.Add(txtid);
                dataGridView1.Columns[0].Name = "TableId";
                dataGridView1.Columns[0].Visible = false;

                DataGridViewTextBoxColumn txtrestrauntId = new DataGridViewTextBoxColumn();
                txtrestrauntId.DataPropertyName = "RestrauntId";
                txtrestrauntId.HeaderText = "Restaurent Id";
                txtrestrauntId.Resizable = DataGridViewTriState.False;
                txtrestrauntId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns.Add(txtrestrauntId);
                dataGridView1.Columns[1].Name = "RestrauntId";
                dataGridView1.Columns[1].Visible = false;


                DataGridViewTextBoxColumn txtDinerName = new DataGridViewTextBoxColumn();
                txtDinerName.DataPropertyName = "DinerName";
                txtDinerName.HeaderText = "Diner Name";
                txtDinerName.Resizable = DataGridViewTriState.False;
                txtDinerName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns.Add(txtDinerName);


                DataGridViewTextBoxColumn txtMobile = new DataGridViewTextBoxColumn();
                txtMobile.DataPropertyName = "MobileNo";
                txtMobile.HeaderText = "Mobile No.";
                txtMobile.Resizable = DataGridViewTriState.False;
                txtMobile.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns.Add(txtMobile);

                DataGridViewTextBoxColumn txtBookingDt = new DataGridViewTextBoxColumn();
                txtBookingDt.DataPropertyName = "ReservationDate";
                txtBookingDt.HeaderText = "Booking Date";
                txtBookingDt.Resizable = DataGridViewTriState.False;
                txtBookingDt.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns.Add(txtBookingDt);

                DataGridViewTextBoxColumn txtGuestCount = new DataGridViewTextBoxColumn();
                txtGuestCount.DataPropertyName = "GuestCount";
                txtGuestCount.HeaderText = "Guest Count";
                txtGuestCount.Resizable = DataGridViewTriState.False;
                txtGuestCount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns.Add(txtGuestCount);

                DataGridViewTextBoxColumn txtTableNo = new DataGridViewTextBoxColumn();
                txtTableNo.DataPropertyName = "TableNo";
                txtTableNo.HeaderText = "Table";
                txtTableNo.Resizable = DataGridViewTriState.False;
                txtTableNo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns.Add(txtTableNo);

                DataGridViewButtonColumn btnStatus = new DataGridViewButtonColumn();
                btnStatus.DataPropertyName = "ReservationStatus";
                btnStatus.HeaderText = "Status";
                btnStatus.Text = "Pending";
                btnStatus.UseColumnTextForButtonValue = false;
                btnStatus.Resizable = DataGridViewTriState.False;
                btnStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns.Add(btnStatus);
                dataGridView1.Columns[7].Name = "ReservationStatus";
            }
            else if (type == EmGridType.OrderIn)
            {
                //Columns
                DataGridViewTextBoxColumn txtOrderNo = new DataGridViewTextBoxColumn();
                txtOrderNo.DataPropertyName = "OrderNo";
                txtOrderNo.HeaderText = "Order No";
                txtOrderNo.Resizable = DataGridViewTriState.False;
                txtOrderNo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns.Add(txtOrderNo);
                dataGridView1.Columns[0].Name = "OrderNo";


                DataGridViewTextBoxColumn txtOrdertype = new DataGridViewTextBoxColumn();
                txtOrdertype.DataPropertyName = "OrderType";
                txtOrdertype.HeaderText = "Order Type";
                txtOrdertype.Resizable = DataGridViewTriState.False;
                txtOrdertype.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns.Add(txtOrdertype);
                dataGridView1.Columns[1].Name = "OrderType";

                DataGridViewTextBoxColumn txtTotal = new DataGridViewTextBoxColumn();
                txtTotal.DataPropertyName = "OrderTotal";
                txtTotal.HeaderText = "Total";
                txtTotal.Resizable = DataGridViewTriState.False;
                txtTotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns.Add(txtTotal);
                dataGridView1.Columns[2].Name = "OrderTotal";

                DataGridViewButtonColumn btnCol = new DataGridViewButtonColumn();
                btnCol.DataPropertyName = "OrderStatus";
                btnCol.HeaderText = "Status";
                btnCol.Text = "Pending";
                btnCol.UseColumnTextForButtonValue = true;
                btnCol.Resizable = DataGridViewTriState.False;
                btnCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns.Add(btnCol);
                dataGridView1.Columns[3].Name = "OrderStatus";

            }
            else if (type == EmGridType.Delivery)
            {
                //Columns
                DataGridViewTextBoxColumn txtOrderNo = new DataGridViewTextBoxColumn();
                txtOrderNo.DataPropertyName = "OrderNo";
                txtOrderNo.HeaderText = "Order No";
                txtOrderNo.Resizable = DataGridViewTriState.False;
                txtOrderNo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns.Add(txtOrderNo);
                dataGridView1.Columns[0].Name = "OrderNo";

                DataGridViewTextBoxColumn txtOrdertype = new DataGridViewTextBoxColumn();
                txtOrdertype.DataPropertyName = "OrderType";
                txtOrdertype.HeaderText = "Order Type";
                txtOrdertype.Resizable = DataGridViewTriState.False;
                txtOrdertype.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns.Add(txtOrdertype);

                DataGridViewTextBoxColumn txtTotal = new DataGridViewTextBoxColumn();
                txtTotal.DataPropertyName = "OrderTotal";
                txtTotal.HeaderText = "Total";
                txtTotal.Resizable = DataGridViewTriState.False;
                txtTotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns.Add(txtTotal);

                DataGridViewTextBoxColumn txtCol = new DataGridViewTextBoxColumn();
                txtCol.DataPropertyName = "OrderStatus";
                txtCol.HeaderText = "Status";
                txtCol.Resizable = DataGridViewTriState.False;
                txtCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns.Add(txtCol);


            }

        }

        public void UpdateGridColumnType(EmGridType _type)
        {
            if (_type == EmGridType.Reservation)
            {
                //int i = 0;
                //while (i < dataGridView1.Rows.Count)
                //{
                //    var _row = dataGridView1.Rows[i];
                //    //var _allCells = dataGridView1.Rows[i].Cells;
                //    //_allCells.RemoveAt(6);
                //    //DataGridViewCell[] _cellList = null;
                //    var _cell = _row.Cells[6];
                //    if (_cell.Value.ToString() == "Pending")
                //    {
                //        var TextCell = new DataGridViewTextBoxCell();
                //        TextCell.Value = _row.Cells[6].Value;
                //        _cell.Value = TextCell;
                //        //_allCells.Add(TextCell);

                //        //_allCells.CopyTo(_cellList, 0);
                //        //dataGridView1.Rows[i].Cells.Clear();
                //        //dataGridView1.Rows[i].Cells.AddRange(_cellList);
                //    }
                //}

                dataGridView1.Rows[0].Cells[6].ReadOnly = true;
                dataGridView1.Rows[0].Cells.Remove(dataGridView1.Rows[0].Cells[6]);
            }

        }
    }

    
}
