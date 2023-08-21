using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays.Medium
{
    public class MinimumSizeSubarraySum209
    {
        // Using Slidin Window. 
        public int MinSubArrayLen(int target, int[] nums)
        {
            int rsum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                rsum += nums[i];
            }
            if (rsum < target) return 0;
            int ans = int.MaxValue;
            int s = 0;
            rsum = 0;
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {

                rsum = rsum + nums[i];
                count++;

                while (rsum >= target)
                {
                    ans = Math.Min(ans, count);
                    if (rsum >= target)
                    {
                        count--;
                    }
                    rsum = rsum - nums[s];
                    s++;



                }
            }

            // ans = Math.Min(ans, count);

            return ans;
        }

        public int MinSubArrayLen2(int target, int[] nums)
        {
            int rsum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                rsum += nums[i];
            }
            if (rsum < target) return 0;
            int ans = nums.Length+1;
            int s = 0;
            rsum = 0;
            int MinLength = nums.Length + 1;
            for (int i = 0; i < nums.Length; i++)
            {

                rsum = rsum + nums[i];
             

                while (rsum >= target)
                {
                    MinLength = i - s + 1;
                    ans = Math.Min(ans, MinLength);                  
                    rsum = rsum - nums[s];
                    s++;



                }
            }

       

            return ans;
        }
    }
}
