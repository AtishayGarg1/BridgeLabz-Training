using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.sorting
{
    internal class ExamScore
    {
        public void SelectionSort(int[] scores)
        {
            for (int i = 0; i < scores.Length - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < scores.Length; j++)
                {
                    if (scores[j] < scores[minIndex])
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    int temp = scores[i];
                    scores[i] = scores[minIndex];
                    scores[minIndex] = temp;
                }
            }
        }

        public void DisplayAll(int[] scores)
        {
            for (int i = 0; i < scores.Length - 1; i++)
            {
                Console.Write(scores[i] + ", ");
            }
            Console.Write(scores[scores.Length - 1]);
        }

        static void Main(string[] args)
        {
            ExamScore examScores = new ExamScore();
            int[] scoreArray = { 78, 45, 89, 67, 92, 54, 81 };

            Console.WriteLine("Before Sorting:");
            examScores.DisplayAll(scoreArray);

            examScores.SelectionSort(scoreArray);

            Console.WriteLine("\n\nAfter Sorting:");
            examScores.DisplayAll(scoreArray);
        }
    }
}
