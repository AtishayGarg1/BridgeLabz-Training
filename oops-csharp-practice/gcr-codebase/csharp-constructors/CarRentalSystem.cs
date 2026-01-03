using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Constructors
{
    internal class CarRentalSystem
    {
        // Instance variables
        public string customerName;
        public string carModel;
        public int rentalDays;
        public int costPerDay = 1000;

        // Parameterized constructor
        public CarRentalSystem(string customerName, string carModel, int rentalDays)
        {
            this.customerName = customerName;
            this.carModel = carModel;
            this.rentalDays = rentalDays;
        }

        // Default constructor
        public CarRentalSystem()
        {
            customerName = "Amrit";
            carModel = "WagonR";
            rentalDays = 7;
        }

        // Method to calculate and display total rental cost
        public void CalculateTotal()
        {
            int price = costPerDay * rentalDays;
            Console.WriteLine("Name: " + customerName);
            Console.WriteLine("Car Model: " + carModel);
            Console.WriteLine("Rental Days: " + rentalDays);
            Console.WriteLine("Total Price: " + price);
            Console.WriteLine("\n");
        }
    }

    // Main execution class
    class run
    {
        static void Main(string[] args)
        {
            CarRentalSystem car1 = new("Atishay", "Swift Dezire", 10);
            car1.CalculateTotal();

            CarRentalSystem car2 = new();
            car2.CalculateTotal();
        }
    }
}
