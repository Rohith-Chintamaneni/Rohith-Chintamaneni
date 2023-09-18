using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays._2pointer
{
    class IntersectionofTwoArrays
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            HashSet<int> set = new HashSet<int>();
            HashSet<int> intersect = new HashSet<int>();
            for (int i = 0; i < nums1.Length; i++)
            {
                set.Add(nums1[i]);
            }
            for (int i = 0; i < nums2.Length; i++)
            {
                if (set.Contains(nums2[i]))
                {
                    intersect.Add(nums2[i]);
                }
            }
            int[] result = new int[intersect.Count()];
            int j = 0;
            foreach (var num in intersect)
            {
                result[j++] = num;
            }
            return result;
        }

        //using 2 hashSets.
        public int[] Intersection2(int[] nums1, int[] nums2)
        {
            HashSet<int> sol = new HashSet<int>();
            for (int i = 0; i < nums2.Length; i++)
            {
                if (!sol.Contains(nums2[i])) sol.Add(nums2[i]);
            }

            HashSet<int> ans = new HashSet<int>();
            for (int i = 0; i < nums1.Length; i++)
            {
                if (sol.Contains(nums1[i]))
                {
                    if (!ans.Contains(nums1[i])) ans.Add(nums1[i]);
                }
            }
            return ans.ToArray();
        }

        // using one hashSet but more efficient.
            public int[] Intersection3(int[] nums1, int[] nums2)
            {

                // always check the array with less elements
                if (nums2.Length < nums1.Length) Intersection3(nums2, nums1);

                HashSet<int> list1 = new HashSet<int>();

                for (int i = 0; i < nums1.Length; i++)
                {
                    list1.Add(nums1[i]);
                }

                list1.IntersectWith(nums2);
                return list1.ToArray();


            }

        // Approach 3: DO a Binary Search on Bigger array for each element in Small array. The Bigger array must be Sorted. The final answer must be in HashSet
        public int[] Intersection4(int[] nums1, int[] nums2)
        {
            if (nums2.Length < nums1.Length)
            {
                Intersection4(nums2, nums1);
            }

            Array.Sort(nums2);



            var intersection = new HashSet<int>();

            foreach (int num in nums1)
            {
                // Find it in inner arary
                if (BinarySearch(nums2, num))
                {
                    intersection.Add(num);
                }
            }

            return intersection.ToArray();
        }

        private bool BinarySearch(int[] nums, int target)
        {
            int low = 0;
            int high = nums.Length - 1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (target == nums[mid])
                {
                    return true;
                }
                else if (target < nums[mid])
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }

            return false;
        }
    }
}
