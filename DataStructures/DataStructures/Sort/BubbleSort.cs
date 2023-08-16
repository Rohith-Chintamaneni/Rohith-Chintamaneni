using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Sort
{
    public class BubbleSort
    {
        // Bubble sort
        // O(n2) in worst case and O(n) if already sorted no extra space
        // on every iteration of I, you will notice that the highest element is at the end. BEcause the internal loop runs all the way till the end
        // which means you only need to compare upto n-1, which is nothing but length-i;
        public int[] Sort(int[] arr)
        {
            for(int i=0; i< arr.Length; i++)
            {
                var IsSorted = false;
                for (int j=1; j<arr.Length-i; j++)
                {
                  
                    if(arr[j-1]> arr[j])
                    {
                        var temp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = temp;
                        IsSorted = true;
                    }
                }

                if (!IsSorted) return arr; // this means the arr is already sorted and does not need to be sorted anymore.

            }

            return arr;
        }
    }
}