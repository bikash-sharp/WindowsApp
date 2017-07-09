using App_BAL;
using App_UI.UserControls;
using CustomServerControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_UI.Forms
{
    public partial class frmMain : Form
    {
        List<CartItemsCL> cartItems = new List<CartItemsCL>();
        public static bool IsClosed = false;
        public int SelectedCategoryID = 0;
        public frmMain()
        {
            InitializeComponent();
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
            BindProducts(0);

        }

        void uc_CategoryMenu1_EventCategoryClicked(object sender, EventArgs e)
        {
            SelectedCategoryID = 0;
            if (sender != null)
            {
                int.TryParse(sender.ToString(), out SelectedCategoryID);
                BindProducts(SelectedCategoryID);
            }
        }

        private void BindProducts(int CategoryID, string SearchText = "")
        {
            var prods = Program.Products.Where(p => (CategoryID == 0 ? true : p.CategoryID == CategoryID)
                & (SearchText != "" ? p.ProductName.ToLower().Contains(SearchText.ToLower()) : true)).ToList();

            flyLayout.Controls.Clear();
            foreach (var itm in prods)
            {
                CreateProdButtons(itm);
            }

        }

        private void CreateProdButtons(ProductListCL itm)
        {
            Panel pnl = new Panel();

            pnl.Name = "pnl_" + itm.ProductID;
            pnl.Width = 200;
            pnl.Height = 200;
            pnl.Tag = itm;
            pnl.BorderStyle = BorderStyle.FixedSingle;
            pnl.Cursor = Cursors.Hand;


            PictureBox pic = new PictureBox();
            pic.Name = "pic_" + itm.ProductID;
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
            lblName.Name = "lblProductName_" + itm.ProductID;
            lblName.Text = itm.ProductName + Environment.NewLine + "MYR - " + itm.Price;
            lblName.Location = new Point(5, pic.Height + 5);
            lblName.AutoSize = false;
            lblName.Width = pnl.Width - 10;
            lblName.Height = 50;
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
            ProductListCL prod = new ProductListCL();
            if (sender is Panel)
            {
                prod = (ProductListCL)(sender as Panel).Tag;
            }
            else if (sender is Label)
            {
                prod = (ProductListCL)(sender as Label).Tag;
            }
            else if (sender is PictureBox)
            {
                prod = (ProductListCL)(sender as PictureBox).Tag;
            }
            if (prod != null)
            {
                CartItemsCL cl = new CartItemsCL();
                bool IsNew = false;
                if (cartItems.Count > 0)
                {
                    cl = cartItems.Where(p => p.ProductID == prod.ProductID).FirstOrDefault();
                    if(cl != null)
                    {
                        cl.Quantity += 1;
                        cl.Price = prod.Price * cl.Quantity;
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
                    cl.ProductID = prod.ProductID;
                    cl.CategoryID = prod.CategoryID;
                    cl.Price = prod.Price;
                    cl.Quantity = 1;
                    cl.ProductName = prod.ProductName;
                    cartItems.Add(cl);
                }

                BindCart(cartItems);
            }
        }

        private void BindCart(List<CartItemsCL> cartItems)
        {
            lstCart.Items.Clear();
            foreach (CartItemsCL cartItem in cartItems)
            {
                ListViewItem item = new ListViewItem(cartItem.ProductName.ToString());
                item.SubItems.Add(cartItem.Quantity.ToString());
                item.SubItems.Add("MYR " + cartItem.Price.ToString("N"));
                lstCart.Items.Add(item);
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
            BindProducts(SelectedCategoryID, txtSearch.Text.Trim());
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            TxtBox txtSearch = (TxtBox)sender;
            if (txtSearch != null)
            {
                if (e.KeyChar == (char)Keys.Return)
                {
                    BindProducts(SelectedCategoryID, txtSearch.Text.Trim());
                }
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (cartItems.Count > 0)
            {
                var TotalAmount = 0.0;  // Total Price
                TotalAmount = cartItems.Sum(p => p.Price);
                FrmContainer frm = new FrmContainer();
                ucPayment uc = new ucPayment();
                frm.Dock = DockStyle.Fill;
                uc.BindData(TotalAmount);
                frm.Width = uc.Width + 20; ;
                frm.Height = uc.Height + 40;
                frm.Controls.Add(uc);
                var dgRes = frm.ShowDialog();
                if (dgRes == System.Windows.Forms.DialogResult.OK)
                {
                    string OrderNumber = DateTime.UtcNow.Ticks.ToString();

                    CartCL cart = new CartCL();
                    cart.IsOrderConfirmed = false;
                    cart.OrderID = 0;
                    cart.OrderNo = OrderNumber;
                    if (rdbDelivery.Checked)
                    {
                        cart.OrderType = EmOrderType.Delivery;
                    }
                    else
                    {
                        cart.OrderType = EmOrderType.TakeAway;
                    }
                    cart.PaymentType = uc.PayementType;
                    cart.Items = cartItems;
                    MessageBox.Show("Order Number : " + OrderNumber + " has been placed successfully", " Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Program.PlacedOrders.Add(cart);

                    lblOrderCount.Text = Program.PlacedOrders.Where(p => p.IsOrderConfirmed == false).Count().ToString();

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
            cartItems = new List<CartItemsCL>();
            lstCart.Items.Clear();
        }

        private void lblOrderCount_Click(object sender, EventArgs e)
        {
            if (Program.PlacedOrders.Where(p => p.IsOrderConfirmed == false).Count() > 0)
            {
                FrmContainer frm = new FrmContainer();
                uc_ConfirmOrder uc = new uc_ConfirmOrder();
                frm.Dock = DockStyle.Fill;
                uc.BindData();
                frm.Width = uc.Width + 20; ;
                frm.Height = uc.Height + 40;
                frm.Controls.Add(uc);
                frm.ShowDialog();
                lblOrderCount.Text = Program.PlacedOrders.Where(p => p.IsOrderConfirmed == false).Count().ToString();

            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstCart.SelectedItems.Count > 0)
            {
                var item = lstCart.SelectedItems[0];
                ProductListCL prod = (ProductListCL)item.Tag;
                var itm = cartItems.Where(p => p.ProductID == prod.ProductID && p.CategoryID == prod.CategoryID && p.Price == prod.Price).FirstOrDefault();
                if (itm != null)
                {
                    cartItems.Remove(itm);
                    lstCart.Items.Remove(item);
                }
            }
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearList();
        }
    }
}
