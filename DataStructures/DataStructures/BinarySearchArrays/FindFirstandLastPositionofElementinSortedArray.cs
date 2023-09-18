using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/submissions/
namespace DataStructures.BinarySearchArrays
{
    class FindFirstandLastPositionofElementinSortedArray
    {
        public int[] SearchRange(int[] nums, int target)
        {

            int start = 0;
            int end = nums.Length - 1;
            int firstOccurence = -1;
            int LastOccurence = -1;

            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (nums[mid] == target)
                {
                    firstOccurence = mid;
                    end = mid - 1;
                }
                else if (nums[mid] < target)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }

            }

            start = 0;
            end = nums.Length - 1;

            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (nums[mid] == target)
                {
                    LastOccurence = mid;
                    start = mid + 1;
                }
                else if (nums[mid] < target)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }

            }



            return new int[] { firstOccurence, LastOccurence };
        }

        public int[] SearchRange2(int[] nums, int target)
        {

            int[] ans = new int[] { -1, -1 };

            ans[0] = SearchRangeHelper(nums, target, true);
            ans[1] = SearchRangeHelper(nums, target, false);
            return ans;
        }

        public int SearchRangeHelper(int[] arr, int target, bool FindFirstIndex)
        {
            int start = 0, end = arr.Length - 1; int ans = -1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (target < arr[mid]) end = mid - 1;
                else if (target > arr[mid]) start = mid + 1;
                else
                {
                    ans = mid;
                    if (FindFirstIndex)
                    {
                        end = mid - 1;
                    }
                    else start = mid + 1;
                }

            }
            return ans;
        }

        // A more elegant way of writing BInary Search

        public int[] SearchRange3(int[] nums, int target)
        {
            int[] sol = new int[2];

            sol[0] = BinarySearch3(nums, target, true);
            sol[1] = BinarySearch3(nums, target, false);

            return sol;
        }
        public int BinarySearch3(int[] nums, int target, bool SearchFirstIndex)
        {
            int low = 0, high = nums.Length-1, ans = -1;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (nums[mid] == target)
                {
                    ans = mid;
                    if (SearchFirstIndex)
                    {
                       
                        high = mid - 1;
                    }
                    else
                        low = mid + 1;
                }
                else if (nums[mid] < target) low = mid + 1;
                else high = mid - 1;
            }

            return ans;
        }
    }
}
