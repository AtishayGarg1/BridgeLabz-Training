using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.builtinstring.leveltwo
{
    internal class DateComparison
    {
        static void Main(string[] args)
        {
            //Enter First Date
            Console.Write("Enter first date (yyyy-MM-dd): ");
            DateTime date1 = DateTime.Parse(Console.ReadLine());

            //Enter Second Date
            Console.Write("Enter second date (yyyy-MM-dd): ");
            DateTime date2 = DateTime.Parse(Console.ReadLine());

            //Compare Two Dates
            int result = DateTime.Compare(date1, date2);

            if(result < 0)
            {
                Console.WriteLine("First date is before the second date.");
            }
            else if(result > 0)
            {
                Console.WriteLine("First date is after the second date.");
            }
            else
            {
                Console.WriteLine("Both dates are the same.");
            }
        }
    }
}
