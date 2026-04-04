using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.thisstatic
{
    internal class VehicleRegistrationSystem
    {
        // Static variable
        public static double registrationFee = 1500;

        // Readonly variable
        public readonly string registrationNumber;

        // Instance variables
        public string ownerName;
        public string vehicleType;

        // Constructor using this keyword
        public VehicleRegistrationSystem(string registrationNumber, string ownerName, string vehicleType)
        {
            this.registrationNumber = registrationNumber;
            this.ownerName = ownerName;
            this.vehicleType = vehicleType;
        }

        // Static method to update registration fee
        public static void UpdateRegistrationFee(double newFee)
        {
            registrationFee = newFee;
        }

        // Display vehicle details using is operator
        public void DisplayDetails(object obj)
        {
            if (obj is VehicleRegistrationSystem)
            {
                Console.WriteLine("Registration No : " + registrationNumber);
                Console.WriteLine("Owner           : " + ownerName);
                Console.WriteLine("Vehicle Type    : " + vehicleType);
                Console.WriteLine("Registration Fee: " + registrationFee);
            }
            else
            {
                Console.WriteLine("Invalid vehicle object");
            }
        }
    }

    class run
    {
        static void Main(string[] args)
        {
            // Update registration fee for all vehicles
            VehicleRegistrationSystem.UpdateRegistrationFee(2000);

            // Create vehicle object
            VehicleRegistrationSystem v1 =
                new VehicleRegistrationSystem("MH12AB1234", "Atishay Garg", "Car");

            v1.DisplayDetails(v1);
        }
    }
}
