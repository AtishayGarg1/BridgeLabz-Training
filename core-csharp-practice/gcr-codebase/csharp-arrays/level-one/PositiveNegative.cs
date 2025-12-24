using System;

internal class PositiveNegative
{
    static void Main(string[] args)
    {
        //create an array to store 5 numbers
        int[] numbers = new int[5];
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("Enter a number:");
            numbers[i] = int.Parse(Console.ReadLine());

            //check if the number is positive or negative
            if (numbers[i] >= 0)
            {
                Console.WriteLine("The number " + numbers[i] + " is Positive.");
            }
            else
            {
                Console.WriteLine("The number " + numbers[i] + " is Negative.");
            }
        }

        //compare first and last elements
        if (numbers[0] < numbers[4])
        {
            Console.WriteLine("Last Element is greater");
        }
        else if (numbers[0] > numbers[4])
        {
            Console.WriteLine("First Element is greater");
        }
        else
        {
            Console.WriteLine("Both are equal");
        }
    }
}