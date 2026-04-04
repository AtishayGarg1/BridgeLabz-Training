using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.leveltwo
{
    internal class UnitConvertor
    {
        static void Main(string[] args)
        {
            //Read inputs and perform conversions
            Console.WriteLine("Enter Fahrenheit: ");
            double f = double.Parse(Console.ReadLine());
            Console.WriteLine("Fahrenheit to Celsius = " + FahrenheitToCelsius(f));

            Console.WriteLine("Enter Celsius: ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("Celsius to Fahrenheit = " + CelsiusToFahrenheit(c));

            Console.WriteLine("Enter Pounds: ");
            double pounds = double.Parse(Console.ReadLine());
            Console.WriteLine("Pounds to Kilograms = " + PoundsToKilograms(pounds));

            Console.WriteLine("Enter Kilograms: ");
            double kg = double.Parse(Console.ReadLine());
            Console.WriteLine("Kilograms to Pounds = " + KilogramsToPounds(kg));

            Console.WriteLine("Enter Gallons: ");
            double gallons = double.Parse(Console.ReadLine());
            Console.WriteLine("Gallons to Liters = " + GallonsToLiters(gallons));

            Console.WriteLine("Enter Liters: ");
            double liters = double.Parse(Console.ReadLine());
            Console.WriteLine("Liters to Gallons = " + LitersToGallons(liters));
        }

        // Conversion Methods
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        public static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        public static double PoundsToKilograms(double pounds)
        {
            return pounds * 0.453592;
        }

        public static double KilogramsToPounds(double kilograms)
        {
            return kilograms * 2.20462;
        }

        public static double GallonsToLiters(double gallons)
        {
            return gallons * 3.78541;
        }

        public static double LitersToGallons(double liters)
        {
            return liters * 0.264172;
        }
    }
}
