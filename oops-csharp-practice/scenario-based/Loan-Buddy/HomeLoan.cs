using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BridgeLabzTraining.Loan_Buddy
{
    class HomeLoan : LoanApplication
    {
         Applicant applicant;
        public HomeLoan(Applicant applicant, int term)
            : base(applicant, term, 8.5)
        {
        }

        public override bool ApproveLoan()
        {
            bool approved = applicant.getCreditScore() >= 700 &&
                            applicant.getIncome() >= 50000;

            SetLoanStatus(approved);
            return approved;
        }

        public override double CalculateEMI()
        {
            return BaseEMI();
        }
    }

}
