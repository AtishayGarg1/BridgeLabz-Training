using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharpstring.levelone
{
    internal class ConvertTexttoUppercase
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String");
            string str = Console.ReadLine();

            string result = ConvertToUpperCase(str);
            string expected = str.ToUpper();
            if (result.Equals(expected))
            {
                Console.WriteLine("Function works correctly.");
            }
            else
            {
                Console.WriteLine("Function does not work correctly.");
            }
        }


        //Function to convert text to uppercase
        public static string ConvertToUpperCase(string str)
        {
            StringBuilder sb = new StringBuilder(str);
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'a' && str[i] <= 'z')
                {
                    sb[i] = (char)(sb[i] - 32);
                }
            }
            return sb.ToString();
        }
    }
}
