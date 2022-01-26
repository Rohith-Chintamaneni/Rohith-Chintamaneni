using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BinarySearchArrays
{
    class FirstOccurenceInSortedArray
    {
        public int FirstOccurence(int[] arr, int target)
        {
            int low = 0,mid=0, high = arr.Length-1;

            while(low <= high)
            {
                mid = low + (high - low) / 2;
                if (arr[mid] > target) low = mid + 1;
                else if (arr[mid] < target) high = mid - 1;
                else
                {
                    if (mid == 0 || arr[mid - 1] != arr[mid]) return mid;
                    else high = mid - 1; 
                }

            }

            return -1;
        }
    }
}
