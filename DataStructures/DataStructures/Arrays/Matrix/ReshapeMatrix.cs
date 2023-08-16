using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays.Matrix
{
   public class ReshapeMatrix
    {

        // My Idea. Very complicated. 
        // It will boil down to 2 cases, When r is high and C is less than source and when r is less and C is high than source.
        public int[][] MatrixReshape(int[][] mat, int r, int c)
        {
            int m = mat.Length;
            int n = mat[0].Length;
            if (r * c != m * n) return mat;
            if (r == m && c == n) return mat;

            var ans = new int[r][];
            int rlimit = 0;
            int climit = 0;
            var singlearray = new int[r * c];
            int k = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    singlearray[k] = mat[i][j];
                    k++;
                }
            }
            var temp = 0;
            k = 0;
            List<int> columnaaray = new List<int>();
            List<int> rowarray = new List<int>();
            for (int i = 0; i < singlearray.Length; i++)
            {
                if (r > m && c < n)
                {
                    if (climit == c)
                    {
                        ans[rlimit] = rowarray.ToArray();
                        rlimit++;
                        climit = 0;
                        rowarray.Clear();
                    }
                    rowarray.Add(singlearray[i]);
                    climit++;
                }
                if (r < m && c > n)
                {
                    if (climit == c)
                    {
                        ans[rlimit] = columnaaray.ToArray();
                        rlimit++;
                        columnaaray.Clear();
                        climit = 0;
                    }
                    columnaaray.Add(singlearray[i]);
                    climit++;
                }


            }
            // add this statement so that the last temp variable will be added to new matrix.
            if (columnaaray.Count == 0)
                ans[rlimit] = rowarray.ToArray();
            else
                ans[rlimit] = columnaaray.ToArray();
            return ans;
     
        }

        // Modulo approach
        public int[][] MatrixReshape2(int[][] mat, int r, int c)
        {
            if (mat.Length == 0 || mat.Length * mat[0].Length != r * c)
                return mat;
            int[][] result = new int[r][];
            int count = 0;

            // just to initialize memory coz this is what differs in Jagged Array C#
            for (int i = 0; i < r; i++)
            {
                result[i] = new int[c];
            }
            // main logic
            for (int i = 0; i < mat.Length; i++)
            {
                for (int j = 0; j < mat[0].Length; j++)
                {
                    result[count / c][count % c] = mat[i][j];
                    count++;
                }
            }
            return result;
        }


        public int[][] MatrixReshape3(int[][] mat, int r, int c)
        {
            int num = mat.Length * mat[0].Length;
            if (num != r * c)
            {
                return mat;
            }

            var newMat = new int[r][];
            int i = -1;
            while (++i < num)
            {
                int r1 = i / c;
                int c1 = i % c;
                if (newMat[r1] == null)
                {
                    newMat[r1] = new int[c];
                }
                newMat[r1][c1] = mat[i / mat[0].Length][i % mat[0].Length];
            }

            return newMat;
        }

        // Easy appraoch Not Modulo or anything.
        public int[][] MatrixReshape4(int[][] mat, int r, int c)
        {
            int m = mat.Length;
            int n = mat[0].Length;
            if (r * c != m * n) return mat;

            int[][] ans = new int[r][];

            for (int i = 0; i < r; i++)
            {
                ans[i] = new int[c];
            }

            int rowcount = 0;
            int colcount = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    ans[rowcount][colcount] = mat[i][j];
                    colcount++;
                    if (colcount == c)
                    {
                        colcount = 0;
                        rowcount++;
                    }
                }
            }


            return ans;

        }
    }
}
