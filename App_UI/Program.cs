using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BestariTerrace.Forms;
using App_BAL;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing.Printing;
using System.Management;

namespace BestariTerrace
{
    static class Program
    {
        //public static string PrinterName
        //{
        //    get {
        //        PrinterSettings _printerSettings = new PrinterSettings();
        //        return String.Format(@"\\{0}\{1}",Environment.MachineName, _printerSettings.PrinterName); }
        //}

        //public static string[] Printers
        //{
        //    get
        //    {
        //        return new string[] { "192.168.20.5", "192.168.1.200" };
        //    }
        //}
        public static StoreDetails StoreInfo = new StoreDetails();
        public static List<CategoryListCL> Categories = new List<CategoryListCL>();
        public static List<ProductListCL> Products = new List<ProductListCL>();

        public static List<CartCL> PlacedOrders = new List<CartCL>();
        public static List<ReservationCL> Reservations = new List<ReservationCL>();
        public static BindingList<CartItemsCL> cartItems = new BindingList<CartItemsCL>();
        public static List<CartItemsCL> PlacedCartItems = new List<CartItemsCL>();
        public static BindingList<CalculateCart> cartTotal = new BindingList<CalculateCart>();
        public const String BaseUrl = "http://202.75.42.25/index.php/restwebservices/";
        public const String ProductImagesLoc = "http://202.75.42.25/app/webroot/images/uploads/product_images/";
        public const String StoreImagesLoc = "http://202.75.42.25/app/webroot/images/uploads/restaurants_images/";
        public static string SessionId { get; set; }
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

        public static void OrderCount(EmOrderType _OrderType)
        {
            OrderBindings.OrderCount = Reservations.Where(p => p.ActionText.ToLower().Trim() != "assigned").Count();
            var SumConfirmed = PlacedOrders.Where(p => p.OrderType == _OrderType).Sum(p => double.Parse(p.OrderTotal)); //p.IsOrderConfirmed == true &&
            var SumUncofirmed = PlacedOrders.Where(p => p.IsOrderConfirmed == false && p.OrderType == _OrderType).Sum(p => double.Parse(p.OrderTotal));
            if(_OrderType == EmOrderType.Delivery)
            {
                OrderBindings.SumDeliveryConfirmedAmountTotal = double.Parse(SumConfirmed.ToString());
                OrderBindings.SumDeliveryUnconfirmedAmountTotal = double.Parse(SumUncofirmed.ToString());
            }
            else if(_OrderType == EmOrderType.DineIn)
            {
                OrderBindings.SumDineInConfirmedAmountTotal = double.Parse(SumConfirmed.ToString());
                OrderBindings.SumDineInUnconfirmedAmountTotal = double.Parse(SumUncofirmed.ToString());
            }
            else if(_OrderType == EmOrderType.Reservation)
            {
                OrderBindings.SumReservationConfirmedAmountTotal = double.Parse(SumConfirmed.ToString());
                OrderBindings.SumReservationUnconfirmedAmountTotal = double.Parse(SumUncofirmed.ToString());
            }
            else if(_OrderType == EmOrderType.TakeOut)
            {
                OrderBindings.SumTakeAwayConfirmedAmountTotal = double.Parse(SumConfirmed.ToString());
                OrderBindings.SumTakeAwayUnconfirmedAmountTotal = double.Parse(SumUncofirmed.ToString());
            }
            
        }
        
    }
}
