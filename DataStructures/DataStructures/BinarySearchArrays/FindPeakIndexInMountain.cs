using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BinarySearchArrays
{
    public class FindPeakIndexInMountain
    {
        // if you try to compare mid to its previous element. It might lead to index out as we can compare to -1. But I don't that happening for mid +1;
        public int PeakIndexInMountainArray(int[] arr)
        {
            int low = 0; int high = arr.Length - 1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (arr[mid] < arr[mid + 1]) low = mid + 1;
                else high = mid - 1;
            }
            return low;
        }

        // if you start from low =1 and high =  length-2 then you can compare to previous element also
        public int PeakIndexInMountainArray2(int[] nums)
        {
            int low = 1; int high = nums.Length - 2;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (nums[mid - 1] < nums[mid] && nums[mid] < nums[mid + 1]) low = mid + 1;
                else high = mid - 1;
            }
            return low;

        }

        // just check the variation in all 3 problems
        public int PeakIndexInMountainArray3(int[] nums)
        {
            int low = 1; int high = nums.Length - 2;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (nums[mid - 1] < nums[mid]) low = mid + 1;
                else high = mid - 1;
            }
            return high;

        }
    }
   
}
