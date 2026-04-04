using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.inheritance
{
    //Base class
    internal class BankAccount
    {
    
        public int AccountNumber;
        public double Balance;

        public BankAccount(int accNo, double balance)
        {
            AccountNumber = accNo;
            Balance = balance;
        }

        public virtual void DisplayAccountType()
        {
            Console.WriteLine("Generic Bank Account");
        }
    }

    //Savings Account
    class SavingsAccount : BankAccount
    {
        public double InterestRate;

        public SavingsAccount(int acc, double bal, double rate)
            : base(acc, bal)
        {
            InterestRate = rate;
        }

        public override void DisplayAccountType()
        {
            Console.WriteLine("Savings Account");
        }
    }

    //Checking Account
    class CheckingAccount : BankAccount
    {
        public int WithdrawalLimit;

        public CheckingAccount(int acc, double bal, int limit)
            : base(acc, bal)
        {
            WithdrawalLimit = limit;
        }

        public override void DisplayAccountType()
        {
            Console.WriteLine("Checking Account");
        }
    }
}
