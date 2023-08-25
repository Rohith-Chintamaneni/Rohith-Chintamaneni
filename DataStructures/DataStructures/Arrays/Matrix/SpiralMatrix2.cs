using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/spiral-matrix-ii/
namespace DataStructures.Arrays.Matrix
{
    public class SpiralMatrix2
    {
        public int[][] GenerateMatrix(int n)
        {


            int[][] matrix = new int[n][];
            for (int i = 0; i < n; i++)
            {
                matrix[i] = new int[n];
            }
            int left = 0;
            int right = matrix[0].Length; ;
            int top = 0;
            int bottom = matrix.Length;
            int count = 0;
            while (count <= n * n)
            {

                for (int i = left; i < right; i++)
                {
                    count++;
                    matrix[top][i] = count;

                }
                top++;
                if (left >= right || top >= bottom) break;

                for (int i = top; i < bottom; i++)
                {
                    count++;
                    matrix[i][right - 1] = count;

                }
                right--;
                if (left >= right || top >= bottom) break;

                for (int i = right - 1; i >= left; i--)
                {
                    count++;
                    matrix[bottom - 1][i] = count;
                }
                bottom--;
                if (left >= right || top >= bottom) break;

                for (int i = bottom - 1; i >= top; i--)
                {
                    count++;
                    matrix[i][left] = count;
                }
                left++;
                if (left >= right || top >= bottom) break;
            }



            return matrix;
        }
    }
}
