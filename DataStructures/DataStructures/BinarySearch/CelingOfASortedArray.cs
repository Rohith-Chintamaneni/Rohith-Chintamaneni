using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BinarySearch
{
   public class CelingOfASortedArray
    {
       public int FindCeilingOfGivenNumber(int[] arr, int target)
        {
            // 1) sorted array so use Binary Search
            // 2) Find the list of elements equal or greater than target.(you don't need to have list of elements)
            // you need to udnerstand that the array will split into half. And the condition will break once Start>end and that tells us that Start will always be the answer.
            // SImilarily you can also return the floor by returning the end
            // 3) Return the first element of Array.
            if (target > arr[arr.Length - 1]) return -1;

            int start = 0, end = arr.Length - 1;
          
            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (arr[mid] == target) return arr[mid];
                if (arr[mid] < target)
                {
                    start = mid + 1;
                   
                }                   
                else
                    end = mid - 1;

            }
            return arr[start];
        }
    }
}
