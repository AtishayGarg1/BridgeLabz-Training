using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.scenariobased
{
    internal class TemperatureAnalyzer
    {
        static void Main()
        {
            TemperatureAnalyzer analyzer = new TemperatureAnalyzer();
            analyzer.Execute();
        }

        public void Execute()
        {
            float[,] temperatureData = ReadTemperatureData();
            AnalyzeTemperatureData(temperatureData);
        }

        //Function to read 7x24 temperature data
        float[,] ReadTemperatureData()
        {
            float[,] data = new float[7, 24];

            Console.WriteLine("Enter hourly temperature data for 7 days");

            for (int day = 0; day < 7; day++)
            {
                Console.WriteLine("Day " + (day + 1));

                for (int hour = 0; hour < 24; hour++)
                {
                    while (true)
                    {
                        Console.Write("Hour " + (hour + 1) + ": ");
                        if (float.TryParse(Console.ReadLine(), out data[day, hour]))
                        {
                            break;
                        }
                        Console.WriteLine("Invalid input. Enter a numeric value.");
                    }
                }
            }

            return data;
        }

        //Function to analyze temperatures
        void AnalyzeTemperatureData(float[,] data)
        {
            float hottestAverage = float.MinValue;
            float coldestAverage = float.MaxValue;
            int hottestDay = 0;
            int coldestDay = 0;

            for (int day = 0; day < 7; day++)
            {
                float dailySum = CalculateDailySum(data, day);
                float dailyAverage = dailySum / 24;

                Console.WriteLine("Average temperature for Day " + (day + 1) + ": " + dailyAverage);

                if (dailyAverage > hottestAverage)
                {
                    hottestAverage = dailyAverage;
                    hottestDay = day + 1;
                }

                if (dailyAverage < coldestAverage)
                {
                    coldestAverage = dailyAverage;
                    coldestDay = day + 1;
                }
            }

            DisplayExtremes(hottestDay, coldestDay);
        }

        //Function to calculate daily sum
        float CalculateDailySum(float[,] data, int day)
        {
            float sum = 0;

            for (int hour = 0; hour < 24; hour++)
            {
                sum += data[day, hour];
            }

            return sum;
        }

        //Function to display hottest and coldest days
        void DisplayExtremes(int hottestDay, int coldestDay)
        {
            Console.WriteLine();
            Console.WriteLine("Hottest Day: Day " + hottestDay);
            Console.WriteLine("Coldest Day: Day " + coldestDay);
        }
    }
}
