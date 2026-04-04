using System;

class FizzBuzzFor
{
	static void Main()
	{
		//Read a positive Number
		Console.Write("Enter a positive number: ");
		int n = int.Parse(Console.ReadLine());
		//Printing required value according to given condition using for loop
		for(int i = 1; i <= n; i++)
		{
			if(i % 3 == 0 && i % 5 == 0)
				Console.WriteLine("FizzBuzz");
			else if(i % 3 == 0)
				Console.WriteLine("Fizz");
			else if(i % 5 == 0)
				Console.WriteLine("Buzz");
			else
				Console.WriteLine(i);
		}
	}
}
