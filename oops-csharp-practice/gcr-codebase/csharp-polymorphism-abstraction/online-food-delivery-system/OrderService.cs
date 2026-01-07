using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphism_abstraction.OnlineFoodDeliverySystem
{
    internal class OrderService
    {
        public static void ProcessOrder(FoodItem[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                FoodItem item = items[i];

                double totalPrice = item.CalculateTotalPrice();
                double discount = 0;

                if (item is IDiscountable discountable)
                {
                    discount = discountable.ApplyDiscount();
                    Console.WriteLine(discountable.GetDiscountDetails());
                }

                item.GetItemDetails();
                Console.WriteLine($"Total Price: {totalPrice}");
                Console.WriteLine($"Discount: {discount}");
                Console.WriteLine($"Final Amount: {totalPrice - discount}");
            }
        }
    }
}
