using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/kth-missing-positive-number/submissions/1049047494/
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

        // approach 3: O(n) and no extra space.
        // case 1: {3,4,5} k=2 ans = 2
        // case 2: {1,2,3} k=2 ans =5
        // case 3: {3,4,5,9} k=3 ans =6
        // Here we are coding for all cases with different branches(if-else)
        public int FindKthPositive3(int[] arr, int k)
        {
            int missed = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    missed += arr[i] - 1;
                    if (missed >= k) return k;
                }
                else
                {
                    missed += arr[i] - arr[i - 1] - 1;
                    if (missed >= k)
                    {
                        missed -= arr[i] - arr[i - 1] - 1;
                        int result = arr[i - 1];
                        while (missed++ < k)
                        {
                            result++;
                        }
                        return result;
                    }
                }
            }
            int ans = arr[arr.Length - 1];
            while (missed++ < k)
            {
                ans++;
            }

            return ans;
        }

        // mind blowing approach but still O(n). But very neat
        public int FindKthPositive4(int[] arr, int k)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] <= k) k++;
                else
                    break;
            }
            return k;
        }
    }
}
