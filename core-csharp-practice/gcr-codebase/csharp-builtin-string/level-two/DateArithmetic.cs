using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.builtinstring.leveltwo
{
    internal class DateArithmetic
    {
        static void Main(string[] args)
        {
            //Enter the Date
            Console.Write("Enter a date (yyyy-MM-dd): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            //Calculate the date after adding the given data
            DateTime result = date.AddDays(7).AddMonths(1).AddYears(2).AddDays(-21);

            Console.WriteLine("Final Date: " + result.ToShortDateString());
        }
    }
}
