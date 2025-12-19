using System;

class IntOperation
{
	static void Main()
	{
		// Take integer inputs
        	Console.WriteLine("Enter value of a:");
        	int a = int.Parse(Console.ReadLine());
	        Console.WriteLine("Enter value of b:");
        	int b = int.Parse(Console.ReadLine());
	        Console.WriteLine("Enter value of c:");
        	int c = int.Parse(Console.ReadLine());
		// Perform Operations on Integer Variables
	        int result1 = a + b * c;
        	int result2 = a * b + c;
        	int result3 = c + a / b;
        	int result4 = a % b + c;
	        Console.WriteLine("The results of Int Operations are " + result1 + ", " + result2 + ", " + result3 + ", and " + result4 );
    }
}
