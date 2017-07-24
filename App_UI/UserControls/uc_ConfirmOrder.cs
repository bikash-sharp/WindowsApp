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

        public void BindData()
        {
            var OrderLst = Program.PlacedOrders.Where(p => p.IsOrderConfirmed == false).ToList();
            flyLayout.Controls.Clear();
            foreach (var itm in OrderLst)
            {
                CreateControl(itm);
            }
        }

        private void CreateControl(App_BAL.CartCL itm)
        {
            Panel pnl = new Panel();
            pnl.Height = 60;
            pnl.Width = flyLayout.Width - 5;
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
            btn.Text = "Confirm";
            btn.Location = new Point(pnl.Width - 130, 15);
            btn.Tag = itm.OrderNo;
            btn.Click += btn_Click;
            btn.FlatStyle = FlatStyle.Flat;
            btn.Height = 35;
            btn.Width = 120;
            pnl.Controls.Add(btn);

            flyLayout.Controls.Add(pnl);
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
                    BindData();
                }
            }
        }
    }
}
