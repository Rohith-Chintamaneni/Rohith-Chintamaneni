using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.SlidingWindow
{
    public class MaximumAverageSubarrayIProblem
    {
        //nums = [1,12,-5,-6,50,3], k = 4
        public double FindMaxAverage(int[] nums, int k)
        {
            float avg = 0, max = float.MinValue;
            int begin = 0, sum=0;

            for (int i = 0, end=0; i < nums.Length; end++)
            {
                sum += nums[end];
                if (avg > max)
                {
                    max = avg;
                }
            }

            return 0;
        }
    }
}
