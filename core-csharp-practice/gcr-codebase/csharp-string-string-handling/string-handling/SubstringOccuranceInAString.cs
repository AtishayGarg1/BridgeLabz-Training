using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.stringhandling
{
    internal class SubstringOccuranceInAString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String");
            string str = Console.ReadLine();

            Console.WriteLine("Enter a Substring");
            string subStr = Console.ReadLine();

            int count = 0;
            int len = subStr.Length;

            for (int i = 0; i <= str.Length - len; i++)
            {
                if (str.Substring(i, len) == subStr)
                {
                    count++;
                }
            }
            Console.WriteLine("The Number Of Times Substring Occurs is: " + count);
        }
    }
}
