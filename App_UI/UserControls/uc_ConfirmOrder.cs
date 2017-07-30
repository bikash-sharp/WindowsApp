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

namespace App_UI.UserControls
{
    public partial class uc_ConfirmOrder : UserControl
    {
        public uc_ConfirmOrder()
        {
            InitializeComponent();
        }

        public void BindData(bool? IsOrderConfirmed = null)
        {
            var OrderLst = Program.PlacedOrders.Where(p=> IsOrderConfirmed== null ? true : p.IsOrderConfirmed == IsOrderConfirmed.Value).ToList();
            var source = new BindingSource(OrderLst, null);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = source;
            dataGridView1.ClearSelection();
            //var OrderLst = Program.PlacedOrders.Where(p => p.IsOrderConfirmed == false).ToList();
            //dataGridView1.Width = this.Width-20;
            //dataGridView1.Height = this.Height - 100;
            //flyLayout.Controls.Clear();
            //foreach (var itm in OrderLst)
            //{
            //    CreateControl(itm);
            //}
        }

        private void CreateControl(App_BAL.CartCL itm)
        {
            Panel pnl = new Panel();
            pnl.Height = 60;
            //pnl.Width = flyLayout.Width - 10;
            pnl.BackColor = Color.LightGray;

            Label lbl = new Label();
            lbl.Text = itm.OrderNo;
            lbl.AutoSize = false;
            lbl.Height = 50;
            lbl.Width = 200;
            lbl.Location = new Point(10, 5);
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            pnl.Controls.Add(lbl);

            Button btn = new Button();
            if(itm.IsOrderConfirmed)
            {
                btn.Text = "Delivered";                
                btn.Enabled = false;
            }
            else
            {
                btn.Text = "Confirm";
                btn.Click += btn_Click;
            }
            btn.Location = new Point(pnl.Width - 130, 15);
            btn.Font = new Font("Segoe UI Semilight", 12, FontStyle.Bold);
            btn.Tag = itm.OrderNo;
            btn.Height = 35;
            btn.Width = 120;
            btn.Cursor = Cursors.Hand;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderColor = Color.FromArgb(251, 51, 51);
            btn.FlatAppearance.BorderSize = 2;
            btn.FlatAppearance.MouseOverBackColor = Color.White;
            btn.FlatAppearance.MouseDownBackColor = Color.White;
            pnl.Controls.Add(btn);

            //flyLayout.Controls.Add(pnl);
        }

        void btn_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                var OrderNo = (sender as Button).Tag.ToString();
                var itm = Program.PlacedOrders.Where(p => p.OrderNo == OrderNo).FirstOrDefault();
                if (itm != null)
                {
                    string URL = Program.BaseUrl;
                    string ChangeOrdStatusURL = URL + "/confirmorder?order_id=" + OrderNo + "&order_status=completed&acess_token=" + Program.Token;

                    var GetStatus = DataProviderWrapper.Instance.GetData(ChangeOrdStatusURL, Verbs.GET, "");
                    JavaScriptSerializer serializer = new JavaScriptSerializer();
                    var result = serializer.Deserialize<MessageCL>(GetStatus);
                    itm.IsOrderConfirmed = true;
                    BindData(false);
                    Program.OrderCount();
                }
            }
        }
    }
}
