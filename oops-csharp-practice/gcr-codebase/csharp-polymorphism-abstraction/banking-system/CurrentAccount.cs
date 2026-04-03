using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphism_abstraction.bankingSystem
{
    internal class CurrentAccount : BankAccount, ILoanable
    {
        public override double CalculateInterest()
        {
            return balance * 0.02; // 2% interest
        }

        public void ApplyForLoan(double amount)
        {
            Console.WriteLine($"Loan applied for ₹{amount} on Current Account");
        }

        public double CalculateLoanEligibility()
        {
            return balance * 10; // eligible up to 10x balance
        }
    }
}
