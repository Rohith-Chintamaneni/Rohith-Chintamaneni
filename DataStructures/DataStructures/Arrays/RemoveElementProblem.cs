using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures.Arrays
{
    public class RemoveElementProblem
    {
        public int RemoveElement(int[] nums, int val)
        {

            Console.WriteLine(nums.Length);
            int i = 0;
            for (int j = 0; j <= nums.Length-1; j++)
            {
                if (nums[j] != val)
                {
                    nums[i] = nums[j];
                    i++;
                }

            }

            return i;

            //int j = 0;
            //if (nums == null || nums.Length == 0)
            //    return 0;

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] == val)
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        nums[j] = nums[i];
            //        j++;
            //    }
            //}
            //return j;

        }
    }
}
