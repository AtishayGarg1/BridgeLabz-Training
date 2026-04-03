using System;

class SumNaturalFor
{
	static void Main()
	{
		Console.Write("Enter a natural number: ");
		int n = int.Parse(Console.ReadLine());
		//Check for natural number
		if(n <= 0)
		{
			Console.WriteLine("Invalid input. Enter a natural number.");
			return;
		}
		int sumLoop = 0;
		//sum of natural number using for loop
		for(int i = 1; i <= n; i++)
		{
			sumLoop += i;
		}
		//Sum of n natural no. using formula ((n+1)*n)/2
		int sumFormula = n * (n + 1) / 2;
		Console.WriteLine("Sum using for loop = " + sumLoop);
		Console.WriteLine("Sum using formula = " + sumFormula);
	}
}
