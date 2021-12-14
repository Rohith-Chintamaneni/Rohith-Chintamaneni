using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BinarySearchArrays
{
    class FIndPeakElementProblem
    {
        public int FindPeakElement(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;

            while(left <= right)
            {
                var mid = left + (right - left) / 2;
                // to freely check that mid element is not the first or last elment in array and it has got neighbours
                if (mid > 0 && mid < nums.Length - 1)
                {
                    if (nums[mid] > nums[mid - 1] && nums[mid] > nums[mid + 1]) return mid;
                    else if (nums[mid] > nums[mid - 1]) left = mid + 1;
                    else right = mid - 1;
                }
                
                if (mid == 0)
                {
                    if (nums[mid] > nums[1])
                        return 0;
                    else return 1;
                }
                 if (mid == nums.Length - 1)
                {
                    if (nums[mid] > nums[mid - 1])
                        return mid;
                    else return mid-1;

                }
                    
            }

            return -1;
        }

        public int FindPeakElement2(int[] nums)
        {
            int low = 0, high = nums.Length - 1;
            if (high == 0) return 0;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (mid > 0 && mid < nums.Length - 1)
                {
                    if (nums[mid] > nums[mid - 1] && nums[mid] > nums[mid + 1]) return mid;
                    else if (nums[mid] > nums[mid - 1]) low = mid + 1;
                    else high = mid - 1;
                }
                else if (mid == 0) if (nums[0] > nums[1]) return 0; else return 1;
                else if (mid == nums.Length - 1) if (nums[mid] > nums[mid - 1]) return mid; else return mid - 1;
            }
            return 0;
        }

    }


   
}

