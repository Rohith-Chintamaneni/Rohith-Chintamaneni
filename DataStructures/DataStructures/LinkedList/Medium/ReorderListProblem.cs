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
            ListNode slow = head;
            ListNode fast = head;
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
        // remember what should each element must point.
        // 1->2
        //5->4->3
        // 1->5->2->4->3
        // refer neat code to understand more
        private void merge(ListNode head1, ListNode head2)
        {
            while (head2 != null)
            {
                // Both next nodes are first put in temp variables
                ListNode temp1 = head1.next;
                ListNode temp2 = head2.next;

                // first node is pointing to secondnode and secondnode is pointing to firstnode's next node
                head1.next = head2;
                head2.next = temp1;

                // both firstnode and second advance to next nodes
                head1 = temp1;
                head2 = temp2;
            }
        }



        public void reorderList2(ListNode head)
        {
            if (head == null) return;
            reorderList(head, head.next);
        }

        public ListNode reorderList(ListNode root, ListNode curr)
        {
            if (curr == null) return root;

            // keep on passing the intial root to the end
            root = reorderList(root, curr.next);

            if (root == null) return null;
            /** 
             * we stop reconfiguring in 2 cases. 
             *   1. returned new root is same as head: Odd number of list items so we have come to the middle
             *   2. returned new root's next is same as head: Even number of list items
             **/
            ListNode temp = null;
            if (root == curr || root.next == curr)
            {
                curr.next = null;
            }
            else
            {
                // make returned root's next to be curr and return root's next as the new root
                temp = root.next;
                root.next = curr;
                curr.next = temp;
            }
            return temp;
        }
    }
}
