using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.scenariobased
{
    internal class BusTrackerSystem
    {
        private Bus[] buses = new Bus[20];
        private int busCount = 0;

        static void Main()
        {
            BusTrackerSystem tracker = new BusTrackerSystem();
            tracker.RunSystem();
        }

        //Function to run the program
        void RunSystem()
        {
            int choice;

            do
            {
                Console.WriteLine("\n--- Bus Route Tracker ---");
                Console.WriteLine("1. Add Bus");
                Console.WriteLine("2. View All Buses");
                Console.WriteLine("3. View Bus Details");
                Console.WriteLine("4. Start Bus");
                Console.WriteLine("5. Track Bus");
                Console.WriteLine("6. Exit");
                Console.Write("Enter choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddBus();
                        break;
                    case 2:
                        ListBuses();
                        break;
                    case 3:
                        ViewBusDetails();
                        break;
                    case 4:
                        StartBus();
                        break;
                    case 5:
                        TrackBus();
                        break;
                }

            } while (choice != 6);
        }

        //Function too add bus
        void AddBus()
        {
            Console.Write("Driver ID: ");
            int driver = int.Parse(Console.ReadLine());

            Console.Write("Conductor ID: ");
            int conductor = int.Parse(Console.ReadLine());

            Console.Write("Bus Number: ");
            string number = Console.ReadLine();

            Console.Write("Total Stops: ");
            int stops = int.Parse(Console.ReadLine());

            Console.Write("Capacity: ");
            int capacity = int.Parse(Console.ReadLine());

            buses[busCount] = new Bus(conductor, driver, number, stops, capacity);
            busCount++;

            Console.WriteLine("Bus added successfully.");
        }

        //Function to show buses
        void ListBuses()
        {
            for (int i = 0; i < busCount; i++)
            {
                Console.WriteLine((i + 1) + ". " + buses[i].BusNumber);
            }
        }

        //Function display Bus Details
        void ViewBusDetails()
        {
            ListBuses();
            Console.Write("Select bus number: ");
            int index = int.Parse(Console.ReadLine()) - 1;

            buses[index].ShowBusDetails();
        }

        //Function to start bus
        void StartBus()
        {
            ListBuses();
            Console.Write("Select bus to start: ");
            int index = int.Parse(Console.ReadLine()) - 1;

            buses[index].MoveToNextStop();
        }

        //Function to track bus 
        void TrackBus()
        {
            ListBuses();
            Console.Write("Select bus to track: ");
            int index = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine("Current Stop: " + buses[index].CurrentStop);
        }
    }


    //Bus class to store bus details
    internal class Bus
    {
        private int conductorId;
        private int driverId;
        private int totalStops;
        private int capacity;

        public string BusNumber { get; private set; }
        public int CurrentStop { get; private set; }
        public int DistanceTravelled { get; private set; }

        private Passenger[] passengers;
        private int passengerCount = 0;

        //Constructor to create bus
        public Bus(int conductorId, int driverId, string busNumber, int totalStops, int capacity)
        {
            this.conductorId = conductorId;
            this.driverId = driverId;
            this.totalStops = totalStops;
            this.capacity = capacity;
            BusNumber = busNumber;

            passengers = new Passenger[capacity];
            CurrentStop = 0;
            DistanceTravelled = 0;
        }

        //Function to show bus details
        public void ShowBusDetails()
        {
            Console.WriteLine("\n--- Bus Information ---");
            Console.WriteLine("Bus Number   : " + BusNumber);
            Console.WriteLine("Driver ID    : " + driverId);
            Console.WriteLine("Conductor ID : " + conductorId);
            Console.WriteLine("Total Stops  : " + totalStops);
            Console.WriteLine("Capacity     : " + capacity);
            Console.WriteLine("Current Stop : " + CurrentStop);
        }

        //Function to add passenger
        public void AddPassenger()
        {
            if (passengerCount >= capacity)
            {
                Console.WriteLine("Bus is full.");
                return;
            }

            Console.Write("Passenger Name: ");
            string name = Console.ReadLine();

            Console.Write("Passenger ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Contact Number: ");
            string phone = Console.ReadLine();

            Console.Write("Drop Stop Number: ");
            int stop = int.Parse(Console.ReadLine());

            if (stop <= 0 || stop > totalStops)
            {
                Console.WriteLine("Invalid stop number.");
                return;
            }

            Passenger passenger = new Passenger(id, name, phone);
            passenger.IssueTicket(stop);
            passenger.BoardBus();

            passengers[passengerCount] = passenger;
            passengerCount++;

            Console.WriteLine("Passenger boarded successfully.");
        }

        //Function to move to next stop
        public void MoveToNextStop()
        {
            while (CurrentStop < totalStops)
            {
                CurrentStop++;
                DistanceTravelled += 5;

                Console.WriteLine("\nBus reached stop " + CurrentStop);
                RemovePassengersAtCurrentStop();

                Console.Write("Add passenger at this stop? (yes/no): ");
                string response = Console.ReadLine().ToLower();

                if (response == "yes")
                {
                    AddPassenger();
                }
            }

            Console.WriteLine("\nBus has reached the final stop.");
        }

        //Function to remove passenger at a stop
        private void RemovePassengersAtCurrentStop()
        {
            for (int i = 0; i < passengerCount; i++)
            {
                if (passengers[i] != null && passengers[i].DropStop == CurrentStop)
                {
                    passengers[i].LeaveBus();
                    Console.WriteLine("Passenger got down at stop " + CurrentStop);
                    passengers[i] = null;
                }
            }
        }
    }


    internal class Passenger
    {
        private int passengerId;
        private string name;
        private string phoneNumber;

        public int DropStop { get; private set; }
        public bool HasTicket { get; private set; }
        public bool IsOnBoard { get; private set; }

        public Passenger(int passengerId, string name, string phoneNumber)
        {
            this.passengerId = passengerId;
            this.name = name;
            this.phoneNumber = phoneNumber;
        }

        public void IssueTicket(int dropStop)
        {
            DropStop = dropStop;
            HasTicket = true;
        }

        public void BoardBus()
        {
            IsOnBoard = true;
        }

        public void LeaveBus()
        {
            IsOnBoard = false;
        }
    }
}
