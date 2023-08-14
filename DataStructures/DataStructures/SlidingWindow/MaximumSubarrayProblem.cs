using System;
using System.Collections.Generic;
using System.Text;
// 53. Maximum Subarray
namespace DataStructures.SlidingWindow
{
    public class MaximumSubarrayProblem
    {
        // Brute Force
        // Brute force will have (o^3)
        // for inside for is to calculate all subarrays. then one more for to calculate sum

        public int MaxSubArrayUnOptimizedBruteForce(int[] nums)
        {
            int maxsubarray = int.MinValue;

            for (int i = 0; i < nums.Length; i++)
            {
         
                for (int j = i; j < nums.Length; j++)
                {
                    // having a print here vs having a print in third loop helps you understand how data is getting formed
                   Console.Write("{0} ", nums[j]);

                    int currentsubarray = 0;
                    for (int k = i; k<=j;k++)
                    {

                       // Console.Write("{0} ", nums[k]);
                        currentsubarray += nums[k];
                        maxsubarray = Math.Max(currentsubarray, maxsubarray);
                      
                    }
                   
                }
                Console.WriteLine();
            }

            return maxsubarray;
        }


        // Brute Force Optmized
        public int MaxSubArrayOptimizedBruteForce(int[] nums)
        {
            int maxsubarray = int.MinValue;

            for (int i = 0; i < nums.Length; i++)
            {
                int currentsubarray = 0;
                for (int j = i; j < nums.Length; j++)
                {
                    currentsubarray += nums[j];
                    maxsubarray = Math.Max(currentsubarray, maxsubarray);
                }
            }

            return maxsubarray;
        }


        public int MaxSubArrayKindofSlidingWindow(int[] nums)
        {
            int maxsubarray = nums[0];
            int currsum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (currsum < 0)
                    currsum = 0;
                currsum += nums[i];
                maxsubarray = Math.Max(maxsubarray, currsum);
            }
            return maxsubarray;
        }

        public int MaxSubArrayKadaneAlgorithm(int[] arr)
        {
            int maxEndingHere = arr[0];
            int maxSoFar = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                maxEndingHere = Math.Max(arr[i], maxEndingHere + arr[i]);
                maxSoFar = Math.Max(maxSoFar, maxEndingHere);
            }

            return maxSoFar;
        }
        public int MaxSubArrayUsingSliding(int[] nums)
        {
            int start = 0, end = 0, sum = 0;
            int maxSum = int.MinValue;

            //sliding window
            while (end < nums.Length)
            {
                //always add numer at the end pointer
                sum += nums[end];

                //after adding, increment end pointer
                end++;

                //check if current sum can be max. Useful for cases of all -ve numbers
                //like [-2, -1, -3]
                if (sum > maxSum)
                {
                    maxSum = sum;
                }
                //we will always try to maintain a window of non-negative sum of at least 0
                //So, if sum is less than 0, move the start pointer to shrink the window
                while (sum < 0)
                {
                    sum = sum - nums[start];
                    start++;
                }

            }

            return maxSum;
        }
    }
}
