using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Loan_Buddy
{
    internal class LoanMain
    {
        class Program
        {
            static void Main(string[] args)
            {
                LoanMenu menu = new LoanMenu();
                menu.Start();
            }
        }
    }
}
