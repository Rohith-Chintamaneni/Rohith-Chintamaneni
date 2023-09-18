using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BinarySearchArrays
{
    public class FindPeakIndexInMountain
    {
        // if you try to compare mid to its previous element. It might lead to index out as we can compare to -1. But I don't that happening for mid +1;
        public int PeakIndexInMountainArray(int[] arr)
        {
            int low = 0; int high = arr.Length - 1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (arr[mid] < arr[mid + 1]) low = mid + 1;
                else high = mid - 1;
            }
            return low;
        }

       
    }
}
