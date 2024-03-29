﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DataStructures.Recursion
{
    public class SumProblemUsingRecursion
    {

        public int Sum(int[] A, int N)
        {
            if (N <= 0)
                return 0;
            return (Sum(A, N - 1) + A[N - 1]);
        }

        public int Sum2(int[] A)
        {
      
            return Sum2Helper(A, A.Length);
        }

        public int Sum2Helper(int[] a, int indexcount)
        {
          
            if (indexcount == 0) return 0;

           return Sum2Helper(a, indexcount - 1) + a[indexcount-1];
          
        }

        public int Sum3(int[] A)
        {

            return Sum3Helper(A, 0,0);
        }

        public int Sum3Helper(int[] a, int sum, int index)
        {
            if (index == a.Length) return sum; sum += a[index]; return Sum3Helper(a, sum, index + 1);

        }

        public int SumOftwoNumbers(int x, int y)
        {
            if (y == 0) return x;

           return 1 + SumOftwoNumbers(x, y - 1);

            
        }

        public int ProductOftwoNumbers(int x, int y)
        {
            if (y == 1) return x;

            return x + ProductOftwoNumbers(x, y - 1);


        }



        //public int Sum(int[] a)
        //{

        //    if (a.Length < 2)
        //        return a[0];

        //    return a[a.Length-1] + Sum(a.Take(a.Length-1).ToArray());


        //}
    }
}
