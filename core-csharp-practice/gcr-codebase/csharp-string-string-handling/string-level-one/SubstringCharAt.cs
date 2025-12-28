using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharpstring.levelone
{
    internal class SubstringCharAt
    {
        static void Main(string[] args)
        {
            //Read string and indices from the user
            Console.WriteLine("Enter a String");
            string str = Console.ReadLine();
            Console.WriteLine("Enter Start Index");
            int startIndex = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter End Index");
            int endIndex = int.Parse(Console.ReadLine());

            string result = SubstringUsingCharAt(str, startIndex, endIndex);
            string expected = SubstringUsingSubstring(str, startIndex, endIndex);
            if (result.Equals(expected))
            {
                Console.WriteLine("Substring function using Char At works correctly.");
            }
            else
            {
                Console.WriteLine("Substring function using Char At does not work correctly.");
            }
        }

        //Function to get substring using Char At
        public static string SubstringUsingCharAt(string str, int startIndex, int endIndex)
        {
            StringBuilder substring = new StringBuilder();
            for (int i = startIndex; i < endIndex && i < str.Length; i++)
            {
                substring.Append(str[i]);
            }
            return substring.ToString();
        }

        //Function to get substring using built-in Substring method
        public static string SubstringUsingSubstring(string str, int startIndex, int endIndex)
        {
            return str.Substring(startIndex, endIndex - startIndex);
        }
    }
}
