using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    class IntersectionofTwoArraysII
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            if (nums2.Length < nums1.Length)
            {
                Intersect(nums2, nums1);
            }
            // another approach is to run
            var keydictionary = new Dictionary<int, int>();
            int count = 0;
            for (int i = 0; i < nums1.Length; i++)
            {
                if (!keydictionary.ContainsKey(nums1[i]))
                {
                    count++;
                    keydictionary.Add(nums1[i], count);
                }
                else
                {
                    keydictionary[nums1[i]] = keydictionary.GetValueOrDefault(nums1[i]) + 1;
                }

                count = 0;

            }

            var list = new List<int>();
            for (int i = 0; i < nums2.Length; i++)
            {
                if (keydictionary.ContainsKey(nums2[i]) && keydictionary.GetValueOrDefault(nums2[i]) > 0)
                {
                    list.Add(nums2[i]);
                    // reduce the count on dictionary
                    keydictionary[nums2[i]] = keydictionary.GetValueOrDefault(nums2[i]) - 1;
                }
            }


            return list.ToArray();
        }

        public int[] Intersect2(int[] nums1, int[] nums2)
        {
            if (nums1.Length > nums2.Length) Intersect2(nums2, nums1);
            var result = new List<int>();
            Dictionary<int, int> hashmap = new Dictionary<int, int>();

            for (int i = 0; i < nums1.Length; i++)
            {

                if (hashmap.ContainsKey(nums1[i]))
                {
                    hashmap[nums1[i]] = hashmap[nums1[i]] + 1;
                }
                else hashmap[nums1[i]] = 1;

            }

            var k = 0;
            for (int j = 0; j < nums2.Length; j++)
            {
                if (hashmap.ContainsKey(nums2[j]) && hashmap[nums2[j]] > 0)
                {

                    hashmap[nums2[j]] = hashmap[nums2[j]] - 1;
                    result.Add(nums2[j]);
                    k++;
                }
            }
            return result.ToArray();
        }

        public int[] Intersect3(int[] nums1, int[] nums2)
        {
            if (nums1.Length > nums2.Length) Intersect3(nums2, nums1);
            var result = new int[nums2.Length];
            Dictionary<int, int> hashmap = new Dictionary<int, int>();

            for (int i = 0; i < nums1.Length; i++)
            {

                if (!hashmap.ContainsKey(nums1[i]))
                {
                    hashmap[nums1[i]] = 1;

                }
                hashmap[nums1[i]] = hashmap[nums1[i]] + 1;
               var ans=  hashmap.GetValueOrDefault(nums1[i]);
            }

            var k = 0;
            for (int j = 0; j < nums2.Length; j++)
            {
                if (hashmap.ContainsKey(nums2[j]) && hashmap[nums2[j]] > 0)
                {

                    hashmap[nums2[j]] = hashmap[nums2[j]] - 1;
                    result[k] = nums2[j];
                    k++;
                }
            }
            return result.Take(k).ToArray();
        }
    }
}
