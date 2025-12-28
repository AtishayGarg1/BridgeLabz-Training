using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.stringhandling
{
    internal class LongestWordInASentence
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Sentence");
            string str = Console.ReadLine();

            string[] words = str.Split(' ');
            string longestWord = "";
            int maxWordLength = 0;

            foreach (string word in words)
            {
                if (word.Length > maxWordLength)
                {
                    maxWordLength = word.Length;
                    longestWord = word;
                }
            }
            Console.WriteLine("Longest Word is: " + longestWord);
        }
    }
}
