using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.thisstatic
{
    internal class BankAccountSystem
    {
        //Static variable 
        public static string bankName = "Global Bank";

        private static int totalAccounts = 0;

        public string accountHolderName;


        //Readonly variable
        public readonly int accountNumber;

        //Class Method to get Account counts
        public static int getTotalAccount()
        {
            return totalAccounts;
        }

        //Constructor to resolve Ambiguity
        public BankAccountSystem(string accountHolderName, int accountNumber)
        {
            this.accountNumber = accountNumber;
            this.accountHolderName = accountHolderName;
            totalAccounts++;
        }


        //Function to display details 
        public void DisplayDetails(object obj)
        {
            if (obj is BankAccountSystem)
            {
                Console.WriteLine("Bank Name: " + bankName);
                Console.WriteLine("Account Holder: " + accountHolderName);
                Console.WriteLine("Account Number: " + accountNumber);

            }
            else
            {
                Console.WriteLine("Invalid account object");
            }
        }
    }


    class run
    {
        //Main method for execution
        static void Main(string[] args)
        {
            BankAccountSystem obj1 = new("Atishay Garg", 123);
            obj1.DisplayDetails(obj1);

            Console.WriteLine();

            BankAccountSystem obj2 = new("Amritanshu Gupta", 456);
            obj2.DisplayDetails(obj2);
        }
    }

}
