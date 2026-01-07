using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphism_abstraction.vehiclerentalsystem
{
    internal abstract class Vehicle
    {
        protected string vehicleNumber;
        protected string type;
        protected double rentalRate;

        private string insurancePolicyNumber;

        public string VehicleNumber
        {
            get { return vehicleNumber; }
            set { vehicleNumber = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public double RentalRate
        {
            get { return rentalRate; }
            set
            {
                if (value > 0)
                    rentalRate = value;
            }
        }

        public void SetInsurancePolicyNumber(string policyNumber)
        {
            insurancePolicyNumber = policyNumber;
        }

        protected string GetInsurancePolicyNumber()
        {
            return insurancePolicyNumber;
        }

        public abstract double CalculateRentalCost(int days);

        public void DisplayDetails()
        {
            Console.WriteLine($"Vehicle No: {VehicleNumber}, Type: {Type}, Rate/Day: {RentalRate}");
        }
    }
}
