using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.scenariobased
{
    internal class StudentScoreManager
    {
        static void Main()
        {
            StudentScoreManager manager = new StudentScoreManager();
            manager.Execute();
        }

        public void Execute()
        {
            int studentCount = GetStudentCount();
            double[] scores = ReadScores(studentCount);
            ProcessScores(scores);
        }

        //Function to get number of students
        int GetStudentCount()
        {
            Console.Write("Enter number of students: ");
            int count;

            while (!int.TryParse(Console.ReadLine(), out count) || count <= 0)
            {
                Console.WriteLine("Invalid input. Enter a positive integer.");
            }

            return count;
        }

        //Function to read scores of students
        double[] ReadScores(int count)
        {
            double[] scores = new double[count];

            for (int i = 0; i < count; i++)
            {
                while (true)
                {
                    Console.Write("Enter score for student " + (i + 1) + ": ");
                    if (double.TryParse(Console.ReadLine(), out scores[i]) && scores[i] >= 0)
                    {
                        break;
                    }
                    Console.WriteLine("Invalid score. Enter a non-negative number.");
                }
            }

            return scores;
        }

        //Function to process and display results
        void ProcessScores(double[] scores)
        {
            double total = CalculateTotal(scores);
            double average = total / scores.Length;

            double highest = FindHighest(scores);
            double lowest = FindLowest(scores);

            DisplaySummary(average, highest, lowest);
            DisplayAboveAverage(scores, average);
        }

        //Function to Calculate total score
        double CalculateTotal(double[] scores)
        {
            double sum = 0;

            for (int i = 0; i < scores.Length; i++)
            {
                sum += scores[i];
            }

            return sum;
        }

        //Function to find highest
        double FindHighest(double[] scores)
        {
            double max = scores[0];

            for (int i = 1; i < scores.Length; i++)
            {
                if (scores[i] > max)
                {
                    max = scores[i];
                }
            }

            return max;
        }

        //Function to find Lowest 
        double FindLowest(double[] scores)
        {
            double min = scores[0];

            for (int i = 1; i < scores.Length; i++)
            {
                if (scores[i] < min)
                {
                    min = scores[i];
                }
            }

            return min;
        }

        //Function to display Summary
        void DisplaySummary(double average, double highest, double lowest)
        {
            Console.WriteLine();
            Console.WriteLine("Average Score: " + average);
            Console.WriteLine("Highest Score: " + highest);
            Console.WriteLine("Lowest Score: " + lowest);
        }

        //Function to display students above Average score
        void DisplayAboveAverage(double[] scores, double average)
        {
            Console.WriteLine();
            Console.WriteLine("Scores above average:");

            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] > average)
                {
                    Console.WriteLine(scores[i]);
                }
            }
        }
    }
}
