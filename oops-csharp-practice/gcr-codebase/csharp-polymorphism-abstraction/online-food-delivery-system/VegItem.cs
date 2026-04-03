using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphism_abstraction.OnlineFoodDeliverySystem
{
    internal class VegItem : FoodItem, IDiscountable
    {
        public override double CalculateTotalPrice()
        {
            return Price * Quantity; // no extra charge
        }

        public double ApplyDiscount()
        {
            return CalculateTotalPrice() * 0.10; // 10% discount
        }

        public string GetDiscountDetails()
        {
            return "Veg Item Discount: 10%";
        }
    }
}
