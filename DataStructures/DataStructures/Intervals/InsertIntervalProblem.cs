using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Intervals
{
    class InsertIntervalProblem
    {
        //Input: intervals = [[1,3],[6,9]], newInterval = [2,5]
       //  Output: [[1,5],[6,9]]
        public int[][] Insert(int[][] intervals, int[] newInterval)
        {
            if (intervals.Length == 0) return new int[][] { newInterval };
            List<int[]> rst = new List<int[]>();
            int i = 0, n = intervals.Length;
            while (i < n && intervals[i][1] < newInterval[0])
            {
                rst.Add(intervals[i]);
                ++i;
            }
            while (i < n && intervals[i][0] <= newInterval[1])
            {
                newInterval[0] = Math.Min(intervals[i][0], newInterval[0]);
                newInterval[1] = Math.Max(intervals[i][1], newInterval[1]);
                ++i;
            }
            rst.Add(newInterval);
            while (i < n)
            {
                rst.Add(intervals[i]);
                ++i;
            }

            return rst.ToArray();
        }

        public int[][] Insert_AnotherApproach(int[][] intervals, int[] newInterval)
        {
            List<int[]> result = new List<int[]>();

            foreach (var i in intervals)
            {
                if (newInterval == null || i[1] < newInterval[0])
                {
                    result.Add(i);
                }
                else if (i[0] > newInterval[1])
                {
                    // be carefult the sequence here
                    result.Add(newInterval);
                    result.Add(i);
                    newInterval = null;
                }
                else
                {

                    newInterval[0] = Math.Min(newInterval[0], i[0]);//get min
                    newInterval[1] = Math.Max(newInterval[1], i[1]);//get max
                }
            }

            if (newInterval != null)
                result.Add(newInterval);

            return result.ToArray();
        }


        public int[] MergeOverlappedIntervals(int[] i1, int[] i2)
        {
            var mergedfront = Math.Min(i1[0], i2[0]);
            var mergedback = Math.Max(i1[1], i2[1]);
            return new int[] { mergedfront, mergedback };
        }

    }
}
