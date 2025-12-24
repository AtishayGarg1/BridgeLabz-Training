using System;

internal class ResizeLargestSecondLargest
{
    static void Main(string[] args)
    {
        //read a number from user
        Console.WriteLine("Enter a Number");
        long number = long.Parse(Console.ReadLine());

        //find largest and second largest digit
        int maxDigit = 10;
        long n1 = number;
        long[] arr = new long[maxDigit];
        int index = 0;

        //store digits in an array
        while (n1 > 0)
        {
            if (index == maxDigit)
            {
                maxDigit += 10;
                long[] temp = new long[maxDigit];
                Array.Copy(arr, temp, arr.Length);
                arr = temp;
            }
            arr[index++] = n1 % 10;
            n1 /= 10;
        }

        //resize the array to actual number of digits
        long largest = arr[0];
        long secondLargest = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > largest)
            {
                secondLargest = largest;
                largest = arr[i];
            }
            else if (arr[i] > secondLargest && arr[i] != largest)
            {
                secondLargest = arr[i];
            }
        }
        Console.WriteLine("Largest Digit is: " + largest);
        Console.WriteLine("Second Largest Digit is: " + secondLargest);
    }
}