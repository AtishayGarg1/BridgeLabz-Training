using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Constructors
{
    internal class ProductInventory
    {
        // Instance variables
        public string productName;
        public int price;

        // Static variable to track total products
        public static int totalProducts;

        // Constructor
        public ProductInventory(string productName, int price)
        {
            this.productName = productName;
            this.price = price;
            totalProducts++;
        }

        // Static method to display total product count
        public static void DisplayTotalProducts()
        {
            Console.WriteLine("Total Products are: " + totalProducts);
        }

        // Method to display product details
        public void DisplayProduct()
        {
            Console.WriteLine("Product: " + productName);
            Console.WriteLine("Price: " + price);
        }
    }

    // Main execution class
    class run
    {
        static void Main(string[] args)
        {
            ProductInventory obj = new("Laptop", 59999);
            obj.DisplayProduct();

            ProductInventory obj1 = new("Pc", 89999);
            obj1.DisplayProduct();

            ProductInventory obj2 = new("Groccery", 800);
            obj2.DisplayProduct();

            ProductInventory obj3 = new("Snacks", 2000);
            obj3.DisplayProduct();

            ProductInventory.DisplayTotalProducts();
        }
    }
}
