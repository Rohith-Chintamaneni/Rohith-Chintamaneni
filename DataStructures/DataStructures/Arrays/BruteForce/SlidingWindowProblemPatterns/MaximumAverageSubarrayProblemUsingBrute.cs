using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Arrays.BruteForce.SlidingWindowProblemPatterns
{
    public class MaximumAverageSubarrayProblemUsingBrute
    {
        // Step 1: You need to find all Subarrays of size 4
        // step 2:find avg of each sub array and assign it to a variable
        // step 3: repeat the process for all sub arrays and finally return maxavg
        //nums = [1,12,-5,-6,50,3], k = 4
        public double FindMaxAverage(int[] nums, int k)
        {

            if (nums.Length == 0)
            {
                return 0;
            }

            if (nums.Length == 1)
            {
                return nums[0];
            }

           
            double maxavg = 0;
           

            for (int i = 0; i < nums.Length-k; i++)
            {
                double subarraytotal = 0;
                for (int j = i; j < i + k; j++)
                {

                    subarraytotal += nums[j];
                   var runningavg = subarraytotal / (k);
                    maxavg = Math.Max(runningavg, maxavg);
                }

               
            }

            return maxavg;
        }
    }
}
