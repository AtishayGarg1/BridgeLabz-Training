using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphism_abstraction.bankingSystem
{
    internal class SavingsAccount : BankAccount, ILoanable
    {
        public override double CalculateInterest()
        {
            return balance * 0.04; // 4% interest
        }

        public void ApplyForLoan(double amount)
        {
            Console.WriteLine($"Loan applied for ₹{amount} on Savings Account");
        }

        public double CalculateLoanEligibility()
        {
            return balance * 5; // eligible up to 5x balance
        }
    }
}
