using System;

internal class BMIIndex2DArray
{
    static void Main(string[] args)
    {
        //Read Number of People
        Console.WriteLine("Enter the Number of People");
        int number = int.Parse(Console.ReadLine());

        //2d Array to store Weight, Height and BMI Index
        double[,] arr = new double[number, 3];
        String[] weightStatus = new String[3];

        //Calculate BMI Index for each person
        for (int i = 0; i < number; i++)
        {
            Console.WriteLine("Enter Weight in Kilograms");
            arr[i, 0] = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Height in Centimeters");
            arr[i, 1] = double.Parse(Console.ReadLine()) / 100;

            if (arr[i, 0] <= 0 || arr[i, 1] <= 0)
            {
                i--;
                Console.WriteLine("Enter Positive Values Only");
                continue;
            }

            arr[i, 2] = arr[i, 0] / (arr[i, 1] * arr[i, 1]);

            //Determine Weight Status
            if (arr[i, 2] <= 18.4)
            {
                weightStatus[i] = "Underweight";
            }
            else if (arr[i, 2] <= 24.9 && arr[i, 2] >= 18.5)
            {
                weightStatus[i] = "Normal";
            }
            else if (arr[i, 2] >= 25 && arr[i, 2] <= 39.9)
            {
                weightStatus[i] = "Overweight";
            }
            else
            {
                weightStatus[i] = "Obese";
            }
            Console.WriteLine("Height is: " + (arr[i, 1] * 100) + " Centimeters \nWeight is: " + arr[i, 0] + " Kilograms \nBMI Index is: " + arr[i, 2] + "\nStatus is: " + weightStatus[i] + "\n");

        }
    }
}