using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.stringbuilder_search
{
    internal class StringConcatenation
    {
        public void Operation()
        {
            Console.WriteLine("Enter length Of array");
            int length = int.Parse(Console.ReadLine());
            string[] stringArray = new string[length];
            StringBuilder sb = new();
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine("Enter string");
                stringArray[i] = Console.ReadLine();
                sb.Append(stringArray[i]);
                sb.Append(" ");
            }
            Console.Write("Result: " + sb.ToString());
        }
        static void Main(string[] args)
        {
            StringConcatenation stringConcatenation = new StringConcatenation();
            stringConcatenation.Operation();
        }
    }
}
