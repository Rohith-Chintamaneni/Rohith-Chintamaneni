using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays.PrefixSum
{
    public class LeftandRightSumDifferences
    {
        public int[] LeftRightDifference(int[] nums)
        {
            int[] ans = new int[nums.Length];
            int[] rsum = new int[nums.Length];

            int n = nums.Length - 1;
            for (int i = 1; i < nums.Length; i++)
            {
                ans[i] = ans[i - 1] + nums[i-1];
             
            }
            for(int i=nums.Length-2; i>=0; i--)
            {
                rsum[i] = rsum[i + 1] + nums[i+1];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                ans[i] = Math.Abs(ans[i] - rsum[i]);

            }
            return ans;
        }
    }
}
