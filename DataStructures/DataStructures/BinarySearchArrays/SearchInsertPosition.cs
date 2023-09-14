using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BinarySearchArrays
{
    class SearchInsertPosition
    {
        public int SearchInsert(int[] nums, int target)
        {

            int low = 0, index = 0, high = nums.Length - 1;
            while (low <= high)
            {
                index = low + (high - low) / 2;
                if (target == nums[index]) return index;
                else if (target > nums[index]) low = index + 1;
                else high = index - 1;

            }
            return low;
        }

        public int SearchInsert2(int[] nums, int target)
        {
            int low = 0, high = nums.Length - 1;
            int ans = nums.Length;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (nums[mid] >= target) // this may be my answer but I want to search more.
                {
                    ans = mid;
                    high = mid - 1;
                }
                else low = mid + 1;

            }

            return ans;

        }
    }
}
