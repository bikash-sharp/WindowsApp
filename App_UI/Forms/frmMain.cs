using App_BAL;
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

            PictureBox pic = new PictureBox();
            pic.Name = "pic_" + itm.ProductID;
            pic.Image = global::App_UI.Properties.Resources.IMG_NotFound;
            pic.Width = 200;
            pic.Height = 130;
            pic.Location = new Point(0, 0);
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.Click += pnl_Click;
            pic.Tag = itm;
            pnl.Controls.Add(pic);

            Label lblName = new Label();
            lblName.Name = "lblProductName_" + itm.ProductID;
            lblName.Text = itm.ProductName + " (RS - " + itm.Price + ")";
            lblName.Location = new Point(5, pic.Height + 10);
            lblName.AutoSize = false;
            lblName.Width = pnl.Width - 10;
            lblName.Height = 50;
            lblName.Font = new Font("Segoe UI", 12, FontStyle.Italic);
            lblName.Click += pnl_Click;
            lblName.Tag = itm;
            pnl.Controls.Add(lblName);

            pnl.Click += pnl_Click;
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
                ListViewItem itm = new ListViewItem(prod.ProductName.ToString());
                itm.SubItems.Add(prod.Price.ToString("N"));
                itm.Tag = prod;
                lstCart.Items.Add(itm);
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            BindProducts(SelectedCategoryID, txtSearch.Text.Trim());
        }
    }
}
