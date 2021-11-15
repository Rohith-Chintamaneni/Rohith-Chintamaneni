using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Dynamic_Programming
{
    class KnapsackProblem
    {
        public int[,] t;
        public int KnapsackDPTopDown(int[] weights, int[] price, int capacity, int length)
        { 
            // two things that change here are capacity and size of array

            // so initialize and set it to -1
            t = new int[length+1,capacity+1];
            for (int i = 0; i < length+1; i++)
            {
                for (int j = 0; j < capacity+1; j++)
                {
                    
                        t[i, j] = -1;
                }
            }
          
            
          int n=  KnapsackUsingDPRecursion(weights, price, capacity, length);

            return n;
        }

        // just recursion
        public int KnapsackUsingRecursion(int[] weights, int[] price, int capacity, int length)
        {
            // base condition
            if (capacity == 0 || length == 0) return 0;


            // recursive condition

            if (weights[length - 1] > capacity) return KnapsackUsingRecursion(weights, price, capacity, length - 1);
            else
            {
                return Math.Max(
                    price[length - 1] +
                    KnapsackUsingRecursion(weights, price, capacity - weights[length - 1], length - 1),
                    KnapsackUsingRecursion(weights, price, capacity, length - 1));
            }
           
        }

        // using recursion with memoization,
        // WHere ever you are returning a value it is first stored inside the array first. so the sub problem result can be used later
        public int KnapsackUsingDPRecursion(int[] weights, int[] price, int capacity, int length)
        {
            // base condition
            if (capacity == 0 || length == 0) return 0;

            // memoize condition
            // checking the sub problem result first. if exist use it.
            if (t[length, capacity] != -1) return t[length,capacity];


            // recursive condition
            if (weights[length - 1] > capacity) return t[length, capacity] = KnapsackUsingDPRecursion(weights, price, capacity, length - 1);
            else
            {
                return t[length, capacity] = Math.Max(
                    price[length - 1] +
                    KnapsackUsingDPRecursion(weights, price, capacity - weights[length - 1], length - 1),
                    KnapsackUsingDPRecursion(weights, price, capacity, length - 1));
            }

        }

        // bottom up

        public int KnapsackDPBottomUp(int[] weights, int[] price, int capacity, int length)
        {
            // two things that change here are capacity and size of array

            // so initialize and set it to -1
            t = new int[length + 1, capacity + 1];
         


            int n = KnapsackUsingDPBottomUp_Iterative(weights, price, capacity, length);

            return n;
        }
        // the iterative method of DP comes from recursive method only. so it is important to solve the problem using recursion first.
        public int KnapsackUsingDPBottomUp_Iterative(int[] weights, int[] price, int capacity, int length)
        {
            // base condition of recursive will be converted in populating the Array default values.
            // you will be populating the first row and first column of the array with base condition values.
            // Base condition of recursion: if (capacity == 0 || length == 0) return 0;
            for (int i = 0; i < length + 1; i++)
            {
                for (int j = 0; j < capacity + 1; j++)
                {
                    if (i == 0 || j == 0)
                        t[i, j] = 0;
                }
            }

            // recursive condition is changed into interative approach, where we calculate the values of subproblems first

            for (int i = 1; i < length + 1; i++)
            {
                for (int j = 1; j < capacity + 1; j++)
                {
                    if (weights[i-1] <= j)
                        t[i, j] = Math.Max((price[i - 1] + t[i - 1, j - weights[i - 1]]), t[i - 1, j]);
                    else
                    {
                        t[i, j] = t[i - 1,j];
                    }
                }
            }

            return t[length, capacity];
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
    }
}
