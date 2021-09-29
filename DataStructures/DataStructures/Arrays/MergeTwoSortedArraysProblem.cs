using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Text;
using Newtonsoft.Json.Linq;

namespace DataStructures.Arrays
{
    public class MergeTwoSortedArraysProblem
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            
            // the main take away is start filling the Array from reverse order since the nums1 array will have empty slots at the end.
            // know how to read elements from Both arrays at the same time. you will be forced to use 2 pointers on two separate arrays at the same time.

            // first you find the lastindex, so that you know that you need to start from Nums1 in reverse order
            int lastindex = m + n-1;
           
            while (m>0 && n>0)
            {
                if (nums1[m-1] > nums2[n-1])
                {
                    nums1[lastindex] = nums1[m - 1];
                    m--;
                }
                else
                {
                    nums1[lastindex] = nums2[n - 1];
                    n--;
                }

                lastindex--;
            }
            
             // There is one edge case in this scenario where you fill nums1 with leftover of nums2
             // since these elements are already in sorted order you can directly insert them.
             while (n>0)
             {
                 nums1[lastindex] = nums2[n-1];
                 n--;
                 lastindex--;
             }


        }
    }
}
