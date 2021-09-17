using System;
using System.Collections.Generic;
using System.Text;
// 53. Maximum Subarray
namespace DataStructures.SlidingWindow
{
    public class MaximumSubarrayProblem
    {
        public int MaxSubArray(int[] nums)
        {
            int continoussum = 0, windowstart = 0;
            int maxval = int.MinValue;

            for (int windowend=0; windowend < nums.Length; windowend++)
            {
                continoussum = nums[windowend];

                if (continoussum > maxval)
                {
                    maxval = continoussum;
                }
                else
                {
                    while (continoussum < maxval)
                    {
                        continoussum = continoussum - nums[windowstart];
                        windowstart++;
                    }
                }

                windowend++;
            }

            return maxval;
        }
    }
}
