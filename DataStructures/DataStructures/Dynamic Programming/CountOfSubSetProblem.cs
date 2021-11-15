using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.Arrays;

namespace DataStructures.Dynamic_Programming
{
    class CountOfSubSetProblem
    {
        public int?[,] t;
        public int COuntOfSubsetUsingRecursion(int[] nums, int capacity)
        {
            t = new int?[nums.Length + 1, capacity + 1];
            return DFS(nums, capacity, nums.Length);
        }

        public int DFS(int[] nums, int capacity, int length)
        {
            if (capacity == 0) return 1;
            if (length == 0 || capacity < 0) return 0;

            if (t[length, capacity] != null) return t[length, capacity].Value;

            int result;
            if (nums[length - 1] > capacity)
            {
                result = DFS(nums, capacity, length - 1);
            }
            else
            {
                result = DFS(nums, capacity - nums[length - 1], length - 1) + DFS(nums, capacity, length - 1);
            }

            t[length, capacity] = result;
            return result;
        }
    }
}
