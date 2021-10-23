using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataStructures.LinkedList.Medium
{
    class ReorderListProblem
    {
        public void ReorderList(ListNode head)
        {
            if (head == null || head.next == null) return;

            // Find the middle node
            ListNode slow = head, fast = head.next.next;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            // Reverse the second half
            ListNode head2 = reverse(slow.next);
            slow.next = null;

            // Intertwine the two halves
            merge(head, head2);
        }

        private ListNode reverse(ListNode n)
        {
            ListNode prev = null, cur = n;
            while (cur != null)
            {
                ListNode tmp = cur.next;
                cur.next = prev;
                prev = cur;
                cur = tmp;
            }

            return prev;
        }

        private void merge(ListNode head1, ListNode head2)
        {
            while (head2 != null)
            {
                ListNode next = head1.next;
                head1.next = head2;
                head1 = head2;
                head2 = next;
            }
        }
    }
}
