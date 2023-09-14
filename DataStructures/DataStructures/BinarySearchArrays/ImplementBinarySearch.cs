using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BinarySearch
{
    public class ImplementBinarySearch
    {
        public int SearchusingRecursion(int[] arr, int target)
        {

            return SearchusingRecursionHelper(arr, target, 0, arr.Length - 1);
        }
        // you need to pay attention to what is passed in Mid, Like Mid + 1 and Mid -1. THen only the base condition (Start>End) will hit.
        private int SearchusingRecursionHelper(int[] arr, int target, int start, int end)
        {
            if (start > end) return -1;

            int mid = start + (end - start) / 2;

            if (arr[mid] == target) return mid;
           
            return arr[mid] < target ? SearchusingRecursionHelper(arr, target, mid+1, end) : SearchusingRecursionHelper(arr, target, start, mid-1);

        }

        public int SearchUsingInteration(int[] arr, int target)
        {
            int start = 0;
            int end = arr.Length-1;

            while(start <= end)
            {
                int mid = start + (end - start) / 2;

                if (arr[mid] == target) return mid;

                if (arr[mid] < target)
                    start = mid + 1;
                else
                    end = mid - 1;
            }

            return -1;
        }
    }
}
