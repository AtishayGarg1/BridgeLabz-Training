using System;

internal class DimensionConversion
{
    static void Main(string[] args)
    {
        //read rows and columns
        Console.WriteLine("Enter the Rows");
        int row = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the columns");
        int columns = int.Parse(Console.ReadLine());

        //make a 2d array and store elements
        int[,] arr = new int[row, columns];
        Console.WriteLine("Enter the Elements");
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = int.Parse(Console.ReadLine());
            }
        }
        int[] ans = new int[row * columns];
        int index = 0;

        //convert 2d to 1d
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                ans[index++] = arr[i, j];
            }
        }
        for (int i = 0; i < ans.Length; i++)
        {
            Console.WriteLine(ans[i]);
        }
    }
}