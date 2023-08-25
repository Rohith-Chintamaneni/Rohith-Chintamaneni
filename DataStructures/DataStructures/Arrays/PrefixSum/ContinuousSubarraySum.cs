using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/continuous-subarray-sum/
namespace DataStructures.Arrays.PrefixSum
{
    public class ContinuousSubarraySum
    {

        // Brute Force APpraoch.
        public bool CheckSubarraySum(int[] nums, int k)
        {
            int[] prefix = new int[nums.Length];
            prefix[0] = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                prefix[i] = prefix[i - 1] + nums[i];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i; j < nums.Length; j++)
                {
                    if (j - i >= 1)
                    {
                        var sum = GetRangeSum(prefix, i, j);
                        if (sum % k == 0) return true;
                    }

                }
            }

            return false;
        }

        public int GetRangeSum(int[] prefix, int left, int right)
        {
            if (left == 0) return prefix[right];
            else
                return prefix[right] - prefix[left - 1];
        }
        // Store the index instead of count
        public bool CheckSubarraySum2(int[] nums, int k)
        {
            int sum = 0;
            Dictionary<int, int> remainderMap = new Dictionary<int, int>();
            remainderMap[0] = -1; // Initialize with remainder 0 at index -1

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];

                if (k != 0)
                {
                    sum %= k; // Take the remainder to handle negative numbers and prevent division by 0
                }

                if (remainderMap.ContainsKey(sum))
                {
                    if (i - remainderMap[sum] > 1)
                    {
                        return true;
                    }
                }
                else
                {
                    remainderMap[sum] = i;
                }
            }

            return false;
        }
    }
}
