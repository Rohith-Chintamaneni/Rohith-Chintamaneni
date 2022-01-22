using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BinarySearchArrays
{
    class IterativeBinarySearchInSortedArray
    {
       public int FindtheIndexOfElementInSortedArrray(int[] array, int elementtosearch)
        {
            int high = array.Length - 1;
            int low = 0;

            while (low<=high)
            {
                int mid = low + (high - low) / 2;
                if (elementtosearch == array[mid]) return mid;
                else if (elementtosearch > array[mid]) low = mid + 1;
                else high = mid - 1;


            }
            return -1;

        }
    }
}
