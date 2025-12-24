using System;

internal class MeanHeight
{
    static void Main(string[] args)
    {
        //store height of 11 players
        double[] height = new double[11];
        double sum = 0;
        double mean = 0;

        //read heights
        for (int i = 0; i < height.Length; i++)
        {
            Console.WriteLine("Enter Height of Player");
            height[i] = double.Parse(Console.ReadLine());
            sum += height[i];
        }

        //calculate mean
        mean = sum / height.Length;
        Console.WriteLine("MMean Height of hte team is: " + mean);
    }
}