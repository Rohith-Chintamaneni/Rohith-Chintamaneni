using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Recursion
{
    public class LinearSearchUsingRecursion
    {
        public int PerformLinearSearch(int[] arr, int target)
        {
            return PerformLinearSearchHelper(arr, target, 0);
        }

        private int PerformLinearSearchHelper(int[] arr, int target, int index)
        {
            if (index >= arr.Length) return -1;

            if(arr[index] == target) return index;

            return PerformLinearSearchHelper(arr, target, index + 1);


        }
    }
}
