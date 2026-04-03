using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphism_abstraction.e_commerce_platform
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Electronics laptop = new Electronics();
            laptop.ProductId1 = 101;
            laptop.ProductName1 = "Laptop";
            laptop.ProductPrice1 = 60000;

            Clothing shirt = new Clothing();
            shirt.ProductId1 = 102;
            shirt.ProductName1 = "Shirt";
            shirt.ProductPrice1 = 2000;

            Grocery rice = new Grocery();
            rice.ProductId1 = 103;
            rice.ProductName1 = "Rice";
            rice.ProductPrice1 = 1200;

            Product[] products = new Product[3];
            products[0] = laptop;
            products[1] = shirt;
            products[2] = rice;

            BillingService.PrintFinalPrices(products);
        }
    }
}
