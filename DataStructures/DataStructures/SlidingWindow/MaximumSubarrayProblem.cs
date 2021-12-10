using System;
using System.Collections.Generic;
using System.Text;
// 53. Maximum Subarray
namespace DataStructures.SlidingWindow
{
    public class MaximumSubarrayProblem
    {
        // Brute Force
        public int MaxSubArrayUnOptimizedBruteForce(int[] nums)
        {
            int maxsubarray = 0;

            for (int i = 0; i < nums.Length; i++)
            {
         
                for (int j = i; j < nums.Length; j++)
                {
                    // having a print here vs having a print in third loop helps you understand how data is getting formed
                   Console.Write("{0} ", nums[j]);

                    int currentsubarray = 0;
                    for (int k = i; k<j;k++)
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

        public int MaxSubArrayKadaneAlgorithm(int[] nums)
        {
            int maxsubarray = int.MinValue;
            int currsum = 0;
            for (int i = 0; i < nums.Length; i++)
            {

                currsum += nums[i];
                maxsubarray = Math.Max(maxsubarray, currsum);
                if (currsum < 0)
                    currsum = 0;
            }
            return maxsubarray;
        }
       
    }
}
