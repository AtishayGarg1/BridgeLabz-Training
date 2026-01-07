using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphism_abstraction.RideHailingApplication
{
    internal class Auto : Vehicle, IGPS
    {
        private string currentLocation;

        public override double CalculateFare(double distance)
        {
            return (distance * ratePerKm) + 20; // base charge
        }

        public void UpdateLocation(string location)
        {
            currentLocation = location;
        }

        public string GetCurrentLocation()
        {
            return currentLocation;
        }
    }
}
