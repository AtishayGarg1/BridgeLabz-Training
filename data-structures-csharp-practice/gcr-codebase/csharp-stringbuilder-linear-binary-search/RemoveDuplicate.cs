using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.stringbuilder_search
{
    internal class RemoveDuplicate
    {
        public void Remove()
        {
            Console.WriteLine("Enter a String");
            string str = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            int[] freq = new int[26];
            for (int i = 0; i < str.Length; i++)
            {
                if (freq[str[i] - 'a'] == 0)
                {
                    freq[str[i] - 'a']++;
                    sb.Append(str[i]);
                }
            }
            Console.Write("After Removing Duplicates: " + sb.ToString());
        }
        static void Main(string[] args)
        {
            RemoveDuplicate removeDuplicate = new RemoveDuplicate();
            removeDuplicate.Remove();
        }
    }
}
