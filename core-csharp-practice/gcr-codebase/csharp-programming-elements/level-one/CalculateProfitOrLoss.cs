using System;
class CalculateProfitOrLoss
{
	static void Main()
	{
		int cost_Price = 129;
		int selling_Price = 191;
		int profit = selling_Price - cost_Price;
		double profit_Percentage = (profit / cost_Price) * 100;
		Console.WriteLine("The Cost Price is INR " + cost_Price + " and Selling Price is INR " + selling_Price);
		Console.WriteLine("The Profit is INR " + profit + " and the Profit Percentage is " + profit_Percentage);
	}
}
