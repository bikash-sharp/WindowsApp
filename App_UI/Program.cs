using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using App_UI.Forms;
using App_BAL;

namespace App_UI
{
    static class Program
    {
        public static List<CategoryListCL> Categories = new List<CategoryListCL>();
        public static List<ProductListCL> Products = new List<ProductListCL>();
        public static List<CartCL> PlacedOrders = new List<CartCL>();

        public const String BaseUrl = "http://202.75.42.25/index.php/restwebservices/";
        public static string Token { get; set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            BindData();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }

        public static void BindData()
        {
            CategoryListCL cl = new CategoryListCL();
            cl.CategoryID = 0;
            cl.CategoryName = "All";
            Categories.Add(cl);

            cl = new CategoryListCL();
            cl.CategoryID = 1;
            cl.CategoryName = "Burger";
            Categories.Add(cl);

            cl = new CategoryListCL();
            cl.CategoryID = 2;
            cl.CategoryName = "Sandwich";
            Categories.Add(cl);

            cl = new CategoryListCL();
            cl.CategoryID = 3;
            cl.CategoryName = "Pizza";
            Categories.Add(cl);

            cl = new CategoryListCL();
            cl.CategoryID = 4;
            cl.CategoryName = "Ice Cream";
            Categories.Add(cl);

            cl = new CategoryListCL();
            cl.CategoryID = 5;
            cl.CategoryName = "Snacks";
            Categories.Add(cl);

            cl = new CategoryListCL();
            cl.CategoryID = 6;
            cl.CategoryName = "Pasta";
            Categories.Add(cl);

            cl = new CategoryListCL();
            cl.CategoryID = 7;
            cl.CategoryName = "Shakes";
            Categories.Add(cl);

            //----------- Cat-1
            ProductListCL pr = new ProductListCL();
            pr.CategoryID = 1;
            pr.ProductID = 1;
            pr.ProductName = "Aalo Tikki Burger";
            pr.ImageName = "";
            pr.Price = 40;
            Products.Add(pr);

            pr = new ProductListCL();
            pr.CategoryID = 1;
            pr.ProductID = 2;
            pr.ProductName = "Veggie Burger";
            pr.ImageName = "";
            pr.Price = 50;
            Products.Add(pr);

            pr = new ProductListCL();
            pr.CategoryID = 1;
            pr.ProductID = 3;
            pr.ProductName = "Cheese Burger";
            pr.ImageName = "";
            pr.Price = 55;
            Products.Add(pr);

            pr = new ProductListCL();
            pr.CategoryID = 1;
            pr.ProductID = 4;
            pr.ProductName = "Spicy Paneer Burger";
            pr.ImageName = "";
            pr.Price = 60;
            Products.Add(pr);

            pr = new ProductListCL();
            pr.CategoryID = 1;
            pr.ProductID = 5;
            pr.ProductName = "Jumbo Cheese Burger";
            pr.ImageName = "";
            pr.Price = 70;
            Products.Add(pr);

            //----------- Cat-2
            pr = new ProductListCL();
            pr.CategoryID = 2;
            pr.ProductID = 6;
            pr.ProductName = "Veg Grilled Sandwich";
            pr.ImageName = "";
            pr.Price = 50;
            Products.Add(pr);

            pr = new ProductListCL();
            pr.CategoryID = 2;
            pr.ProductID = 7;
            pr.ProductName = "Paneer Tikka Sanwich";
            pr.ImageName = "";
            pr.Price = 50;
            Products.Add(pr);

            pr = new ProductListCL();
            pr.CategoryID = 2;
            pr.ProductID = 8;
            pr.ProductName = "Spicy Mexican Sandwich";
            pr.ImageName = "";
            pr.Price = 50;
            Products.Add(pr);

            pr = new ProductListCL();
            pr.CategoryID = 2;
            pr.ProductID = 9;
            pr.ProductName = "Cheese Corn Sandwich";
            pr.ImageName = "";
            pr.Price = 55;
            Products.Add(pr);

            // Cat-3
            pr = new ProductListCL();
            pr.CategoryID = 3;
            pr.ProductID = 10;
            pr.ProductName = "Veggie Fresh";
            pr.ImageName = "";
            pr.Price = 80;
            Products.Add(pr);

            pr = new ProductListCL();
            pr.CategoryID = 3;
            pr.ProductID = 11;
            pr.ProductName = "Cheese Caps Onion";
            pr.ImageName = "";
            pr.Price = 90;
            Products.Add(pr);

            pr = new ProductListCL();
            pr.CategoryID = 3;
            pr.ProductID = 12;
            pr.ProductName = "Paneer Tikka";
            pr.ImageName = "";
            pr.Price = 100;
            Products.Add(pr);

            pr = new ProductListCL();
            pr.CategoryID = 3;
            pr.ProductID = 13;
            pr.ProductName = "Spicy Mexican";
            pr.ImageName = "";
            pr.Price = 100;
            Products.Add(pr);

            pr = new ProductListCL();
            pr.CategoryID = 3;
            pr.ProductID = 14;
            pr.ProductName = "Cheese Corn";
            pr.ImageName = "";
            pr.Price = 110;
            Products.Add(pr);

            pr = new ProductListCL();
            pr.CategoryID = 3;
            pr.ProductID = 15;
            pr.ProductName = "Mushroom Veg Cheese";
            pr.ImageName = "";
            pr.Price = 110;
            Products.Add(pr);

            // Cat-4
            pr = new ProductListCL();
            pr.CategoryID = 4;
            pr.ProductID = 16;
            pr.ProductName = "Vanilla";
            pr.ImageName = "";
            pr.Price = 30;
            Products.Add(pr);

            pr = new ProductListCL();
            pr.CategoryID = 4;
            pr.ProductID = 17;
            pr.ProductName = "ButterScotch";
            pr.ImageName = "";
            pr.Price = 30;
            Products.Add(pr);

            pr = new ProductListCL();
            pr.CategoryID = 4;
            pr.ProductID = 18;
            pr.ProductName = "Chocolate";
            pr.ImageName = "";
            pr.Price = 30;
            Products.Add(pr);

            // Cat-5
            pr = new ProductListCL();
            pr.CategoryID = 5;
            pr.ProductID = 19;
            pr.ProductName = "French Fries";
            pr.ImageName = "";
            pr.Price = 50;
            Products.Add(pr);

            pr = new ProductListCL();
            pr.CategoryID = 5;
            pr.ProductID = 20;
            pr.ProductName = "Masala Fries";
            pr.ImageName = "";
            pr.Price = 60;
            Products.Add(pr);

            pr = new ProductListCL();
            pr.CategoryID = 5;
            pr.ProductID = 21;
            pr.ProductName = "Nuggets";
            pr.ImageName = "";
            pr.Price = 80;
            Products.Add(pr);

            pr = new ProductListCL();
            pr.CategoryID = 5;
            pr.ProductID = 22;
            pr.ProductName = "Veg Fingers";
            pr.ImageName = "";
            pr.Price = 70;
            Products.Add(pr);

            pr = new ProductListCL();
            pr.CategoryID = 5;
            pr.ProductID = 23;
            pr.ProductName = "Cheese Shots";
            pr.ImageName = "";
            pr.Price = 90;
            Products.Add(pr);

            // Cat-6

            pr = new ProductListCL();
            pr.CategoryID = 6;
            pr.ProductID = 24;
            pr.ProductName = "Veg Sauce";
            pr.ImageName = "";
            pr.Price = 80;
            Products.Add(pr);

            pr = new ProductListCL();
            pr.CategoryID = 6;
            pr.ProductID = 25;
            pr.ProductName = "White Sauce";
            pr.ImageName = "";
            pr.Price = 80;
            Products.Add(pr);

            pr = new ProductListCL();
            pr.CategoryID = 6;
            pr.ProductID = 26;
            pr.ProductName = "Spicy Mexican";
            pr.ImageName = "";
            pr.Price = 80;
            Products.Add(pr);

            // Cat-7

            pr = new ProductListCL();
            pr.CategoryID = 7;
            pr.ProductID = 27;
            pr.ProductName = "Mango Shake";
            pr.ImageName = "";
            pr.Price = 40;
            Products.Add(pr);

            pr = new ProductListCL();
            pr.CategoryID = 7;
            pr.ProductID = 28;
            pr.ProductName = "Banana Shake";
            pr.ImageName = "";
            pr.Price = 30;
            Products.Add(pr);

            pr = new ProductListCL();
            pr.CategoryID = 7;
            pr.ProductID = 29;
            pr.ProductName = "Strawberry Shake";
            pr.ImageName = "";
            pr.Price = 50;
            Products.Add(pr);

            pr = new ProductListCL();
            pr.CategoryID = 7;
            pr.ProductID = 30;
            pr.ProductName = "Ice Tea";
            pr.ImageName = "";
            pr.Price = 30;
            Products.Add(pr);

            pr = new ProductListCL();
            pr.CategoryID = 7;
            pr.ProductID = 31;
            pr.ProductName = "Cold Coffee";
            pr.ImageName = "";
            pr.Price = 40;
            Products.Add(pr);
        }
    }
}
