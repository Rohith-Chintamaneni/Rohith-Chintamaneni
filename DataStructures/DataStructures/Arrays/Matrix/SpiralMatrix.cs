using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/spiral-matrix/description/
namespace DataStructures.Arrays.Matrix
{
    public class SpiralMatrix
    {
        // In order to go all the way, you need to have multiple loops within main loop;
        public IList<int> SpiralOrder(int[][] matrix)
        {
            var ans = new List<int>();
            int left = 0;
            int top = 0;
            int bottom = matrix.Length - 1;
            int right = matrix[0].Length - 1;
            if (matrix.Length * matrix[0].Length == 1)
            {
                ans.Add(matrix[top][left]);
                return ans;
            }

            while (ans.Count != matrix.Length * matrix[0].Length)
            {
                for (int i = left; i <= right; i++)
                {
                    ans.Add(matrix[top][i]);

                }
                top++;
                if (left > right || top > bottom) break;

                for (int i = top; i <= bottom; i++)
                {
                    ans.Add(matrix[i][right]);
                }
                right--;
               if (left > right || top > bottom) break;

                for (int i = right; i >= left; i--)
                {
                    ans.Add(matrix[bottom][i]);
                }
                bottom--;
                if (left > right || top > bottom) break;
                for (int i = bottom; i >= top; i--)
                {
                    ans.Add(matrix[i][left]);
                }
                left++;
                if (left > right || top > bottom) break;
            }

            return ans;
        }
    }
}
