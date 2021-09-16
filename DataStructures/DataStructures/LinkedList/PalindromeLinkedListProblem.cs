using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.ObjectModel;

namespace DataStructures.LinkedList
{
    public class PalindromeLinkedListProblem
    {
        public bool IsPalindrome(ListNode head)
        {
            bool flag = true;
            if (head == null)
            {
                return flag;
            }

           

            ListNode slowListNode = head;
            ListNode fastListNode = head;

            while (fastListNode != null && fastListNode.next != null)
            {
                slowListNode = slowListNode.next;
                fastListNode = fastListNode.next.next;
            }

            var reverseListNode = ReverseListImplementation(slowListNode);
            var originalListNode = head;

            while (reverseListNode !=  null && originalListNode != null)
            {
                if (reverseListNode.val != originalListNode.val)
                {
                    flag = false;
                }

                reverseListNode = reverseListNode.next;
                originalListNode = originalListNode.next;
            }

            return flag;
        }

        private ListNode ReverseListImplementation(ListNode head)
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

    }

   


}
