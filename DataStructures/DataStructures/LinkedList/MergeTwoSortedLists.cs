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
           

            ListNode resultnode = new ListNode(0);
            DummyNode.next = resultnode;

            while (l1 != null || l2 != null)
            {

                if (l2.val == l1.val)
                {
                    var temp = new ListNode(l1.val);
                    resultnode.next = temp;
                    var temp2 = new ListNode(l2.val);
                    resultnode.next.next = temp2;
                    l1 = l1.next;
                    l2 = l2.next;
                    resultnode = resultnode.next.next;
                }
                else if(l2.val > l1.val)
                {
                   
                    var temp2 = new ListNode(l1.val);
                    resultnode.next = temp2;
                    l1 = l1.next;
                    resultnode = resultnode.next;
                }
                else
                {
                    var temp2 = new ListNode(l2.val);
                    resultnode.next = temp2;
                    l2 = l2.next;
                    resultnode = resultnode.next;
                }
                

                
            }




            return DummyNode.next.next;
        }

    }
}
