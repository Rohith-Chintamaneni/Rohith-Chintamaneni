using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays.Matrix
{
    public class LuckyNumberInMatrix
    {

        // Lucknumber is a number that would be minimum in row and max in column traversing. So I declared two hashsets and looped through both row wise and column wise and finnaly the intersect will have a common element. 
        public IList<int> LuckyNumbers(int[][] matrix)
        {
            HashSet<int> MinimumValueForRow = new HashSet<int>();
            HashSet<int> MaximumValueForCol = new HashSet<int>();
            int minvalue = int.MaxValue;
            int maxvalue = int.MinValue;
            //int m = matrix.Length-1, n = matrix[0].Length - 1;
            int j = 0;
            for (int i = 0; i < matrix.Length; i++)
            {
               while(j < matrix[0].Length)
                { 
                    if (matrix[i][j] < minvalue)
                    {
                      
                        minvalue = matrix[i][j];
                    }
                j++;
                }            
                MinimumValueForRow.Add(minvalue);
                minvalue = int.MaxValue;
                j = 0;
             
            }
            int n = matrix[0].Length - 1; 
            while(n>=0)
            {
                for (int m = matrix.Length - 1; m >= 0; m--)
                {

                    if (matrix[m][n] > maxvalue)
                    {
                        maxvalue = matrix[m][n];
                    }
                }
                MaximumValueForCol.Add(maxvalue);
                maxvalue = int.MinValue; ;
                n--;
            }


            return MaximumValueForCol.Intersect(MinimumValueForRow).ToArray();



          

        }
        // Advanced way. This GOes by the initial idea I had but I could not implement it properly
        public List<int> LuckyNumbers2(int[][] matrix)
        {
            int n = matrix.Length;
            int m = matrix[0].Length;
            List<int> ls = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int num = int.MaxValue;
                int index = -1;
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i][j] < num)
                    {
                        num = matrix[i][j];
                        index = j;
                    }
                }
                bool flag = true;
                for (int row = 0; row < n; row++)
                {
                    if (matrix[row][index] > num) flag = false;
                }
                if (flag) ls.Add(num);
            }

            return ls;
        }
    }
}
