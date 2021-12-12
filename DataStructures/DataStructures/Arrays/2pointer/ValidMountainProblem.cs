using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Arrays._2pointer
{
    class ValidMountainProblem
    {
        // need to understand such question in depth more.
        public bool ValidMountainArray(int[] arr)
        {
            if (arr.Length < 3) return false;

            int i = 0;

            while (i + 1 < arr.Length && arr[i] < arr[i + 1])
            {
                i++;
            }

            if (i == 0 || i + 1 >= arr.Length) return false;

            while (i+1 < arr.Length)
            {
                if (arr[i] <= arr[i + 1])
                {
                    return false;
                }

                i++;
            }

            return true;
        }

        // more clear and better approach
        public bool validMountainArraySecondApproach(int[] A)
        {
            int N = A.Length;
            int i = 0;

            // walk up
            while (i + 1 < N && A[i] < A[i + 1])
                i++;

            // peak can't be first or last
            if (i == 0 || i == N - 1)
                return false;

            // walk down
            while (i + 1 < N && A[i] > A[i + 1])
                i++;

            return i == N - 1;
        }

        public bool validMountainArrayUsing2pointer(int[] A)
        {
            int n = A.Length, i = 0, j = n - 1;
            while (i + 1 < n && A[i] < A[i + 1]) i++;
            while (j > 0 && A[j - 1] > A[j]) j--;
            return i > 0 && i == j && j < n - 1;
        }
    }
}
