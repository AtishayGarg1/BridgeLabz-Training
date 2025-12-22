using System;

class MultiplesBelowHundred
{
	static void Main()
	{
		//Read a number
		Console.Write("Enter a number: ");
		int number = int.Parse(Console.ReadLine());
		//Calculate factors below 100
		for(int i = 100; i >= 1; i--)
		{
			if(i % number == 0)
				Console.WriteLine(i);
		}
	}
}
