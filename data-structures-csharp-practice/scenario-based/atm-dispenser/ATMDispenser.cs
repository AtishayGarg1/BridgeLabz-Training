using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.scenariobased.atmdispenser
{
    internal class ATMDispenser
    {
        ATMNode head;

        // Function to Find optimal combo using Linked List
        public void Initialize(int amount, int[] notesPresent)
        {
            Array.Sort(notesPresent);
            int index = notesPresent.Length - 1;
            if (amount == 0)
            {
                Console.WriteLine("Zero Entered As Zero");
                return;
            }
            for (int i = index; i >= 0; i--)
            {
                while (notesPresent[i] <= amount)
                {
                    
                    ATMNode node = new ATMNode(notesPresent[i]);
                    amount -= notesPresent[i];
                    if(head == null)
                    {
                        head = node;
                        continue;
                    }
                    ATMNode curr = head;
                    while(curr.Next != null)
                    {
                        curr = curr.Next;
                    }
                    curr.Next = node;
                    node.Next = null;
                }
            }
            DisplayList();
            if(amount > 0)
            {
                Console.WriteLine("Exact Change Not Found\nRemaining Amount: "+amount);
            }
        }

        // Function to display the combo retrieved
        public void DisplayList()
        {
            ATMNode curr = head;
            Console.WriteLine("Amount Retrieved in Combo ");
            while(curr != null)
            {
                Console.WriteLine(curr.ToString());
                curr = curr.Next;
            }
        }

    }
}
