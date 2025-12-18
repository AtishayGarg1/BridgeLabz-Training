using System;

class Palindrome
{
	static void Main()
	{
		int n = 1234321;
		int n1 = n;
		int rev = 0;
		
		while(n1 > 0)
		{
			int r = n1 % 10;
			rev = rev * 10 + r;
			n1 /= 10;
		}

		if(rev == n)
		{
			Console.WriteLine(n + " is a Palindrome Number ");
		}
		else
		{
			Console.WriteLine(n + " is not a Palindrome Number ");
		}
	}
}