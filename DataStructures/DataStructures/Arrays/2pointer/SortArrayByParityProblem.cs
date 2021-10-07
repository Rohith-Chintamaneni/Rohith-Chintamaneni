using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Arrays._2pointer
{
    class SortArrayByParityProblem
    {
        public int[] SortArrayByParity(int[] nums)
        {
            if (nums.Length == 0) return nums;

            if (nums.Length == 1) return nums;

            int n = 0;
            int m = nums.Length-1;
            int[] result = new int[nums.Length];


            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    result[n] = nums[i];
                    n++;
                }
                else
                {
                    result[m] = nums[i];
                    m--;
                }
            }

            return result;
        }
    }
}
