using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharpstring.levelone
{
    internal class DemonstrateArgumentOutOfRangeException
    {
        static void Main(string[] args)
        {
            string str = "Hello, World!";
            try
            {
                string substring = str.Substring(55, 10);
                Console.WriteLine(substring);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Caught an ArgumentOutOfRangeException: " + ex.ToString());
            }
        }
    }
}
