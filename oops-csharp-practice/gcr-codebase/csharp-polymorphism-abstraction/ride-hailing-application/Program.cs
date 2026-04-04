using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphism_abstraction.RideHailingApplication
{
    internal class Program
    {
        static void Main()
        {
            Car car = new Car();
            car.VehicleId = 1;
            car.DriverName = "Amit";
            car.RatePerKm = 15;
            car.UpdateLocation("MG Road");

            Bike bike = new Bike();
            bike.VehicleId = 2;
            bike.DriverName = "Ravi";
            bike.RatePerKm = 10;
            bike.UpdateLocation("City Center");

            Auto auto = new Auto();
            auto.VehicleId = 3;
            auto.DriverName = "Suresh";
            auto.RatePerKm = 12;
            auto.UpdateLocation("Railway Station");

            Vehicle[] vehicles = new Vehicle[3];
            vehicles[0] = car;
            vehicles[1] = bike;
            vehicles[2] = auto;

            RideService.ProcessRides(vehicles, 8);
        }
    }
}
