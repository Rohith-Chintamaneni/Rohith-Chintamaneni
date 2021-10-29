using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Intervals
{
    public class MergeIntervalsProblem
    {
        public int[][] Merge(int[][] intervals)
        {
            Array.Sort(intervals, (x, y) => x[0] - y[0]);

            List<int[]> result = new List<int[]>();
            // Iterate over Intervals
            //result.Add(intervals[0]);

            foreach (var interval in intervals)
            {
                bool isOverlapped = false;
                // Check if Interval Overlap
                isOverlapped = IntervalsOverlap(result.LastOrDefault(), interval);
                if (isOverlapped)
                {

                    var mergedresult = MergeIntervalsforOverlapped(result.LastOrDefault(), interval);
                    result.Remove(result.LastOrDefault());
                    result.Add(mergedresult);
                }
                else
                {
                    result.Add(interval);
                }

            }



            return result.ToArray();
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


        public int[] MergeIntervalsforOverlapped(int[] i1, int[] i2)
        {
            var mergedfront = Math.Min(i1[0], i2[0]);
            var mergeback = Math.Max(i1[1], i2[1]);
            return new int[] { mergedfront, mergeback };

        }

    }
}
