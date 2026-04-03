using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Loan_Buddy
{
    internal class Applicant
    {
        private string name;
        private int creditScore;   // private (encapsulation)
        private double income;
        private double loanAmount;

        public Applicant(string name, int creditScore, double income, double loanAmount)
        {
            this.name = name;
            this.creditScore = creditScore;
            this.income = income;
            this.loanAmount = loanAmount;
        }

        public string getName()
        {
            return name;
        }

        public int getCreditScore()
        {
            return creditScore;
        }

        public double getIncome()
        {
            return income;
        }
        public double getLoanAmount()
        {
            return loanAmount;
        }

    }
}
