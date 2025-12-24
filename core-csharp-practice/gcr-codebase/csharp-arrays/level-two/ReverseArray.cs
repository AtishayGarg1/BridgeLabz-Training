using System;

internal class ReverseArray
{
    static void Main(string[] args)
    {

        //read a number from user
        Console.WriteLine("Enter a Number ");
        int number = int.Parse(Console.ReadLine());

        int n1 = number;
        int n2 = number;
        int counter = 0;
        int index = 0;

        //count number of digits
        while (n1 > 0)
        {
            counter++;
            n1 /= 10;
        }

        int[] arr = new int[counter];
        while (n2 > 0)
        {
            arr[index++] = n2 % 10;
            n2 /= 10;
        }

        //create reverse array to reverse a number
        int[] reverseArray = new int[counter];
        for (int i = 0; i < arr.Length; i++)
        {
            reverseArray[i] = arr[i];
        }
        Console.WriteLine("Reversed Array");
        for (int i = 0; i < reverseArray.Length; i++)
        {
            Console.WriteLine(reverseArray[i]);
        }
    }
}