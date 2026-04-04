using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.stringhandling
{
    internal class CheckAnnagram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1'st String");
            string str1 = Console.ReadLine();

            Console.WriteLine("Enter 2'nd String");
            string str2 = Console.ReadLine();

            bool result = false;

            if (str1.Length == str2.Length)
            {
                char[] char1 = str1.ToCharArray();
                char[] char2 = str2.ToCharArray();
                Array.Sort(char1);
                Array.Sort(char2);
                result = char1.SequenceEqual(char2);
            }
            Console.WriteLine("Strings are Annagram: " + result);
        }
    }
}
