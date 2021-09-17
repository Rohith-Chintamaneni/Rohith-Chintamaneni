using System;
using System.Collections.Generic;
using System.Text;
using DataStructures.Recursion;

// leetCode : 83. Remove Duplicates from Sorted List

namespace DataStructures.LinkedList
{
    public class RemoveDuplicatesFromSortedList
    {
        public ListNode RemoveDuplicatesFromSorted(ListNode headNode)
        {
           
            var currentnode = headNode;
          
            while (currentnode != null && currentnode.next != null)
            {
                if (currentnode.val == currentnode.next.val)
                {
                    currentnode.next = currentnode.next.next;
                }
                else
                {
                    currentnode = currentnode.next;
                }
            }

            return headNode;
        }
    }
}

