using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.scenariobased.atmdispenser
{
    // Node class representing a single currency note in the ATM
    internal class ATMNode
    {
        public int Amount;
        public ATMNode Next;

        public ATMNode(int amount)
        {
            Amount = amount;
            Next = null;
        }

        // Override ToString() to Display Node
        public override string? ToString()
        {
            return "Amount: " + Amount;
        }
    }
}
