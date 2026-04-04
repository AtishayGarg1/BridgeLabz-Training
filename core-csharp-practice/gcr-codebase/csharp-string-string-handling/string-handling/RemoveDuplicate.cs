using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace BridgeLabzTraining.stringhandling
{
    internal class RemoveDuplicate
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String");
            string str = Console.ReadLine();

            int[] freq = new int[26];
            StringBuilder sb = new StringBuilder();

            foreach (char ch in str)
            {
                if (ch == ' ')
                {
                    sb.Append(ch);
                }
                else if (freq[ch - 'a'] == 0)
                {
                    sb.Append(ch);
                    freq[ch - 'a']++;
                }
            }
            Console.WriteLine("String after removal of duplicate character is: " + sb.ToString());
        }
    }
}
