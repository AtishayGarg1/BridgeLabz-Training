using System;

class FizzBuzzWhile
{
	static void Main()
	{
		//Enter a positive number
		Console.Write("Enter a positive number: ");
		int n = int.Parse(Console.ReadLine());
		int i = 1;
		//Printing required value according to given condition using while loop
		while(i <= n)
		{
			if(i % 3 == 0 && i % 5 == 0)
				Console.WriteLine("FizzBuzz");
			else if(i % 3 == 0)
				Console.WriteLine("Fizz");
			else if(i % 5 == 0)
				Console.WriteLine("Buzz");
			else
				Console.WriteLine(i);
			i++;
		}
	}
}
