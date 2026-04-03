using System;

internal class SumOfElements
{
    static void Main(string[] args)
    {
        //create an array to store 10 numbers
        double[] numbers = new double[10];
        double sum = 0;
        int i = 0;

        //read numbers until a non-positive number is entered or array is full
        while (true)
        {
            Console.WriteLine("Enter a number:");
            numbers[i] = double.Parse(Console.ReadLine());
            if (i == 10)
            {
                break;
            }
            if (numbers[i] <= 0)
            {
                break;
            }
            sum += numbers[i];
        }
        Console.WriteLine("The sum of the elements in the array is: " + sum);
    }
}