using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphism_abstraction.e_commerce_platform
{
    internal class Grocery : Product, ITaxable
    {
        public override double CalculateDiscount()
        {
            return ProductPrice1 * 0.05;
        }

        public double CalculateTax()
        {
            return ProductPrice1 * 0.05;
        }

        public string GetTaxDetails()
        {
            return "Grocery Tax: GST: 5%";
        }

    }
}
