using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharpstring.levelone
{
    internal class ConvertTexttoLowercase
    {
        static void Main(string[] args)
        {
            //Read a String
            Console.WriteLine("Enter a String");
            string str = Console.ReadLine();

            string result = ConvertLowerCase(str);
            string expected = str.ToLower();
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
            if (result.Equals(expected))
            {
                Console.WriteLine("Function works correctly");
            }
            else
            {
                Console.WriteLine("Function does not work correctly");
            }
        }

        //Function to convert text to Lower Case
        public static string ConvertLowerCase(string str)
        {
            StringBuilder sb = new StringBuilder(str);
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'A' && str[i] <= 'Z')
                {
                    sb[i] = (char)(sb[i] + 32);
                }
            }
            return sb.ToString();
        }
    }
}
