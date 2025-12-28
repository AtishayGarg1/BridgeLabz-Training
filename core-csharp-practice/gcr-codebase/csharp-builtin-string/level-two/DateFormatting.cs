using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.builtinstring.leveltwo
{
    internal class DateFormatting
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;

            //Display the results in three formats
            Console.WriteLine("dd/MM/yyyy           : " + today.ToString("dd/MM/yyyy"));
            Console.WriteLine("yyyy-MM-dd           : " + today.ToString("yyyy-MM-dd"));
            Console.WriteLine("EEE, MMM dd, yyyy    : " + today.ToString("ddd, MMM dd, yyyy"));
        }
    }
}
