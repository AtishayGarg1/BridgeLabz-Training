using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Constructors
{
    internal class HotelBookingSystem
    {
        // Instance variables
        public string guestName;
        public string roomType;
        public int nights;

        // Parameterized constructor
        public HotelBookingSystem(string guestName, string roomType, int nights)
        {
            this.guestName = guestName;
            this.roomType = roomType;
            this.nights = nights;
        }

        // Default constructor
        public HotelBookingSystem()
        {
            guestName = "Amrit";
            roomType = "Single Bed";
            nights = 2;
        }

        // Copy constructor
        public HotelBookingSystem(HotelBookingSystem hotel)
        {
            guestName = hotel.guestName;
            roomType = hotel.roomType;
            nights = hotel.nights;
        }

        // Display booking details
        public void Display()
        {
            Console.WriteLine("Name: " + guestName);
            Console.WriteLine("Room Type: " + roomType);
            Console.WriteLine("Nights: " + nights);
            Console.WriteLine("\n");
        }
    }

    // Main execution class
    class run
    {
        static void Main(string[] args)
        {
            HotelBookingSystem hotelBookingSystem1 = new("Atishay", "Delux Single Bed", 3);
            hotelBookingSystem1.Display();

            HotelBookingSystem hotelBookingSystem2 = new();
            hotelBookingSystem2.Display();

            HotelBookingSystem hotelBookingSystem3 = new(hotelBookingSystem1);
            hotelBookingSystem3.Display();
        }
    }
}
