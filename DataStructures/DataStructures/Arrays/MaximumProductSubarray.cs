using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/maximum-product-subarray/
namespace DataStructures.Arrays
{
    public class MaximumProductSubarray
    {
        // Brute Force which times out.
        public int MaxProduct(int[] nums)
        {
            if (nums.Length == 1) return nums[0];
            int maxproduct = 0;
            int max =int.MinValue;

            for (int i = 0; i < nums.Length; i++)
            {
                
                for (int j = i; j < nums.Length; j++)
                {
                    maxproduct = nums[i]; // this is important and when you think you are considering for that subarray.
                    for (int k = i+1; k <= j; k++)  //k<=j condition is important.
                    {
                        maxproduct = maxproduct * nums[k];
                        max = Math.Max(max, maxproduct);
                    }
                    //maxproduct = nums[i];
                    max = Math.Max(max, maxproduct);
                }
            }
            return max;
        }

        // calculate the prefix and suffix product
        public int MaxProduct2(int[] nums)
        {
            int l = 1;
            int r = 1;
            int n = nums.Length;
            int ans = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                l = l == 0 ? 1 : l;
                r = r == 0 ? 1 : r;

                l = l * nums[i];
                r = r * nums[n - 1 - i];
                ans = Math.Max(ans, Math.Max(l, r));
            }
            return ans;

        }
    }
}
