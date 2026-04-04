using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphism_abstraction.bankingSystem
{
    internal class Program
    {
        static void Main()
        {
            SavingsAccount savings = new SavingsAccount();
            savings.AccountNumber = "SAV1001";
            savings.HolderName = "Atishay";
            savings.SetPin("1234");
            savings.Deposit(50000);

            CurrentAccount current = new CurrentAccount();
            current.AccountNumber = "CUR2001";
            current.HolderName = "BusinessCorp";
            current.SetPin("5678");
            current.Deposit(200000);

            BankAccount[] accounts = new BankAccount[2];
            accounts[0] = savings;
            accounts[1] = current;

            BankService.ProcessAccounts(accounts);
        }
}
