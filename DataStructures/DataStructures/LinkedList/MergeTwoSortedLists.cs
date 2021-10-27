using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic;

namespace DataStructures.LinkedList
{
    public class MergeTwoSortedLists
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null) return l2;

            if (l2 == null) return l1;


            ListNode DummyNode = new ListNode(0);
            var head = DummyNode;

            while (l1 != null || l2 != null)
            {
                if (l2 == null || (l1 != null && l1.val <= l2.val))
                {
                    DummyNode.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    DummyNode.next = l2;
                    l2 = l2.next;
                }

                DummyNode = DummyNode.next;
            }




            return head.next;
        }

        // If conditions are simple
        public ListNode MergeTwoLists_LittleImproved(ListNode l1, ListNode l2)
        {

            ListNode h = new ListNode(0);
            ListNode ans = h;

            while (l1 != null && l2 != null)
            {
                if (l1.val < l2.val)
                {
                    h.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    h.next = l2;
                    l2 = l2.next;
                }
                h = h.next;
            }

            if (l1 == null)
            {
                h.next = l2;
            }
            if (l2 == null)
            {
                h.next = l1;
            }
            return ans.next;
        }

    }
}
