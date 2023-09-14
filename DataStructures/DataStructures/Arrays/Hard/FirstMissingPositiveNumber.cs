using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays.Hard
{
    public class FirstMissingPositiveNumber
    {
        // Brute Force.
        public int FirstMissingPositive(int[] nums)
        {

            Array.Sort(nums);
            int min = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == min)
                {
                    min++;
                }
            }
            return min;
        }

        // O(n) and O(n) space
        public int FirstMissingPositive2(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 1;
            }

            int result = -1;

            var hashSet = new HashSet<int>();
            int maxPositiveNumber = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > maxPositiveNumber)
                {
                    maxPositiveNumber = nums[i];
                }

                if (nums[i] > 0)
                {
                    hashSet.Add(nums[i]);
                }
            }

            for (int i = 1; i <= maxPositiveNumber; i++)
            {
                if (!hashSet.Contains(i))
                {
                    result = i;
                    break;
                }
            }

            if (result < 0)
            {
                result = maxPositiveNumber + 1;
            }

            return result;
        }

    }
}
