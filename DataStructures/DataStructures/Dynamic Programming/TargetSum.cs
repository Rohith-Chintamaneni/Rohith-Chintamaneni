using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Dynamic_Programming
{
    class TargetSum
    {
        int total;
        private int?[,] memo;
        public int FindTargetSumWays(int[] nums, int target)
        {
            total = nums.Sum();

            memo = new int?[nums.Length, (2 * total) + 1];

            return calculate(nums, 0, 0, target);
        }
        public int calculate(int[] nums, int i, int sum, int target)
        {
            if (i == nums.Length)
            {
                if (sum == target)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                if (memo[i, sum + total] != null)
                {
                    return memo[i, sum + total].Value;
                }
                int add = calculate(nums, i + 1, sum + nums[i], target);
                int subtract = calculate(nums, i + 1, sum - nums[i], target);
                memo[i, sum + total] = add + subtract;
                return memo[i, sum + total].Value;
            }
        }
    }
}
