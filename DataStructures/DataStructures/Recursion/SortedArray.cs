using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Recursion
{
   public class SortedArray
    {
        public bool CHeckIfArrayisSorted(int[] arr)
        {
            return CHeckIfArrayisSortedHelper(arr, 0, arr.Length - 1);
        }
        // my implementation
        private bool CHeckIfArrayisSortedHelper(int[] arr, int start, int end)
        {
            if (start >= end) return true;

            if (arr[start] < arr[start + 1]) return CHeckIfArrayisSortedHelper(arr, start + 1, end);
            else return false;


        }
        // His implementation
        public bool CHeckIfArrayisSortedHelper1(int[] arr, int start, int end)
        {
            if (start >= end) return true;

            return (arr[start] < arr[start + 1]) && CHeckIfArrayisSortedHelper1(arr, start + 1, end);
        }


    }
}
