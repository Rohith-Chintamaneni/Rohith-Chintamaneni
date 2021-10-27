using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList.Hard
{
    class MergeKLinkedListProblem
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            if (lists.Length == 0) return null;
            if (lists.Length == 1) return lists[0];

            var head = MergeTwolinkedLists(lists[0], lists[1]);
            for (int i = 2; i < lists.Length; i++)
            {
                head = MergeTwolinkedLists(head, lists[i]);
            }


            return head;

        }

        private ListNode MergeTwolinkedLists(ListNode l1, ListNode l2)
        {
            //if (h1 == null) return h2;

            //if (h2 == null) return h1;
            //ListNode dummyNode = new ListNode(0);
            //var head = dummyNode;

            //while (h1 != null || h2 != null)
            //{
            //    if (h2 == null|| ( h1 != null && h1.val < h2.val))
            //    {
            //        dummyNode.next = h1;
            //        h1 = h1.next;

            //    }
            //    else
            //    {
            //        dummyNode = h2;
            //        h2 = h2.next;
            //    }

            //    dummyNode = dummyNode.next;
            //}

            //return head.next;


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
    }
}
