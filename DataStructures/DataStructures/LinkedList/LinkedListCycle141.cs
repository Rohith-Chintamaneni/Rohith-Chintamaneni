using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList
{
    class LinkedListCycle141
    {
        public bool HasCycle(ListNode head)
        {
            if (head == null || head.next == null || head.next.next == null)
                return false;

            var dummynode = head;
            var slow = head;
            var fast = head.next.next;
            bool flag = false;
            while (fast != null && fast.next != null)
            {
                if (slow == fast)
                {
                    flag = true;
                    return flag;
                }

                slow = slow.next;
                fast = fast.next.next;
            }

            return flag;

        }
    }
}
