using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphism_abstraction.OnlineFoodDeliverySystem
{
    internal interface IDiscountable
    {
        double ApplyDiscount();
        string GetDiscountDetails();
    }
}
