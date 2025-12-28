using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharpstring.levelone
{
    internal class ReturnCharacters
    {
        static void Main(string[] args)
        {
            //Read string from the user
            Console.WriteLine("Enter a String");
            string str = Console.ReadLine();
            char[] result = GetCharactersAsArray(str);
            char[] expected = GetCharactersToCharArray(str);
            Console.WriteLine("Characters in the string: ");
            foreach (char ch in result)
            {
                Console.WriteLine(ch);
            }
            //Check if both methods give the same result
            if (result.Equals(expected))
            {
                Console.WriteLine("Function works correctly.");
            }
            else
            {
                Console.WriteLine("Function does not work correctly.");
            }
        }

        //Function to return characters of a string as an array
        public static char[] GetCharactersAsArray(string str)
        {
            char[] charArray = new char[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                charArray[i] = str[i];
            }
            return charArray;
        }

        // Function to return characters of a string as an array using ToCharArray method
        public static char[] GetCharactersToCharArray(string str)
        {
            return str.ToCharArray();
        }
    }
}
