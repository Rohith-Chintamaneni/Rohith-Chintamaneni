using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Intervals
{
    class NonOverlappingIntervals
    {
        public int EraseOverlapIntervals(int[][] intervals)
        {
            Array.Sort(intervals, (i1, i2)=> i1[0]-i2[0]);
            int countofOccurrence = 0, overlappedcount =0;
        
           int count = 0, prevend = 0;
             prevend = intervals[0][1];
            for (int i = 1; i < intervals.Length; i++)
            {
                if (prevend <= intervals[i][0]) // no overlap
                {
                    prevend = intervals[i][1];


                }
                else
                {
                    count++;
                    prevend = Math.Min(prevend, intervals[i][1]);
                   
                }
               
            }


            return count;
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

            return back - front > 0;
        }


        public int[] MergeIntervalsforOverlapped(int[] i1, int[] i2)
        {
            var mergedfront = Math.Min(i1[0], i2[0]);
            var mergeback = Math.Max(i1[1], i2[1]);
            return new int[] { mergedfront, mergeback };

        }
    }
}
