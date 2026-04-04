using System;

class Handshakes
{
	static void Main()
	{
		Console.WriteLine("Enter The Number Of Students");	
		int students = int.Parse(Console.ReadLine());		//Input Number Of Students
		int handshakes = (students * (students-1)) / 2;		//Using Formula (n*(n-1))/2
		Console.WriteLine("Total Handshakes Possible: " + handshakes);
	}
}