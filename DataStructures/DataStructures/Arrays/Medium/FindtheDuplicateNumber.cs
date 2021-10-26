using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays.Medium
{
    class FindtheDuplicateNumber
    {
        public int FindDuplicateLinkedList(int[] nums)
        {
            int slow = nums[0];
            int fast = nums[0];
            int S2 = nums[0];
            do
            {
                slow = nums[slow];
                fast = nums[nums[fast]];
            } while (slow != fast);

            while (S2 != slow)
            {
                S2 = nums[S2];
                slow = nums[slow];
            }

            return S2;
        }

        public int FindDuplicateBinarySearch(int[] nums)
        {

            return 0;
        }
    }
}
