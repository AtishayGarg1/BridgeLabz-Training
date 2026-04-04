using System;

internal class MultiplicationTableBetweenSixToNine
{
    static void Main(string[] args)
    {
        //read a number
        Console.WriteLine("Enter a Number from 6 to 9");
        int number = int.Parse(Console.ReadLine());

        //make an array to store multiplication table from 6 to 9
        int[] table = new int[4];
        for (int i = 6; i < 10; i++)
        {
            table[i - 6] = i * number;
            Console.WriteLine(number + " x " + (i) + " = " + table[i - 6]);
        }
    }
}