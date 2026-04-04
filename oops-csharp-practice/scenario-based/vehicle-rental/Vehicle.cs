using BridgeLabzTraining.scenariobased.VehicleTrntai;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.scenariobased.calllogmanager
{
    internal abstract class Vehicle : IRentable
    {
        protected string vehicleNumber;
        protected string brand;
        protected int ratePerDay;

        protected Vehicle(string vehicleNumber, string brand, int ratePerDay)
        {
            this.vehicleNumber = vehicleNumber;
            this.brand = brand;
            this.ratePerDay = ratePerDay;
        }


        public abstract double CalculateRent(int days);


        public virtual string GetDetails()
        {
            return "\nNumber Plate: " + vehicleNumber +
                   ", Brand: " + brand + "Type: " + GetType().Name + ", Rate/Day: " + ratePerDay;
        }
    }

    internal class Bike : Vehicle
    {
        public Bike(string vehicleNumber, string brand, int ratePerDay) : base(vehicleNumber, brand, ratePerDay){ }

        public override double CalculateRent(int days)
        {
            return ratePerDay * days;
        }
    }

    internal class Car : Vehicle
    {
        public Car(string vehicleNumber, string brand, int ratePerDay) : base(vehicleNumber, brand, ratePerDay) { }
        public override double CalculateRent(int days)
        {
            return ratePerDay * days;
        }
    }

    internal class Truck : Vehicle
    {
        public Truck(string vehicleNumber, string brand, int ratePerDay) : base(vehicleNumber, brand, ratePerDay) { }
        public override double CalculateRent(int days)
        {
            return ratePerDay * days;
        }
    }
}
