using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BinarySearchArrays
{
    public class SearchInARotatedArray2
    {
        // you need to understand the solution of SearchinRotatedSortedArray before understanding this one.
        // master class: Same solution as SearchInARotatedArray but here there are duplicates. Since when duplicates arise you don't know which is sorted hence check for additional condition.
        public bool Search(int[] nums, int target)
        {
            int low = 0, high = nums.Length - 1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (nums[mid] == target) return true;
                // check for additional condition: we are reducing the search space but not eleminating a full half yet because we don't know if this is soretd or not.
                if (nums[mid] == nums[low] && nums[mid] == nums[high])
                {
                    low = low + 1;
                    high = high - 1;
                    continue;
                }

                //left sorted
                if (nums[low] <= nums[mid])
                {
                    if (nums[low] <= target && target <= nums[mid])
                        high = mid - 1;
                    else low = mid + 1;
                }
                else // right sorted
                {
                    if (nums[mid] <= target && target <= nums[high])
                        low = mid + 1;
                    else high = mid - 1;
                }

            }
            return false;
        }
    }
}
