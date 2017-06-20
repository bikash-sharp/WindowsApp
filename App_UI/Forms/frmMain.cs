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
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            uc_CategoryMenu1.EventCategoryClicked += uc_CategoryMenu1_EventCategoryClicked;
        }

        void uc_CategoryMenu1_EventCategoryClicked(object sender, EventArgs e)
        {
            int CategoryID = 0;
            if (sender != null)
            {
                int.TryParse(sender.ToString(), out CategoryID);
                BindProducts(CategoryID);
            }
        }

        private void BindProducts(int CategoryID)
        {
            var prods = Program.Products.Where(p => (CategoryID == 0 ? true : p.CategoryID == CategoryID)).ToList();

            foreach (var itm in prods)
            {
                CreateProdButtons(itm);
            }
        }

        private void CreateProdButtons(ProductListCL itm)
        {

        }

        private void tblMainLayout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
