using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/matrix-diagonal-sum/submissions/
namespace DataStructures.Arrays.Matrix
{
    public class MatrixDiagonalSum
    {
        // Still good solution. 
        public int DiagonalSum_Online(int[][] mat)
        {
            int i = 0;
            int j = mat[0].Length - 1;
            int sum = 0;

            while (i < mat[0].Length && j >= 0)
            {
                if (i != j)
                {
                    sum = sum + mat[i][i];
                    sum = sum + mat[i][j];
                }
                else
                    sum += mat[i][i];

                i++;
                j--;
            }
            return sum;

        }
        // kind of going twice
        public int DiagonalSum_ElaboratedMyversion(int[][] mat)
        {
            int rowsize = mat.Length;
            int colsize = mat[0].Length;
            int sum = 0;
            // use this flag while calculating secondary diagonal
            bool isevenMatrix = (rowsize * colsize) % 2 == 0;

            // calculate Primary Diagonal sum
            int i = 0, j = 0;
            while (i < rowsize && j < colsize)
            {
                sum = sum + mat[i][j];
                i++;
                j++;
            }
            i = 0; j = colsize - 1;
            while (i < rowsize && j >= 0)
            {
                if (i != j || isevenMatrix)
                {
                    sum += mat[i][j];
                }
                i++;
                j--;
            }



            return sum;






        }

        // add both diagonal sums and subtract later when based on even or odd number of matrix.
        // When asked for diagonal we don't have to use 2 for loops.
        public int DiagonalSum2(int[][] mat)
        {

            int n = mat.Length;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += mat[i][i];
                sum += mat[i][n - i - 1];
            }
            return (n % 2 == 0) ? sum : sum - mat[n / 2][n / 2];
        }
    }
}
