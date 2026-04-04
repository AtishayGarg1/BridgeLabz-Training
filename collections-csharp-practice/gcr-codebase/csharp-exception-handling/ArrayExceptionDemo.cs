
using System;

namespace BridgeLabzTraining.csharp_collections.assignment.exception_handling
{
    class ArrayExceptionDemo
    {
        static void Main()
        {
            int[] arr = {10, 20, 30};

            try
            {
                Console.Write("Enter index: ");
                int index = int.Parse(Console.ReadLine());
                Console.WriteLine($"Value: {arr[index]}");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid index!");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Array is not initialized!");
            }
        }
    }
}
