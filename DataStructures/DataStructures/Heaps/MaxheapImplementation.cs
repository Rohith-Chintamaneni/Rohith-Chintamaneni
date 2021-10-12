using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures.Heaps
{
    public class MaxheapImplementation
    {

        // take any array and return it in the form of max heap.
        public int[] MaxHeapSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(arr, n, i);
            }

                return arr;
        }

      
        // if you do this to all elements starting from N/2 to 0 then all elements are heap sorted

        //Heapify Logic - TO remember
        // pass the n/2 value and lenght of array and array
        // let N/2 value as largest which is i i.e=> largest = i
        // calculate left(2i+1) and right(2i+2)
        // if(left < size of array and arr[left]> arr[largest])
        // set largest = left
        // if(right < size of array and arr[right]> arr[largest])
        // set largest = right
        // if(largest != i)
        // Swap and then Heapify() because the sub array might have lost it's property due to swap.




        void Heapify(int[] arr, int n, int i)
        {
            int largest = i; // Initialize largest as root
            int l = 2 * i + 1; // left = 2*i + 1
            int r = 2 * i + 2; // right = 2*i + 2

            // If left child is larger than root
            if (l < n && arr[l] > arr[largest])
                largest = l;

            // If right child is larger than largest so far
            if (r < n && arr[r] > arr[largest])
                largest = r;

            // If largest is not root
            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;

                // Recursively heapify the affected sub-tree
                Heapify(arr, n, largest);
            }
        }

        public int[] AddElement(int[] arr, int element)
        {
            int[] myarr = new int[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                myarr[i] = arr[i];
            }

            myarr[myarr.Length - 1] = element;
            Heapify(myarr,myarr.Length, myarr.Length/2-1);

            return myarr;
        }

        // remove the max element and heapify
        public int Remove(int[] arr, int n)
        {
            
          
                // Move current root to end
              
                arr[0] = arr[n];
               
                
                Heapify(arr, n-1, 0);

                return n - 1;
        }

        // always top element
        public int Peek(int[] arr)
        {
            return arr[0];
        }


        /* A utility function to print array of size N */
        public void printArray(int[] arr, int n)
        {
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");

            Console.WriteLine();
        }

        public int deleteRoot(int[] arr, int n)
        {
            // Get the last element
            int lastElement = arr[n - 1];

            // Replace root with first element
            arr[0] = lastElement;

            // Decrease size of heap by 1
            n = n - 1;

            // heapify the root node
            Heapify(arr, n, 0);

            // return new size of Heap
            return n;
        }
    }
}
