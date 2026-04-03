using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.leetcode
{
    internal class RemoveDuplicates
    {
        // Definition for singly-linked list
        public class ListNode
        {
            public int val;
            public ListNode next;

            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public ListNode DeleteDuplicates(ListNode head)
        {
            ListNode curr = head;

            while (curr != null && curr.next != null)
            {
                if (curr.val == curr.next.val)
                {
                    curr.next = curr.next.next; // remove duplicate
                }
                else
                {
                    curr = curr.next;
                }
            }

            return head;
        }

        //  Function to print the linked list
        static void PrintList(ListNode head)
        {
            while (head != null)
            {
                Console.Write(head.val + " -> ");
                head = head.next;
            }
            Console.WriteLine("null");
        }

        // Main method
        static void Main(string[] args)
        {
            ListNode head = new ListNode(1);
            head.next = new ListNode(1);
            head.next.next = new ListNode(2);
            head.next.next.next = new ListNode(3);
            head.next.next.next.next = new ListNode(3);

            RemoveDuplicates removeDuplicates = new RemoveDuplicates();

            Console.Write("Original List: ");
            PrintList(head);

            head = removeDuplicates.DeleteDuplicates(head);

            Console.Write("After Removing Duplicates: ");
            PrintList(head);
        }
    }
}
