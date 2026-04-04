using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphism_abstraction.vehiclerentalsystem
{
    internal class Truck : Vehicle, IInsurable
    {
        public override double CalculateRentalCost(int days)
        {
            return (RentalRate * days) + 1000;
        }

        public double CalculateInsurance()
        {
            return 1500;
        }

        public string GetInsuranceDetails()
        {
            return "Truck Insurance Applied (₹1500)";
        }
    }
}
