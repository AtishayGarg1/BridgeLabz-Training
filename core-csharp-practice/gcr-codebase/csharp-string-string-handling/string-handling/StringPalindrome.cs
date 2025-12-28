using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.stringhandling
{
    internal class StringPalindrome
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String");
            string str = Console.ReadLine();

            int l = 0;
            int r = str.Length - 1;
            int c = 0;

            while (l < r)
            {
                if (str[l++] != str[r--])
                {
                    Console.WriteLine("String is not a Palindrome String");
                    c++;
                    break;
                }
            }
            if (c == 0)
            {
                Console.WriteLine("String is Palindrome");
            }
        }
    }
}
