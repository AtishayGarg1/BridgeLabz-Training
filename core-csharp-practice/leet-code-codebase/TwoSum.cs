using System;

class TwoSum
{
	static void Main()
	{
		int[] nums = new int[9];
		for(int i = 1;i<=9;i++){
			nums[i] = i;
		}
		int target = 10;
		int[] ans = { 0, 0 };

		bool found = false;

		for (int i = 0; i < nums.Length - 1 && !found; i++)
		{
			for (int j = i + 1; j < nums.Length; j++)
			{
				if (nums[i] + nums[j] == target)
				{
					ans[0] = i;
					ans[1] = j;
					found = true;
					break;
				}
			}
		}

		Console.WriteLine(ans[0] + " " + ans[1]);
	}
}
