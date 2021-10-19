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
    }
}
