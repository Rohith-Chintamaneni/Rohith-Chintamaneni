using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Dynamic_Programming
{
    class UnboundKnapsack
    {
        public int?[,] t;
        public int UnBoundKnapsackUsingRecursion(int[] weights, int[] price, int capacity, int length)
        {
            // base condition
            if (capacity == 0 || length == 0) return 0;


            // recursive condition

            if (weights[length - 1] > capacity) return UnBoundKnapsackUsingRecursion(weights, price, capacity, length - 1);
            else
            {
                return Math.Max(
                    price[length - 1] +
                    UnBoundKnapsackUsingRecursion(weights, price, capacity - weights[length - 1], length),
                    UnBoundKnapsackUsingRecursion(weights, price, capacity, length - 1));
            }

        }

        public int UnboundknapsackUsingRecursionMemoization(int[] weights, int[] price, int capacity, int length)
        {
            // two things that change here are capacity and size of array

            // so initialize and set it to -1
            t = new int?[length + 1, capacity + 1];
            //for (int i = 0; i < length + 1; i++)
            //{
            //    for (int j = 0; j < capacity + 1; j++)
            //    {

            //        t[i, j] = -1;
            //    }
            //}
            int n = UnboundKnapsackUsingRecursion(weights, price, capacity, length);

            return n;
        }

        public int UnboundKnapsackUsingRecursion(int[] weights, int[] price, int capacity, int length)
        {
            // base condition
            if (capacity == 0 || length == 0) return 0;

            // memoize condition
            // checking the sub problem result first. if exist use it.
            if (t[length, capacity] != null) return t[length, capacity].Value;


            // recursive condition
            if (weights[length - 1] > capacity)
            {
                var result = UnboundKnapsackUsingRecursion(weights, price, capacity, length - 1);
                t[length, capacity] = result;
                return result;
            }
            else
            {
              var result = Math.Max(
                    price[length - 1] +
                    UnboundKnapsackUsingRecursion(weights, price, capacity - weights[length - 1], length),
                    UnboundKnapsackUsingRecursion(weights, price, capacity, length - 1));
              t[length, capacity] = result;
              return result;

            }

        }
    }
}
