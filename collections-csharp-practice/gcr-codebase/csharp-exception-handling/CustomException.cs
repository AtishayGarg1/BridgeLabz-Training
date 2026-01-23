
using System;

namespace BridgeLabzTraining.csharp_collections.assignment.exception_handling
{
    class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message) { }
    }

    class AgeValidation
    {
        static void ValidateAge(int age)
        {
            if (age < 18)
                throw new InvalidAgeException("Age must be 18 or above");
        }

        static void Main()
        {
            try
            {
                Console.Write("Enter age: ");
                int age = int.Parse(Console.ReadLine());
                ValidateAge(age);
                Console.WriteLine("Access granted!");
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
