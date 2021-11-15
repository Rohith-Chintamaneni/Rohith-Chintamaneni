using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Dynamic_Programming
{
    class SubsetSum
    {
        public bool?[,] t;
        public bool SubSetSum_DP(int[] weights, int capacity, int length)
        {
            // two things that change here are capacity and size of array

            // so initialize and set it to -1
            t = new bool?[length + 1, capacity + 1];



            bool n = SubSetSumBottomUp_Iterative(weights, capacity, length);

            return n;
        }
        public bool SubSetSumBottomUp_Iterative(int[] weights, int capacity, int length)
        {
            // base condition of recursive will be converted in populating the Array default values.
            // you will be populating the first row and first column of the array with base condition values.
            // Base condition of recursion: if (capacity == 0 || length == 0) return 0;
            for (int i = 0; i < length + 1; i++)
            {
                for (int j = 0; j < capacity + 1; j++)
                {
                    if (i == 0)
                        t[i, j] = false;

                    if (j == 0)
                        t[i, j] = true;
                }
            }

            // recursive condition is changed into interative approach, where we calculate the values of subproblems first

            for (int i = 1; i < length + 1; i++)
            {
                for (int j = 1; j < capacity + 1; j++)
                {
                    if (weights[i - 1] <= j)
                        t[i, j] =  t[i - 1, j - weights[i - 1]].Value || t[i - 1, j].Value;
                    else
                    {
                        t[i, j] = t[i - 1, j];
                    }
                }
            }

            return t[length, capacity].Value;
            // recursive condition
            //if (weights[length - 1] > capacity)
            //    return t[length-1, capacity];
            ////t[length, capacity] = KnapsackUsingDPRecursion(weights, price, capacity, length - 1);
            //else
            //{

            //    return t[length, capacity] = Math.Max((price[length - 1] + t[length - 1, capacity - weights[length - 1]]), t[length - 1, capacity]);
            //    //   KnapsackUsingDPRecursion(weights, price, capacity - weights[length - 1], length - 1),
            //    //  KnapsackUsingDPRecursion(weights, price, capacity, length - 1));
            //}

        }

        public bool SubSetSum_Recursion(int[] nums, int capacity, int length)
        {
           
            t = new bool?[length + 1, capacity + 1];
            return DFS(nums, length, capacity);

        }

        public bool DFS(int[] arr, int length, int capacity)
        {
            if (capacity == 0) return true;
            if (length == 0 || capacity < 0) return false;

            if (t[length, capacity] != null) return t[length, capacity].Value;

            bool result = DFS(arr, length - 1, capacity - arr[length - 1]) || DFS(arr, length - 1, capacity);

            t[length, capacity] = result;
            return result;
        }
    }
}
