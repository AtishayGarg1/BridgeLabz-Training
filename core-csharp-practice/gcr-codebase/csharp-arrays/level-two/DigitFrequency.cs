using System;

internal class DigitFrequency
{
    static void Main(string[] args)
    {
        //read a number
        Console.WriteLine("Enter a Number");
        int number = int.Parse(Console.ReadLine());

        int[] frequency = new int[10];

        //calculate frequency of digits
        while (number > 0)
        {
            int digit = number % 10;
            frequency[digit]++;
            number /= 10;
        }
        for (int i = 0; i < frequency.Length; i++)
        {
            if (frequency[i] > 0)
            {
                Console.WriteLine(i + " occurs " + frequency[i] + " times");
            }
        }
    }
}