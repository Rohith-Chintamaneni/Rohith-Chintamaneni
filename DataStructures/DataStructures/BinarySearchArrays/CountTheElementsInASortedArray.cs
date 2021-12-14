using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BinarySearchArrays
{
    class CountTheElementsInASortedArray
    {

        public int COunttheElementsINSortedArrayProblem(int [] nums, int target)
        {

            int start = 0;
            int end = nums.Length - 1;
            int result = 0;
          

            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (nums[mid] == target)
                {
                    result += 1;
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
                    result += 1;
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

            return result;
        }
    }
}
