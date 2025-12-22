using System;

class SumNaturalWhile
{
	static void Main()
	{
		//Read a number
		Console.Write("Enter a natural number: ");
		int n = int.Parse(Console.ReadLine());
		//Check for natural number
		if(n <= 0)
		{
			Console.WriteLine("Invalid input. Enter a natural number.");
			return;
		}
		int sumLoop = 0;
		int i = 1;
		//sum of natural number using while loop
		while(i <= n)
		{
			sumLoop += i;
			i++;
		}
		//Sum of n natural no. using formula ((n+1)*n)/2
		int sumFormula = n * (n + 1) / 2;
		Console.WriteLine("Sum using while loop = " + sumLoop);
		Console.WriteLine("Sum using formula = " + sumFormula);
	}
}
