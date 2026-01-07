using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphism_abstraction.e_commerce_platform
{
    internal interface ITaxable
    {
        double CalculateTax();
        string GetTaxDetails();
    }
}
