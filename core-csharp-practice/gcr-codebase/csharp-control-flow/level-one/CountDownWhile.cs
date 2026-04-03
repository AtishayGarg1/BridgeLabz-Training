using System;

class CountDownWhile
{
	static void Main()
	{
		//Read a Counter for Rocket Launch
		Console.Write("Enter countdown start number: ");
		int counter = int.Parse(Console.ReadLine());
		//Run Loop for Counter
		while(counter >= 1)
		{
			Console.WriteLine(counter);
			counter--;
		}
	}
}