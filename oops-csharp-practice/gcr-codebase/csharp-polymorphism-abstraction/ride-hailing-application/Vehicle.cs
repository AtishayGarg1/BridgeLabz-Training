using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphism_abstraction.RideHailingApplication
{
    internal abstract class Vehicle
    {
        private int vehicleId;
        private string driverName;
        protected double ratePerKm;

        public int VehicleId
        {
            get { return vehicleId; }
            set { vehicleId = value; }
        }

        public string DriverName
        {
            get { return driverName; }
            set { driverName = value; }
        }

        public double RatePerKm
        {
            get { return ratePerKm; }
            set
            {
                if (value > 0)
                    ratePerKm = value;
            }
        }

        public abstract double CalculateFare(double distance);

        public void GetVehicleDetails()
        {
            Console.WriteLine($"Vehicle ID: {VehicleId}, Driver: {DriverName}, Rate/Km: {RatePerKm}");
        }
    }
}
