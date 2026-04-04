using BridgeLabzTraining.scenariobased.calllogmanager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.scenariobased.VehicleTrntai
{
    internal class VehicleControler
    {
        private Vehicle[] vehicle;
        private int count;
        public VehicleControler(int capacity)
        {
            vehicle = new Vehicle[capacity];
            count = 0;
        }


        public void Run()
        {
            while (true)
            {
                Console.WriteLine("Welcome to Vehicle Rental System");
                Console.WriteLine("1. Add vehicle");
                Console.WriteLine("2. View Vehicle");
                Console.WriteLine("3. Calculate Rent");
                Console.WriteLine("4. Exit");
                int choice;
                bool b = int.TryParse(Console.ReadLine(), out choice);
                if (!b)
                {
                    Console.WriteLine("Invalid Choice");
                    continue;
                }
                switch (choice)
                {
                    case 1:
                        AddVehicle();
                        break;
                    case 2:
                        ShowVehicle();
                        break;
                    case 3:
                        RentVehicle();
                        break;
                    case 4:
                        return;
                    default:
                        break;
                }
            }
        }

        private void AddVehicle()
        {
            if(count == vehicle.Length)
            {
                Console.WriteLine("Storage Full");
                return;
            }
            Console.WriteLine("1. Bike \n2. Car \n3. Truck");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Vehicle Number: ");
            string vehicleNumber = Console.ReadLine();

            Console.WriteLine("Enter Brand: ");
            string brand = Console.ReadLine();

            Console.WriteLine("Enter Rate per Day: ");
            int ratePerDay = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    vehicle[count++] = new Bike(vehicleNumber, brand, ratePerDay);
                    break;
                case 2:
                    vehicle[count++] = new Car(vehicleNumber, brand, ratePerDay);
                    break;
                case 3:
                    vehicle[count++] = new Truck(vehicleNumber, brand, ratePerDay);
                    break;
                default:
                    Console.WriteLine("Invalid Vehicle");
                    return;
            }
        }

        private void ShowVehicle()
        {
            if (count == 0)
            {
                Console.WriteLine("No vehicles available.");
                return;
            }

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine((i + 1) + ". " + vehicle[i].GetDetails());
            }
        }

        private void RentVehicle()
        {
            if (count == 0)
            {
                Console.WriteLine("No vehicles to rent.");
                return;
            }

            ShowVehicle();

            Console.Write("Select vehicle number: ");
            int index = int.Parse(Console.ReadLine()) - 1;

            Console.Write("Enter days: ");
            int days = int.Parse(Console.ReadLine());

            double amount = vehicle[index].CalculateRent(days);

            Console.WriteLine("Total Rent: " + amount);
        }
    }
}
