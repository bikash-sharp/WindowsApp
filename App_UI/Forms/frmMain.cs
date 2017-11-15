using App_BAL;
using App_UI.UserControls;
using App_Wrapper;
using CustomServerControls;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using App_UI;

namespace App_UI.Forms
{
    public partial class frmMain : Form
    {
        public static bool IsClosed = false;
        public int SelectedCategoryID = 0;
        public static bool IsOrder = false;
        public static EmOrderType CurrentOrderType;
        public frmMain()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
            uc_CategoryMenu1.BindData();
            uc_CategoryMenu1.EventCategoryClicked += uc_CategoryMenu1_EventCategoryClicked;
            flyLayout.AutoScroll = true;
            flyLayout.VerticalScroll.Visible = true;
            flyLayout.VerticalScroll.Enabled = true;
            BindProducts();
            GetPendingOrders();

            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, lblOrderCount.Width, lblOrderCount.Height);
            this.lblOrderCount.Region = new Region(path);

        }


        void uc_CategoryMenu1_EventCategoryClicked(object sender, EventArgs e)
        {
            rdbOrder.Checked = rdbDelivery.Checked = rdbReservation.Checked = rdbTakeWay.Checked = false;
            rdbProducts.Checked = true;
            string FoodType = sender.ToString().Trim();
            BindProducts(FoodType.ToLower());
        }

        private void BindProducts(String foodtype = "all")
        {
            if (rdbDelivery.Checked != true && rdbOrder.Checked != true && rdbTakeWay.Checked != true && rdbReservation.Checked != true)
            {
                string URL = Program.BaseUrl;
                string ProductURL = String.Empty;
                if (foodtype == "all")
                {
                    ProductURL = URL + "/productlisting?acess_token=" + Program.Token;
                }
                else
                {
                    ProductURL = URL + "/filterproducts?category=" + foodtype + "&acess_token=" + Program.Token;
                }

                var ProductList = DataProviderWrapper.Instance.GetData(ProductURL, Verbs.GET, "");
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                var result = serializer.Deserialize<ProductListAPICL>(ProductList);

                this.flyLayout.Controls.Clear();
                this.flyLayout.VerticalScroll.Enabled = true;
                this.flyLayout.VerticalScroll.Visible = true;
                if (result.status)
                {
                    foreach (var itm in result.data)
                    {
                        CreateProdButtons(itm.Product);
                    }
                }
            }

        }

        private void CreateProdButtons(ProductCL itm)
        {
            Panel pnl = new Panel();

            pnl.Name = "pnl_" + itm.id;
            pnl.Width = 200;
            pnl.Height = 220;
            pnl.Tag = itm;
            pnl.BorderStyle = BorderStyle.FixedSingle;
            pnl.Cursor = Cursors.Hand;


            PictureBox pic = new PictureBox();
            pic.Name = "pic_" + itm.id;
            pic.ImageLocation = Program.ProductImagesLoc + itm.product_image;
            pic.ErrorImage = global::App_UI.Properties.Resources.IMG_NotFound;
            //pic.Image = global::App_UI.Properties.Resources.IMG_NotFound;
            pic.Width = 200;
            pic.Height = 130;
            pic.BorderStyle = BorderStyle.None;
            pic.Margin = new Padding(0);
            pic.Location = new Point(0, 0);
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.Cursor = Cursors.Hand;
            pic.Click += pnl_Click;
            pic.Tag = itm;
            pnl.Controls.Add(pic);

            Label lblName = new Label();
            lblName.Name = "lblProductName_" + itm.id;
            lblName.Text = itm.product_name + Environment.NewLine + "MYR - " + itm.product_price;
            lblName.Location = new Point(5, pic.Height + 5);
            lblName.AutoSize = false;
            lblName.Width = pnl.Width - 10;
            lblName.Height = 80;
            lblName.Cursor = Cursors.Hand;
            lblName.Font = new Font("Segoe UI Semilight", 12, FontStyle.Regular);
            lblName.Click += pnl_Click;
            lblName.Tag = itm;
            pnl.Controls.Add(lblName);

            pnl.Click += pnl_Click;
            pnl.Margin = new Padding(0, 0, 10, 20);
            this.flyLayout.Controls.Add(pnl);
        }

        void pnl_Click(object sender, EventArgs e)
        {
            ProductCL prod = new ProductCL();
            if (sender is Panel)
            {
                prod = (ProductCL)(sender as Panel).Tag;
            }
            else if (sender is Label)
            {
                prod = (ProductCL)(sender as Label).Tag;
            }
            else if (sender is PictureBox)
            {
                prod = (ProductCL)(sender as PictureBox).Tag;
            }
            if (prod != null)
            {
                CartItemsCL cl = new CartItemsCL();
                bool IsNew = false;
                if (Program.cartItems.Count > 0)
                {
                    cl = Program.cartItems.Where(p => p.ProductID == Convert.ToInt32(prod.id)).FirstOrDefault();
                    if (cl != null)
                    {
                        cl.Quantity += 1;
                        cl.Price = Convert.ToDouble(cl.OriginalPrice) * cl.Quantity;
                    }
                    else
                    {
                        IsNew = true;
                    }

                }
                else
                {
                    IsNew = true;
                }

                if (IsNew)
                {
                    cl = new CartItemsCL();
                    cl.ProductID = Convert.ToInt32(prod.id);
                    cl.FoodType = prod.food_type;
                    cl.Price = Convert.ToDouble(prod.product_price);
                    cl.OriginalPrice = Convert.ToDouble(prod.product_price);
                    cl.Quantity = 1;
                    cl.ProductName = prod.product_name;
                    Program.cartItems.Add(cl);
                }

                var source = new BindingSource(Program.cartItems, null);
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = source;
                dataGridView1.ClearSelection();

                Program.TotalCart();
                lblCartTotal.DataBindings.Clear();
                lblGrandTotal.DataBindings.Clear();
                lblTax.DataBindings.Clear();
                //if(!IsConnected)
                //{
                var CartTotalBinding = new Binding("Text", Program.cartItems.FirstOrDefault(), "CartTotal", true, DataSourceUpdateMode.Never, "0.00", "N");
                lblCartTotal.DataBindings.Add(CartTotalBinding);
                var GrandTotalBinding = new Binding("Text", Program.cartItems.FirstOrDefault(), "GrandTotal", true, DataSourceUpdateMode.Never, "0.00", "N");
                lblGrandTotal.DataBindings.Add(GrandTotalBinding);
                //  IsConnected = true;
                //}
                // BindCart(Program.cartItems);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult msgResult = MessageBox.Show("Do you want to Exit Application ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (msgResult == DialogResult.Yes)
            {
                Application.ExitThread();
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindProductBySearchText();
        }

        private void BindProductBySearchText()
        {
            string URL = Program.BaseUrl;
            string SearchTextURL = URL + "/filterbyname?name=" + txtSearch.Text.Trim() + "&acess_token=" + Program.Token;

            var ProductList = DataProviderWrapper.Instance.GetData(SearchTextURL, Verbs.GET, "");
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            var result = serializer.Deserialize<ProductListAPICL>(ProductList);

            if (result.status)
            {
                flyLayout.Controls.Clear();
                foreach (var itm in result.data)
                {
                    CreateProdButtons(itm.Product);
                }
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            TxtBox txtSearch = (TxtBox)sender;
            if (txtSearch != null)
            {
                if (e.KeyChar == (char)Keys.Return)
                {
                    BindProductBySearchText();
                }
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (Program.cartItems.Count > 0)
            {
                frmOrderType _frmOrder = new frmOrderType();
                _frmOrder.ShowDialog();
                if (!frmOrderType.isClosed)
                {
                    var TotalAmount = 0.0;  // Total Price
                    TotalAmount = Program.cartItems.Sum(p => p.Price);
                    FrmContainer frm = new FrmContainer();
                    ucPayment uc = new ucPayment();
                    frm.Dock = DockStyle.Fill;
                    uc.BindData(TotalAmount);
                    frm.Width = uc.Width + 20;
                    frm.Height = uc.Height + 40;
                    frm.Controls.Add(uc);
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    var dgRes = frm.ShowDialog();
                    if (dgRes == System.Windows.Forms.DialogResult.OK)
                    {
                        string OrderNumber = DateTime.UtcNow.Ticks.ToString();

                        CartCL cart = new CartCL();
                        cart.IsOrderConfirmed = true;
                        cart.OrderStatus = EmOrderStatus.Delivered;
                        cart.OrderID = 0;
                        cart.OrderNo = OrderNumber;
                        cart.OrderType = CurrentOrderType;
                        cart.PaymentType = uc.PayementType;
                        cart.Items = Program.cartItems;
                        cart.OrderTotal = Program.cartItems.First().GrandTotal.ToString("N");
                        cart.IsCurrentOrder = true;
                        cart.TransactionID = uc.LastTransactionID;
                        MessageBox.Show("Order has been placed successfully", " Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Program.PlacedOrders.Add(cart);
                        //Program.OrderCount();
                        //Update Cart Order Number
                        foreach (var item in Program.cartItems)
                        {
                            item.orderNo = OrderNumber;
                        }
                        //Post Order
                        var NewOrderId = PostOrder(OrderNumber);
                        lblOrderCount.DataBindings.Clear();
                        var OrderCount = new Binding("Text", Program.OrderBindings, "OrderCount", true, DataSourceUpdateMode.Never, "0", "");
                        lblOrderCount.DataBindings.Add(OrderCount);
                        //Clear the Cart and Total Field
                        ClearList();

                        //Printing
                        Up:
                        try
                        {
                            Print(Program.PrinterName, GetDocument(NewOrderId));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Printer Connectivity Issue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        DialogResult reprintMsg = MessageBox.Show("Do you want to print again ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (reprintMsg == DialogResult.Yes)
                        {
                            goto Up;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Cart is Empty", "Empty Cart", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public static void Print(string printerName, byte[] document)
        {

            NativeMethods.DOC_INFO_1 documentInfo;
            IntPtr printerHandle;

            documentInfo = new NativeMethods.DOC_INFO_1();
            documentInfo.pDataType = "RAW";
            documentInfo.pDocName = "Receipt";

            printerHandle = new IntPtr(0);

            if (NativeMethods.OpenPrinter(printerName.Normalize(), out printerHandle, IntPtr.Zero))
            {
                if (NativeMethods.StartDocPrinter(printerHandle, 1, documentInfo))
                {
                    int bytesWritten;
                    byte[] managedData;
                    IntPtr unmanagedData;

                    managedData = document;
                    unmanagedData = Marshal.AllocCoTaskMem(managedData.Length);
                    Marshal.Copy(managedData, 0, unmanagedData, managedData.Length);

                    if (NativeMethods.StartPagePrinter(printerHandle))
                    {
                        NativeMethods.WritePrinter(
                            printerHandle,
                            unmanagedData,
                            managedData.Length,
                            out bytesWritten);
                        NativeMethods.EndPagePrinter(printerHandle);
                    }
                    else
                    {
                        throw new Win32Exception();
                    }

                    Marshal.FreeCoTaskMem(unmanagedData);

                    NativeMethods.EndDocPrinter(printerHandle);
                }
                else
                {
                    throw new Win32Exception();
                }

                NativeMethods.ClosePrinter(printerHandle);
            }
            else
            {
                throw new Win32Exception();
            }

        }
        public static byte[] GetDocument(string OrderNumber)
        {
            using (var ms = new MemoryStream())
            using (var bw = new BinaryWriter(ms))
            {
                // Reset the printer bws (NV images are not cleared)
                bw.Write(AsciiControlChars.Escape);
                bw.Write('@');

                // Render the logo
                //RenderLogo(bw);
                PrintReceipt(bw, OrderNumber);

                // Feed 3 vertical motion units and cut the paper with a 1 point cut
                bw.Write(AsciiControlChars.GroupSeparator);
                bw.Write('V');
                bw.Write((byte)66);
                bw.Write((byte)3);

                bw.Flush();

                return ms.ToArray();
            }
        }

        /// <summary>
        /// This is the method we print the receipt the way we want. Note the spaces. 
        /// Wasted a lot of paper on this to get it right.
        /// </summary>
        /// <param name="bw"></param>
        public static void PrintReceipt(BinaryWriter bw, string OrderNumber)
        {
            var Order = Program.PlacedOrders.FirstOrDefault(p => p.OrderNo == OrderNumber);
            bw.BoldON("", false);
            bw.Center("Bastari Terrace");
            bw.Center("Contact Address");
            bw.Center("Contact Number");
            bw.BoldOFF("", false);
            bw.LeftJustify("");
            bw.LeftJustify("------------------------------------------------------");
            bw.NormalFont("Invoice #: " + OrderNumber);
            bw.NormalFont("Staff : test User");
            bw.NormalFont("Date: " + DateTime.UtcNow.ToString("dd-MM-yyyy hh:mm:ss"));
            bw.NormalFont("-------------------------------------");
            bw.LeftJustify("");
            bw.NormalFont("-------------------------------------");
            bw.NormalFont("Description         Qty         Amount");
            bw.NormalFont("--------------------------------------");
            foreach (var item in Order.Items)
            {
                string text = "";
                text += item.ProductID.ToString() + " ";
                text += item.ProductName;
                bw.NormalFont(text + " " + item.Quantity.ToString() + " " + item.Price.ToString());
                //bw.LeftJustify(text,false);
                //bw.Center(item.Quantity.ToString(), false);
                //bw.RightJustify(item.Price.ToString());
            }
            bw.NormalFont("---------------------------------------");
            bw.NormalFont("Number of Items : " + Order.Items.Sum(p => p.Quantity));
            bw.NormalFont("Discount:" + "0");
            bw.NormalFont("Sub Total:  " + Order.Items.FirstOrDefault().CartTotal.ToString());
            bw.NormalFont("---------------------------------------");
            bw.Finish();
        }

        public string PostOrder(string OrderNo)
        {
            string fresult = OrderNo;
            try
            {
                //POST Cart Details
                List<NewOrder> Orders = new List<NewOrder>();
                var CurrentOrder = Program.PlacedOrders.FirstOrDefault(p => p.IsCurrentOrder == true && p.OrderNo == OrderNo);
                var CartItems = Program.cartItems.Where(p => p.orderNo == OrderNo).ToList();
                foreach (var item in CartItems)
                {
                    NewOrder _order = new NewOrder();
                    _order.product_id = item.ProductID.ToString();
                    _order.quantity = item.Quantity.ToString();
                    _order.price = Convert.ToInt32(Math.Ceiling(decimal.Parse(item.Price.ToString())));
                    if (CurrentOrder.OrderType == EmOrderType.TakeOut)
                    {
                        _order.delivery_type = "take_away";
                    }
                    else if (CurrentOrder.OrderType == EmOrderType.DineIn)
                    {
                        _order.delivery_type = "dine_in";
                    }
                    Orders.Add(_order);
                }

                string URL = Program.BaseUrl;
                string PostOrderURL = URL + "/makedineinorder?acess_token=" + Program.Token;
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                var postData = serializer.Serialize(Orders);
                var PostResult = DataProviderWrapper.Instance.PostData(PostOrderURL, postData);
                var result = serializer.Deserialize<TransactionAPICL>(PostResult);
                if (result != null)
                {
                    fresult = result.message;
                }
                if (fresult == "Success.")
                {
                    CurrentOrder.OrderNo = result.orderid;
                    foreach (var item in CartItems)
                    {
                        item.orderNo = result.orderid;
                    }

                    fresult = result.orderid;
                }
            }
            catch(Exception ex)
            {

            }
            return fresult;
        }

        private void ClearList()
        {
            //Program.cartItems.Clear();
            //Program.TotalCart();

            dataGridView1.Rows.Clear();
            dataGridView1.DataBindings.Clear();
            lblTax.Text = "0.00";
            lblCartTotal.Text = "0.00";
            lblGrandTotal.Text = "0.00";
            lblCartTotal.DataBindings.Clear();
            lblGrandTotal.DataBindings.Clear();
            lblTax.DataBindings.Clear();

        }

        private void lblOrderCount_Click(object sender, EventArgs e)
        {
            if (!rdbDelivery.Checked)
            {
                rdbDelivery.Checked = true;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bool IsSelected = dataGridView1.CurrentCell.Selected;
            int ProductId = 0;
            if (IsSelected)
            {
                string value = dataGridView1.Rows[e.RowIndex].Cells["Column1"].FormattedValue.ToString();
                int.TryParse(value, out ProductId);
            }

            if (ProductId != 0)
            {
                Program.SelectedProductId = ProductId;

                frmProductQty objFrmQty = new frmProductQty();
                objFrmQty.ShowDialog();
            }
            if (Program.cartItems.Count < 1)
            {
                lblCartTotal.DataBindings.Clear();
                lblGrandTotal.DataBindings.Clear();
                lblTax.DataBindings.Clear();
                lblTax.Text = "0.00";
                lblCartTotal.Text = "0.00";
                lblGrandTotal.Text = "0.00";
            }
            else
            {
                Program.TotalCart();
                lblCartTotal.DataBindings.Clear();
                lblGrandTotal.DataBindings.Clear();
                lblTax.DataBindings.Clear();

                var CartTotalBinding = new Binding("Text", Program.cartItems.FirstOrDefault(), "CartTotal", true, DataSourceUpdateMode.Never, "0.00", "N");
                lblCartTotal.DataBindings.Add(CartTotalBinding);
                var GrandTotalBinding = new Binding("Text", Program.cartItems.FirstOrDefault(), "GrandTotal", true, DataSourceUpdateMode.Never, "0.00", "N");
                lblGrandTotal.DataBindings.Add(GrandTotalBinding);
            }
        }

        private void rdbOrder_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbOrder.Checked)
            {
                uc_CategoryMenu1.SetCurrentControlBtnName("");
                uc_CategoryMenu1.SelectedControls();
                BindOrders(false, EmOrderType.DineIn);
                IsOrder = true;
            }
        }

        private void rdbDelivery_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDelivery.Checked)
            {
                uc_CategoryMenu1.SetCurrentControlBtnName("");
                uc_CategoryMenu1.SelectedControls();
                BindOrders(false, EmOrderType.Delivery);
                IsOrder = true;
            }
        }

        private void ovalShape2_Click(object sender, EventArgs e)
        {
            ClearList();
        }

        public void BindOrders(bool? IsOrderConfirmed = null, EmOrderType OrderType = EmOrderType.DineIn)
        {
            this.flyLayout.Controls.Clear();
            //this.flyLayout.AutoScroll = false;
            this.flyLayout.VerticalScroll.Visible = false;
            this.flyLayout.VerticalScroll.Enabled = false;
            this.flyLayout.Refresh();
            int Count = Program.PlacedOrders.Where(p => p.OrderType == OrderType).Count();
            if (Count > 0)
            {
                uc_ConfirmOrder uc = new uc_ConfirmOrder();
                uc.Width = flyLayout.Width - 15;
                uc.Height = flyLayout.Height - 15;
                uc.AutoScroll = true;
                uc.VerticalScroll.Visible = true;
                uc.VerticalScroll.Enabled = true;
                if (OrderType == EmOrderType.Delivery)
                {
                    uc.UpdateGridColumns(EmGridType.Delivery);
                }
                else if (OrderType == EmOrderType.DineIn)
                {
                    uc.UpdateGridColumns(EmGridType.OrderIn);
                }
                else if (OrderType == EmOrderType.TakeOut)
                {
                    uc.UpdateGridColumns(EmGridType.TakeAway);
                }
                uc.BindData(IsOrderConfirmed, OrderType);
                this.flyLayout.Controls.Add(uc);
            }
        }

        public void BindReservations()
        {
            this.flyLayout.Controls.Clear();
            //this.flyLayout.AutoScroll = false;
            this.flyLayout.VerticalScroll.Enabled = false;
            this.flyLayout.VerticalScroll.Visible = false;
            this.flyLayout.Refresh();
            uc_ConfirmOrder uc = new uc_ConfirmOrder();
            uc.Width = flyLayout.Width - 15;
            uc.Height = flyLayout.Height - 15;
            uc.AutoScroll = true;
            uc.VerticalScroll.Visible = true;
            uc.VerticalScroll.Enabled = true;
            uc.UpdateGridColumns(EmGridType.Reservation);
            uc.BindReservations();
            flyLayout.Controls.Add(uc);
        }
        private void rdbProducts_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbProducts.Checked)
                BindProducts();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetPendingOrders();
            if (!IsOrder)
            {
                uc_CategoryMenu1.SetCurrentControlBtnName("All");
                uc_CategoryMenu1.SelectedControls();
                BindProducts();
            }
            else
            {
                if (rdbReservation.Checked)
                {
                    uc_CategoryMenu1.SetCurrentControlBtnName("");
                    uc_CategoryMenu1.SelectedControls();
                    BindReservations();
                }
                else if (rdbOrder.Checked)
                {
                    uc_CategoryMenu1.SetCurrentControlBtnName("");
                    uc_CategoryMenu1.SelectedControls();
                    BindOrders(false, EmOrderType.DineIn);
                }
                else if (rdbDelivery.Checked)
                {
                    uc_CategoryMenu1.SetCurrentControlBtnName("");
                    uc_CategoryMenu1.SelectedControls();
                    BindOrders(false, EmOrderType.Delivery);
                }
                else if (rdbTakeWay.Checked)
                {
                    uc_CategoryMenu1.SetCurrentControlBtnName("");
                    uc_CategoryMenu1.SelectedControls();
                    BindOrders(false, EmOrderType.TakeOut);
                }
            }
        }

        private void rdbReservation_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbReservation.Checked)
            {
                uc_CategoryMenu1.SetCurrentControlBtnName("");
                uc_CategoryMenu1.SelectedControls();
                BindReservations();
                IsOrder = true;
            }
        }

        public void GetPendingOrders()
        {
            //Load with Reservations
            string URL = Program.BaseUrl;
            string PendingOrdURL = URL + "/pendingorders?acess_token=" + Program.Token;

            var GetStatus = DataProviderWrapper.Instance.GetData(PendingOrdURL, Verbs.GET, "");
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            var result = serializer.Deserialize<PendingOrderAPI>(GetStatus);
            if (result != null)
            {
                foreach (var item in result.data)
                {
                    var OrderId = "" + item.Order?.Orderdetail?.order_id;
                    //var OrderType = EmOrderType.Delivery;
                    var ordStatus = EmOrderStatus.Pending;
                    var btnActionText = "Update Status";
                    var OrderStatus = "" + item.Order?.Orderdetail?.order_status;
                    if(OrderStatus.ToLower().Trim() == "pending")
                    {
                        ordStatus = EmOrderStatus.Pending;
                        btnActionText = "Pending Status";
                    }
                    else if(OrderStatus.ToLower().Trim() == "in_progress")
                    {
                        ordStatus = EmOrderStatus.Confirmed;
                        btnActionText = "In-Progress Status";
                    }
                    else if(OrderStatus.ToLower().Trim() == "completed")
                    {
                        ordStatus = EmOrderStatus.Delivered;
                        btnActionText = "Delivered";
                    }
                    var Total = "" + item.Order?.Orderdetail?.total;
                    if (!String.IsNullOrEmpty(OrderId) && !String.IsNullOrEmpty(OrderStatus))
                    {
                        bool isExist = Program.PlacedOrders.Where(p => p.OrderNo == OrderId).Any();
                        if (!isExist)
                        {
                            Program.PlacedOrders.Add(new CartCL { OrderNo = OrderId.Trim(), OrderStatus = ordStatus, OrderType = EmOrderType.Delivery, OrderTotal = Total, IsOrderConfirmed = false, BtnActionStatus = btnActionText });
                        }
                    }
                }
            }
            //Get the Counting
            Program.OrderCount(EmOrderType.Delivery);
            //Set the Notification Count
            lblOrderCount.DataBindings.Clear();
            var OrderCount = new Binding("Text", Program.OrderBindings, "OrderCount", true, DataSourceUpdateMode.OnPropertyChanged, "0", "");
            lblOrderCount.DataBindings.Add(OrderCount);
        }

        private void rdbTakeWay_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTakeWay.Checked)
            {
                uc_CategoryMenu1.SetCurrentControlBtnName("");
                uc_CategoryMenu1.SelectedControls();
                BindOrders(true, EmOrderType.TakeOut);
                IsOrder = true;
            }
        }
    }
}
