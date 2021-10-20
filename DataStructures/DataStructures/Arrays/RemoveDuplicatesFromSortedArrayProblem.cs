﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Arrays
{
    public class RemoveDuplicatesFromSortedArrayProblem
    {
        public int RemoveDuplicates(int[] nums)
        {

            if (nums == null || nums.Length == 0)
                return 0;
            else if (nums.Length == 1)
                return 1;

            int index1 = 0,
                index2 = 1;

            while (index2 < nums.Length)
            {
                if (nums[index1] != nums[index2])
                {
                    index1++;
                    nums[index1] = nums[index2];
                    index2++;

                }
                else
                {
                    index2++;

                }
            }

            return index1 + 1;


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
