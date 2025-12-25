using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.leveltwo
{
    internal class UnitConvertorLength
    {
        static void Main(string[] args)
        {
            //Read yards and convert to feet
            Console.WriteLine("Enter yards: ");
            double yards = double.Parse(Console.ReadLine());
            Console.WriteLine("Yards to Feet = " + ConvertYardsToFeet(yards));

            //Read feet and convert to yards
            Console.WriteLine("Enter feet: ");
            double feet = double.Parse(Console.ReadLine());
            Console.WriteLine("Feet to Yards = " + ConvertFeetToYards(feet));

            //Read meters and convert to inches
            Console.WriteLine("Enter meters: ");
            double meters = double.Parse(Console.ReadLine());
            Console.WriteLine("Meters to Inches = " + ConvertMetersToInches(meters));

            //Read inches and convert to meters and cm
            Console.WriteLine("Enter inches: ");
            double inches = double.Parse(Console.ReadLine());
            Console.WriteLine("Inches to Meters = " + ConvertInchesToMeters(inches));
            Console.WriteLine("Inches to CM = " + ConvertInchesToCm(inches));
        }

        //Function to convert Yards to Feet
        public static double ConvertYardsToFeet(double yards)
        {
            return yards * 3;
        }

        //Function to convert Feet to Yards
        public static double ConvertFeetToYards(double feet)
        {
            return feet * 0.333333;
        }

        //Function to convert Meters to Inches
        public static double ConvertMetersToInches(double meters)
        {
            return meters * 39.3701;
        }

        //Function to convert Inches to Meters
        public static double ConvertInchesToMeters(double inches)
        {
            return inches * 0.0254;
        }

        //Function to convert Inches to Centimeters
        public static double ConvertInchesToCm(double inches)
        {
            return inches * 2.54;
        }
    }
}
