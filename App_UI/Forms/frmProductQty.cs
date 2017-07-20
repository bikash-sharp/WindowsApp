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
    public partial class frmProductQty : Form
    {
        public int ProductId = 0;
        public frmProductQty()
        {
            InitializeComponent();
        }

        private void frmProductQty_Load(object sender, EventArgs e)
        {
            int ProductId = Program.SelectedProductId;
            var SelectedProduct = Program.cartItems.Where(p => p.ProductID == ProductId).FirstOrDefault();
            if(SelectedProduct != null)
            {
                lblProductName.Text = SelectedProduct.ProductName;
                txtQty.Text = SelectedProduct.Quantity.ToString();
            }
        }

        private void btnUpdateQty_Click(object sender, EventArgs e)
        {
            int ProductId = Program.SelectedProductId;
            int Quantity = 0;
            var SelectedProduct = Program.cartItems.Where(p => p.ProductID == ProductId).FirstOrDefault();
            if (SelectedProduct != null)
            {
                int.TryParse(txtQty.Text.ToString(), out Quantity);
                SelectedProduct.Quantity = Quantity;
                SelectedProduct.Price = Convert.ToDouble(SelectedProduct.Price) * SelectedProduct.Quantity;
                //Reset the SelectProductId
                Program.SelectedProductId = 0;
            }

            this.Close();
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            int ProductId = Program.SelectedProductId;
            var SelectedProduct = Program.cartItems.Where(p => p.ProductID == ProductId).FirstOrDefault();
            if (SelectedProduct != null)
            {
                Program.cartItems.Remove(SelectedProduct);                
                //Reset the SelectProductId
                Program.SelectedProductId = 0;
            }

            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
