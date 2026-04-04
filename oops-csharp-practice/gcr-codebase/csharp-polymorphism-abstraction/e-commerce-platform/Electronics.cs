using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphism_abstraction.e_commerce_platform
{
    internal class Electronics : Product, ITaxable
    {

        public override double CalculateDiscount()
        {
            return ProductPrice1 * 0.10;
        }

        public double CalculateTax()
        {
            return ProductPrice1 * 0.18;
        }

        public string GetTaxDetails()
        {
            return "Electronics Tax: GST: 18%";
        }

    }
}
