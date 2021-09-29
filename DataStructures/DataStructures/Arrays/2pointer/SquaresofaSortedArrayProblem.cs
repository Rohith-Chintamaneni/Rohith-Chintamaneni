using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataStructures.Recursion;

namespace DataStructures.Arrays._2pointer
{
    public class SquaresofaSortedArrayProblem
    {
        // Leetcode 977: input: [-4,-1,0,3,10] output: [0,1,9,16,100]
        public int[] SortedSquares(int[] nums)
        {
            int begin = 0;
            int end = nums.Length - 1;
            int currentindex = nums.Length - 1;
            int[] finalresult = new int[nums.Length];    
            // use a aux storage to insert max values but 

            while (begin <= end)
            {
                if (nums[begin] * nums[begin] < nums[end] * nums[end])
                {
                    finalresult[currentindex] = nums[end] * nums[end];
                    currentindex--;
                    end--;
                }
                else
                {
                    finalresult[currentindex] = nums[begin] * nums[begin];
                    currentindex--;
                    begin++;
                }
            }

            return finalresult;

            //SortedSet<int> sortedarray = new SortedSet<int>();
            //// approach 2:  did not work, since it cannot insert duplicates
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    nums[i] = nums[i] * nums[i];
            //    sortedarray.Add(nums[i]);
            //}

            //return sortedarray.ToArray();
        }
    }
}
