using System;

class MultiplicationTable
{
	static void Main()
	{
		//Enter a number
		Console.Write("Enter a number: ");
		int number = int.Parse(Console.ReadLine());
		//Run loop to find Multiplication of a number from  to 9
		for(int i = 6; i <= 9; i++)
		{
			Console.WriteLine(number + " * " + i + " = " + (number * i));
		}
	}
}
