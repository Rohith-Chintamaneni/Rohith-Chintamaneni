using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BinarySearchArrays
{
    class RecursiveBinarySearchOfSortedArray
    {

        public int BSearchRecursive(int[] array, int element, int low, int high)
        {
            if (low > high) return -1;

            int mid = low + (high - low) / 2;

            if (array[mid] == element) return mid;
            else if (element > array[mid]) return BSearchRecursive(array, element, mid + 1, high);
            else return BSearchRecursive(array, element, low, mid-1);

        }
    }
}
