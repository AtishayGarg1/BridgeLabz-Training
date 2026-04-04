using System;

internal class OddEven
{
    static void Main(string[] args)
    {
        //read a number
        Console.WriteLine("Enter a Number");
        int number = int.Parse(Console.ReadLine());

        //create two arrays to store even and odd numbers
        int l = number / 2 + 1;
        int[] evenArray = new int[l];
        int[] oddArray = new int[l];
        int evenIndex = 0;
        int oddIndex = 0;

        //separate even and odd numbers
        for (int i = 1; i <= number; i++)
        {
            if (i % 2 == 0)
            {
                evenArray[evenIndex++] = i;
            }
            else
            {
                oddArray[oddIndex++] = i;
            }

        }
        Console.WriteLine("Even Elements");
        for (int i = 0; i < evenIndex; i++)
        {
            Console.WriteLine(evenArray[i]);
        }
        Console.WriteLine("Odd Elements");
        for (int i = 0; i < oddIndex; i++)
        {
            Console.WriteLine(oddArray[i]);
        }
    }
}