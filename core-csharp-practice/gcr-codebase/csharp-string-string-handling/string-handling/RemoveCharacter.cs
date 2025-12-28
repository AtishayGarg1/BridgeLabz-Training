using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.stringhandling
{
    internal class RemoveCharacter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String");
            string str = Console.ReadLine();

            Console.WriteLine("Enter the Character To Be Removed");
            char chStr = char.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            foreach (char ch in str)
            {
                if (ch != chStr)
                {
                    sb.Append(ch);
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
