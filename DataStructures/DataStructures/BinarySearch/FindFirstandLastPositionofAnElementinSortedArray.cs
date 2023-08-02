using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Leetcode: Problem 34: FInd first and last
namespace DataStructures.BinarySearch
{
    public class FindFirstandLastPositionofAnElementinSortedArray
    {
        public int[] SearchRange(int[] arr, int target)
        {
           
            int[] ans = new int[] { -1, -1 };
           
            ans[0] = SearchRangeHelper(arr, target, true);
            ans[1] = SearchRangeHelper(arr, target, false);
            return ans;
        }

        public int SearchRangeHelper(int[] arr, int target, bool FindFirstIndex)
        {
            int start = 0, end = arr.Length - 1;int ans = -1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (target < arr[mid]) end = mid - 1;
                else if (target > arr[mid]) start = mid + 1;
                else
                {
                    // this could be my potential ans, but you are also searching more to find if there is one more that matches the target.
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
    }
}
