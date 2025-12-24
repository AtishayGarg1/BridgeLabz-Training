using System;

internal class MultiplicationTable
{
    static void Main(string[] args)
    {
        //read a number
        Console.WriteLine("Enter a number");
        int number = int.Parse(Console.ReadLine());

        //make an array to store multiplication table
        int[] table = new int[10];

        //calculate multiplication table
        for (int i = 0; i < table.Length; i++)
        {
            table[i] = number * (i + 1);
            Console.WriteLine(number + " x " + (i + 1) + " = " + table[i]);
        }
    }
}