using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.stringhandling
{
    internal class CountVowelsAndConsonants
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String");
            string str = Console.ReadLine();

            int vowelsCount = 0;
            int consonantCount = 0;

            string newStr = str.ToLower();

            foreach (char ch in newStr)
            {
                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                {
                    vowelsCount++;
                }
                else if (ch >= 'a' && ch <= 'z')
                {
                    consonantCount++;
                }
            }

            Console.WriteLine("No of Vowels are: " + vowelsCount + "\nNumber of Consonants are: " + consonantCount);
        }
    }
}
