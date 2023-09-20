using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BinarySearchArrays
{
    class SearchinRotatedSortedArray
    {
        public int Search(int[] nums, int target)
        {
            var minIndex = FindMinimum(nums);

            if (nums[minIndex] == target) return minIndex;

            return Math.Max(FindInBst(0, minIndex - 1, nums, target), FindInBst(minIndex, nums.Length - 1, nums, target));
        }

        public int FindInBst(int left, int right, int[] nums, int target)
        {

            while (left <= right)
            {
                var mid = left + ((right - left) / 2);

                if (nums[mid] == target) return mid;

                else if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1;
        }

        public int FindMinimum(int[] nums)
        {
            int left = 0, right = nums.Length - 1, n = nums.Length;

            while (left <= right)
            {

                if (nums[left] <= nums[right])
                {
                    return left;
                }

                var mid = left + ((right - left) / 2);
                var prev = (mid + n - 1) % n;
                var next = (mid + 1) % n;

                if (nums[mid] <= nums[prev] && nums[mid] <= nums[next])
                {
                    return mid;
                }
                else if (nums[mid] <= nums[right])
                {
                    right = prev;
                }
                else if (nums[left] <= nums[mid])
                {
                    left = next;
                }
            }

            return -1;
        }

        // Look for Sorted subarray inside rotated array and look for the target inside that.
        public int Search2(int[] nums, int target)
        {
            int low = 1, high = nums.Length - 2;
            if (nums[0] == target) return 0;
            if (nums[nums.Length - 1] == target) return nums.Length - 1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (nums[mid] == target) return mid;
                // left half is sorted
                else if (nums[low] <= nums[mid])
                {
                    if ((target >= nums[low] && target <= nums[mid]))
                        high = mid - 1;
                    else
                        low = mid + 1;
                }
                else // right half is sorted. Then check in right half
               if (nums[mid] <= target && target <= nums[high])
                    low = mid + 1;
                else
                    high = mid - 1;
            }

            return -1;
        }
    }
}
