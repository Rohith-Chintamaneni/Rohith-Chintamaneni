using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedList
{
    public class ReverseLinkedListProblem
    {

        public ListNode ReverseList(ListNode head)
        {

            //var currentnode = head;
            ListNode previousnode = null;
            ListNode nextNode = null;
            while (head != null)
            {
                nextNode = head.next;
                head.next = previousnode;
                previousnode = head;
                head = nextNode;
            }

            return previousnode;
        }




        ////  Looping
        //public ListNode ReverseList(ListNode head)
        //{
        //    ListNode newHead = null;
        //    while (head != null)
        //    {
        //        ListNode next = head.next;
        //        head.next = newHead;
        //        newHead = head;
        //        head = next;
        //    }
        //    return newHead;
        //}


        //// recursive
        //public ListNode reverseList(ListNode head)
        //{
        //    /* recursive solution */
        //    return reverseListInt(head, null);
        //}

        //private ListNode reverseListInt(ListNode head, ListNode newHead)
        //{
        //    if (head == null)
        //        return newHead;
        //    ListNode next = head.next;
        //    head.next = newHead;
        //    return reverseListInt(next, head);
        //}
    }

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
}
