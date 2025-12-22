using System;

class PrimeCheck
{
	static void Main()
	{
		//Read a Number
		Console.Write("Enter a number: ");
		int number = int.Parse(Console.ReadLine());
		bool isPrime = true;
		//check for negative number
		if(number <= 1)
		{
			isPrime = false;
		}
		else
		{
			//check for prime
			for(int i = 2; i < number; i++)
			{
				if(number % i == 0)
				{
					isPrime = false;
					break;
				}
			}
		}
		if(isPrime)
			Console.WriteLine("Prime Number");
		else
			Console.WriteLine("Not a Prime Number");
	}
}
