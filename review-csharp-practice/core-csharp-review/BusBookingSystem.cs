//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Reflection.Metadata.Ecma335;
//using System.Text;
//using System.Threading.Channels;
//using System.Threading.Tasks;

//namespace BridgeLabzTraining.review
//{
//    internal class BusBookingSystem
//    {

//        static void Main(string[] args)
//        {
//            BusBookingSystem busBookingSystem = new();
//            busBookingSystem.menu();
//        }

//        void menu()
//        {
//            while (true)
//            {
//                Console.WriteLine("Welcome to Bus Booking System");
//                Console.WriteLine("1. Admin");
//                Console.WriteLine("2. User");
//                Console.WriteLine("3. Exit");

//                int choice;
//                bool b = int.TryParse(Console.ReadLine(), out choice);
//                if (!b)
//                {
//                    Console.WriteLine("Invalid choice");
//                    continue;
//                }
//                else
//                {
//                    Admin admin = new();
//                    User user = new();
//                    switch (choice)
//                    {
//                        case 1:
//                            admin.ConfigureBus();
//                            break;
//                        case 2:
//                            user.Bookticket();
//                            break;
//                        case 3:
//                            return;
//                        default:
//                            Console.WriteLine("Enter Valid choice");
//                            break;
//                    }
//                }
//            }
//        }
//    }

//    public class Bus
//    {
//        public const int totalSeats = 20;
//        public static int availableSeats = totalSeats;

//        public static int stopsCount = 5;
//        public static string[] nameStops = new string[stopsCount];
//        public static int[] stops = new int[stopsCount];
//        public static bool isConfigured = false;
//    }

//    public class User
//    {
//        public void Bookticket()
//        {
//            if (!Bus.isConfigured)
//            {
//                Console.WriteLine("Bus not Configured by admin");
//                return;
//            }
//            Console.WriteLine("Stops are");
//            for(int i = 0; i < Bus.stopsCount; i++)
//            {
//                Console.WriteLine(i+1+"Stop ");
//                Console.WriteLine(Bus.nameStops[i]+" - price: "+ Bus.stops[i]);
//            }
//            Console.WriteLine("Available seats: "+Bus.availableSeats);

//            Console.WriteLine("Enter stop Number where you want to go");
//            int choice = int.Parse(Console.ReadLine());
//            if(choice > Bus.stopsCount || choice < 1)
//            {
//                Console.WriteLine("Invalid Number of stops");
//                return;
//            }

//            Console.WriteLine("Enter Number of Seats to book");
//            int seats = int.Parse(Console.ReadLine());
//            if(seats < 0)
//            {
//                Console.WriteLine("Invalid");
//                return;
//            }
//            else if(seats > Bus.availableSeats)
//            {
//                Console.WriteLine("Seats not available");
//                return;
//            }

//            double price = seats * Bus.stops[(choice-1)];
//            Bus.availableSeats -= seats;

//            Console.WriteLine("Seat Booked");
//            Console.WriteLine("Number Of seats: " + seats);
//            Console.WriteLine("Price: "+price);
//            Console.WriteLine("Available seats: "+Bus.availableSeats);
//        }
//    }

//    public class Admin
//    {
//        public void ConfigureBus()
//        {
//            int n = Bus.stops.Length;

//            for (int i = 0; i < n; i++)
//            {
//                Console.WriteLine("Enter Name of stop " + (i+1));
//                Bus.nameStops[i] = Console.ReadLine();
//                Console.WriteLine("Enter price of stop " + (i + 1));
//                Bus.stops[i] = int.Parse(Console.ReadLine());

//            }
//            Bus.isConfigured = true;
//            Console.WriteLine("Bus Configured Successfully");
//            while (true)
//            {
//                Console.WriteLine("1. Change Stop price");
//                Console.WriteLine("2. Display stop price");
//                Console.WriteLine("3. Exit");
//                int choice;
//                bool b = int.TryParse(Console.ReadLine(), out choice);
//                if (!b)
//                {
//                    Console.WriteLine("Invalid choice");
//                    continue;

//                }
//                else
//                {
//                    switch (choice)
//                    {
//                        case 1:
//                            Console.WriteLine("Enter stop to change price");
//                            int ans = int.Parse(Console.ReadLine()) - 1;
//                            Console.WriteLine("Enter price");
//                            Bus.stops[ans] = int.Parse(Console.ReadLine());
//                            break;
//                        case 2:
//                            for (int i = 0; i < n; i++)
//                            {
//                                Console.WriteLine("price of stop " + Bus.nameStops[i] + ": " + Bus.stops[i]);
//                            }
//                            break;
//                        case 3:
//                            return;
//                        default:
//                            break;
//                    }
//                }
//            }
//        }
//    }
//}
