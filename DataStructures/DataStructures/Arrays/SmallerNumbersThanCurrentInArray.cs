using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class SmallerNumbersThanCurrentInArray
    {
        // O(n^2)
        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            int[] ans = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i != j && nums[i] > nums[j])
                    {
                        count++;
                    }
                }
                ans[i] = count;
            }
            return ans;
        }

        public int[] SmallerNumbersThanCurrent1(int[] nums)
        {
            int[] bucket = new int[102];
            for (int i = 0; i < nums.Length; i++)
                bucket[nums[i] + 1]++;

            for (int i = 1; i < 102; i++)
                bucket[i] += bucket[i - 1];

            for (int i = 0; i < nums.Length; i++)
                nums[i] = bucket[nums[i]];

            return nums;
        }
        // Both 2 and 3 are implementations of Prefix sum. In This approach the numbers in original array are
        // marked in a new array at their indexes and increase it's count based on occurences in original array
        // finally we calculate prefix sum and return the values. Because the Prefix sum tells that particular number is 
        // by the index we would know how many times an number is repeated or not.
        public int[] SmallerNumbersThanCurrent3(int[] nums)
        {

            int n = nums.Length;
            // Step 1: Find the maximum value in the array
            int maxValue = 0;
            foreach (int num in nums)
            {
                if (num > maxValue)
                    maxValue = num;
            }

            // Step 2: Create the counting array and count occurrences
            int[] countArr = new int[maxValue + 1];
            foreach (int num in nums)
            {
                countArr[num]++;
            }

            // Step 3: Perform cumulative summation on countArr
            for (int i = 1; i <= maxValue; i++)
            {
                countArr[i] += countArr[i - 1];
            }

            // Step 4: Create a new array to store the counts of smaller numbers
            int[] result = new int[n];

            // Step 5: Calculate the count of smaller numbers for each element
            for (int i = 0; i < n; i++)
            {
                int num = nums[i];
                result[i] = num == 0 ? 0 : countArr[num - 1];
            }

            return result;
        }
    }
}
