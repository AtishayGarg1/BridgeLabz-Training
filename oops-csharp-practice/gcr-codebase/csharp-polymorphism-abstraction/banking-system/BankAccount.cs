using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphism_abstraction.bankingSystem
{
    internal abstract class BankAccount
    {
        protected string accountNumber;
        protected string holderName;
        protected double balance;

        private string pin;

        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        public string HolderName
        {
            get { return holderName; }
            set { holderName = value; }
        }

        public double Balance
        {
            get { return balance; }
        }

        public void SetPin(string pinNumber)
        {
            pin = pinNumber;
        }

        protected bool VerifyPin(string enteredPin)
        {
            return pin == enteredPin;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
                balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
                balance -= amount;
        }

        public abstract double CalculateInterest();

        public void DisplayAccountDetails()
        {
            Console.WriteLine($"Account No: {AccountNumber}, Holder: {HolderName}, Balance: {Balance}");
        }
    }
}
