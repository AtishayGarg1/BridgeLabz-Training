
using System;

namespace BridgeLabzTraining.csharp_collections.assignment.exception_handling
{
    class InterestCalculator
    {
        static double CalculateInterest(double amount, double rate, int years)
        {
            if (amount < 0 || rate < 0)
                throw new ArgumentException("Amount and rate must be positive");

            return amount * rate * years / 100;
        }

        static void Main()
        {
            try
            {
                Console.WriteLine(CalculateInterest(10000, -5, 2));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Invalid input: " + ex.Message);
            }
        }
    }
}
