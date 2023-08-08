using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
   public class DetermineWhetherMatricCanBeObtainedByRotation
    {
        // NO rotation just index counting. Intuitive solution
        public bool FindRotation(int[][] mat, int[][] target)
        {

            int n = mat.Length;
            int c90 = 0, c180 = 0, c270 = 0, c0 = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (target[i][j] == mat[n - j - 1][i])
                        c90++;
                    if (target[i][j] == mat[n - i - 1][n - j - 1])
                        c180++;
                    if (target[i][j] == mat[j][n - i - 1])
                        c270++;
                    if (target[i][j] == mat[i][j])
                        c0++;
                }
            }

            if (c90 == n * n || c270 == n * n || c180 == n * n || c0 == n * n)
                return true;
            else return false;


        }

        public bool findRotation2(int[][] mat, int[][] target)
        {

            for (int i = 0; i < 4; i++)
            {
                if (isEqual(mat, target)) return true;
                mat = rotate(mat);
            }
            return false;
        }


        //     Function to rotate matrix by 90 degree using transpose
        public static int[][] rotate(int[][] mat)
        {
            int[][] check = mat;
            int m = check.Length;
            //             First transposing the matrix
            for (int col = 0; col < m; col++)
            {
                for (int row = 1 + col; row < m; row++)
                {
                    int temp = check[row][col];
                    check[row][col] = check[col][row];
                    check[col][row] = temp;
                }
            }

            //             Now swapping coloumns like said in start
            for (int col_1 = 0, col_2 = m - 1; col_1 < m / 2; col_1++, col_2--)
            {
                for (int row = 0; row < m; row++)
                {
                    int temp = check[row][col_1];
                    check[row][col_1] = check[row][col_2];
                    check[row][col_2] = temp; ;
                }
            }
            return check;
        }


        //     Function to check whether two matrix are equal
        public static bool isEqual(int[][] m1, int[][] m2)
        {
            if (m1.Length != m2.Length) return false;
            if (m1[0].Length != m2[0].Length) return false;
            for (int row = 0; row < m1.Length; row++)
            {
                for (int col = 0; col < m1[0].Length; col++)
                {
                    if (m1[row][col] != m2[row][col]) return false;
                }
            }
            return true;
        }

    }
}
