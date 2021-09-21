using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Arrays
{
    public class MaximumAverageSubarrayProblem
    {
        // --{0, 1, 1, 3, 3},4
        // [1,12,-5,-6,50,3], k = 4
        // [1,12,-5,-6,50,3], k = 3
        public double FindMaxAverage(int[] nums, int k)
        {

            long sum = 0;
            for (int i = 0; i < k; i++) sum += nums[i];
            long max = sum;

            for (int i = k; i < nums.Length; i++)
            {
                sum += nums[i] - nums[i - k];
                max = Math.Max(max, sum);
            }

            return max / 1.0 / k;
        }


        
        
    }

}
