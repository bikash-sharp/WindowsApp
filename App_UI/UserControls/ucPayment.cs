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
            ChangeColorSelectedButton(btnCash);
            
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            if(PayementType == EmPaymentType.Cash)
            {
                double PaidAmount = 0;
                double.TryParse(txtAmount.Text, out PaidAmount);
                RemAmount = PaidAmount - TotalAmount;
                lblRem.Text = "Balance : " + RemAmount.ToString("N");
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            bool IsDone = false;
            if(PayementType == EmPaymentType.Cash)
            {
                if (RemAmount < 0)
                {
                    MessageBox.Show("Payment not complete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    IsDone = true;
                }
            }
            else if(PayementType == EmPaymentType.Wallet)
            {
                if (txtAmount.TextLength <= 0)
                {
                    MessageBox.Show("Please enter the Transaction Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Verify the transaction Id here
                    IsDone = true;
                }
            }
            else
            {
                IsDone = true;
            }
            
            if(IsDone)
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
            ChangeColorSelectedButton(btnCash);
            txtAmount.Text = "";
            txtAmount.PlaceholderText = "Cash Amount";
            PayementType = EmPaymentType.Cash;
            pnlCash.BringToFront();
        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            ChangeColorSelectedButton(btnCard);
            txtAmount.Text = TotalAmount.ToString("N");
            PayementType = EmPaymentType.Card;
            pnlCard.BringToFront();
        }

        public void ChangeColorSelectedButton(Button btn)
        {
            if(btn != null)
            {
                String Name = btn.Name;
                btnCash.BackColor = btnCard.BackColor = btnWallet.BackColor = Color.White;
                btnCash.FlatAppearance.MouseOverBackColor = btnCard.FlatAppearance.MouseOverBackColor = btnWallet.FlatAppearance.MouseOverBackColor = Color.White;
                rectBtnCard.BackColor = Color.White;
                rectbtnCash.BackColor = Color.White;
                rectBtnWallet.BackColor = Color.White;
                switch (Name)
                {
                    case "btnCard":
                        rectBtnCard.BackColor = Color.FromArgb(93, 213, 93);
                        btn.BackColor = Color.FromArgb(93, 213, 93);
                        btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(93, 213, 93);
                        btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(93, 213, 93);
                        break;
                    case "btnCash":
                        rectbtnCash.BackColor = Color.FromArgb(93, 213, 93);
                        btn.BackColor = Color.FromArgb(93, 213, 93);
                        btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(93, 213, 93);
                        btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(93, 213, 93);
                        break;
                    case "btnWallet":
                        rectBtnWallet.BackColor = Color.FromArgb(93, 213, 93);
                        btn.BackColor = Color.FromArgb(93, 213, 93);
                        btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(93, 213, 93);
                        btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(93, 213, 93);
                        break;
                    default :
                        btnCash.BackColor = Color.FromArgb(93, 213, 93);

                        rectBtnCard.BackColor = Color.FromArgb(93, 213, 93);
                        break; 
                }
                
            }
        }

        private void btnWallet_Click(object sender, EventArgs e)
        {
            ChangeColorSelectedButton(btnWallet); txtAmount.Text = "";
            txtAmount.PlaceholderText = "Transaction Number";
            PayementType = EmPaymentType.Wallet;
            pnlCash.BringToFront();
        }
    }
}
