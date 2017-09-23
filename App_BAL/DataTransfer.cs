﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace App_BAL
{
    public class DataTransfer
    {

    }

    public enum EmOrderStatus
    {
        Pending = 1,
        Confirmed = 2,
        Delivered = 3
    }
    public enum EmOrderType
    {
        TakeOut = 1,
        Delivery = 2,
        DineIn=3,
        Reservation=4
    }
    public enum EmPaymentType
    {
        Cash = 1,
        Card = 2,
        Wallet=3
    }

    public enum EmGridType
    {
        Reservation,
        OrderIn,
        Delivery
    }
    public class ReservationCL : INotifyPropertyChanged
    {
        private string ReservationStatusValue;
        public string TableId { get; set; }
        public string RestrauntId { get; set; }
        public string DinerName { get; set; }
        public string MobileNo { get; set; }
        public string ReservationDate { get; set; }
        public string GuestCount { get; set; }
        public string ReservationStatus {
            get
            {
                return this.ReservationStatusValue;
            }
            set
            {
                if (value != this.ReservationStatusValue)
                {
                    this.ReservationStatusValue = value;
                    this.NotifyPropertyChanged();
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
    public class CartCL
    {
        public int SrNo { get; set; }
        public int OrderID { get; set; }
        public string OrderNo { get; set; }
        public string OrderTotal { get; set; }
        public EmOrderType OrderType { get; set; }
        public BindingList<CartItemsCL> Items { get; set; }
        public bool IsOrderConfirmed { get; set; }
        public EmOrderStatus OrderStatus { get; set; }
        public EmPaymentType PaymentType { get; set; }
        public CartCL()
        {
            Items = new BindingList<CartItemsCL>();
        }
    }

    public class PlaceOrderBinding : INotifyPropertyChanged
    {
        private int _orderCount=0;
        private double _sumConfirmedAmountTotal = 0.00;
        private double _sumUnconfirmedAmountTotal = 0.00;
        public int OrderCount
        {
            get
            {
                return this._orderCount;
            }
            set
            {
                if (value != this._orderCount)
                {
                    this._orderCount = value;
                    this.NotifyPropertyChanged();
                }
            }
        }

        public double SumConfirmedAmountTotal
        {
            get
            {
                return this._sumConfirmedAmountTotal;
            }
            set
            {
                if (value != this._sumConfirmedAmountTotal)
                {
                    this._sumConfirmedAmountTotal = value;
                    this.NotifyPropertyChanged();
                }
            }
        }

        public double SumUnconfirmedAmountTotal
        {
            get
            {
                return this._sumUnconfirmedAmountTotal;
            }
            set
            {
                if (value != this._sumUnconfirmedAmountTotal)
                {
                    this._sumUnconfirmedAmountTotal = value;
                    this.NotifyPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    public class CartItemsCL : INotifyPropertyChanged
    {
        private int QuantityValue = 0;
        private double PriceValue = 0;
        private double CartTotalValue = 0;
        private double GrandTotalValue = 0;
        private double TaxValue = 0;
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int CategoryID { get; set; }
        public string FoodType { get; set; }
        public double OriginalPrice { get; set; }
        public double Price {
            get
            {
                return this.PriceValue;
            }
            set {
                if (value != this.PriceValue)
                {
                    this.PriceValue = value;
                    this.NotifyPropertyChanged();
                }
            }
        }
        public int Quantity {
            get {
                return this.QuantityValue;
            }
            set {
                if(value != this.QuantityValue)
                {
                    this.QuantityValue = value;
                    this.NotifyPropertyChanged();
                }
            }
        }

         
        public double CartTotal
        {
            get
            {
                return this.CartTotalValue;
            }
            set
            {
                if (value != this.CartTotalValue)
                {
                    this.CartTotalValue = value;
                    this.NotifyPropertyChanged();
                }
            }
        }

        public double GrandTotal
        {
            get
            {
                return this.GrandTotalValue;
            }
            set
            {
                if (value != this.GrandTotalValue)
                {
                    this.GrandTotalValue = value;
                    this.NotifyPropertyChanged();
                }
            }
        }


        public double Tax
        {
            get
            {
                return this.TaxValue;
            }
            set
            {
                if (value != this.TaxValue)
                {
                    this.TaxValue = value;
                    this.NotifyPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName="")
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    public class CalculateCart : INotifyPropertyChanged
    {
        private double CartTotalValue = 0;
        private double GrandTotalValue = 0;
        private double TaxValue = 0;
        public double CartTotal
        {
            get
            {
                return this.CartTotalValue;
            }
            set
            {
                if (value != this.CartTotalValue)
                {
                    this.CartTotalValue = value;
                    this.NotifyPropertyChanged();
                }
            }
        }

        public double GrandTotal
        {
            get
            {
                return this.GrandTotalValue;
            }
            set
            {
                if (value != this.GrandTotalValue)
                {
                    this.GrandTotalValue = value;
                    this.NotifyPropertyChanged();
                }
            }
        }


        public double Tax
        {
            get
            {
                return this.TaxValue;
            }
            set
            {
                if (value != this.TaxValue)
                {
                    this.TaxValue = value;
                    this.NotifyPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
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
        public Tableorder Tableorder { get; set; }
    }

    public class ProductListAPICL
    {
        public bool status { get; set; }
        public List<Datum> data { get; set; }
        public string message { get; set; }
    }

    public class Tableorder
    {
        public string id { get; set; }
        public string tanent_id { get; set; }
        public string restaurent_id { get; set; }
        public string user_id { get; set; }
        public string diner_name { get; set; }
        public string mobile { get; set; }
        public string email { get; set; }
        public string date { get; set; }
        public string from_time { get; set; }
        public string to_time { get; set; }
        public string guests { get; set; }
        public object special_request { get; set; }
        public string terms_cond { get; set; }
        public string status { get; set; }
        public string created { get; set; }
        public string bookingDate { get {
                return date + Environment.NewLine + from_time + " - " + to_time;
            } }
    }

    public class ReservationListAPICL
    {
        public bool status { get; set; }
        public List<Datum> data { get; set; }
    }

    public class TransactionAPICL
    {
        public bool status { get; set; }
        public string message { get; set; }
    }
}
