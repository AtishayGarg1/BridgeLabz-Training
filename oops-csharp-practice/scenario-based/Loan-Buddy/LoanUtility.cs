using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Loan_Buddy
{
    class LoanUtility
    {
        public static void ProcessLoan(LoanApplication loan)
        {
            if (loan.ApproveLoan())
            {
                Console.WriteLine("\nLoan Approved ✅");
                Console.WriteLine("Monthly EMI: ₹" + loan.CalculateEMI());
            }
            else
            {
                Console.WriteLine("\nLoan Rejected ❌");
            }
        }
    }
}
