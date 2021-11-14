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

        // using recursion with memoization
        public int KnapsackUsingDPRecursion(int[] weights, int[] price, int capacity, int length)
        {
            // base condition
            if (capacity == 0 || length == 0) return 0;

            // memoize condition
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
    }
}
