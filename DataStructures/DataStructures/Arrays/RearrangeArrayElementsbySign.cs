using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/rearrange-array-elements-by-sign/
namespace DataStructures.Arrays
{
   public class RearrangeArrayElementsbySign
    {
        public int[] RearrangeArray(int[] nums)
        {
            int[] positive = new int[nums.Length / 2];
            int[] negative = new int[nums.Length / 2];
            int m = 0, n = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    positive[m] = nums[i];
                    m++;
                }
                else
                {
                    negative[n] = nums[i];
                    n++;
                }

            }
            int index = 2;
            for (int i = 0; i < positive.Length; i++)
            {
                nums[index * i] = positive[i];
                nums[(index * i) + 1] = negative[i];
                //index++;
            }

            return nums;
        }
        // in-Place rearraging
        public int[] RearrangeArray2(int[] nums)
        {
            int[] res = new int[nums.Length];
            int p = 0;
            int n = 1;

            foreach (var num in nums)
            {
                if (num > 0)
                {
                    res[p] = num;
                    p += 2;
                }
                else
                {
                    res[n] = num;
                    n += 2;
                }
            }

            return res;
        }
    }
}
