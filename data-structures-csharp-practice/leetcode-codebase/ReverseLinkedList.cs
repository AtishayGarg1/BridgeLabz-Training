using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.leetcode
{
    internal class ReverseLinkedList
    {

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


        public ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;
            ListNode curr = head;

            while (curr != null)
            {
                ListNode nextTemp = curr.next; 
                curr.next = prev;              
                prev = curr;                   
                curr = nextTemp;               
            }

            return prev; 
        }

        
        static void PrintList(ListNode head)
        {
            while (head != null)
            {
                Console.Write(head.val + " -> ");
                head = head.next;
            }
            Console.WriteLine("null");
        }

        
        public static void Main(string[] args)
        {
            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);
            head.next.next.next.next = new ListNode(5);

            ReverseLinkedList solution = new ReverseLinkedList();

            Console.Write("Original List: ");
            PrintList(head);

            head = solution.ReverseList(head);

            Console.Write("Reversed List: ");
            PrintList(head);
        }
    }
}
