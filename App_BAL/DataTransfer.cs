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
        public string FoodType { get; set; }
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

    public enum Verbs
    {
        GET,
        POST,
        PUT
    }

    public class MessageCL
    {
        public bool status { get; set; }
        public string message { get; set; }
    }

    public class LoginCL
    {
        public bool status { get; set; }
        public string data { get; set; }
        public string message { get; set; }
    }

    public class CategoryCL
    {
        public bool status { get; set; }
        public Object data { get; set; }
        public string message { get; set; }
    }

    public class ProductCL
    {
        public string id { get; set; }
        public string restaurent_id { get; set; }
        public string tanent_id { get; set; }
        public string product_name { get; set; }
        public string product_price { get; set; }
        public string food_type { get; set; }
        public string description { get; set; }
        public string product_image { get; set; }
        public string created { get; set; }
        public string order_type { get; set; }
        public string product_code { get; set; }
    }

    public class RestaurantCL
    {
        public string id { get; set; }
        public string tanent_id { get; set; }
        public string restaurant_name { get; set; }
        public string restaurant_type { get; set; }
        public string location { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string min_item_price { get; set; }
        public string min_order_price { get; set; }
        public string order_type { get; set; }
        public string shipping_charge { get; set; }
        public string delivery_time { get; set; }
        public string delivery_format { get; set; }
        public string payment_types { get; set; }
        public string restaurant_image { get; set; }
        public string created { get; set; }
        public string delivery_hours { get; set; }
        public string reserve_table { get; set; }
        public string closing_day { get; set; }
        public object supported_payment_types { get; set; }
        public object ref_url { get; set; }
    }

    public class Datum
    {
        public ProductCL Product { get; set; }
        public RestaurantCL Restaurant { get; set; }
        public List<object> Productimage { get; set; }
    }

    public class ProductListAPICL
    {
        public bool status { get; set; }
        public List<Datum> data { get; set; }
        public string message { get; set; }
    }
}
