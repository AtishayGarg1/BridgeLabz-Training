using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphism_abstraction.RideHailingApplication
{
    internal class RideService
    {
        public static void ProcessRides(Vehicle[] vehicles, double distance)
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                Vehicle vehicle = vehicles[i];

                vehicle.GetVehicleDetails();
                Console.WriteLine($"Fare for {distance} km: {vehicle.CalculateFare(distance)}");

                if (vehicle is IGPS gps)
                {
                    Console.WriteLine($"Current Location: {gps.GetCurrentLocation()}");
                }
            }
        }
    }
}
