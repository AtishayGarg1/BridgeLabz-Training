using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.stringhandling
{
    internal class CaseOfCharacter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Stirng");
            string str = Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            int change = 'A' - 'a';

            foreach (char ch in str)
            {
                if (ch >= 'a' && ch <= 'z')
                {
                    sb.Append((char)(ch + change));
                }
                else if (ch >= 'A' && ch <= 'Z')
                {
                    sb.Append((char)(ch - change));
                }
                else
                {
                    sb.Append(ch);
                }
            }
            Console.WriteLine("String after changing case of character is: " + sb.ToString());
        }
    }
}
