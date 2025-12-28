using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharpstring.levelone
{
    internal class TextToWords
    {

        static void Main()
        {
            Console.Write("Enter text: ");
            string input = Console.ReadLine();

            string[,] data = SplitWordsWithLength(input);

            Console.WriteLine("Word\tLength");
            for (int i = 0; i < data.GetLength(0); i++)
            {
                Console.WriteLine(data[i, 0] + "\t" + data[i, 1]);
            }
        }
        static int FindLength(string text)
        {
            int len = 0;
            foreach (char ch in text)
                len++;
            return len;
        }

        static string[] GetWords(string text)
        {
            int count = 0;
            bool insideWord = false;

            for (int i = 0; i < FindLength(text); i++)
            {
                if (text[i] != ' ' && !insideWord)
                {
                    count++;
                    insideWord = true;
                }
                else if (text[i] == ' ')
                {
                    insideWord = false;
                }
            }

            string[] words = new string[count];
            string temp = "";
            int index = 0;

            for (int i = 0; i < FindLength(text); i++)
            {
                if (text[i] != ' ')
                {
                    temp += text[i];
                }
                else if (temp != "")
                {
                    words[index++] = temp;
                    temp = "";
                }
            }

            if (temp != "")
                words[index] = temp;

            return words;
        }

        static string[,] SplitWordsWithLength(string text)
        {
            string[] words = GetWords(text);
            string[,] result = new string[words.Length, 2];

            for (int i = 0; i < words.Length; i++)
            {
                result[i, 0] = words[i];
                result[i, 1] = FindLength(words[i]).ToString();
            }

            return result;
        }

    }
}
