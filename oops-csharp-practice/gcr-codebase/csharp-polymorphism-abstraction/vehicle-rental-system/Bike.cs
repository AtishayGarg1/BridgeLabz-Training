using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphism_abstraction.vehiclerentalsystem
{
    internal class Bike : Vehicle, IInsurable
    {
        public override double CalculateRentalCost(int days)
        {
            return RentalRate * days;
        }

        public double CalculateInsurance()
        {
            return 500;
        }

        public string GetInsuranceDetails()
        {
            return "Bike Insurance Applied (₹500)";
        }
    }
}
