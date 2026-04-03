using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphism_abstraction.OnlineFoodDeliverySystem
{
    internal class NonVegItem : FoodItem, IDiscountable
    {
        public override double CalculateTotalPrice()
        {
            double basePrice = Price * Quantity;
            return basePrice + (basePrice * 0.15); // 15% extra charge
        }

        public double ApplyDiscount()
        {
            return CalculateTotalPrice() * 0.05; // 5% discount
        }

        public string GetDiscountDetails()
        {
            return "Non-Veg Item Discount: 5%";
        }
    }
}
