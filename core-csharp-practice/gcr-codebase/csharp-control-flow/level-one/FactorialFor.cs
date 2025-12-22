using System;

class FactorialFor
{
	static void Main()
	{
		Console.Write("Enter a positive integer: ");
		int n = int.Parse(Console.ReadLine());
		//Check for natural number
		if(n < 0)
		{
			Console.WriteLine("Factorial not defined for negative numbers.");
			return;
		}
		long fact = 1;
		//find factorial using while loop
		for(int i = 1; i <= n; i++)
		{
			fact *= i;
		}
		Console.WriteLine("Factorial = " + fact);
	}
}
