using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.stringhandling
{
    internal class ReverseString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String");
            string str = Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            int l = str.Length;
            l -= 1;
            for (int i = l; i >= 0; i--)
            {
                sb.Append(str[i]);
            }
            Console.WriteLine("Reversed String is: " + sb.ToString());
        }
    }
}
