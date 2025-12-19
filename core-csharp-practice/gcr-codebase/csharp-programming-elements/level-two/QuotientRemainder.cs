using System;

class QuotientRemainder
{
   	static void Main()
	{
		//Read Two Numbers
        	Console.WriteLine("Enter first number:");
        	int number1 = int.Parse(Console.ReadLine());	
	        Console.WriteLine("Enter second number:");
        	int number2 = int.Parse(Console.ReadLine());	
		//Perform divison and Modulus Operations to get Quotient and Remainder
	        int quotient = number1 / number2;
        	int remainder = number1 % number2;
	        Console.WriteLine("The Quotient is " + quotient + " and Remainder is " + remainder + " of two numbers " + number1 + " and " + number2 );
	}
}
