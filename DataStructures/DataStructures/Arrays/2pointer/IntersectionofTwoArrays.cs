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
    }
}
