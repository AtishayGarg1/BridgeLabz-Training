using System;

class FriendsInfo
{
	static void Main()
	{
		//Enter Amar's age and height
		Console.Write("Enter Amar's age and height: ");
		int amarAge = int.Parse(Console.ReadLine());
		double amarHeight = double.Parse(Console.ReadLine());
		//Enter Akbar's age and height
		Console.Write("Enter Akbar's age and height: ");
		int akbarAge = int.Parse(Console.ReadLine());
		double akbarHeight = double.Parse(Console.ReadLine());
		//Enter Anthony's age and height
		Console.Write("Enter Anthony's age and height: ");
		int anthonyAge = int.Parse(Console.ReadLine());
		double anthonyHeight = double.Parse(Console.ReadLine());

		//Calculate the youngest and tallest
		int youngestAge = Math.Min(amarAge, Math.Min(akbarAge, anthonyAge));
		double tallestHeight = Math.Max(amarHeight, Math.Max(akbarHeight, anthonyHeight));
		Console.WriteLine("Youngest Age: " + youngestAge);
		Console.WriteLine("Tallest Height: " + tallestHeight);
	}
}
