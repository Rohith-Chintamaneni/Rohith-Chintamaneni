using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Arrays.Medium
{
    public class RotateArrayProblem
    {
        public void Rotate(int[] nums, int k)
        {
            
            var steps = k % nums.Length;

            if (steps == 0)
            {
                return;
            }

            Rotate(nums[0], steps, 0, nums);
        }

        private static void Rotate(int value, int position, int count, int[] nums)
        {
            if (count < nums.Length - 1)
            {
                Rotate(nums[count + 1], (position + 1) % nums.Length, count + 1, nums);
            }

            nums[position] = value;
        }








        //public int[] Rotate(int[] nums, int k)
        //{
        //    k = k % nums.Length;
        //    Reverse(nums, 0, nums.Length-1);  // First rotate
        //    Reverse(nums, 0, k-1);    // now only rotate first 3 elements
        //    Reverse(nums, k, nums.Length);
        //    return nums;
        //}


        //public void Reverse(int[] nums, int left, int right)
        //{
        //    int temp = 0;
        //    while (left<right)
        //    {
        //        temp = nums[left];
        //        nums[left] = nums[right];
        //        nums[right] = temp;

        //        left++;
        //        right--;
        //    }

        //}
    }
}
