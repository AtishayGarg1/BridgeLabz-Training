using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphism_abstraction.bankingSystem
{
    internal class BankService
    {
        public static void ProcessAccounts(BankAccount[] accounts)
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                BankAccount account = accounts[i];

                double interest = account.CalculateInterest();

                account.DisplayAccountDetails();
                Console.WriteLine($"Interest Earned: {interest}");

                if (account is ILoanable loanable)
                {
                    Console.WriteLine($"Loan Eligibility: {loanable.CalculateLoanEligibility()}");
                }
            }
        }
    }
}
