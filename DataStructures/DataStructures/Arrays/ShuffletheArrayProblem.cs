using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Arrays
{
    class ShuffletheArrayProblem
    {
        public int[] Shuffle(int[] nums, int n)
        {
            if (n <= 1) return nums;

            int[] res = new int[2 * n];
            for (int i = 0; i < n; i++)
            {
                res[2 * i] = nums[i];
                res[2 * i + 1] = nums[n + i];
            }

            return res;

        }

        public int[] shuffle2(int[] nums, int n)
        {
            for (int i = 0; i < n; i++)
            {
                nums[i] += nums[n + i] * 10000;
            }

            for (int i = n - 1; i >= 0; i--)
            {
                nums[2 * i + 1] = nums[i] / 10000;
                nums[2 * i] = nums[i] % 10000;
            }

            return nums;
        }

        public int[] Shuffle3(int[] nums, int n)
        {
            var ans = new int[nums.Length];
            int s = nums.Length / 2;
            for (int i = 0; i < s; i++)
            {
                ans[2 * i] = nums[i];
                ans[2 * i + 1] = nums[i + s];
            }
            return ans;
        }
    }

}
