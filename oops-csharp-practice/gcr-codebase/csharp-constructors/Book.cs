using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Constructors
{
    internal class BankAccountManagement
    {
        // Instance variables
        public int accountNumber;
        protected string name;
        private int balance;

        // Getter for balance
        public int GetBalance()
        {
            return balance;
        }

        // Setter for balance
        public void SetBalance(int balance)
        {
            this.balance = balance;
        }

        // Constructor
        public BankAccountManagement(int accountNumber, string name, int balance)
        {
            this.accountNumber = accountNumber;
            this.name = name;
            this.balance = balance;
        }

        // Display details
        public void DisplayDetails()
        {
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Balance: " + balance);
        }
    }

    // Derived class
    class SavingsAccount : BankAccountManagement
    {
        public SavingsAccount(int accountNumber, string name, int balance)
            : base(accountNumber, name, balance) { }
    }

    // Main execution class
    class run
    {
        static void Main(string[] args)
        {
            BankAccountManagement obj1 = new(12345, "Atishay", 6000);
            obj1.DisplayDetails();

            obj1.SetBalance(6600);
            Console.WriteLine("Updated: " + obj1.GetBalance());
            obj1.DisplayDetails();
        }
    }
}
