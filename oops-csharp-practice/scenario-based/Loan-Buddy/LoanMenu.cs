using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Loan_Buddy
{
    class LoanMenu
    {
        public void Start()
        {
            Console.WriteLine("===== Welcome to LoanBuddy =====");

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Credit Score: ");
            int creditScore = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Monthly Income: ");
            double income = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Loan Amount: ");
            double loanAmount = Convert.ToDouble(Console.ReadLine());

            Applicant applicant = new Applicant(name, creditScore, income, loanAmount);

            Console.WriteLine("\nSelect Loan Type:");
            Console.WriteLine("1. Home Loan");
            Console.WriteLine("2. Auto Loan");
            Console.Write("Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Loan Term (months): ");
            int term = Convert.ToInt32(Console.ReadLine());

            LoanApplication loan = null;

            switch (choice)
            {
                case 1:
                    loan = new HomeLoan(applicant, term);
                    break;
                case 2:
                    loan = new AutoLoan(applicant, term);
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    return;
            }

            LoanUtility.ProcessLoan(loan);
        }
    }
}
