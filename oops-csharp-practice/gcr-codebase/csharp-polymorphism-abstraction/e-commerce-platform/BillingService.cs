using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphism_abstraction.e_commerce_platform
{
    internal class BillingService
    {
        public static void PrintFinalPrices(Product[] products)
        {
            for (int i = 0; i < products.Length; i++)
            {
                Product product = products[i];

                double discount = product.CalculateDiscount();
                double tax = 0;

                if (product is ITaxable taxableProduct)
                {
                    tax = taxableProduct.CalculateTax();
                    Console.WriteLine(taxableProduct.GetTaxDetails());
                }

                double finalPrice = product.ProductPrice1 + tax - discount;

                Console.WriteLine(product.ToString());
                Console.WriteLine("Final Price: "+finalPrice);
            }
        }
    }
}
