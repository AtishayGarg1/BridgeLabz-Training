using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphism_abstraction.vehiclerentalsystem
{
    internal interface IInsurable
    {
        double CalculateInsurance();
        string GetInsuranceDetails();
    }
}
