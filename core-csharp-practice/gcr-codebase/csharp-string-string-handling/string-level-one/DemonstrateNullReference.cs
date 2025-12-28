using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharpstring.levelone
{
    internal class DemonstrateNullReference
    {
        static void Main(string[] args)
        {
            string str = null;
            try
            {
                int length = str.Length;
                Console.WriteLine(length);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Caught a NullReferenceException: " + ex.ToString());
            }
        }
    }
}
