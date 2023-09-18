using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/special-array-with-x-elements-greater-than-or-equal-x/
namespace DataStructures.BinarySearchArrays.Easy
{
    public class Special_array_with_x_elements_greater_than_or_equal_x
    {
        // Brute force
        public int SpecialArray(int[] nums)
        {
            int max = nums.Max();
       
           
            for (int i = 1; i <= max; i++)
            {
               int count = 0;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i <= nums[j])
                        count++;
                }
                if (i == count) return i;
            }

            return -1;
        }

        // 2 pass solution
        public int SpecialArray2(int[] nums)
        {
            int x = nums.Length;
            int[] counts = new int[x + 1];

            foreach (var elem in nums)
                if (elem >= x)
                    counts[x]++;
                else
                    counts[elem]++;

            int res = 0;
            for (int i = counts.Length - 1; i > 0; i--)
            {
                res += counts[i];
                if (res == i)
                    return i;
            }

            return -1;
            
        }
        // Using Binary Search
        public int countPossibility(int[] nums, int x)
        {
            int cnt = 0;
            foreach (var n in nums) if (n >= x) cnt++;
            return cnt;
        }
        // Pay attention to how BInary Search is used. high is max of array
        public int specialArray3(int[] nums)
        {
            int maxi = nums.Max(), start = 1, mid = 0;
        
            int end = maxi;
            while (start <= end)
            {
                mid = (start + end) / 2;
                int check = countPossibility(nums, mid);
                if (check == mid) return mid;
                if (mid < check) start = mid + 1;
                else end = mid - 1;
            }
            return -1;
        }
    }
}
