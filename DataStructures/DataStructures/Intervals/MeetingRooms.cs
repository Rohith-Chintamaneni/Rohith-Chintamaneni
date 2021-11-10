using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Intervals
{
    class MeetingRooms
    {
        public bool CanAttendMeetings(int[][] intervals)
        {

            Array.Sort(intervals, (i1, i2) => i1[0] - i2[0]);
            bool canUserAttendallMeetings = true;
            for (int i = 0; i < intervals.Length - 1; i++)
            {

                if (Overlap(intervals[i], intervals[i + 1]))
                {
                    canUserAttendallMeetings = false;
                }


            }
            return canUserAttendallMeetings;
        }


        // touching intervals are not considered as overlap. since the person can goto next meeting after the first one just finishes
        public bool Overlap(int[] i1, int[] i2)
        {
            var front = Math.Max(i1[0], i2[0]);
            var back = Math.Min(i1[1], i2[1]);

            return back - front > 0;
        }



        // Brute Force -- Understand for intervals

        public bool canAttendMeetings(int[][] intervals)
        {
            for (int i = 0; i < intervals.Length; i++)
            {
                for (int j = i + 1; j < intervals.Length; j++)
                {
                    if (overlap(intervals[i], intervals[j]))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private bool overlap(int[] interval1, int[] interval2)
        {
            return (interval1[0] >= interval2[0] && interval1[0] < interval2[1])
                   || (interval2[0] >= interval1[0] && interval2[0] < interval1[1]);
        }
    }
}
