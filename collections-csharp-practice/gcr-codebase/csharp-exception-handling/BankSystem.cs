
using System;

namespace BridgeLabzTraining.csharp_collections.assignment.exception_handling
{
    class InsufficientFundsException : Exception
    {
        public InsufficientFundsException(string message) : base(message) { }
    }

    class BankAccount
    {
        double balance = 5000;

        public void Withdraw(double amount)
        {
            if (amount < 0)
                throw new ArgumentException("Invalid amount!");

            if (amount > balance)
                throw new InsufficientFundsException("Insufficient balance!");

            balance -= amount;
            Console.WriteLine("Withdrawal successful, new balance: " + balance);
        }
    }

    class BankDemo
    {
        static void Main()
        {
            try
            {
                new BankAccount().Withdraw(7000);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
