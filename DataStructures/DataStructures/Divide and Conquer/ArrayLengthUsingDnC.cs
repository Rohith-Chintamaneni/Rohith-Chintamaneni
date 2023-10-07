using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Divide_and_Conquer
{
    public class ArrayLengthUsingDnC
    {
        // to get length. use can use array Length property
        // you can loop through array
        // you can use recursion and count
        // you can use divide and conquer

        //using Divide and COnquer. It does use recursion but after recursion it will process more.
        public int GetArrayLength(int[] nums)
        {
            return GetArrayLengthHelper(nums, 0, nums.Length - 1);
        }

        private int GetArrayLengthHelper(int[] nums, int start, int end)
        {
            if(start == end)
            {
                return 1;
            }
            int mid = (start + end) / 2;

            var left = GetArrayLengthHelper(nums, start, mid);
            var right = GetArrayLengthHelper(nums, mid+1, end);


            return left + right;
        }

        // GEt Array Sum Using DnC
        public int GetArraySum(int[] nums)
        {
            return GetArraySumHelper(nums, 0, nums.Length - 1);
        }

        private int GetArraySumHelper(int[] nums, int start, int end)
        {
            if (start == end)
            {
                return nums[start];
            }
            int mid = (start + end) / 2;

            var left = GetArraySumHelper(nums, start, mid);
            var right = GetArraySumHelper(nums, mid + 1, end);


            return left + right;
        }

        // GEt Array Sum Using DnC
        public int GetArrayMax(int[] nums)
        {
            return GetArrayMaxHelper(nums, 0, nums.Length - 1);
        }

        private int GetArrayMaxHelper(int[] nums, int start, int end)
        {
            if (start == end)
            {
                return nums[start];
            }
            int mid = (start + end) / 2;

            var left = GetArrayMaxHelper(nums, start, mid);
            var right = GetArrayMaxHelper(nums, mid + 1, end);

            return Math.Max(left, right);
          
        }
    }
}
