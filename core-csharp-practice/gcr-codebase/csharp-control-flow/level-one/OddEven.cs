using System;

class OddEven
{
	static void Main()
	{
		Console.Write("Enter a natural number: ");
		int number = int.Parse(Console.ReadLine());
		//Check for natural number
		if(number <= 0)
		{
			Console.WriteLine("Invalid input.");
			return;
		}
		//loop till number n
		for(int i = 1; i <= number; i++)
		{
			if(i % 2 == 0)
			{
				Console.WriteLine(i + " is Even");
			}
			else
			{
				Console.WriteLine(i + " is Odd");
			}
		}
	}
}
