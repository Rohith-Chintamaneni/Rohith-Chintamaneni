using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/sum-of-all-odd-length-subarrays/description/
namespace DataStructures.Arrays.PrefixSum
{
    public class SumOfAllOddLengthSubArray
    {
        // Brute force
        public int SumOddLengthSubarrays(int[] arr)
        {
            
            int ssum = 0;
            int count = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {

                    for (int k = i; k <= j; k++)
                    {
                        if (count % 2 != 0)
                            ssum += arr[k];

                    }
                    count++;
                }
            }

            return ssum;
        }

        public int SumOddLengthSubarrays2(int[] arr)
        {

            int gsum = 0;
            int ssum = 0;
            int count = 1;
            int[] parr = new int[arr.Length];

            parr[0] = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                parr[i] = parr[i - 1] + arr[i];
            }
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    if (((j - i + 1) % 2) != 0) ssum += i == 0 ? parr[j] : parr[j] - parr[i - 1];
                }
            }
            
            return ssum;
        }
    }
}
