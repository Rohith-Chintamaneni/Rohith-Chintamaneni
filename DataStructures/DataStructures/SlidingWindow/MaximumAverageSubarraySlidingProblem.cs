using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.SlidingWindow
{
    public class MaximumAverageSubarraySlidingProblem
    {
        //nums = [1,12,-5,-6,50,3], k = 4
        public double FindMaxAverage(int[] nums, int k)
        {
            int sum = 0;
            for (int i = 0; i < k; i++)
            {
                sum += nums[i];
            }

            int maxSum = sum;
            for (int i = 0, j = k; j < nums.Length; i++, j++)
            {
                sum = sum - nums[i] + nums[j];
                maxSum = Math.Max(sum, maxSum);
            }

            return ((double)maxSum) / ((double)k);

            // second way
            //long sum = 0;
            //for (int i = 0; i < k; i++) sum += nums[i];
            //long max = sum;

            //for (int i = k; i < nums.Length; i++)
            //{
            //    sum += nums[i] - nums[i - k];
            //    max = Math.Max(max, sum);
            //}

            //return max / 1.0 / k;
        }
    }
}
