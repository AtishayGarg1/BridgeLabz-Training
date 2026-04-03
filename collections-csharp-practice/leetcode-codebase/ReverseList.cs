using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_collections.leetcode
{
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int val=0, ListNode next=null) {
            this.val = val;
            this.next = next;
        }
    }
    public class RecerseList
    {
        public ListNode ReverseBetween(ListNode head, int left, int right)
        {
            if (head == null || left == right)
                return head;

            ListNode dummy = new ListNode(0);
            dummy.next = head;

            ListNode prev = dummy;
            for (int i = 1; i < left; i++)
            {
                prev = prev.next;
            }

            ListNode curr = prev.next;
            for (int i = 0; i < right - left; i++)
            {
                ListNode temp = curr.next;
                curr.next = temp.next;
                temp.next = prev.next;
                prev.next = temp;
            }

            return dummy.next;
        }
    }
}
