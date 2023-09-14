using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BinarySearchArrays.Easy
{
    public class kth_missing_positive_number
    {
        // using Array indexing.
        public int FindKthPositive(int[] arr, int k)
        {
            int[] ans = new int[2002];
            for (int i = 0; i < arr.Length; i++)
            {
                ans[arr[i]] = 1;
            }
            int count = 1;
            for (int i = 1; i < ans.Length; i++)
            {
                if (ans[i] == 0 && k > 0)
                {
                    k--;
                    count = i;
                }
            }

            return count;
        }

        // Need to understand Binary Search since itis sorted.
    }
}
