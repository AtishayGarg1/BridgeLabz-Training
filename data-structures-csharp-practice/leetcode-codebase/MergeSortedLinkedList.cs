using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.leetcode
{
    using System;

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

    public class MergeSortedLinkedList
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode dummy = new ListNode(-1);
            ListNode current = dummy;

            while (list1 != null && list2 != null)
            {
                if (list1.val <= list2.val)
                {
                    current.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    current.next = list2;
                    list2 = list2.next;
                }
                current = current.next;
            }

            current.next = list1 ?? list2;
            return dummy.next;
        }

        static void Main(string[] args)
        {
            ListNode list1 = new ListNode(1,
                                new ListNode(2,
                                    new ListNode(4)));

            ListNode list2 = new ListNode(1,
                                new ListNode(3,
                                    new ListNode(4)));

            MergeSortedLinkedList solution = new MergeSortedLinkedList();
            ListNode result = solution.MergeTwoLists(list1, list2);

            while (result != null)
            {
                Console.Write(result.val + " ");
                result = result.next;
            }
        }
    }

}
