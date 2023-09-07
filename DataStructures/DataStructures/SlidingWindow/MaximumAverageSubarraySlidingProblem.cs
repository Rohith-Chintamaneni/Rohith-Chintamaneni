using System;
using System.Collections.Generic;
using System.Text;
//https://leetcode.com/problems/maximum-average-subarray-i/description/
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
        // using the Sliding window comprehensive Guide
        //https://leetcode.com/discuss/interview-question/3722472/mastering-sliding-window-technique-a-comprehensive-guide
        public double FindMaxAverage2(int[] nums, int k)
        {
            double ans = int.MinValue;
            int start = 0, end = 0;
            double avg = 0, sum = 0;
            while (end < nums.Length)
            {
                if (end - start + 1 < k)
                {
                    sum += nums[end];
                    end++;
                }
                else
                {
                    sum += nums[end];
                    // calculate ans
                    avg = sum / k;
                    ans = Math.Max(ans, avg);

                    // remove oldest element
                    sum = sum - nums[start];
                    start++;
                    end++;
                }
            }

            return ans;
        }
    }
    /*
     * 
     * fixed_window()
{
    int low = 0, high = 0, windowsize = k;
    while (i < sizeofarray)
    {
        // Step 1: Create a window that is one element smaller than the desired window size
        if (high - low + 1 < windowsize)
        {
            // Generate the window by increasing the high index
            high++;
        }
        // Step 2: Process the window
        else
        {
            // Window size is now equal to the desired window size
            // Step 2a: Calculate the answer based on the elements in the window
            // Step 2b: Remove the oldest element (at low index) from the window for the next window

            // Proceed to the next window by incrementing the low and high indices
        }
    }
}*/
}
