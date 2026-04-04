using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharpstring.levelone
{
    internal class DemonstrateIndexOutOfRangeException
    {
        static void Main(string[] args)
        {
            string str = "Hello, World!";
            try
            {
                char ch = str[20];
                Console.WriteLine(ch);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("IndexOutOfRangeException caught: " + ex.ToString());
            }
        }
    }
}
