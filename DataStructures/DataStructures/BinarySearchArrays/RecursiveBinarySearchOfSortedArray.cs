using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BinarySearchArrays
{
    class RecursiveBinarySearchOfSortedArray
    {
        // if you want to store a ans and then return it.
        public int BSearchRecursive(int[] array, int element, int low, int high)
        {
            int ans = -2;
            int ans2 = -2;
            if (low > high) return -1;

            int mid = low + (high - low) / 2;

            if (array[mid] == element) return mid;
            else if (element > array[mid])
            {
                ans = BSearchRecursive(array, element, mid + 1, high);
                
            }
            else
            {
               ans2 = BSearchRecursive(array, element, low, mid - 1);
               
            }
            if (ans != -2) return ans; else return ans2;
        }


        // if you want to store a ans and then return it.
        public int BSearchRecursive3(int[] array, int element, int low, int high)
        {
            
            if (low > high) return -1;
            
            int mid = low + (high - low) / 2;

            if (array[mid] == element) return mid;
            else if (element > array[mid])
            {
                int ans = BSearchRecursive(array, element, mid + 1, high);
                return ans;
            }
            else
            {
              int ans2 =  BSearchRecursive(array, element, low, mid - 1);
                return ans2;
            }
       
        }

        // more efficient way. When you have a return type simply put return statement before calling the recursive call.
        public int BSearchRecursive2(int[] array, int element, int low, int high)
        {
            if (low > high) return -1;

            int mid = low + (high - low) / 2;

            if (array[mid] == element) return mid;
            else if (element > array[mid])
            {
                return BSearchRecursive(array, element, mid + 1, high);
                
            }
            else
            {
               return BSearchRecursive(array, element, low, mid - 1);
               
            }

        }
    }
}
