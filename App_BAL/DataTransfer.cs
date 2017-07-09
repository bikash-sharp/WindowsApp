using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_BAL
{
    public class DataTransfer
    {

    }


    public enum EmOrderType
    {
        TakeAway = 1,
        Delivery = 2
    }
    public enum EmPaymentType
    {
        Cash = 1,
        Card = 2
    }
    public class CartCL
    {
        public int SrNo { get; set; }
        public int OrderID { get; set; }
        public string OrderNo { get; set; }
        public EmOrderType OrderType { get; set; }
        public List<CartItemsCL> Items { get; set; }
        public bool IsOrderConfirmed { get; set; }
        public EmPaymentType PaymentType { get; set; }
    }

    public class CartItemsCL
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int CategoryID { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }

    public class CategoryListCL
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
    }

    public class ProductListCL
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int CategoryID { get; set; }
        public string ImageName { get; set; }
    }
}
