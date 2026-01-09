using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.scenariobased.atmdispenser
{
    internal class ATMDispenserMain
    {
        static void Main(string[] args)
        {
            ATMDispenser aTMDispenser = new ATMDispenser();

            // Scenario 1 - Optimal combo with 500 note
            int[] notesPresent = new int[] { 2, 5, 10, 20, 50, 100, 200, 500 };
            Console.Write("Enter Amount: ");
            int amount = int.Parse(Console.ReadLine());
            aTMDispenser.Initialize(amount, notesPresent);
        }
    }
}
