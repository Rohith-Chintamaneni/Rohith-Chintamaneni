using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/find-smallest-letter-greater-than-target/description/
namespace DataStructures.BinarySearchArrays.Easy
{
    public class FindSmallestLetterGreaterThanTarget
    {
        public char NextGreatestLetter(char[] letters, char target)
        {
            int low = 0, mid, high = letters.Length - 1;

            while (low <= high)
            {
                mid = low + (high - low) / 2;
                if (letters[mid] <= target)
                {
                    low = mid + 1;
                }
                else if (letters[mid] > target)
                {
                    high = mid - 1;
                }
            }

            return low < letters.Length ? letters[low] : letters[0];
        }

    }
}
