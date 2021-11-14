using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Dynamic_Programming
{
    class FibonacciUsingMemoization
    {
        public long[] t;

        public long CalculateFibonacci(int n)
        {
            t = new long[n + 1];
            Array.Fill(t, -1);
           return FibonacciWithMemoization(n);
        }
        public long FibonacciWithMemoization(int n)
        {
            if (n <= 1) return n;

            if (t[n] != -1) return t[n];
            return t[n] = FibonacciWithMemoization(n - 1) + FibonacciWithMemoization(n - 2);
        }

        public long FibonacciWithOutMemoization(int n)
        {
            if (n <= 1) return n;

          
            return FibonacciWithOutMemoization(n - 1) + FibonacciWithOutMemoization(n - 2);
        }
    }
}
