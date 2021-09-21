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
    }
}
