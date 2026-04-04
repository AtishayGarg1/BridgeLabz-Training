using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BridgeLabzTraining.Loan_Buddy
{
    public abstract class LoanApplication : IApprovable
    {
        public  Applicant applicant;   // FIXED: protected
        protected int term;               // months
        protected double interestRate;

        private bool loanStatus;           // restricted access

        public LoanApplication(Applicant applicant, int term, double interestRate)
        {
            this.applicant = applicant;
            this.term = term;
            this.interestRate = interestRate;
        }

        protected void SetLoanStatus(bool status)
        {
            loanStatus = status;
        }

        public bool GetLoanStatus()
        {
            return loanStatus;
        }

        protected double BaseEMI()
        {
            double P = applicant.getLoanAmount();   // FIXED
            double R = interestRate / 12 / 100;
            int N = term;

            return (P * R * Math.Pow(1 + R, N)) /
                   (Math.Pow(1 + R, N) - 1);
        }

        public abstract bool ApproveLoan();
        public abstract double CalculateEMI();
    }
}
