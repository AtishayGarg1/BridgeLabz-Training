using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.builtinstring.levelone
{
    internal class TemperatureConverter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 to convert Celcius To Fahrenheit | Press 2 to convert Fahrenheit to Celcius");
            int option = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Temperature");
            double temperature = double.Parse(Console.ReadLine());

            if (option == 2)
            {
                FahrenheitToCelcius(temperature);
            }
            else if (option == 1)
            {
                CelciusToFahrenheit(temperature);
            }
            else
            {
                Console.WriteLine("Invalid Option");
            }
        }

        // Function to convert Fahrenheit to Celcius
        public static void FahrenheitToCelcius(double fahrenheit)
        {
            double celcius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("Temperature in Celcius: " + celcius);
        }

        // Function to convert Celcius to Fahrenheit
        public static void CelciusToFahrenheit(double celcius)
        {
            double fahrenheit = (celcius * 9 / 5) + 32;
            Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit);
        }
    }
}
