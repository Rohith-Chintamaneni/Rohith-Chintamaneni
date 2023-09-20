using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/single-element-in-a-sorted-array/description/
namespace DataStructures.BinarySearchArrays
{
    public class SingleElementinaSortedArray
    {
        // Binary Search
        public int SingleNonDuplicate(int[] nums)
        {
            int low = 1, high = nums.Length - 2;
            if (nums.Length == 1) return nums[0];
            // Since we last with low =1 and high = length-2. we are handling the edge cases. If we start from low =0 and high = length-1 we will have to check lot more edge cases when mid =0 or mid = length-1;
            if (nums[1] != nums[0]) return nums[0];
            if (nums[nums.Length - 1] != nums[nums.Length - 2]) return nums[nums.Length - 1];

            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                // Single element
                if (nums[mid] != nums[mid - 1] && nums[mid] != nums[mid + 1]) return nums[mid];
                // If the mid index is even or odd, we look at on which side the element could be present and we trim it down.
                else if (mid % 2 == 0 && nums[mid] == nums[mid + 1] || mid % 2 == 1 && nums[mid] == nums[mid - 1]) low = mid + 1;
                else high = mid - 1;
            }
            return -1;


        }

        //int singleNonDuplicate(vector<int>& nums)
        //{

        //    int n = nums.size();

        //    // apply binary search

        //    int low = 1;

        //    int high = n - 1;

        //    while (low <= high)
        //    {
        //        // find mid

        //        int mid = low + (high - low) / 2;

        //        // if the mid is even then it is the 1st instance

        //        if (mid % 2 == 0)
        //        {
        //            if (nums[mid] == nums[mid - 1])
        //            {
        //                high = mid - 1;
        //            }
        //            else
        //            {
        //                low = mid + 1;
        //            }
        //        }

        //        // if the mid is odd then it is the second instance

        //        else if (mid % 2 == 1)
        //        {
        //            if (nums[mid] == nums[mid - 1])
        //            {
        //                low = mid + 1;
        //            }
        //            else
        //            {
        //                high = mid - 1;
        //            }
        //        }
        //    }

        //    return nums[high];
        //}
    }
}
