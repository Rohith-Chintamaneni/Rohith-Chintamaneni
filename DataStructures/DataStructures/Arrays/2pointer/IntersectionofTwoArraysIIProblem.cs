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
                    keydictionary[nums1[i]] = keydictionary.GetValueOrDefault(nums1[i]) + 1;
                }

                count = 0;

            }

            var list = new List<int>();
            for (int i = 0; i < nums2.Length; i++)
            {
                // reduce the count from dictionary everytime when a value is present
                if (keydictionary.ContainsKey(nums2[i]) && keydictionary.GetValueOrDefault(nums2[i]) > 0)
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

        public int[] Intersect2(int[] nums1, int[] nums2)
        {
            if (nums2.Length < nums1.Length)
            {
                Intersect2(nums2, nums1);
            }

            var dictionary = new Dictionary<int, int>();

            for (int i = 0; i < nums2.Length; i++)
            {
                if (dictionary.ContainsKey(nums2[i]))
                {
                    dictionary[nums2[i]] = dictionary.GetValueOrDefault(nums2[i]) + 1;
                }
                else
                    dictionary[nums2[i]] = 1;


            }
            var ans = new List<int>();
            for (int i = 0; i < nums1.Length; i++)
            {
                if (dictionary.ContainsKey(nums1[i]) && dictionary.GetValueOrDefault(nums1[i]) > 0)
                {
                    ans.Add(nums1[i]);
                    dictionary[nums1[i]] = dictionary.GetValueOrDefault(nums1[i]) - 1;
                }

            }
            return ans.ToArray();
        }

        // Using Indexing
        public int[] Intersect3(int[] nums1, int[] nums2)
        {

            if (nums2.Length < nums1.Length) Intersect3(nums2, nums1);

            int[] index = new int[1001];

            for (int i = 0; i < nums2.Length; i++)
            {
                index[nums2[i]] = index[nums2[i]] + 1;

            }
            List<int> ans = new List<int>();
            for (int i = 0; i < nums1.Length; i++)
            {
                if (index[nums1[i]] > 0)
                {
                    ans.Add(nums1[i]);
                    index[nums1[i]] = index[nums1[i]] - 1;
                }
            }

            return ans.ToArray();
        }

        public int[] Intersect4(int[] nums1, int[] nums2)
        {
            if (nums2.Length < nums1.Length) Intersect4(nums2, nums1);

            Array.Sort(nums2);
            Array.Sort(nums1);
            List<int> sol = new List<int>();
            int leftindex = 0;
            for (int i = 0; i < nums1.Length; i++)
            {
                int index = BinarySearch(nums2, nums1[i], leftindex);

                if (index != -1)
                {
                    sol.Add(nums1[i]);
                    leftindex = index + 1;
                }
            }
            return sol.ToArray();
        }

        public int BinarySearch(int[] arr, int target, int left)
        {
            int right = arr.Length - 1;
            int index = -1;

            while (left <= right)
            {
                int middle = left + (right - left) / 2;

                if (arr[middle] == target)
                {
                    index = middle;

                    right = middle - 1;
                }
                else if (arr[middle] > target)
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }

            return index;
        }

    }
}




//main idea:

//using binary search, search for the elements of the smallest array(nums1) in the largest array(nums2)

//sort the largest array o that binary search is feasible
//sort the smallest array so that we can seach sequentially

//if element is found,
//	keep searching to the left until we find the first occurrence of the element

//	add element to the result

//when element is found, keep track of the last index where element was found so that next binary search ignores previous used indexes
//	ie. nums1 = 1,1   nums2 = 1,2,2 - output should be [1] -once we found first 1 at index 0 and next search is done as of index 1
