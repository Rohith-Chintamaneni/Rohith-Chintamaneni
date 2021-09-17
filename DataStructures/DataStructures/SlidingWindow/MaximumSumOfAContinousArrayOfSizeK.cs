using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.SlidingWindow
{
    // [4,2,1,7,8,1,2,8,1,0] and size k = 3
    public class MaximumSumOfAContinousArrayOfSizeK
    {
        public int FindMaxSumSubArray(int[] nums, int k)
        {
            int maxval = 0;
            int coninuousSUm = 0;
            // i is moving continously, you need to make sure you take the left most element when you have 3 elements to calculate the sum
            for (int i = 0; i < nums.Length; i++)
            {
                coninuousSUm += nums[i];

                if (i >= (k - 1))
                {
                    maxval = Math.Max(maxval, coninuousSUm);
                    coninuousSUm = coninuousSUm - nums[i - (k - 1)];
                }
            }


            return maxval;
        }
    }
}
