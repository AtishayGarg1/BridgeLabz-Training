using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphism_abstraction.RideHailingApplication
{
    internal class Bike : Vehicle, IGPS
    {
        private string currentLocation;

        public override double CalculateFare(double distance)
        {
            return (distance * ratePerKm) * 0.8; // cheaper rides
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
