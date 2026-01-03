using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Constructors
{
    internal class VehicleRegistration
    {
        // Instance variables
        public string vehicleName;
        public string vehicletype;

        // Static variable for registration fees
        public static int registrationFees = 600;

        // Parameterized constructor
        public VehicleRegistration(string vehicleName, string vehicletype)
        {
            this.vehicleName = vehicleName;
            this.vehicletype = vehicletype;
        }

        // Display vehicle details
        public void DisplayDetails()
        {
            Console.WriteLine("Vehicle Name: " + vehicleName);
            Console.WriteLine("Vehicle type: " + vehicletype);
            Console.WriteLine("Registration Fees: " + registrationFees);
        }

        // Static method to update registration fees
        public static void ChangeRegistrationFees(int registrationFees)
        {
            VehicleRegistration.registrationFees = registrationFees;
        }
    }

    // Main execution class
    class run
    {
        static void Main(string[] args)
        {
            VehicleRegistration obj1 = new("WagonR", "Four Wheeler");
            obj1.DisplayDetails();

            Console.Write("Change Registration Fees: ");
            int registrationfees = int.Parse(Console.ReadLine());

            VehicleRegistration.ChangeRegistrationFees(registrationfees);

            VehicleRegistration obj2 = new("Thar", "Four Wheeler");
            obj2.DisplayDetails();
        }
    }
}
