using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.inheritance
{
    
    // Superclass Vehicle
    internal class Vehicle
    {
        public int MaxSpeed;
        public string FuelType;

        // Constructor
        public Vehicle(int maxSpeed, string fuelType)
        {
            MaxSpeed = maxSpeed;
            FuelType = fuelType;
        }

        // Virtual method
        public virtual void DisplayInfo()
        {
            Console.WriteLine("Max Speed : " + MaxSpeed);
            Console.WriteLine("Fuel Type : " + FuelType);
        }
    }

    // Car subclass
    class Car : Vehicle
    {
        public int SeatCapacity;

        public Car(int speed, string fuel, int seats)
            : base(speed, fuel)
        {
            SeatCapacity = seats;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Seats     : " + SeatCapacity);
        }
    }

    // Truck subclass
    class Truck : Vehicle
    {
        public int PayloadCapacity;

        public Truck(int speed, string fuel, int payload)
            : base(speed, fuel)
        {
            PayloadCapacity = payload;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Payload   : " + PayloadCapacity);
        }
    }

    // Motorcycle subclass
    class Motorcycle : Vehicle
    {
        public bool HasSidecar;

        public Motorcycle(int speed, string fuel, bool sidecar)
            : base(speed, fuel)
        {
            HasSidecar = sidecar;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Sidecar   : " + HasSidecar);
        }
    }

    class Program
    {
        static void Main()
        {
            // Array of Vehicle type (polymorphism)
            Vehicle[] vehicles =
            {
                new Car(180, "Petrol", 5),
                new Truck(120, "Diesel", 5000),
                new Motorcycle(150, "Petrol", false)
            };

            // Dynamic method dispatch
            foreach (Vehicle v in vehicles)
            {
                v.DisplayInfo();
                Console.WriteLine();
            }
        }
    }
}
