using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharpstring.levelone
{
    internal class DemonstrateFormatException
    {
        static void Main(string[] args)
        {
            string str = "Hello, World!";
            try
            {
                int number = int.Parse(str);
                Console.WriteLine(number);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Caught a FormatException: " + ex.ToString());
            }
        }
    }
}
