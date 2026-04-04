using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphism_abstraction.vehiclerentalsystem
{
    internal class Car : Vehicle, IInsurable
    {
        public override double CalculateRentalCost(int days)
        {
            return RentalRate * days;
        }

        public double CalculateInsurance()
        {
            return 1000;
        }

        public string GetInsuranceDetails()
        {
            return "Car Insurance Applied (₹1000)";
        }
    }
}
