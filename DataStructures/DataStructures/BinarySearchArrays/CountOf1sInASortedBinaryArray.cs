using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BinarySearchArrays
{
    class CountOf1sInASortedBinaryArray
    {
        // we are kind of counting based on subtracting the start and end of index count
        public int CountOfOnesBinaryArray(int[] arr)
        {
            int low = 0, high = arr.Length - 1, mid = 0;

            while(low <= high)
            {
                mid = low + (high - low) / 2;
                if (arr[mid] == 0) low = mid + 1;  // since we will have one 0 and 1s in array else if condition is not required
                else
                {
                    if (mid == 0 || arr[mid - 1] == 0) return arr.Length - mid;
                    else high = mid - 1;
                }


            }
            return 0;
        }

    }
}
