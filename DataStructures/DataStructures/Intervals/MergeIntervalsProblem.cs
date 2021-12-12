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



        public int[][] MergeAlternate(int[][] intervals)
        {
            if (intervals.Length <= 1)
                return intervals;

            // Sort by ascending starting point
            Array.Sort(intervals, (i1, i2) => i1[0] - i2[0]);

            List<int[]> result = new List<int[]>();
            int[] newInterval = intervals[0];
            result.Add(newInterval);
            foreach (var interval in intervals)
            {

                //}

                //(int[] interval : intervals)
                //{
                if (interval[0] <= newInterval[1]) // Overlapping intervals, move the end if needed
                    newInterval[1] = Math.Max(newInterval[1], interval[1]);
                else
                {
                    // Disjoint intervals, add the new interval to the list
                    newInterval = interval;
                    result.Add(newInterval);
                }
            }

            return result.ToArray();
        }

       
        public int[][] MergeAlternate_RC(int[][] intervals)
        {
            if (intervals.Length <= 1) return intervals;

            Array.Sort(intervals, (i1, i2)=> i1[0]-i2[0]);

            var Oldinterval = intervals[0];
            var results = new List<int[]>();
            results.Add(Oldinterval);
            foreach (var curr in intervals)
            {
                if (curr[0] <= Oldinterval[1]) // overlap exist, if currentinterval.start <= oldinterval.endtime
                {

                    Oldinterval[1] = Math.Max(curr[1], Oldinterval[1]); // then the old interval endtime will be updated based on Max, since this is Array the value in the List also automatically gets updated
                     
                }
                else
                {
                    Oldinterval = curr;
                    results.Add(Oldinterval);
                }
            }

            return results.ToArray();
        }

        // using the method about intervals
        public int[][] Merge2(int[][] intervals)
        {

            Array.Sort(intervals, (i1, i2) => i1[0] - i2[0]);

            List<int[]> results = new List<int[]>();
            var oldinterval = intervals[0];
            results.Add(oldinterval);
            for(int i =1; i< intervals.Length; i++)
            {
                if (OverlapExists(oldinterval, intervals[i]))
                {
                    var mergedInterval = MergeIntervals(oldinterval, intervals[i]);
                    results.Remove(oldinterval);
                    results.Add(mergedInterval);
                    oldinterval = mergedInterval;
                }
                else
                {
                    oldinterval = intervals[i];
                    results.Add(oldinterval);
                }
               
            }

            return results.ToArray();
        }

        public bool OverlapExists(int[] i1, int[] i2)
        {
            var front = Math.Max(i1[0], i2[0]);
            var back = Math.Min(i1[1], i2[1]);
            return back - front >= 0;

        }

        public int[] MergeIntervals(int[] i1, int[] i2)
        {
            var front = Math.Min(i1[0], i2[0]);
            var back = Math.Max(i1[1], i2[1]);
            return new int[] { front, back };
        }
    }
}
