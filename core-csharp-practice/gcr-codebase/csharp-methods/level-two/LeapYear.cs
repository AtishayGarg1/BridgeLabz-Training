using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.leveltwo
{
    internal class LeapYear
    {
        static void Main(string[] args)
        {
            //Read a Year
            Console.WriteLine("Enter year: ");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine(IsLeapYear(year) ? "Leap Year" : "Not a Leap Year");
        }


        static bool IsLeapYear(int year)
        {
            if(year < 1582)
            {
                return false;
            }
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }

    }
}
