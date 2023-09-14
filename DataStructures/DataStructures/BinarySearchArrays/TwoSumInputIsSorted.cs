using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BinarySearchArrays
{
    public class TwoSumInputIsSorted
    {
        // using Binary Search. you find the complement and do a binary search on complement.
        public int[] TwoSum(int[] numbers, int target)
        {
            int y = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int complement = target - numbers[i];
                y = BinarySearch(numbers, complement, i + 1);
                if (y > -1)
                {
                    return new int[] { i + 1, y + 1 };
                }
            }
            return new int[] { 0, 0 };
        }

        public int BinarySearch(int[] numbers, int target, int low)
        {
            int high = numbers.Length - 1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (numbers[mid] == target) return mid;
                else if (numbers[mid] > target)
                {
                    high = mid - 1;
                }
                else low = mid + 1;

            }
            return -1;
        }

        // Approach 2: Using two pointers from Left and right is another way
    }
}
