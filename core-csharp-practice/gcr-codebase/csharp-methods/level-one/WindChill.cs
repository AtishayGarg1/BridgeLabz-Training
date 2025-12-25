using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.levelone
{
    internal class WindChill
    {
        static void Main(string[] args)
        {
            //Read temperature and wind speed
            Console.WriteLine("Enter temperature: ");
            double temperature = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter wind speed: ");
            double speed = double.Parse(Console.ReadLine());

            Console.WriteLine("Wind Chill = " + CalculateWindChill(temperature, speed));
        }

        //Function to calculate Wind Chill
        public static double CalculateWindChill(double temperature, double windSpeed)
        {
            //Wind Chill calculation formula
            return 35.74 + 0.6215 * temperature + (0.4275 * temperature - 35.75) * Math.Pow(windSpeed, 0.16);
        }
    }
}
