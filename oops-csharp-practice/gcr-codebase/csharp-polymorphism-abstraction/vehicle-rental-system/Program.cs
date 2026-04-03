using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphism_abstraction.vehiclerentalsystem
{
    internal class Program
    {
        static void Main()
        {
            Car car = new Car();
            car.VehicleNumber = "CAR101";
            car.Type = "Car";
            car.RentalRate = 1500;
            car.SetInsurancePolicyNumber("CAR-INS-001");

            Bike bike = new Bike();
            bike.VehicleNumber = "BIKE202";
            bike.Type = "Bike";
            bike.RentalRate = 500;
            bike.SetInsurancePolicyNumber("BIKE-INS-002");

            Truck truck = new Truck();
            truck.VehicleNumber = "TRUCK303";
            truck.Type = "Truck";
            truck.RentalRate = 3000;
            truck.SetInsurancePolicyNumber("TRUCK-INS-003");

            Vehicle[] vehicles = new Vehicle[3];
            vehicles[0] = car;
            vehicles[1] = bike;
            vehicles[2] = truck;

            RentalService.CalculateTotalCost(vehicles, 5);
        }
    }
}
