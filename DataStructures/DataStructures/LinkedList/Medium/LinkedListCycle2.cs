using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataStructures.LinkedList.Medium
{
    class LinkedListCycle2
    {
        public ListNode DetectCycle(ListNode head)
        {
            var slow = head;
            var fast = head;
            var s2 = head;
            bool iscycle = false;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (slow == fast)
                {
                    iscycle = true;
                    break;
                }

            }

            while (iscycle)
            {
                if (s2 == slow) return s2;
                s2 = s2.next;
                slow = slow.next;
            }


            return null;
        }
    }
}
