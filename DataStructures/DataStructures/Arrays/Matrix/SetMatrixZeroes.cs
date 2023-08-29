using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/set-matrix-zeroes/
// https://leetcode.com/problems/set-matrix-zeroes/solutions/2525398/all-approaches-from-brute-force-to-optimal-with-easy-explanation/
namespace DataStructures.Arrays.Matrix
{
    public class SetMatrixZeroes
    {
        // Brute Force
        public void SetZeroes(int[][] matrix)
        {
            int[][] ans = new int[matrix.Length][];
            for (int i = 0; i < matrix.Length; i++)
            {
                ans[i] = new int[matrix[0].Length];
               
            }
            // copy to new matrix
            for(int i=0; i< matrix.Length; i++)
            {
                Array.Copy(matrix[i], ans[i], matrix[i].Length);
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        // set row to zero
                       for(int k=0; k < matrix[0].Length; k++ )
                        {
                            ans[i][k] = 0;
                        }

                        // set column to zero
                        for (int k = 0; k < matrix.Length; k++)
                        {
                            ans[k][j] = 0;
                        }
                    }
                }
            }

            // copy back
            for (int i = 0; i < matrix.Length; i++)
            {
                Array.Copy(ans[i],matrix[i], ans[i].Length);
            }
        }
        // Optimized with the help of O(M+N) Space
        // Create A row array and a column array and use them to update the actual Array
        public void SetZeroes2(int[][] matrix)
        {

            int[] rowarray = new int[matrix.Length];
            int[] colarray = new int[matrix[0].Length];

            Array.Fill(rowarray, 1);
            Array.Fill(colarray, 1);

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        rowarray[i] = 0;
                        colarray[j] = 0;
                    }
                }
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    if (rowarray[i] == 0 || colarray[j] == 0)
                        matrix[i][j] = 0;
                }
            }
        }
    }
}
