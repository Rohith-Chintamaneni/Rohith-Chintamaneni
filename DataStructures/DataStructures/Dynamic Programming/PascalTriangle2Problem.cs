using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Dynamic_Programming
{
    class PascalTriangle2Problem
    {
        public List<int> GetRow(int rowIndex)
        {
            List<int> curr, prev = new List<int>() { 1 };
         
             for (int i = 1; i <= rowIndex; i++) 
            {
                curr = new List<int>(i + 1) {1}; // adding first element to 1

                  for (int j = 1; j < i; j++)
                  {
                      curr.Add(prev[j - 1] + prev[j]);
                  }

                  curr.Add(1); // adding last element to 1;
                  
                  prev = curr;
            }

             return prev;


        }

    }

}
    