using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.LinkedList;
namespace DataStructures.Recursion
{
    class SwapNodesInPairsProblem
    {
        public ListNode SwapPairsRecursive(ListNode head)
        {

            // If the list has no node or has only one node left.
            if ((head == null) || (head.next == null))
            {
                return head;
            }

            // Nodes to be swapped
            ListNode firstNode = head;
            ListNode secondNode = head.next;

            // Swapping
            firstNode.next = SwapPairsRecursive(secondNode.next);
            secondNode.next = firstNode;

            // Now the head is the second node
            return secondNode;
        }

        public ListNode SwapPairsIterative(ListNode head)
        {

            // Dummy node acts as the prevNode for the head node
            // of the list and hence stores pointer to the head node.
            ListNode dummy = new ListNode(-1);
            dummy.next = head;

            ListNode prevNode = dummy;

            while ((head != null) && (head.next != null))
            {

                // Nodes to be swapped
                ListNode firstNode = head;
                ListNode secondNode = head.next;

                // Swapping
                prevNode.next = secondNode;
                firstNode.next = secondNode.next;
                secondNode.next = firstNode;

                // Reinitializing the head and prevNode for next swap
                prevNode = firstNode;
                head = firstNode.next; // jump
            }

            return dummy.next;

        }
    }
}
