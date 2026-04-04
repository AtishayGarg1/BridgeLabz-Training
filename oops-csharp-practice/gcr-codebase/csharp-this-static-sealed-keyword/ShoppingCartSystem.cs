using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.thisstatic
{
    internal class ShoppingCartSystem
    {
        // Static variable
        public static double discount = 10.0;

        // Readonly variable
        public readonly int productId;

        // Instance variables
        public string productName;
        public double price;
        public int quantity;

        // Constructor using this keyword
        public ShoppingCartSystem(int productId, string productName, double price, int quantity)
        {
            this.productId = productId;
            this.productName = productName;
            this.price = price;
            this.quantity = quantity;
        }

        // Static method to update discount
        public static void UpdateDiscount(double newDiscount)
        {
            discount = newDiscount;
        }

        // Display product details using is operator
        public void DisplayDetails(object obj)
        {
            if (obj is ShoppingCartSystem)
            {
                Console.WriteLine("Product ID   : " + productId);
                Console.WriteLine("Product Name : " + productName);
                Console.WriteLine("Price        : " + price);
                Console.WriteLine("Quantity     : " + quantity);
                Console.WriteLine("Discount (%) : " + discount);
            }
            else
            {
                Console.WriteLine("Invalid product object");
            }
        }
    }

    class run
    {
        //Main method for execution
        static void Main(string[] args)
        {
            ShoppingCartSystem.UpdateDiscount(15);

            ShoppingCartSystem p1 = new (201, "Laptop", 75000, 1);
            p1.DisplayDetails(p1);
        }
    }
}
