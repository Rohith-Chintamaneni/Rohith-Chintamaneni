using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Intervals
{
    class IntervalListIntersections
    {
        public int[][] IntervalIntersection(int[][] firstList, int[][] secondList)
        {
            List<int[]> results = new List<int[]>();
            int firstindex = firstList.Length, secondindex = secondList.Length, i = 0, j = 0;


            while (i < firstindex && j < secondindex)
            {
               var front = Math.Max(firstList[i][0], secondList[j][0]);
                var back = Math.Min(firstList[i][1], secondList[j][1]);
                if (back - front >= 0)
                {
                    results.Add(new int[]{front, back});
                }

                if (firstList[i][1] == back) i++;
                if (secondList[j][1] == back) j++;

            }

            return results.ToArray();
        }
    }
}
