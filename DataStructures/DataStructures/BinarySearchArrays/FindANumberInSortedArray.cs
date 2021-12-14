using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BinarySearchArrays
{
    class FindANumberInSortedArray
    {
        public int FindNumberInSortedArrayProblem (int[] nums, int findnumber)
        {
            int start = 0;
            int end = nums.Length-1;

            while(start <= end)
            {
                int mid = start + (end- start) / 2;
                if (nums[mid] == findnumber) return mid;
                else if(nums[mid] > findnumber)
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }

            }

            return -1;
        }
    }
}
