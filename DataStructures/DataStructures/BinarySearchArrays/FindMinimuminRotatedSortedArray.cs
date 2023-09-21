using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BinarySearchArrays
{
    //https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/description/
    public class FindMinimuminRotatedSortedArray
    {
        // they all go by fundamental to find out which one is sorted and then apply different variations to it.
        public int FindMin(int[] nums)
        {
            int low = 0, high = nums.Length - 1;
            int ans = int.MaxValue;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;


                //left sorted
                if (nums[low] <= nums[mid])
                {
                    ans = Math.Min(nums[low], ans);
                    low = mid + 1;

                }
                else // right sorted
                {
                    ans = Math.Min(nums[mid], ans);
                    high = mid - 1;
                }

            }
            return ans;
        }
    }
}
