using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DataStructures.Arrays._2pointer
{
    public class IntersectionofTwoArraysIIProblem
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
                    keydictionary[nums1[i]]= keydictionary.GetValueOrDefault(nums1[i]) + 1;
                }

                count = 0;

            }

            var list = new List<int>();
            for (int i = 0; i < nums2.Length; i++)
            {
                // reduce the count from dictionary everytime when a value is present
                if (keydictionary.ContainsKey(nums2[i]) && keydictionary.GetValueOrDefault(nums2[i])>0)
                {
                    list.Add(nums2[i]);
                    // reduce the count on dictionary
                    keydictionary[nums2[i]] = keydictionary.GetValueOrDefault(nums2[i]) - 1;
                }
            }


            return list.ToArray();


            // Approach 2: sorting first
            //   Array.Sort(nums1);
            //   Array.Sort(nums2);

            //    int n1 = 0; 
            //    int n2 = 0;
            //    List<int> result = new List<int>();
            //    while (n1 < nums1.Length && n2 < nums2.Length)
            //    {
            //        if (nums1[n1] < nums2[n2])
            //        {
            //            n1++;
            //        }
            //        else if(nums1[n1] > nums2[n2])
            //        {
            //            n2++;
            //        }
            //        else
            //        {
            //            result.Add(nums1[n1]);
            //            n1++;
            //            n2++;
            //        }
            //    }

            //   return result.ToArray();
        }


    }
}
