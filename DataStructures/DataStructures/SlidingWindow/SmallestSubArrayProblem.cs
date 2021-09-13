using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.SlidingWindow
{
   public class SmallestSubArrayProblem
    {

            public int smallestSubarray(int targetSum, int[] arr)
            {
                int minWindowSize = int.MaxValue;
                int currentWindowSum = 0;
                int windowStart = 0;
                for (int windowEnd = 0; windowEnd < arr.Length; windowEnd++)
                {
                    currentWindowSum += arr[windowEnd];
                // while loop is compulsory since you want to make sure that you continously check that the value is less 
                    while (currentWindowSum >= targetSum)
                    {
                        minWindowSize = Math.Min(minWindowSize, windowEnd - windowStart + 1);
                        currentWindowSum -= arr[windowStart];
                        windowStart++;
                    }
                }

                return minWindowSize;
            }

            //public static void main(String[] args)
            //{
            //    int[] input = new int[] { 4, 2, 2, 7, 8, 1, 2, 8, 10 };
            //    int targetSum = 8;
            //    System.out.println(smallestSubarray(targetSum, input));
            //}
        }
}
