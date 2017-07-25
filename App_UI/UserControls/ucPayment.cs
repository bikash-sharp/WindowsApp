using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App_BAL;

namespace App_UI.UserControls
{
    public partial class ucPayment : UserControl
    {
        public double TotalAmount = 0;
        public double RemAmount = 0;
        public EmPaymentType PayementType = EmPaymentType.Cash;
        public ucPayment()
        {
            InitializeComponent();
            
        }

        public void BindData(double _Amount)
        {
            TotalAmount = _Amount;
            lblTotal.Text = _Amount.ToString("N");
            RemAmount = 0 - _Amount;
            lblRem.Text = "Balance : " + RemAmount.ToString("N");
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            double PaidAmount = 0;
            double.TryParse(txtAmount.Text, out PaidAmount);
            RemAmount = PaidAmount - TotalAmount;
            lblRem.Text = "Balance : " + RemAmount.ToString("N");
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (RemAmount < 0)
            {
                MessageBox.Show("Payment not complete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (this.ParentForm.Modal)
                {
                    this.ParentForm.DialogResult = DialogResult.OK;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (this.ParentForm.Modal)
            {
                this.ParentForm.DialogResult = DialogResult.Cancel;
            }
        }

        private void btnExactAmount_Click(object sender, EventArgs e)
        {

        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            txtAmount.Text = "";
            PayementType = EmPaymentType.Card;
            pnlCash.BringToFront();
        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            txtAmount.Text = TotalAmount.ToString("N");
            PayementType = EmPaymentType.Cash;
            pnlCard.BringToFront();
        }
    }
}
