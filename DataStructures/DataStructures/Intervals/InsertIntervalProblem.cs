using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Intervals
{
    class InsertIntervalProblem
    {
        public int[][] Insert(int[][] intervals, int[] newInterval)
        {

           
            List<int[]> results = new List<int[]>();
       
         

            return results.ToArray();
        }

        public bool IntervalsOverlap(int[] i1, int[] i2)
        {
            if (i1 == null) return false;
            int front = 0, back = 0;
            for (int i = 0; i < i1.Length - 1; i++)
            {
                front = Math.Max(i1[i], i2[i]);
                back = Math.Min(i1[i + 1], i2[i + 1]);
            }
            return back - front >= 0;
        }


        public int[] MergeOverlappedIntervals(int[] i1, int[] i2)
        {
            var mergedfront = Math.Min(i1[0], i2[0]);
            var mergedback = Math.Max(i1[1], i2[1]);
            return new int[] { mergedfront, mergedback };
        }

    }
}
