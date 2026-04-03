
using System;

namespace BridgeLabzTraining.csharp_collections.assignment.exception_handling
{
    class NestedTryDemo
    {
        static void Main()
        {
            int[] arr = {10, 20, 30};

            try
            {
                int index = int.Parse(Console.ReadLine());
                try
                {
                    int divisor = int.Parse(Console.ReadLine());
                    Console.WriteLine(arr[index] / divisor);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Cannot divide by zero!");
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid array index!");
            }
        }
    }
}
