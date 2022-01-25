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
    }
}
