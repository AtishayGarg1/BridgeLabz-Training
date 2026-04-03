using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphism_abstraction.e_commerce_platform
{
    internal class Clothing : Product, ITaxable
    {
        public override double CalculateDiscount()
        {
            return ProductPrice1 * 0.10;
        }

        public double CalculateTax()
        {
            return ProductPrice1 * 0.12;
        }

        public string GetTaxDetails()
        {
            return "Clothing Tax: GST: 12%";
        }
    }
}
