using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using App_UI.Forms;
using App_BAL;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace App_UI
{
    static class Program
    {
        public static List<CategoryListCL> Categories = new List<CategoryListCL>();
        public static List<ProductListCL> Products = new List<ProductListCL>();
        public static List<CartCL> PlacedOrders = new List<CartCL>();
        public static List<ReservationCL> Reservations = new List<ReservationCL>();
        public static BindingList<CartItemsCL> cartItems = new BindingList<CartItemsCL>();
        public static BindingList<CalculateCart> cartTotal = new BindingList<CalculateCart>();
        public const String BaseUrl = "http://202.75.42.25/index.php/restwebservices/";
        public static string Token { get; set; }
        public static int SelectedProductId { get; set;}
        public static PlaceOrderBinding OrderBindings = new PlaceOrderBinding();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //BindData();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
        public static void TotalCart()
        {
            foreach (var item in Program.cartItems)
            {
                item.CartTotal = Program.cartItems.Sum(p => p.Price);
                item.GrandTotal = Program.cartItems.Sum(p => p.Price);
            }

        }

        public static void OrderCount()
        {
            OrderBindings.OrderCount = PlacedOrders.Where(p => p.IsOrderConfirmed == false).Count();
            var SumConfirmed = PlacedOrders.Where(p => p.IsOrderConfirmed == true).Sum(p => double.Parse(p.OrderTotal));
            var SumUncofirmed = PlacedOrders.Where(p => p.IsOrderConfirmed == false).Sum(p => double.Parse(p.OrderTotal));
            OrderBindings.SumConfirmedAmountTotal = double.Parse(SumConfirmed.ToString());
            OrderBindings.SumUnconfirmedAmountTotal = double.Parse(SumUncofirmed.ToString());
        }
        
    }
}
