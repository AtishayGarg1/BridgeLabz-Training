using System;

internal class Factors
{
    static void Main(string[] args)
    {
        //read a number
        Console.WriteLine("Enter a Number");
        int number = int.Parse(Console.ReadLine());

        //make an array to store factors
        int[] factors = new int[number / 2 + 1];
        int index = 0;

        //calculate factors
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                factors[index++] = i;
            }
        }
        for (int i = 0; i < index; i++)
        {
            Console.WriteLine(factors[i]);
        }
    }
}