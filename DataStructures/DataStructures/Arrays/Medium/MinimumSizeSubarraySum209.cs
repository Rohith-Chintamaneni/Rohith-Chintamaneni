using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays.Medium
{
    public class MinimumSizeSubarraySum209
    {
        public int N;
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
        // optimized in terms of variables.
        public int MinSubArrayLen2(int target, int[] nums)
        {
            int rsum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                rsum += nums[i];
            }
            if (rsum < target) return 0;
            int ans = nums.Length + 1;
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

        public int MinSubArrayLen3(int target, int[] A)
        {
           N = A.Length;
            for (int i = 1; i < N; i++)
                A[i] += A[i - 1];

            int l = 1, r = N;
            while (l < r) {
                int mid = (l + r) / 2;
                if (overTarget(mid, target, A))
                    r = mid;
                else
                    l = mid + 1;
            }
            return overTarget(l, target, A) ? l : 0;
        }
    
        private bool overTarget(int len, int target, int[] A)
        {
             for (int i = 0; i <= N - len; i++)
             {
                 int sum = i > 0 ? A[i + len - 1] - A[i - 1] : A[i + len - 1];
                 if (sum >= target)
                     return true;
             }
             return false;
        }
    }
}
