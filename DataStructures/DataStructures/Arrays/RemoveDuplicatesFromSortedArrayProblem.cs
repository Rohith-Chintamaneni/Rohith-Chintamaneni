using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Arrays
{
    public class RemoveDuplicatesFromSortedArrayProblem
    {
        public int RemoveDuplicates(int[] nums)
        {

            if (nums.Length == 0)
                return 0;
            // keep track of the last position we swapped the value with.

            int lastPosition = 0;

            for (int i = 0; i < nums.Length; i++)
            {

                if (nums[i] != nums[lastPosition])
                    nums[++lastPosition] = nums[i];

            }


            return lastPosition + 1;



            // approach 2
            //if (nums == null || nums.Length == 0)
            //    return 0;
            //else if (nums.Length == 1)
            //    return 1;

            //int index1 = 0,
            //    index2 = 1;

            //while (index2 <= nums.Length - 1)
            //    if (nums[index1] == nums[index2])
            //        index2++;
            //    else
            //        nums[++index1] = nums[index2++];

            //return ++index1;
          
        }
    }
}
