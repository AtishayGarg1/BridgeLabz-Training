using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Linear_Binary_Search
{
    internal class FindWordInArraySentence
    {
        public void FindWord()
        {
            Console.WriteLine("Enter Length");
            int length = int.Parse(Console.ReadLine());
            string[] sentences = new string[length];
            for (int i = 0; i < sentences.Length; i++)
            {
                Console.WriteLine("Enter a sentence");
                sentences[i] = Console.ReadLine();
            }
            Console.WriteLine("Enter the word to find");
            string word = Console.ReadLine();
            for (int i = 0; i < length; i++)
            {
                if (sentences[i].ToLower().Contains(word.ToLower()))
                {
                    Console.Write("sentence: " + sentences[i]);
                    return;
                }
            }
            Console.WriteLine("Sentence containing " + word + " does not exist");
        }

        static void Main(string[] args)
        {
            FindWordInArraySentence findWordInArraySentence = new FindWordInArraySentence();
            findWordInArraySentence.FindWord();
        }
    }
}
