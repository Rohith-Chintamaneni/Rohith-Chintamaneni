using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Dynamic_Programming
{
    class PascalTriangleProblem
    {
        public IList<IList<int>> GeneratePascalTriangle(int numRows)
        {
            var ans = new List<List<int>>();
            ans.Add(new List<int>() { 1 }); // adding first row as 1;

            for(int rownums =1; rownums < numRows; rownums++)
            {
                var curr = new List<int>(); // current row, which will be added to ANs
                var prevrow = ans[rownums - 1];  // from recurrence relation only previous row is needed for current row
                curr.Add(1);  // first column of each row is 1

                for(int col =1; col<prevrow.Count; col++)
                {
                    curr.Add(prevrow[col - 1] + prevrow[col]);
                }
                curr.Add(1); // adding 1 to last column of row
                ans.Add(curr);
            }

            return ans.ToArray();

        }
    }
}
