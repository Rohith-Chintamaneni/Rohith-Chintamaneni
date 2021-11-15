using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Dynamic_Programming
{
    // Problem 416 leetcode:
    class PartitionEqualSubsetSum
    {

        public bool?[,] t;
        public bool CanPartition(int[] nums)
        {
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];

            }

            if (sum % 2 != 0) return false;
            else
            {
                return EqualSumPartition(nums, sum / 2, nums.Length);
            }


        }

        public bool EqualSumPartition(int[] arr, int capacity, int n)
        {
            bool[,] t = new bool[n + 1, capacity + 1];

            for (int i = 0; i < n + 1; i++)
            {
                for (int j = 0; j < capacity + 1; j++)
                {
                    if (i == 0)
                        t[i, j] = false;

                    if (j == 0) t[i, j] = true;
                }
            }

            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 1; j < capacity + 1; j++)
                {
                    if (arr[i - 1] <= j)
                        t[i, j] = t[i - 1, j - arr[i - 1]] || t[i - 1, j];
                    else
                        t[i, j] = t[i - 1, j];

                }

            }

            return t[n, capacity];

        }


        public bool canPartition(int[] nums)
        {
            if (nums.Length == 0)
                return false;
            int totalSum = 0;
            // find sum of all array elements
            foreach (var num in nums)
            {
                totalSum += num;
            }

            // if totalSum is odd, it cannot be partitioned into equal sum subset
            if (totalSum % 2 != 0) return false;
            int subSetSum = totalSum / 2;
            bool[] dp = new bool[subSetSum + 1];
            dp[0] = true;
            foreach (var curr in nums)
            {
                for (int j = subSetSum; j >= curr; j--)
                {
                    dp[j] |= dp[j - curr];
                }
            }

            return dp[subSetSum];
        }


        public bool canPartitionUsingRecursion(int[] nums)
        {
            int totalSum = 0;
            // find sum of all array elements
            foreach (var num in nums)
            {
                totalSum += num;
            }
            // if totalSum is odd,it cannot be partitioned into equal sum subset
            if (totalSum % 2 != 0) return false;
            int subSetSum = totalSum / 2;
            int n = nums.Length;
            t = new bool?[n + 1, subSetSum + 1];
            return DFS(nums, n, subSetSum);

        }

        public bool DFS(int[] arr, int length, int capacity)
        {
            if (capacity == 0) return true;
            if (length == 0 || capacity < 0) return false;

            if (t[length, capacity] != null) return t[length, capacity].Value;
            bool result;
            if (arr[length - 1] > capacity)
            {
                result = DFS(arr, length - 1, capacity);
            }
            else
            {
                result = DFS(arr, length - 1, capacity - arr[length - 1]) || DFS(arr, length - 1, capacity);
            }
                // both approaches can be followed

          //  bool result = DFS(arr, length - 1,capacity-arr[length-1]) || DFS(arr, length - 1, capacity);

            t[length, capacity] = result;
            return result;
        }
    }
}
