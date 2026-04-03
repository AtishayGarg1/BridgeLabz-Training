using System;

class PowerProgram
{
	static void Main()
	{
		//Read a number
		Console.Write("Enter number: ");
		int number = int.Parse(Console.ReadLine());
		//Read the power
		Console.Write("Enter power: ");
		int power = int.Parse(Console.ReadLine());

		int result = 1;
		//Calculate the result
		for (int i = 1; i <= power; i++)
		{
			result *= number;
		}
		Console.WriteLine("Result: " + result);
	}
}
