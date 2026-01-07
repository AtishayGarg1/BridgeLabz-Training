using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphism_abstraction.bankingSystem
{
    internal interface ILoanable
    {
        void ApplyForLoan(double amount);
        double CalculateLoanEligibility();
    }
}
