using System;

class UniversityFees
{	
	static void Main()
	{
	        int original_Fees = 125000;
	        double discount_Percent = 0.10;
        	int discount = (int)(original_Fees * discount_Percent);
        	int final_Fees = original_Fees - discount;
        	Console.WriteLine("The discount amount is INR " + discount + " and final discounted fee is INR " + final_Fees);
	}
}
