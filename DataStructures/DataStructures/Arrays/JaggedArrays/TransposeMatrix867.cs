using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays.JaggedArrays
{
    class TransposeMatrix867
    {
        public int[][] Transpose(int[][] matrix)
        {

            int rowlength = matrix.Length;
            int columnLength = matrix[0].Length;

            var result = new int[columnLength][];
            
            for(int i=0; i< columnLength; i++)
            {
                result[i] = new int[rowlength];
            }


                for (int i = 0; i < matrix.Length; i++)                {
                   
                    for (int j = 0; j < matrix[i].Length; j++)
                    {
                     result[j][i] = matrix[i][j];
                    }
                
                }
          
           

            return result;
        }
    }
}
