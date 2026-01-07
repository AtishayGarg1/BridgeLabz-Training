using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphism_abstraction.vehiclerentalsystem
{
    internal class RentalService
    {
        public static void CalculateTotalCost(Vehicle[] vehicles, int days)
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                Vehicle vehicle = vehicles[i];

                double rentalCost = vehicle.CalculateRentalCost(days);
                double insurance = 0;

                if (vehicle is IInsurable insurable)
                {
                    insurance = insurable.CalculateInsurance();
                    Console.WriteLine(insurable.GetInsuranceDetails());
                }

                vehicle.DisplayDetails();
                Console.WriteLine($"Rental Cost ({days} days): {rentalCost}");
                Console.WriteLine($"Insurance Cost: {insurance}");
                Console.WriteLine($"Total Payable: {rentalCost + insurance}");
            }
        }
    }
}
