using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.SlidingWindow
{
    // SMallestSubArraywithGivenSUm >= 8
   //  [4,2,2,7,8,1,2,8,1,0] targetsum = 8;
    public class SmallestSubArrayProblem
    {

        public int smallestSubarray(int targetSum, int[] arr)
        {

            int windowstart = 0;
            int minwindowSize = int.MaxValue;
            int continuoussum = 0;

            for (int windowend = 0; windowend < arr.Length; windowend++)
            {
                continuoussum += arr[windowend];

                while (continuoussum >= targetSum)
                {
                    minwindowSize = Math.Min(minwindowSize, (windowend - windowstart + 1));
                    continuoussum = continuoussum - arr[windowstart];
                    windowstart++;
                }


            }

            return minwindowSize;





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
