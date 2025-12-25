using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.leveltwo
{
    internal class UnitConvertotDistance
    {
        static void Main(string[] args)
        {
            //Read distance in KM and convert to Miles
            Console.WriteLine("Enter distance in KM: ");
            double km = double.Parse(Console.ReadLine());
            Console.WriteLine("KM to Miles = " + ConvertKmToMiles(km));

            //Read distance in Miles and convert to KM
            Console.WriteLine("Enter distance in Miles: ");
            double miles = double.Parse(Console.ReadLine());
            Console.WriteLine("Miles to KM = " + ConvertMilesToKm(miles));

            //Read distance in Meters and convert to Feet
            Console.WriteLine("Enter distance in Meters: ");
            double meters = double.Parse(Console.ReadLine());
            Console.WriteLine("Meters to Feet = " + ConvertMetersToFeet(meters));

            //Read distance in Feet and convert to Meters
            Console.WriteLine("Enter distance in Feet: ");
            double feet = double.Parse(Console.ReadLine());
            Console.WriteLine("Feet to Meters = " + ConvertFeetToMeters(feet));
        }

        //Function to convert KM to Miles
        public static double ConvertKmToMiles(double km)
        {
            return km * 0.621371;
        }

        //Function to convert Miles to KM
        public static double ConvertMilesToKm(double miles)
        {
            return miles * 1.60934;
        }

        //Function to convert Meters to Feet
        public static double ConvertMetersToFeet(double meters)
        {
            return meters * 3.28084;
        }

        //Function to convert Feet to Meters
        public static double ConvertFeetToMeters(double feet)
        {
            return feet * 0.3048;
        }
    }
}
