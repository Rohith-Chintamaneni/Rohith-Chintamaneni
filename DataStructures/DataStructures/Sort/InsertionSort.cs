using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Sort
{
    class InsertionSort
    {
        public void InsertionSort(int[] numbers)
        {
            // this sort is very similar to holding a pack of cards. When a new card is taken you will compare it previous cards in your hand and move them n positions to insert it
            // insertion sort does not swap, it moves(copies) all the items less than current item to right
            // time complexity is worst O(n2)
          //  int previous = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                int curr = numbers[i];
                int j = i-1;
                while (numbers[j] > curr && j>=0)
                {
                    // all elements have been shifted to right
                    numbers[j+1] = numbers[j];
                    j--;
                }
                // finally you need to insert the current item
                // while checking in while loop you go one extra element to find out if it is less or not. But while inserting the current element you need to add j+1 to insert in current location.
                numbers[j+1] = curr;

            }


        }
    }
}
