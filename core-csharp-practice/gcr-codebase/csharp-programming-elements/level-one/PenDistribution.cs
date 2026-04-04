using System;

class PenDistribution
{
	static void Main()
	{
		int pens = 14;
		int students = 3;
		int pens_Each = pens / students;
		int remaining_Pens = pens % students;
		Console.WriteLine("The Pen Per Student is " + pens_Each + " and the remaining pen not distributed is " + remaining_Pens);
	}
}