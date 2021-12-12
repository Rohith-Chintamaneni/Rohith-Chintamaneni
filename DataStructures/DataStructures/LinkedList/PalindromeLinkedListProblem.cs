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



        public bool IsPalindrome2(ListNode head)
        {



            var slow = head;
            var fast = head;
            var original = head;


            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            var reverselist = reverse(slow);

            while (original != null && reverselist != null)
            {
                if (original.val != reverselist.val)
                {
                    return false;
                }
                original = original.next;
                reverselist = reverselist.next;
            }
            return true;
        }


        public ListNode reverse(ListNode head)
        {
            var ans = head;
            ListNode prev = null;
            while (head != null)
            {
                var temp = head.next;
                head.next = prev;
                prev = head;
                head = temp;

            }

            return prev;
        }
    }

   


}
