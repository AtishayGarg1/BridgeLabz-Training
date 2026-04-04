using System;

class SwapNumbers
{
    	static void Main()
    	{
        	// Read two numbers
        	Console.WriteLine("Enter first number:");
       		int number1 = int.Parse(Console.ReadLine());
	        Console.WriteLine("Enter second number:");
        	int number2 = int.Parse(Console.ReadLine());
	        // Swap using a temporary variable
        	int temp = number1;
        	number1 = number2;
        	number2 = temp;
        	Console.WriteLine("The swapped numbers are " + number1 + " and " + number2);
	}
}
