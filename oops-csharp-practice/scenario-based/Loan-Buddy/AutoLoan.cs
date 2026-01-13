using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BridgeLabzTraining.Loan_Buddy
{

    class AutoLoan : LoanApplication
    {
        Applicant applicant;
        public AutoLoan(Applicant applicant, int term)
            : base(applicant, term, 10.5)
        {
        }

        public override bool ApproveLoan()
        {
            bool approved = applicant.getCreditScore() >= 650 &&
                            applicant.getIncome() >= 30000;

            SetLoanStatus(approved);
            return approved;
        }

        public override double CalculateEMI()
        {
            return BaseEMI() * 1.02; // processing fee
        }
    }
}
