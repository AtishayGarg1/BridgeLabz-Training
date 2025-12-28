using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.stringhandling
{
    internal class MostFrequent
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String");
            string str = Console.ReadLine();

            int[] freq = new int[26];
            int max = -1;
            char result = ' ';

            foreach (char ch in str)
            {
                if (ch != ' ')
                {
                    freq[ch - 'a']++;
                    if (max < freq[ch - 'a'])
                    {
                        max = freq[ch - 'a'];
                        result = ch;
                    }
                }
            }
            Console.WriteLine("'" + result + "'");
        }
    }
}
