using System;

class GreatestFactor
{
	static void Main()
	{
		//Read The Numbers
		Console.Write("Enter a number: ");
		int number = int.Parse(Console.ReadLine());
		int greatestFactor = 1;
		//Calculate the greatest Factor
		for(int i = number - 1; i >= 1; i--)
		{
			if(number % i == 0)
			{
				greatestFactor = i;
				break;
			}
		}
		Console.WriteLine("Greatest Factor: " + greatestFactor);
	}
}
