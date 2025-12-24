using System;

internal class LargestSecondLargest
{
    static void Main(string[] args)
    {
        //read a number from user
        Console.WriteLine("Enter a Number: ");
        int number = int.Parse(Console.ReadLine());

        //find largest and second largest digit
        int n1 = number;
        int c = 0;
        while (n1 > 0)
        {
            c++;
            n1 = n1 / 10;
        }

        //store digits in an array
        int[] arr = new int[c];
        int n2 = number;
        int index = 0;
        while (n2 > 0)
        {
            arr[index++] = n2 % 10;
            n2 = n2 / 10;
        }

        //find largest and second largest
        int largest = arr[0];
        int secondLargest = 0;
        int prevLargest = 0;
        for (int i = 1; i < arr.Length; i++)
        {
            if (largest < arr[i])
            {
                secondLargest = largest;
                largest = arr[i];
            }
            else if (secondLargest < arr[i] && arr[i] != largest)
            {
                secondLargest = arr[i];
            }
        }
        Console.WriteLine("Largest Digit: " + largest);
        Console.WriteLine("Second Largest Digit: " + secondLargest);
    }
}