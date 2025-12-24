using System;

class MinimumBoxesLeetcode
{
    public static int Boxes(int[] apple, int[] capacity)
    {
        Array.Sort(capacity);

        int sum = 0;
        int count = 0;
        int sumApple = 0;

        foreach (int i in apple)
        {
            sumApple += i;
        }

        for (int i = capacity.Length - 1; i >= 0; i--)
        {
            sum += capacity[i];
            count++;

            if (sum >= sumApple)
            {
                return count;
            }
        }

        return -1;
    }

    static void Main(string[] args)
    {
        int[] apple = { 1, 3, 2 };
        int[] capacity = { 4, 3, 1, 5 };

        int result = Boxes(apple, capacity);

        Console.WriteLine(result);
    }
}
