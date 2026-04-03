using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.leetcode
{
    internal class FirstUnique
    {
        public int FirstUniqChar(string s)
        {
            int[] freqArray = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                freqArray[s[i] - 'a']++;   
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (freqArray[s[i] - 'a'] == 1)
                {
                    return i;   
                }   
            }
            return -1;    
        }
        static void Main(string[] args)
        {
            FirstUnique firstUnique = new FirstUnique();
            int ans = firstUnique.FirstUniqChar("leetcode");
            Console.Write("Index: "+ans);
        }
    }
}
