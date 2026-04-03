using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.stringhandling
{
    internal class ReplaceWord
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String");
            string str = Console.ReadLine();

            Console.WriteLine("Enter a word to be replaced");
            string replaceWord = Console.ReadLine();

            Console.WriteLine("Enter a word to replace");
            string newWord = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            string[] words = str.Split(' ');

            foreach (string word in words)
            {
                if (word.Equals(replaceWord))
                {
                    sb.Append(newWord + " ");
                }
                else
                {
                    sb.Append(word + " ");
                }
            }
            Console.WriteLine("String after replacing word: " + sb.ToString());
        }
    }
}
