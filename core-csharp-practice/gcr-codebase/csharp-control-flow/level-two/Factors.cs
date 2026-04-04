using System;

class Factors
{
	static void Main()
	{
		//Read a Number
		Console.Write("Enter a number: ");
		int number = int.Parse(Console.ReadLine());
		//Calculate the factors
		for(int i = 1; i < number; i++)
		{
			if(number % i == 0)
				Console.WriteLine(i);
		}
	}
}
