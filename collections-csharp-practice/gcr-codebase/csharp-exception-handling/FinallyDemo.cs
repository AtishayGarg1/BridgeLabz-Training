
using System;

namespace BridgeLabzTraining.csharp_collections.assignment.exception_handling
{
    class FinallyDemo
    {
        static void Main()
        {
            try
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine(a / b);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            finally
            {
                Console.WriteLine("Operation completed");
            }
        }
    }
}
