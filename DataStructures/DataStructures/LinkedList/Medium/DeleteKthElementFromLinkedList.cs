using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedList.Medium
{
    public class DeleteKthElementFromLinkedList
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {// you do need a dummy node to handle single node with n elements
            ListNode dumNode = new ListNode(0);
            dumNode.next = head;

            ListNode slowNode = dumNode;
            ListNode fastNode = dumNode;
            for (int i = 0; i <= n; i++)
            {
                fastNode = fastNode.next;
            }
          
            while (fastNode != null)
            {


                slowNode = slowNode.next;
                fastNode = fastNode.next;
            }

            slowNode.next = slowNode.next.next;
            return dumNode.next;
        }


        public ListNode RemoveNthFromEnd2(ListNode head, int n)
        {
            ListNode dummynode = new ListNode(0);
            dummynode.next = head;
            ListNode slow = dummynode;
            ListNode fast = dummynode;

            while (n >= 0)
            {
                fast = fast.next;
                n--;
            }

            while (fast != null)
            {
                slow = slow.next;
                fast = fast.next;
            }

            slow.next = slow.next.next;

            return dummynode.next;
        }
    }
}
