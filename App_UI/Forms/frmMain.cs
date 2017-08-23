using App_BAL;
using App_UI.UserControls;
using App_Wrapper;
using CustomServerControls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        }


        void uc_CategoryMenu1_EventCategoryClicked(object sender, EventArgs e)
        {
            rdbOrder.Checked = rdbDelivery.Checked = false;
            rdbProducts.Checked = true;
            string FoodType = sender.ToString().Trim();
            BindProducts(FoodType.ToLower());
        }

        private void BindProducts(String foodtype = "all")
        {
            if (rdbDelivery.Checked != true && rdbOrder.Checked != true)
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

                if (result.status)
                {
                    flyLayout.Controls.Clear();
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
            pic.Image = global::App_UI.Properties.Resources.IMG_NotFound;
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
            flyLayout.Controls.Add(pnl);
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
                frmOrderType _frrOrder = new frmOrderType();
                _frrOrder.ShowDialog();

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
                    cart.IsOrderConfirmed = false;
                    cart.OrderStatus = EmOrderStatus.Pending;
                    cart.OrderID = 0;
                    cart.OrderNo = OrderNumber;
                    cart.OrderType = CurrentOrderType;
                    cart.PaymentType = uc.PayementType;
                    cart.Items = Program.cartItems;
                    cart.OrderTotal = Program.cartItems.First().GrandTotal.ToString("N");

                    MessageBox.Show("Order Number : " + OrderNumber + " has been placed successfully", " Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Program.PlacedOrders.Add(cart);
                    Program.OrderCount();
                    lblOrderCount.DataBindings.Clear();

                    var OrderCount = new Binding("Text", Program.OrderBindings, "OrderCount", true, DataSourceUpdateMode.Never, "0", "");
                    lblOrderCount.DataBindings.Add(OrderCount);
                    //Clear the Cart and Total Field
                    ClearList();
                }
            }
            else
            {
                MessageBox.Show("Cart is Empty", "Empty Cart", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearList()
        {
            Program.cartItems.Clear();
            Program.TotalCart();

            dataGridView1.Rows.Clear();
            lblTax.Text = "0.00";
            lblCartTotal.Text = "0.00";
            lblGrandTotal.Text = "0.00";
            lblCartTotal.DataBindings.Clear();
            lblGrandTotal.DataBindings.Clear();
            lblTax.DataBindings.Clear();

        }

        private void lblOrderCount_Click(object sender, EventArgs e)
        {
            if (!rdbOrder.Checked)
            {
                rdbOrder.Checked = true;
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
                BindOrders(false);
                IsOrder = true;
            }
        }

        private void rdbDelivery_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDelivery.Checked)
            {
                uc_CategoryMenu1.SetCurrentControlBtnName("");
                uc_CategoryMenu1.SelectedControls();
                BindOrders(true);
                IsOrder = true;
            }
        }

        private void ovalShape2_Click(object sender, EventArgs e)
        {
            ClearList();
        }

        public void BindOrders(bool? IsOrderConfirmed = null)
        {
            flyLayout.Controls.Clear();
            int Count = Program.PlacedOrders.Where(p => IsOrderConfirmed == null ? true : p.IsOrderConfirmed == IsOrderConfirmed.Value).Count();
            if (Count > 0)
            {
                uc_ConfirmOrder uc = new uc_ConfirmOrder();
                uc.Width = flyLayout.Width - 15;
                uc.Height = flyLayout.Height - 15;
                uc.BindData(IsOrderConfirmed);
                this.flyLayout.Controls.Add(uc);
            }
        }

        public void BindReservations()
        {
            flyLayout.Controls.Clear();
            uc_ConfirmOrder uc = new uc_ConfirmOrder();
            uc.Width = flyLayout.Width - 15;
            uc.Height = flyLayout.Height - 15;
            uc.BindReservations();
            this.flyLayout.Controls.Add(uc);
        }

        private void rdbProducts_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbProducts.Checked)
                BindProducts();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (!IsOrder)
            {
                uc_CategoryMenu1.SetCurrentControlBtnName("All");
                uc_CategoryMenu1.SelectedControls();
                BindProducts();
            }
            else
            {

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
    }
}
