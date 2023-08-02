using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class NumOfGoodPairs
    {
        // Time COmplexity O(n) and Space O(n)
        public int NumIdenticalPairs(int[] nums)
        {
            int count = 0;
            Dictionary<int, int> frequency = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (frequency.ContainsKey(nums[i]))
                {
                    frequency[nums[i]]++;
                }
                else
                    frequency[nums[i]] = 1;

            }
            foreach (var item in frequency)
            {
                var val = item.Value;
                count += val * (val - 1) / 2; // nC2 = n!/(n-r)! * r!  => n! / 2! * (n-2)! => n*(n-1)*(n-2)!/(n-2)!*2 ===> n(n-1)/2;
            }

            return count;
        }

        // Time complexity O(n^2) and Space O(1)
        public int NumIdenticalPairs2(int[] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j] && i < j)
                        count++;
                }
            }
            return count;
        }
    }
}
