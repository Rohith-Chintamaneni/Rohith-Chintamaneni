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
    }

}
