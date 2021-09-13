using System;
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



        //public int Sum(int[] a)
        //{

        //    if (a.Length < 2)
        //        return a[0];

        //    return a[a.Length-1] + Sum(a.Take(a.Length-1).ToArray());


        //}
    }
}
