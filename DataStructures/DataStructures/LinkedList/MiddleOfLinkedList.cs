using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedList
{
    public class MiddleOfLinkedList
    {
        public ListNode MiddleNode(ListNode head)
        {

            if (head == null)
            {
                return head;
            }

            ListNode slowListNode = head;
            ListNode fastListNode = head;

            // can be written as fastlistnode != null and fastlistNode.next != null
            while (fastListNode.next != null && fastListNode.next.next != null)
            {



                slowListNode = slowListNode.next;
                fastListNode = fastListNode.next.next;
            }



            return slowListNode;
        }
    }
}
