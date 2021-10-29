using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays.JaggedArrays
{
    class BasicsOfJaggedArray
    {
        public void AccessArrays(int[][] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.WriteLine($"Array{i} = {array[i][j]}");
                }
                
            }
        }
    }
}
