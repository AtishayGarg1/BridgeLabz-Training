using System;

internal class FizzBuzz
{
    static void Main(string[] args)
    {
        //read a number
        Console.WriteLine("Enter a Number");
        int number = int.Parse(Console.ReadLine());

        //string array to store results
        String[] ans = new String[number];

        //fizzbuzz logic
        if (number < 0)
        {
            Console.WriteLine("Invalid input");
        }
        else
        {
            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    ans[i - 1] = "FizzBuzz";
                }
                else if (i % 5 == 0)
                {
                    ans[i - 1] = "Buzz";
                }
                else if (i % 3 == 0)
                {
                    ans[i - 1] = "Fizz";
                }
                else
                {
                    ans[i - 1] = "" + i;
                }
            }
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(ans[i]);
            }
        }
    }
}