using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/find-pivot-index/
// There are problems like equilibirum, Middle index, Pivot integer all are same.
namespace DataStructures.Arrays.PrefixSum
{
    public class FindPivotIndex
    {
        // after calculating prefix sum. look at example 2
        // left sum of an index = prefix sum[i-1]
        // Right sum after an Index = prefixSum[n - 1] - prefixSum[i];
        // if i =0, then just return 0;
        // general naive approach to solve this problem would be on every iteration. Run 2 loops one for left sum and another for right sum
        // while using Prefix sum, you have already calculated the totalsum and lsum = totalsum-nums[i]-lsum. When you add Lsum+= nums[i] at the end.
        public int PivotIndex(int[] nums)
        {
            int sum = 0, leftsum = 0;
            for(int i=0; i<nums.Length; i++)
            {
                sum += nums[i];
            }
            for(int i=0; i< nums.Length; i++)
            {
                if (leftsum == sum - leftsum - nums[i]) return i;
                leftsum += nums[i];

            }
           
            return -1;
        }

        public int PivotIndex2(int[] nums)
        {
            int n = nums.Length;

            // Calculate prefix sum array
            int[] prefixSum = new int[n];
            prefixSum[0] = nums[0];
            for (int i = 1; i < n; i++)
            {
                prefixSum[i] = prefixSum[i - 1] + nums[i];
            }

            for (int i = 0; i < n; i++)
            {
                int leftSum = i > 0 ? prefixSum[i - 1] : 0;
                int rightSum = prefixSum[n - 1] - prefixSum[i];

                if (leftSum == rightSum)
                {
                    return i;
                }
            }

            return -1; // No pivot index found
        }
    }
}
